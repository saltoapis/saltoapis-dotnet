using System;
using Grpc.Core;

namespace workspace.Tests
{
    internal static class TestAuthHelpers
    {
        internal static bool MetadataContainsAuth(Metadata metadata, string credentials)
        {
            foreach (var entry in metadata.GetAll("authorization"))
            {
                if (String.Equals(entry.Key, "authorization", StringComparison.OrdinalIgnoreCase)
                    && String.Equals(entry.Value, $"bearer {credentials}", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
