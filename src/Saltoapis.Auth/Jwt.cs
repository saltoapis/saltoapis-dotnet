#if NET5_0_OR_GREATER
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Saltoapis.Auth
{
    internal static class Jwt
    {
        internal static string CreateToken(
            JwtPayload payload,
            ECDsa signingAlgorithm,
            string keyId)
        {
            if (payload == null) throw new ArgumentNullException(nameof(payload));
            if (signingAlgorithm == null) throw new ArgumentNullException(nameof(signingAlgorithm));
            if (keyId == null) throw new ArgumentNullException(nameof(keyId));

            var encodedHeader = Base64UrlEncode(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(new JwtHeader
            {
                Algorithm = "ES256",
                KeyId = keyId,
                Type = "JWT"
            })));
            var encodedPayload = Base64UrlEncode(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(payload)));
            var signingInput = encodedHeader + "." + encodedPayload;
            var signature = signingAlgorithm.SignData(
                Encoding.UTF8.GetBytes(signingInput),
                HashAlgorithmName.SHA256,
                DSASignatureFormat.IeeeP1363FixedFieldConcatenation);

            if (signature.Length != 64)
            {
                throw new CryptographicException("The service-account key did not produce an ES256 signature.");
            }

            return signingInput + "." + Base64UrlEncode(signature);
        }

        private static string Base64UrlEncode(byte[] value)
        {
            return Convert.ToBase64String(value)
                .TrimEnd('=')
                .Replace('+', '-')
                .Replace('/', '_');
        }

        private sealed class JwtHeader
        {
            [JsonPropertyName("alg")]
            public string Algorithm { get; set; }

            [JsonPropertyName("kid")]
            public string KeyId { get; set; }

            [JsonPropertyName("typ")]
            public string Type { get; set; }
        }

    }

    internal sealed class JwtPayload
    {
        [JsonPropertyName("iss")]
        public string Issuer { get; set; }

        [JsonPropertyName("sub")]
        public string Subject { get; set; }

        [JsonPropertyName("aud")]
        public string Audience { get; set; }

        [JsonPropertyName("jti")]
        public string JwtId { get; set; }

        [JsonPropertyName("exp")]
        public long Expiration { get; set; }

        [JsonPropertyName("iat")]
        public long IssuedAt { get; set; }
    }
}
#endif
