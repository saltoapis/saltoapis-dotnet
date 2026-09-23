using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Saltoapis.Auth
{
    internal sealed class ClientSecretAuthentication : IClientAuthenticationMethod
    {
        private readonly OidcConfigurationReader oidcConfigurationReader;
        private readonly string clientId;
        private readonly string clientSecret;

        internal ClientSecretAuthentication(string clientId, string clientSecret, Uri discoveryUri)
        {
            if (string.IsNullOrWhiteSpace(clientId))
            {
                throw new ArgumentException("Client ID is required.", nameof(clientId));
            }

            if (string.IsNullOrWhiteSpace(clientSecret))
            {
                throw new ArgumentException("Client secret is required.", nameof(clientSecret));
            }

            oidcConfigurationReader = new OidcConfigurationReader(discoveryUri);
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }

        public IList<KeyValuePair<string, string>> Headers()
        {
            return new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("client_id", clientId),
                new KeyValuePair<string, string>("client_secret", clientSecret),
            };
        }

        public Task<Uri> GetTokenEndpointAsync(HttpClient httpClient, CancellationToken cancellationToken)
        {
            return oidcConfigurationReader.GetTokenEndpointAsync(httpClient, cancellationToken);
        }
    }
}
