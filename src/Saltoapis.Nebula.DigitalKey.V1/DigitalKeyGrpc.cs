// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/nebula/digitalkey/v1/digital_key.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Saltoapis.Nebula.DigitalKey.V1 {
  /// <summary>
  /// DigitalKeyService is the service responsible for managing digital key
  /// resources. This service manages resources for the different types of keys
  /// that exist on mobile devices, such as app keys or wallet keys.
  /// </summary>
  public static partial class DigitalKeyService
  {
    static readonly string __ServiceName = "salto.nebula.digitalkey.v1.DigitalKeyService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyRequest> __Marshaller_salto_nebula_digitalkey_v1_GetDigitalKeyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.DigitalKey.V1.DigitalKey> __Marshaller_salto_nebula_digitalkey_v1_DigitalKey = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.DigitalKey.V1.DigitalKey.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysRequest> __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeysRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysResponse> __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeysResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyAccessPointRequest> __Marshaller_salto_nebula_digitalkey_v1_GetDigitalKeyAccessPointRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyAccessPointRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.DigitalKey.V1.DigitalKeyAccessPoint> __Marshaller_salto_nebula_digitalkey_v1_DigitalKeyAccessPoint = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.DigitalKey.V1.DigitalKeyAccessPoint.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsRequest> __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeyAccessPointsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsResponse> __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeyAccessPointsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyRequest, global::Saltoapis.Nebula.DigitalKey.V1.DigitalKey> __Method_GetDigitalKey = new grpc::Method<global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyRequest, global::Saltoapis.Nebula.DigitalKey.V1.DigitalKey>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetDigitalKey",
        __Marshaller_salto_nebula_digitalkey_v1_GetDigitalKeyRequest,
        __Marshaller_salto_nebula_digitalkey_v1_DigitalKey);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysRequest, global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysResponse> __Method_ListDigitalKeys = new grpc::Method<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysRequest, global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListDigitalKeys",
        __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeysRequest,
        __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeysResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyAccessPointRequest, global::Saltoapis.Nebula.DigitalKey.V1.DigitalKeyAccessPoint> __Method_GetDigitalKeyAccessPoint = new grpc::Method<global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyAccessPointRequest, global::Saltoapis.Nebula.DigitalKey.V1.DigitalKeyAccessPoint>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetDigitalKeyAccessPoint",
        __Marshaller_salto_nebula_digitalkey_v1_GetDigitalKeyAccessPointRequest,
        __Marshaller_salto_nebula_digitalkey_v1_DigitalKeyAccessPoint);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsRequest, global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsResponse> __Method_ListDigitalKeyAccessPoints = new grpc::Method<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsRequest, global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListDigitalKeyAccessPoints",
        __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeyAccessPointsRequest,
        __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeyAccessPointsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Saltoapis.Nebula.DigitalKey.V1.DigitalKeyReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for DigitalKeyService</summary>
    public partial class DigitalKeyServiceClient : grpc::ClientBase<DigitalKeyServiceClient>
    {
      /// <summary>Creates a new client for DigitalKeyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DigitalKeyServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DigitalKeyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DigitalKeyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DigitalKeyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DigitalKeyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Get a digital key
      ///
      /// Gets an existing digital key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Nebula.DigitalKey.V1.DigitalKey GetDigitalKey(global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDigitalKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a digital key
      ///
      /// Gets an existing digital key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Nebula.DigitalKey.V1.DigitalKey GetDigitalKey(global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetDigitalKey, null, options, request);
      }
      /// <summary>
      /// Get a digital key
      ///
      /// Gets an existing digital key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.DigitalKey.V1.DigitalKey> GetDigitalKeyAsync(global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDigitalKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a digital key
      ///
      /// Gets an existing digital key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.DigitalKey.V1.DigitalKey> GetDigitalKeyAsync(global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetDigitalKey, null, options, request);
      }
      /// <summary>
      /// List digital keys
      ///
      /// Returns a list of digital keys that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysResponse ListDigitalKeys(global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDigitalKeys(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List digital keys
      ///
      /// Returns a list of digital keys that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysResponse ListDigitalKeys(global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListDigitalKeys, null, options, request);
      }
      /// <summary>
      /// List digital keys
      ///
      /// Returns a list of digital keys that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysResponse> ListDigitalKeysAsync(global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDigitalKeysAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List digital keys
      ///
      /// Returns a list of digital keys that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysResponse> ListDigitalKeysAsync(global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListDigitalKeys, null, options, request);
      }
      /// <summary>
      /// Get an access point
      ///
      /// Gets an existing digital key's access point association.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Nebula.DigitalKey.V1.DigitalKeyAccessPoint GetDigitalKeyAccessPoint(global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyAccessPointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDigitalKeyAccessPoint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get an access point
      ///
      /// Gets an existing digital key's access point association.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Nebula.DigitalKey.V1.DigitalKeyAccessPoint GetDigitalKeyAccessPoint(global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyAccessPointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetDigitalKeyAccessPoint, null, options, request);
      }
      /// <summary>
      /// Get an access point
      ///
      /// Gets an existing digital key's access point association.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.DigitalKey.V1.DigitalKeyAccessPoint> GetDigitalKeyAccessPointAsync(global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyAccessPointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDigitalKeyAccessPointAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get an access point
      ///
      /// Gets an existing digital key's access point association.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.DigitalKey.V1.DigitalKeyAccessPoint> GetDigitalKeyAccessPointAsync(global::Saltoapis.Nebula.DigitalKey.V1.GetDigitalKeyAccessPointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetDigitalKeyAccessPoint, null, options, request);
      }
      /// <summary>
      /// List access points
      ///
      /// Lists an existing digital key's access point associations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsResponse ListDigitalKeyAccessPoints(global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDigitalKeyAccessPoints(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List access points
      ///
      /// Lists an existing digital key's access point associations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsResponse ListDigitalKeyAccessPoints(global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListDigitalKeyAccessPoints, null, options, request);
      }
      /// <summary>
      /// List access points
      ///
      /// Lists an existing digital key's access point associations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsResponse> ListDigitalKeyAccessPointsAsync(global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDigitalKeyAccessPointsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List access points
      ///
      /// Lists an existing digital key's access point associations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsResponse> ListDigitalKeyAccessPointsAsync(global::Saltoapis.Nebula.DigitalKey.V1.ListDigitalKeyAccessPointsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListDigitalKeyAccessPoints, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override DigitalKeyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DigitalKeyServiceClient(configuration);
      }
    }

  }
}
#endregion
