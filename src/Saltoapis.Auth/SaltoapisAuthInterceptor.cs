using System;

using Grpc.Core;
using Grpc.Core.Interceptors;

using System.Net.Http; // HttpClient
using System.Threading; // CancellationToken
using System.Threading.Tasks; // Task

namespace Saltoapis.Auth
{
    /// <summary>
    /// Provides a valid access token for an OAuth server. 
    ///
    /// The access token should be stored and cached by this class,
    /// requesting a new one to the server before previous token expiration.
    /// </summary>
    public interface OAuthClientCredentialsProvider
    {
        /// <summary>
        /// Returns a valid access token. This call may request
        /// a new token or return a cached one.
        /// If it fails to retrieve a token it will throw a SaltoOAuthException.
        /// Callers should never store the given access token.
        /// </summary>
        /// <exception cref="SaltoOAuthException"></exception>
        Task<string> GetToken();

        /// <summary>
        /// Invalidates current token. This method should return immediately.
        /// So implementor may choose to not retrieve a new token until GetToken
        /// is called again.
        /// </summary>
        void InvalidateToken();
    }

    /// <summary>
    /// Represents an OAuth exception.
    /// </summary>
    public class SaltoOAuthException : Exception
    {
        internal SaltoOAuthException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// Saltoapis authorization interceptor. This interceptor uses a OAuthClientCredentialsProvider
    /// to include a valid token in grpc requests.
    /// </summary>
    public class SaltoapisAuthInterceptor : Interceptor
    {
        OAuthClientCredentialsProvider OAuthClient;

        public SaltoapisAuthInterceptor(String id, String secret)
        {
            this.OAuthClient = new SaltoOAuthClient(id, secret);
        }

        public SaltoapisAuthInterceptor(OAuthClientCredentialsProvider credentialsProvider)
        {
            this.OAuthClient = credentialsProvider;
        }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            Interceptor.AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            AddCallerMetadata(ref context);
            
            var call = continuation(request, context);
            
            // wrap response to capture errors
            return new AsyncUnaryCall<TResponse>(
                HandleRpcUnauthenticated(call.ResponseAsync),
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose
            );
        }
        
        public override TResponse BlockingUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            Interceptor.BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            AddCallerMetadata(ref context);
            
            // call server using a task. This way we can use the same method to handle authentication exceptions.
            return HandleRpcUnauthenticated( Task.Run(() => continuation(request, context)) ).Result;
        }

        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(
            ClientInterceptorContext<TRequest, TResponse> context,
            Interceptor.AsyncClientStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            AddCallerMetadata(ref context);

            var call = continuation(context);

            // wrap response to capture errors
            return new AsyncClientStreamingCall<TRequest, TResponse>(
                call.RequestStream,
                HandleRpcUnauthenticated(call.ResponseAsync),
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose
            );
        }

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            Interceptor.AsyncServerStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            AddCallerMetadata(ref context);

            var call = continuation(request, context);

            return new AsyncServerStreamingCall<TResponse>(
                new AuthErrorStreamReader<TResponse>(call.ResponseStream, this),
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose
            );
        }

        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(
            ClientInterceptorContext<TRequest, TResponse> context,
            Interceptor.AsyncDuplexStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            AddCallerMetadata(ref context);

            var call = continuation(context);

            return new AsyncDuplexStreamingCall<TRequest, TResponse>(
                call.RequestStream,
                new AuthErrorStreamReader<TResponse>(call.ResponseStream, this),
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose
            );
        }

        async Task<TResponse> HandleRpcUnauthenticated<TResponse>(Task<TResponse> t)
        {
            try
            {
                return await t;
            }
            catch (RpcException ex) when (ex.StatusCode == StatusCode.Unauthenticated)
            {
                Console.WriteLine("Server responded with unauthenticated error. Invalidating current token.");
                InvalidateToken();
                throw;
            }
        }

        void AddCallerMetadata<TRequest, TResponse>(ref ClientInterceptorContext<TRequest, TResponse> context)
            where TRequest : class
            where TResponse : class
        {
            var headers = context.Options.Headers;

            // Call doesn't have a headers collection to add to.
            // Need to create a new context with headers for the call.
            if (headers == null)
            {
                headers = new Metadata();
                var options = context.Options.WithHeaders(headers);
                context = new ClientInterceptorContext<TRequest, TResponse>(context.Method, context.Host, options);
            }

            // this call may take a while (depending if we have the token or not)
            var token = OAuthClient.GetToken().Result;
            headers.Add("Authorization", $"Bearer {token}");
        }

        public void InvalidateToken()
        {
            OAuthClient.InvalidateToken();
        }
    }

    internal class AuthErrorStreamReader<T> : IAsyncStreamReader<T>
    {

        IAsyncStreamReader<T> stream;
        SaltoapisAuthInterceptor interceptor;

        internal AuthErrorStreamReader(IAsyncStreamReader<T> stream, SaltoapisAuthInterceptor interceptor)
        {
            this.stream = stream;
            this.interceptor = interceptor;
        }

        public T Current => this.stream.Current;
        
        public async Task<bool> MoveNext(CancellationToken cancellationToken)
        {
            try {
                return await this.stream.MoveNext(cancellationToken);
            }
            catch (RpcException ex) when (ex.StatusCode == StatusCode.Unauthenticated)
            {
                Console.WriteLine("Server responded with unauthenticated error. Invalidating current token.");
                interceptor.InvalidateToken();
                throw;
            }
        }
    }
}
