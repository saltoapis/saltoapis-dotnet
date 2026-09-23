#if NET5_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Saltoapis.Auth
{
    internal sealed class ServiceAccountAuthentication : IClientAuthenticationMethod
    {
        private const string ClientAssertionType = "urn:ietf:params:oauth:client-assertion-type:jwt-bearer";
        private readonly ServiceAccountCredentialData credentialData;

        private ServiceAccountAuthentication(ServiceAccountCredentialData credentialData)
        {
            this.credentialData = credentialData ?? throw new ArgumentNullException(nameof(credentialData));
            Validate(credentialData);
        }

        internal static ServiceAccountAuthentication FromBytes(byte[] contents)
        {
            if (contents == null) throw new ArgumentNullException(nameof(contents));

            try
            {
                var credentialData = JsonSerializer.Deserialize<ServiceAccountCredentialData>(contents);
                if (credentialData == null)
                {
                    throw new SaltoOAuthException("The service-account JSON was empty.");
                }

                return new ServiceAccountAuthentication(credentialData);
            }
            catch (JsonException exception)
            {
                throw new SaltoOAuthException("The service-account JSON was invalid.", exception);
            }
        }

        public IList<KeyValuePair<string, string>> Headers()
        {
            return new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("client_id", credentialData.ClientId),
                new KeyValuePair<string, string>("client_assertion_type", ClientAssertionType),
                new KeyValuePair<string, string>("client_assertion", CreateClientAssertion()),
            };
        }

        public Task<Uri> GetTokenEndpointAsync(HttpClient httpClient, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Task.FromResult(new Uri(credentialData.TokenUri, UriKind.Absolute));
        }

        private string CreateClientAssertion()
        {
            var issuedAt = DateTimeOffset.UtcNow;
            var payload = new JwtPayload
            {
                Issuer = credentialData.ClientId,
                Subject = credentialData.ClientId,
                Audience = credentialData.TokenUri,
                JwtId = Guid.NewGuid().ToString("D"),
                IssuedAt = issuedAt.ToUnixTimeSeconds(),
                Expiration = issuedAt.AddMinutes(5).ToUnixTimeSeconds()
            };

            using var signingAlgorithm = CreateSigningAlgorithm(credentialData.PrivateKey);
            return Jwt.CreateToken(payload, signingAlgorithm, credentialData.PrivateKeyId);
        }

        private static void Validate(ServiceAccountCredentialData credentialData)
        {
            if (string.IsNullOrWhiteSpace(credentialData.ClientId))
                throw new SaltoOAuthException("Service-account client_id is required.");
            if (string.IsNullOrWhiteSpace(credentialData.PrivateKeyId))
                throw new SaltoOAuthException("Service-account private_key_id is required.");
            if (string.IsNullOrWhiteSpace(credentialData.PrivateKey))
                throw new SaltoOAuthException("Service-account private_key is required.");
            if (!Uri.TryCreate(credentialData.TokenUri, UriKind.Absolute, out var tokenUri)
                || tokenUri.Scheme != Uri.UriSchemeHttps)
            {
                throw new SaltoOAuthException("Service-account token_uri must be an absolute HTTPS URI.");
            }

            try
            {
                using (CreateSigningAlgorithm(credentialData.PrivateKey))
                {
                }
            }
            catch (Exception exception) when (exception is not SaltoOAuthException)
            {
                throw new SaltoOAuthException("Service-account private_key is not a supported EC private key.", exception);
            }
        }

        private static ECDsa CreateSigningAlgorithm(string privateKeyPem)
        {
            var ecdsa = ECDsa.Create();
            try
            {
                ecdsa.ImportFromPem(privateKeyPem);
                if (ecdsa.KeySize != 256)
                {
                    throw new CryptographicException("Service-account keys must use the P-256 curve for ES256.");
                }

                return ecdsa;
            }
            catch
            {
                ecdsa.Dispose();
                throw;
            }
        }
    }

    internal sealed class ServiceAccountCredentialData
    {
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        [JsonPropertyName("private_key")]
        public string PrivateKey { get; set; }

        [JsonPropertyName("private_key_id")]
        public string PrivateKeyId { get; set; }

        [JsonPropertyName("token_uri")]
        public string TokenUri { get; set; }
    }

}
#endif
