using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Saltoapis.Auth
{
    /// <summary>
    /// Salto API credential capable of obtaining and refreshing OAuth access tokens.
    /// </summary>
    public sealed class SaltoCredential : IOAuthTokenProvider
    {
        private static readonly HttpClient sharedHttpClient = new HttpClient();

        private readonly SemaphoreSlim getTokenLock = new SemaphoreSlim(1, 1);
        private readonly string clientId;
        private readonly string clientSecret;
        private readonly OidcConfigurationReader oidcConfigurationReader;
        private readonly string[] scopes;
        private readonly HttpClient httpClient;
        private SaltoTokenResponse token;

        private SaltoCredential(
            string clientId,
            string clientSecret,
            OidcConfigurationReader oidcConfigurationReader,
            IEnumerable<string> scopes,
            HttpClient httpClient)
        {
            this.clientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
            this.clientSecret = clientSecret ?? throw new ArgumentNullException(nameof(clientSecret));
            this.oidcConfigurationReader = oidcConfigurationReader ?? throw new ArgumentNullException(nameof(clientSecret));
            this.scopes = NormalizeScopes(scopes);
            this.httpClient = httpClient ?? sharedHttpClient;
        }

        public static SaltoCredential FromClientSecret(
            string clientId,
            string clientSecret,
            Uri discoveryUri = null,
            HttpClient httpClient = null)
        {
            discoveryUri = discoveryUri
                ?? new Uri("https://account.saltosystems.com/.well-known/openid-configuration");

            var oidcConfigurationReader = new OidcConfigurationReader(discoveryUri);
            return new SaltoCredential(
                clientId,
                clientSecret,
                oidcConfigurationReader,
                Array.Empty<string>(),
                httpClient);
        }

        /// <summary>
        /// Returns a credential copy configured with the requested OAuth scopes.
        /// </summary>
        public SaltoCredential CreateScoped(IEnumerable<string> scopes)
        {
            return new SaltoCredential(clientId, clientSecret, oidcConfigurationReader, scopes, httpClient);
        }

        public SaltoCredential CreateScoped(params string[] scopes)
        {
            return CreateScoped((IEnumerable<string>)scopes);
        }

        public async Task<string> GetToken(CancellationToken cancellationToken = default)
        {
            var currentToken = token;
            if (IsUsable(currentToken))
            {
                return currentToken.AccessToken;
            }

            await getTokenLock.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                // Check the token again, we've waited in the semaphore,
                // so another thread may have requested a valid token.
                currentToken = token;
                if (IsUsable(currentToken))
                {
                    return currentToken.AccessToken;
                }

                // Request a new token
                currentToken = await RequestNewToken(cancellationToken).ConfigureAwait(false);
                if (!IsUsable(currentToken))
                {
                    throw new SaltoOAuthException("The token endpoint returned an invalid access token.");
                }

                // Save it
                token = currentToken;

                return currentToken.AccessToken;
            }
            finally
            {
                getTokenLock.Release();
            }
        }

        public void InvalidateToken()
        {
            Interlocked.Exchange(ref token, null);
        }

        private static bool IsUsable(SaltoTokenResponse candidate)
        {
            return candidate != null
                && !candidate.IsExpired()
                && !string.IsNullOrWhiteSpace(candidate.AccessToken);
        }

        private async Task<SaltoTokenResponse> RequestNewToken(CancellationToken cancellationToken)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("scope", string.Join(" ", scopes)),
                new KeyValuePair<string, string>("client_id", clientId),
                new KeyValuePair<string, string>("client_secret", clientSecret),
            };

            var tokenEndpoint = await oidcConfigurationReader
                .GetTokenEndpointAsync(httpClient, cancellationToken)
                .ConfigureAwait(false);

            using (var formBody = new FormUrlEncodedContent(postData))
            using (var responseMessage = await httpClient
                .PostAsync(tokenEndpoint, formBody, cancellationToken)
                .ConfigureAwait(false))
            {
                var result = await responseMessage.Content
                    .ReadAsStringAsync()
                    .ConfigureAwait(false);

                if (responseMessage.IsSuccessStatusCode)
                {
                    try
                    {
                        return JsonSerializer.Deserialize<SaltoTokenResponse>(result) ?? throw new SaltoOAuthException("The token endpoint returned an empty response.");
                    }
                    catch (JsonException exception)
                    {
                        throw new SaltoOAuthException("The token endpoint returned invalid JSON.", exception);
                    }
                }

                TokenError error = null;
                try
                {
                    error = JsonSerializer.Deserialize<TokenError>(result);
                }
                catch (JsonException)
                {
                    // Preserve the HTTP status when the server did not return an OAuth error document.
                }

                var detail = error == null
                    ? "The server did not return an OAuth error document."
                    : $"error = '{error.Error}', error_hint = '{error.ErrorHint}', description = '{error.ErrorDescription}'";

                throw new SaltoOAuthException(
                    $"Error getting the access token. Server returned {responseMessage.StatusCode} ({detail})");
            }
        }

        private static string[] NormalizeScopes(IEnumerable<string> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return values
                .Where(scope => !string.IsNullOrWhiteSpace(scope))
                .Select(scope => scope.Trim())
                .Distinct(StringComparer.Ordinal)
                .ToArray();
        }
    }
}
