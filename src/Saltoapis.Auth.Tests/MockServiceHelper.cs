using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Core.Utils;

namespace workspace.Tests
{
    /// <summary>
    /// Allows setting up a mock service in the client-server tests easily.
    /// </summary>
    public class MockServiceHelper
    {
        public const string ServiceName = "tests.Test";

        readonly string host;
        readonly IEnumerable<ChannelOption> channelOptions;
        readonly ServerCredentials serverCredentials;

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

        public MockServiceHelper(
            string host = null,
            Marshaller<string> marshaller = null,
            IEnumerable<ChannelOption> channelOptions = null,
            ServerCredentials serverCredentials = null)
        {
            this.host = host ?? "localhost";
            this.channelOptions = channelOptions;
            this.serverCredentials = serverCredentials ?? ServerCredentials.Insecure;
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
                    Ports = { { Host, ServerPort.PickUnused, serverCredentials } }
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

        public Channel SetChannelCredentials(ChannelCredentials credentials)
        {
            channel = new Channel(Host, GetServer().Ports.Single().BoundPort, credentials, channelOptions);
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
