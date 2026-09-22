using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Saltoapis.Auth
{
    internal class OidcConfiguration
    {
        [JsonPropertyName("token_endpoint")]
        public string TokenEndpoint { get; set; }
    }

    internal class OidcConfigurationReader
    {
        private readonly Uri discoveryUri;
        private readonly SemaphoreSlim refreshLock = new SemaphoreSlim(1, 1);
        private OidcConfiguration cachedOidcConfiguration;
        private DateTimeOffset? cacheExpiration;

        internal OidcConfigurationReader(Uri discoveryUri)
        {
            if (discoveryUri == null) throw new ArgumentNullException(nameof(discoveryUri));
            if (!discoveryUri.IsAbsoluteUri || discoveryUri.Scheme != Uri.UriSchemeHttps)
            {
                throw new ArgumentException("The Open ID Connect discovery URI must be an absolute HTTPS URI.", nameof(discoveryUri));
            }

            this.discoveryUri = discoveryUri;
        }

        internal async Task<Uri> GetTokenEndpointAsync(HttpClient httpClient, CancellationToken cancellationToken)
        {
            if (httpClient == null) throw new ArgumentNullException(nameof(httpClient));
            await EnsureOidcConfigurationAsync(httpClient, cancellationToken).ConfigureAwait(false);

            if (cachedOidcConfiguration == null || string.IsNullOrWhiteSpace(cachedOidcConfiguration.TokenEndpoint))
            {
                throw new SaltoOAuthException("Open ID Connect configuration did not contain a token endpoint.");
            }

            if (!Uri.TryCreate(cachedOidcConfiguration.TokenEndpoint, UriKind.Absolute, out var tokenEndpoint)
                || tokenEndpoint.Scheme != Uri.UriSchemeHttps)
            {
                throw new SaltoOAuthException("Open ID Connect configuration contains an invalid token endpoint.");
            }

            return tokenEndpoint;
        }

        private async Task EnsureOidcConfigurationAsync(HttpClient httpClient, CancellationToken cancellationToken)
        {
            if (cachedOidcConfiguration != null && !IsCacheExpired())
            {
                return;
            }

            await refreshLock.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                if (cachedOidcConfiguration != null && !IsCacheExpired())
                {
                    return;
                }

                using (var responseMessage = await httpClient
                    .GetAsync(discoveryUri, cancellationToken)
                    .ConfigureAwait(false))
                {
                    var result = await responseMessage.Content
                        .ReadAsStringAsync()
                        .ConfigureAwait(false);

                    if (!responseMessage.IsSuccessStatusCode)
                    {
                        if (cachedOidcConfiguration == null)
                        {
                            throw new SaltoOAuthException(
                                $"Could not retrieve Open ID Connect configuration. Server returned {responseMessage.StatusCode}.");
                        }

                        // Keep a previously valid endpoint if discovery is temporarily unavailable.
                        cacheExpiration = DateTimeOffset.UtcNow.AddMinutes(5);
                        return;
                    }

                    try
                    {
                        var configuration = JsonSerializer.Deserialize<OidcConfiguration>(result);
                        if (configuration == null || string.IsNullOrWhiteSpace(configuration.TokenEndpoint))
                        {
                            throw new SaltoOAuthException("Open ID Connect configuration did not contain a token endpoint.");
                        }

                        cachedOidcConfiguration = configuration;
                        cacheExpiration = DateTimeOffset.UtcNow.AddHours(24);
                    }
                    catch (JsonException exception)
                    {
                        throw new SaltoOAuthException("Open ID Connect configuration was not valid JSON.", exception);
                    }
                }
            }
            finally
            {
                refreshLock.Release();
            }
        }

        private bool IsCacheExpired()
        {
            return !cacheExpiration.HasValue || DateTimeOffset.UtcNow >= cacheExpiration.Value;
        }
    }
}
