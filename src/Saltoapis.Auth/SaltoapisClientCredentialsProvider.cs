using System;
using System.Collections.Generic; // KeyValuePair

using System.Net.Http; // HttpClient
using System.Threading.Tasks; // Task

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Saltoapis.Auth
{
    class OIDCConfiguration
    {
        [JsonPropertyName("token_endpoint")]
        public string TokenEndpoint
        { get; set; }
    }

    class SaltoTokenResponse
    {
        internal const int TokenExpiryTimeWindowSeconds = 60 * 5;

        private double? _expiresIn;
        private DateTimeOffset? authenticationExpiration;

        [JsonPropertyName("access_token")]
        public string AccessToken
        { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType
        { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken
        { get; set; }

        [JsonPropertyName("scope")]
        public string Scope
        { get; set; }
        
        [JsonPropertyName("expires_in")]
        public double? ExpiresIn // expiration in seconds
        { 
            get => _expiresIn;
            set
            {
                _expiresIn = value;
                this.UpdateExpiration();
            }
        }

        void UpdateExpiration()
        {
            // update expiration time
            if (this.ExpiresIn.HasValue)
            {
                authenticationExpiration = DateTimeOffset.Now.AddSeconds(this.ExpiresIn ?? 0);
            }
            else
            {
                authenticationExpiration = null;
            }
        }

        public bool IsExpired() => authenticationExpiration != null && DateTimeOffset.Now.AddSeconds(TokenExpiryTimeWindowSeconds) >= authenticationExpiration;
    }

    class TokenError
    {
        [JsonPropertyName("error")]
        public string Error
        { get; set; }

        [JsonPropertyName("error_hint")]
        public string ErrorHint
        { get; set; }

        [JsonPropertyName("error_description")]
        public string ErrorDescription
        { get; set; }
    }

    /// <summary>
    /// This class performs the OAuth2 client credentials flow. It gets a valid
    /// access token from the authorization server and stores it while it's still
    /// valid. When its close to expiration a new one will be automatically requested.
    /// </summary>
    class SaltoOAuthClient : OAuthClientCredentialsProvider
    {
        OIDCConfiguration cachedOidcConfiguration; // refeshed every 24 hours
        DateTimeOffset oidcCacheExpiration;

        SaltoTokenResponse token;

        readonly String   discoveryUri;
        readonly String   clientId;
        readonly String   clientSecret;
        readonly String[] scopes;

        public SaltoOAuthClient(String id, String secret, String[] scopes, String discoveryHost = "account.saltosystems.com")
        {
            this.discoveryUri = string.Format("https://{0}/.well-known/openid-configuration", discoveryHost);
            this.clientId = id;
            this.clientSecret = secret;
            this.scopes = scopes;
        }

        /**
         * Returns a client token. The token may be cached and return immediately.
         * 
         * It may throw a SaltoOAuthException if authentication server is not accessible
         * or credentials are invalid.
         */
        public async Task<string> GetToken()
        {
            if (token != null && !token.IsExpired())
            {
                // token is still valid
            }
            else
            {
                // Token is expired or null. Getting a new one.
                
                // expired token => get a new one
                var tokenResult = await GetNewToken();

                this.token = tokenResult;
            }
            
            return this.token.AccessToken;
        }

        async Task<SaltoTokenResponse> GetNewToken()
        {
            using (var httpClient = new HttpClient())
            {
                // oidc discovery
                await EnsureOidcConfiguration(httpClient);

                // OAuth token
                return await ObtainOAuthToken(httpClient);
            }
        }

        /**
         * Gets and keeps a 24 hour cache for the oidc configuration.
         * If it fails to access the configuration URI but a previous
         * configuration is accesible it will just log a warning.
         * Otherwise it will throw an error.
         */
        async Task EnsureOidcConfiguration(HttpClient httpClient)
        {
            if (cachedOidcConfiguration == null || IsOidcCacheExpired()) {
                var responseMessage = await httpClient.GetAsync(discoveryUri);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var result = await responseMessage.Content.ReadAsStringAsync();

                    cachedOidcConfiguration = JsonSerializer.Deserialize<OIDCConfiguration>(result);
                    oidcCacheExpiration = DateTimeOffset.Now.AddHours(24);
                }
                else
                {
                    // we could not get the oidc config.
                    if (cachedOidcConfiguration != null) {
                        // just continue with the previous value
                        Console.WriteLine("WARN: Could not get the oidc config. Trying with the previous value.");
                    } else {
                        throw new SaltoOAuthException("Could not get the oidc config. Is server accesible?");
                    }
                }
            }
        }

        async Task<SaltoTokenResponse> ObtainOAuthToken(HttpClient httpClient)
        {
            // build token request post data
            var postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            postData.Add(new KeyValuePair<string, string>("client_id", this.clientId));
            postData.Add(new KeyValuePair<string, string>("client_secret", this.clientSecret));
            postData.Add(new KeyValuePair<string, string>("scope", string.Join(" ", this.scopes)));

            using (var formBody = new FormUrlEncodedContent(postData))
            {
                var responseMessage = await httpClient.PostAsync(cachedOidcConfiguration.TokenEndpoint, formBody);
                var result = await responseMessage.Content.ReadAsStringAsync();
                if (responseMessage.IsSuccessStatusCode)
                {
                    token = JsonSerializer.Deserialize<SaltoTokenResponse>(result);  
                    return token;
                }
                else
                {
                    // get error
                    var error = JsonSerializer.Deserialize<TokenError>(result);
                    throw new SaltoOAuthException($"Error getting the access_token. Server returned {responseMessage.StatusCode} error ( error = '{error.Error}', error_hint = '{error.ErrorHint}', description = '{error.ErrorDescription}')");
                }
            }
        }

        bool IsOidcCacheExpired()
        {
            return oidcCacheExpiration != null && DateTimeOffset.Now >= oidcCacheExpiration;
        }

        public void InvalidateToken()
        {
            token = null;
        }
    }

}
