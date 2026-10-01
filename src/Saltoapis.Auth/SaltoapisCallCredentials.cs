using System;
using Grpc.Core;

namespace Saltoapis.Auth
{
    /// <summary>
    /// Creates asynchronous gRPC call credentials backed by an OAuth token provider.
    /// </summary>
    public static class SaltoapisCallCredentials
    {
        public static CallCredentials FromTokenProvider(IOAuthTokenProvider tokenProvider)
        {
            if (tokenProvider == null) throw new ArgumentNullException(nameof(tokenProvider));

            return CallCredentials.FromInterceptor(async (context, metadata) =>
            {
                for (var index = metadata.Count - 1; index >= 0; index--)
                {
                    if (string.Equals(metadata[index].Key, "Authorization", StringComparison.OrdinalIgnoreCase))
                    {
                        metadata.RemoveAt(index);
                    }
                }

                var token = await tokenProvider
                    .GetToken(context.CancellationToken)
                    .ConfigureAwait(false);
                metadata.Add("Authorization", "Bearer " + token);
            });
        }
    }
}
