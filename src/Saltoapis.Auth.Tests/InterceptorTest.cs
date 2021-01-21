using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Core.Internal;
using Grpc.Core.Utils;

using Saltoapis.Auth;

using NUnit.Framework;

namespace workspace.Tests
{
    [TestFixture]
    public class InterceptorTest
    {
        MockServiceHelper helper;
        Server server;
        Channel channel;

        [SetUp]
        public void Init()
        {
            helper = new MockServiceHelper();

            server = helper.GetServer();
            server.Start();
            channel = helper.GetChannel();
        }

        [TearDown]
        public void Cleanup()
        {
            channel.ShutdownAsync().Wait();
            server.ShutdownAsync().Wait();
        }

        [Test]
        public void BlockingUnaryCall_AddsAuthorizationHeaders()
        {
            // having: server unary handler
            var authorization_received = false;
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);
            SaltoapisAuthInterceptor credentialsInterceptor = new SaltoapisAuthInterceptor(credentialsProvider);

            helper.UnaryHandler = new UnaryServerMethod<string, string>((request, context) =>
            {
                authorization_received = MetadataContainsAuth(context.RequestHeaders, credentials);

                return Task.FromResult("result");
            });

            // when
            CallInvoker invoker = ChannelExtensions.Intercept(channel, credentialsInterceptor);
            var response = helper.CreateBlockingUnaryCall(invoker, "request");

            // then
            Assert.True(authorization_received);
        }


        [Test]
        public async Task AsyncUnaryCall_AddsAuthorizationHeaders()
        {
            // having: server unary handler
            var authorization_received = false;
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);
            SaltoapisAuthInterceptor credentialsInterceptor = new SaltoapisAuthInterceptor(credentialsProvider);

            helper.UnaryHandler = new UnaryServerMethod<string, string>((request, context) =>
            {
                authorization_received = MetadataContainsAuth(context.RequestHeaders, credentials);

                return Task.FromResult("result");
            });

            // when
            CallInvoker invoker = ChannelExtensions.Intercept(channel, credentialsInterceptor);
            var response = await helper.CreateAsyncUnaryCall(invoker, "request").ResponseAsync;

            // then
            Assert.True(authorization_received);
        }

        [Test]
        public async Task ClientStreamingCall_AddsAuthorizationHeaders()
        {
            // having: server unary handler
            var authorization_received = false;
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);
            SaltoapisAuthInterceptor credentialsInterceptor = new SaltoapisAuthInterceptor(credentialsProvider);

            helper.ClientStreamingHandler = new ClientStreamingServerMethod<string, string>((request, context) =>
            {
                authorization_received = MetadataContainsAuth(context.RequestHeaders, credentials);
                return Task.FromResult("result");
            });

            // when
            CallInvoker invoker = ChannelExtensions.Intercept(channel, credentialsInterceptor);
            var response = await helper.CreateClientStreamingCall(invoker).ResponseAsync;

            // then
            Assert.True(authorization_received);
        }

        [Test]
        public async Task ServerStreamingCall_AddsAuthorizationHeaders()
        {
            // having: server unary handler
            var authorization_received = false;
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);
            SaltoapisAuthInterceptor credentialsInterceptor = new SaltoapisAuthInterceptor(credentialsProvider);

            helper.ServerStreamingHandler = new ServerStreamingServerMethod<string, string>((request, responseStream, context) =>
            {
                authorization_received = MetadataContainsAuth(context.RequestHeaders, credentials);
                return TaskUtils.CompletedTask;
            });

            // when
            CallInvoker invoker = ChannelExtensions.Intercept(channel, credentialsInterceptor);
            var response = await helper.CreateServerStreamingCall(invoker, "request").ResponseStream.ToListAsync();

            // then
            Assert.True(authorization_received);
        }

        [Test]
        public async Task DuplexStreamingCall_AddsAuthorizationHeaders()
        {
            // having: server unary handler
            var authorization_received = false;
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);
            SaltoapisAuthInterceptor credentialsInterceptor = new SaltoapisAuthInterceptor(credentialsProvider);

            helper.DuplexStreamingHandler = new DuplexStreamingServerMethod<string, string>((requestStream, responseStream, context) =>
            {
                authorization_received = MetadataContainsAuth(context.RequestHeaders, credentials);
                return TaskUtils.CompletedTask;
            });

            // when
            CallInvoker invoker = ChannelExtensions.Intercept(channel, credentialsInterceptor);
            var call = helper.CreateDuplexStreamingCall(invoker);
            // receive response (otherwise it gets stuck)
            await call.ResponseStream.ToListAsync();

            // then
            Assert.True(authorization_received);
        }


        [Test]
        public void BlockingUnaryCall_InvalidatesTokenOnAuthError()
        {
            // having: server unary handler
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);
            SaltoapisAuthInterceptor credentialsInterceptor = new SaltoapisAuthInterceptor(credentialsProvider);

            helper.UnaryHandler = new UnaryServerMethod<string, string>((request, context) =>
            {
                throw new RpcException(new Status(StatusCode.Unauthenticated, ""));
            });

            // when
            CallInvoker invoker = ChannelExtensions.Intercept(channel, credentialsInterceptor);
            
            try
            {
                var response = helper.CreateBlockingUnaryCall(invoker, "request");
            }
            catch (Exception)
            {

            }

            // then
            Assert.True(credentialsProvider.WasInvalidated);
        }

        [Test]
        public async Task AsyncUnaryCall_InvalidatesTokenOnAuthError()
        {
            // having: server unary handler
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);
            SaltoapisAuthInterceptor credentialsInterceptor = new SaltoapisAuthInterceptor(credentialsProvider);

            helper.UnaryHandler = new UnaryServerMethod<string, string>((request, context) =>
            {
                throw new RpcException(new Status(StatusCode.Unauthenticated, ""));
            });

            // when
            CallInvoker invoker = ChannelExtensions.Intercept(channel, credentialsInterceptor);

            try
            {
                var response = await helper.CreateAsyncUnaryCall(invoker, "request").ResponseAsync;
            }
            catch (Exception)
            {

            }

            // then
            Assert.True(credentialsProvider.WasInvalidated);
        }

        [Test]
        public async Task ClientStreamingCall_InvalidatesTokenOnAuthError()
        {
            // having: server unary handler
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);
            SaltoapisAuthInterceptor credentialsInterceptor = new SaltoapisAuthInterceptor(credentialsProvider);

            helper.ClientStreamingHandler = new ClientStreamingServerMethod<string, string>((request, context) =>
            {
                throw new RpcException(new Status(StatusCode.Unauthenticated, ""));
            });

            // when
            CallInvoker invoker = ChannelExtensions.Intercept(channel, credentialsInterceptor);
            try
            {
                var response = await helper.CreateClientStreamingCall(invoker).ResponseAsync;
            }
            catch (Exception)
            {

            }

            // then
            Assert.True(credentialsProvider.WasInvalidated);
        }

        [Test]
        public async Task ServerStreamingCall_InvalidatesTokenOnAuthError()
        {
            // having: server unary handler
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);
            SaltoapisAuthInterceptor credentialsInterceptor = new SaltoapisAuthInterceptor(credentialsProvider);

            helper.ServerStreamingHandler = new ServerStreamingServerMethod<string, string>((request, responseStream, context) =>
            {
                throw new RpcException(new Status(StatusCode.Unauthenticated, ""));
            });

            // when
            CallInvoker invoker = ChannelExtensions.Intercept(channel, credentialsInterceptor);
            try
            {
                var response = await helper.CreateServerStreamingCall(invoker, "request").ResponseStream.ToListAsync();
            }
            catch (Exception)
            {

            }

            // then
            Assert.True(credentialsProvider.WasInvalidated);
        }

        [Test]
        public async Task DuplexStreamingCall_InvalidatesTokenOnAuthError()
        {
            // having: server unary handler
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);
            SaltoapisAuthInterceptor credentialsInterceptor = new SaltoapisAuthInterceptor(credentialsProvider);

            helper.DuplexStreamingHandler = new DuplexStreamingServerMethod<string, string>((requestStream, responseStream, context) =>
            {
                throw new RpcException(new Status(StatusCode.Unauthenticated, ""));
            });

            // when
            CallInvoker invoker = ChannelExtensions.Intercept(channel, credentialsInterceptor);
            var call = helper.CreateDuplexStreamingCall(invoker);
            try
            {
                // receive response (otherwise it gets stuck)
                await call.ResponseStream.ToListAsync();
            }
            catch (Exception)
            {

            }

            // then
            Assert.True(credentialsProvider.WasInvalidated);
        }


        bool MetadataContainsAuth(Metadata metadata, string credentials)
        {
            var auth = metadata.GetAll("authorization");
            foreach (var m in auth)
            {
                if (String.Equals(m.Key, "authorization", StringComparison.OrdinalIgnoreCase) 
                    && String.Equals(m.Value, $"bearer {credentials}", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

    }

    internal class TestCredentialsProvider : OAuthClientCredentialsProvider
    {
        string credentials;
        bool wasInvalidated = false;
        internal TestCredentialsProvider(string credentials) {
            this.credentials = credentials;
        }

        public Task<string> GetToken()
        {
            return Task.Run(() => this.credentials);
        }

        public void InvalidateToken() {
            wasInvalidated = true;
        }

        public bool WasInvalidated {
            get
            {
                return this.wasInvalidated;
            }
        }
        
    }

    /// <summary>
    /// Allows setting up a mock service in the client-server tests easily.
    /// </summary>
    public class MockServiceHelper
    {
        public const string ServiceName = "tests.Test";

        readonly string host;
        readonly IEnumerable<ChannelOption> channelOptions;

        public readonly Method<string, string> unaryMethod;
        readonly Method<string, string> clientStreamingMethod;
        readonly Method<string, string> serverStreamingMethod;
        readonly Method<string, string> duplexStreamingMethod;

        UnaryServerMethod<string, string> unaryHandler;
        ClientStreamingServerMethod<string, string> clientStreamingHandler;
        ServerStreamingServerMethod<string, string> serverStreamingHandler;
        DuplexStreamingServerMethod<string, string> duplexStreamingHandler;

        Server server;
        Channel channel;

        public MockServiceHelper(string host = null, Marshaller<string> marshaller = null, IEnumerable<ChannelOption> channelOptions = null)
        {
            this.host = host ?? "localhost";
            this.channelOptions = channelOptions;
            marshaller = marshaller ?? Marshallers.StringMarshaller;

            unaryMethod = new Method<string, string>(
                MethodType.Unary,
                ServiceName,
                "Unary",
                marshaller,
                marshaller);

            clientStreamingMethod = new Method<string, string>(
                MethodType.ClientStreaming,
                ServiceName,
                "ClientStreaming",
                marshaller,
                marshaller);

            serverStreamingMethod = new Method<string, string>(
                MethodType.ServerStreaming,
                ServiceName,
                "ServerStreaming",
                marshaller,
                marshaller);

            duplexStreamingMethod = new Method<string, string>(
                MethodType.DuplexStreaming,
                ServiceName,
                "DuplexStreaming",
                marshaller,
                marshaller);

            ServiceDefinition = ServerServiceDefinition.CreateBuilder()
                .AddMethod(unaryMethod, (request, context) => unaryHandler(request, context))
                .AddMethod(clientStreamingMethod, (requestStream, context) => clientStreamingHandler(requestStream, context))
                .AddMethod(serverStreamingMethod, (request, responseStream, context) => serverStreamingHandler(request, responseStream, context))
                .AddMethod(duplexStreamingMethod, (requestStream, responseStream, context) => duplexStreamingHandler(requestStream, responseStream, context))
                .Build();

            var defaultStatus = new Status(StatusCode.Unknown, "Default mock implementation. Please provide your own.");

            unaryHandler = new UnaryServerMethod<string, string>((request, context) =>
            {
                context.Status = defaultStatus;
                return Task.FromResult("");
            });

            clientStreamingHandler = new ClientStreamingServerMethod<string, string>((requestStream, context) =>
            {
                context.Status = defaultStatus;
                return Task.FromResult("");
            });

            serverStreamingHandler = new ServerStreamingServerMethod<string, string>((request, responseStream, context) =>
            {
                context.Status = defaultStatus;
                return TaskUtils.CompletedTask;
            });

            duplexStreamingHandler = new DuplexStreamingServerMethod<string, string>((requestStream, responseStream, context) =>
            {
                context.Status = defaultStatus;
                return TaskUtils.CompletedTask;
            });
        }

        /// <summary>
        /// Returns the default server for this service and creates one if not yet created.
        /// </summary>
        public Server GetServer()
        {
            if (server == null)
            {
                // Disable SO_REUSEPORT to prevent https://github.com/grpc/grpc/issues/10755
                server = new Server(new[] { new ChannelOption(ChannelOptions.SoReuseport, 0) })
                {
                    Services = { ServiceDefinition },
                    Ports = { { Host, ServerPort.PickUnused, ServerCredentials.Insecure } }
                };
            }
            return server;
        }

        /// <summary>
        /// Returns the default channel for this service and creates one if not yet created.
        /// </summary>
        public Channel GetChannel()
        {
            if (channel == null)
            {
                channel = new Channel(Host, GetServer().Ports.Single().BoundPort, ChannelCredentials.Insecure, channelOptions);
            }
            return channel;
        }

        public string CreateBlockingUnaryCall(CallInvoker invoker, string request, CallOptions options = default(CallOptions))
        {
            return invoker.BlockingUnaryCall(unaryMethod, Host, options, request);
        }

        public AsyncUnaryCall<string> CreateAsyncUnaryCall(CallInvoker invoker, string request, CallOptions options = default(CallOptions))
        {
            return invoker.AsyncUnaryCall(unaryMethod, Host, options, request);
        }

        public AsyncClientStreamingCall<string, string> CreateClientStreamingCall(CallInvoker invoker, CallOptions options = default(CallOptions))
        {
            return invoker.AsyncClientStreamingCall(clientStreamingMethod, Host, options);
        }

        public AsyncServerStreamingCall<string> CreateServerStreamingCall(CallInvoker invoker, string request, CallOptions options = default(CallOptions))
        {
            return invoker.AsyncServerStreamingCall(serverStreamingMethod, Host, options, request);
        }

        public AsyncDuplexStreamingCall<string, string> CreateDuplexStreamingCall(CallInvoker invoker, CallOptions options = default(CallOptions))
        {
            return invoker.AsyncDuplexStreamingCall(duplexStreamingMethod, Host, options);
        }

        public string Host
        {
            get
            {
                return this.host;
            }
        }

        public ServerServiceDefinition ServiceDefinition { get; set; }
      
        public UnaryServerMethod<string, string> UnaryHandler
        {
            get
            {
                return this.unaryHandler;
            }

            set
            {
                unaryHandler = value;
            }
        }

        public ClientStreamingServerMethod<string, string> ClientStreamingHandler
        {
            get
            {
                return this.clientStreamingHandler;
            }

            set
            {
                clientStreamingHandler = value;
            }
        }

        public ServerStreamingServerMethod<string, string> ServerStreamingHandler
        {
            get
            {
                return this.serverStreamingHandler;
            }

            set
            {
                serverStreamingHandler = value;
            }
        }

        public DuplexStreamingServerMethod<string, string> DuplexStreamingHandler
        {
            get
            {
                return this.duplexStreamingHandler;
            }

            set
            {
                duplexStreamingHandler = value;
            }
        }
    }
}
