using System;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Saltoapis.Auth
{
    /// <summary>
    /// Provides a valid OAuth access token. Implementations cache the token and
    /// refresh it before it expires.
    /// </summary>
    public interface IOAuthTokenProvider
    {
        Task<string> GetToken(CancellationToken cancellationToken = default);

        /// <summary>
        /// Discards the cached token. A new token is obtained by the next call
        /// to <see cref="GetToken(CancellationToken)"/>.
        /// </summary>
        void InvalidateToken();
    }

    public class SaltoOAuthException : Exception
    {
        public SaltoOAuthException(string message) : base(message)
        {
        }

        public SaltoOAuthException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class SaltoTokenResponse
    {
        // Keep a small safety margin without making short-lived tokens unusable.
        protected const int TokenExpiryTimeWindowSeconds = 60;

        private double? expiresIn;
        private DateTimeOffset? authenticationExpiration;

        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("expires_in")]
        public double? ExpiresIn
        {
            get { return expiresIn; }
            set
            {
                expiresIn = value;
                authenticationExpiration = value.HasValue
                    ? DateTimeOffset.UtcNow.AddSeconds(value.Value)
                    : (DateTimeOffset?)null;
            }
        }

        public bool IsExpired()
        {
            return !authenticationExpiration.HasValue
                || DateTimeOffset.UtcNow.AddSeconds(TokenExpiryTimeWindowSeconds) >= authenticationExpiration.Value;
        }
    }

    public class TokenError
    {
        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("error_hint")]
        public string ErrorHint { get; set; }

        [JsonPropertyName("error_description")]
        public string ErrorDescription { get; set; }
    }
}
