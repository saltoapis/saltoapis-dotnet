using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Saltoapis.Auth
{
    internal interface IClientAuthenticationMethod
    {
        IList<KeyValuePair<string, string>> Headers();
        Task<Uri> GetTokenEndpointAsync(HttpClient httpClient, CancellationToken cancellationToken);
    }
}
