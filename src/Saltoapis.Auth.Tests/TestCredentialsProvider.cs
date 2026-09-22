using System.Threading;
using System.Threading.Tasks;
using Saltoapis.Auth;

namespace workspace.Tests
{
    internal class TestCredentialsProvider : IOAuthTokenProvider
    {
        string credentials;
        bool wasInvalidated = false;

        internal TestCredentialsProvider(string credentials)
        {
            this.credentials = credentials;
        }

        public Task<string> GetToken(CancellationToken cancellationToken)
        {
            return Task.Run(() => this.credentials, cancellationToken);
        }

        public void InvalidateToken()
        {
            wasInvalidated = true;
        }

        public bool WasInvalidated
        {
            get
            {
                return this.wasInvalidated;
            }
        }
    }
}
