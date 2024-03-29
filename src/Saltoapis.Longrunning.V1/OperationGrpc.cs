// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/longrunning/v1/operation.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Saltoapis.Longrunning.V1 {
  /// <summary>
  /// Manages long-running operations with an API service.
  ///
  /// When an API method normally takes long time to complete, it can be designed
  /// to return [`Operation`][salto.longrunning.v1.Operation] to the client, and the
  /// client can use this interface to receive the real response asynchronously by
  /// polling the operation resource, or pass the operation resource to another API
  /// to receive the response. Any API service that returns long-running operations
  /// should implement the `OperationService` interface so developers can have a
  /// consistent client experience.
  /// </summary>
  public static partial class OperationService
  {
    static readonly string __ServiceName = "salto.longrunning.v1.OperationService";

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
    static readonly grpc::Marshaller<global::Saltoapis.Longrunning.V1.GetOperationRequest> __Marshaller_salto_longrunning_v1_GetOperationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Longrunning.V1.GetOperationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Longrunning.V1.Operation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Longrunning.V1.ListOperationsRequest> __Marshaller_salto_longrunning_v1_ListOperationsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Longrunning.V1.ListOperationsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Longrunning.V1.ListOperationsResponse> __Marshaller_salto_longrunning_v1_ListOperationsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Longrunning.V1.ListOperationsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Longrunning.V1.DeleteOperationRequest> __Marshaller_salto_longrunning_v1_DeleteOperationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Longrunning.V1.DeleteOperationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Saltoapis.Longrunning.V1.CancelOperationRequest> __Marshaller_salto_longrunning_v1_CancelOperationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Longrunning.V1.CancelOperationRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Saltoapis.Longrunning.V1.GetOperationRequest, global::Saltoapis.Longrunning.V1.Operation> __Method_GetOperation = new grpc::Method<global::Saltoapis.Longrunning.V1.GetOperationRequest, global::Saltoapis.Longrunning.V1.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOperation",
        __Marshaller_salto_longrunning_v1_GetOperationRequest,
        __Marshaller_salto_longrunning_v1_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Saltoapis.Longrunning.V1.ListOperationsRequest, global::Saltoapis.Longrunning.V1.ListOperationsResponse> __Method_ListOperations = new grpc::Method<global::Saltoapis.Longrunning.V1.ListOperationsRequest, global::Saltoapis.Longrunning.V1.ListOperationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListOperations",
        __Marshaller_salto_longrunning_v1_ListOperationsRequest,
        __Marshaller_salto_longrunning_v1_ListOperationsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Saltoapis.Longrunning.V1.DeleteOperationRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteOperation = new grpc::Method<global::Saltoapis.Longrunning.V1.DeleteOperationRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteOperation",
        __Marshaller_salto_longrunning_v1_DeleteOperationRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Saltoapis.Longrunning.V1.CancelOperationRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CancelOperation = new grpc::Method<global::Saltoapis.Longrunning.V1.CancelOperationRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CancelOperation",
        __Marshaller_salto_longrunning_v1_CancelOperationRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Saltoapis.Longrunning.V1.OperationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for OperationService</summary>
    public partial class OperationServiceClient : grpc::ClientBase<OperationServiceClient>
    {
      /// <summary>Creates a new client for OperationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public OperationServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OperationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public OperationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected OperationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected OperationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Get a operation
      ///
      /// Retrieves an existing long-running operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Longrunning.V1.Operation GetOperation(global::Saltoapis.Longrunning.V1.GetOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOperation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a operation
      ///
      /// Retrieves an existing long-running operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Longrunning.V1.Operation GetOperation(global::Saltoapis.Longrunning.V1.GetOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOperation, null, options, request);
      }
      /// <summary>
      /// Get a operation
      ///
      /// Retrieves an existing long-running operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Longrunning.V1.Operation> GetOperationAsync(global::Saltoapis.Longrunning.V1.GetOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOperationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a operation
      ///
      /// Retrieves an existing long-running operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Longrunning.V1.Operation> GetOperationAsync(global::Saltoapis.Longrunning.V1.GetOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOperation, null, options, request);
      }
      /// <summary>
      /// List operations
      ///
      /// Returns a list of long-running operations that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Longrunning.V1.ListOperationsResponse ListOperations(global::Saltoapis.Longrunning.V1.ListOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListOperations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List operations
      ///
      /// Returns a list of long-running operations that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Saltoapis.Longrunning.V1.ListOperationsResponse ListOperations(global::Saltoapis.Longrunning.V1.ListOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>
      /// List operations
      ///
      /// Returns a list of long-running operations that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Longrunning.V1.ListOperationsResponse> ListOperationsAsync(global::Saltoapis.Longrunning.V1.ListOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListOperationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List operations
      ///
      /// Returns a list of long-running operations that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Longrunning.V1.ListOperationsResponse> ListOperationsAsync(global::Saltoapis.Longrunning.V1.ListOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>
      /// Delete an operation
      ///
      /// Permanently deletes a long-running operation. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteOperation(global::Saltoapis.Longrunning.V1.DeleteOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteOperation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete an operation
      ///
      /// Permanently deletes a long-running operation. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteOperation(global::Saltoapis.Longrunning.V1.DeleteOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteOperation, null, options, request);
      }
      /// <summary>
      /// Delete an operation
      ///
      /// Permanently deletes a long-running operation. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteOperationAsync(global::Saltoapis.Longrunning.V1.DeleteOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteOperationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete an operation
      ///
      /// Permanently deletes a long-running operation. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteOperationAsync(global::Saltoapis.Longrunning.V1.DeleteOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteOperation, null, options, request);
      }
      /// <summary>
      /// Cancel an operation
      ///
      /// Starts asynchronous cancellation on a long-running operation. The server
      /// makes a best effort to cancel the operation, but success is not
      /// guaranteed. Clients can use
      /// [OperationService.GetOperation][salto.longrunning.v1.OperationService.GetOperation]
      /// or other methods to check whether the cancellation succeeded or whether
      /// the operation completed despite cancellation. On successful cancellation,
      /// the operation is not deleted; instead, it becomes an operation with an
      /// [Operation.error][salto.longrunning.v1.Operation.error] value with a
      /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
      /// `Code.CANCELLED`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty CancelOperation(global::Saltoapis.Longrunning.V1.CancelOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelOperation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Cancel an operation
      ///
      /// Starts asynchronous cancellation on a long-running operation. The server
      /// makes a best effort to cancel the operation, but success is not
      /// guaranteed. Clients can use
      /// [OperationService.GetOperation][salto.longrunning.v1.OperationService.GetOperation]
      /// or other methods to check whether the cancellation succeeded or whether
      /// the operation completed despite cancellation. On successful cancellation,
      /// the operation is not deleted; instead, it becomes an operation with an
      /// [Operation.error][salto.longrunning.v1.Operation.error] value with a
      /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
      /// `Code.CANCELLED`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty CancelOperation(global::Saltoapis.Longrunning.V1.CancelOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CancelOperation, null, options, request);
      }
      /// <summary>
      /// Cancel an operation
      ///
      /// Starts asynchronous cancellation on a long-running operation. The server
      /// makes a best effort to cancel the operation, but success is not
      /// guaranteed. Clients can use
      /// [OperationService.GetOperation][salto.longrunning.v1.OperationService.GetOperation]
      /// or other methods to check whether the cancellation succeeded or whether
      /// the operation completed despite cancellation. On successful cancellation,
      /// the operation is not deleted; instead, it becomes an operation with an
      /// [Operation.error][salto.longrunning.v1.Operation.error] value with a
      /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
      /// `Code.CANCELLED`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> CancelOperationAsync(global::Saltoapis.Longrunning.V1.CancelOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelOperationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Cancel an operation
      ///
      /// Starts asynchronous cancellation on a long-running operation. The server
      /// makes a best effort to cancel the operation, but success is not
      /// guaranteed. Clients can use
      /// [OperationService.GetOperation][salto.longrunning.v1.OperationService.GetOperation]
      /// or other methods to check whether the cancellation succeeded or whether
      /// the operation completed despite cancellation. On successful cancellation,
      /// the operation is not deleted; instead, it becomes an operation with an
      /// [Operation.error][salto.longrunning.v1.Operation.error] value with a
      /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
      /// `Code.CANCELLED`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> CancelOperationAsync(global::Saltoapis.Longrunning.V1.CancelOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CancelOperation, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override OperationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OperationServiceClient(configuration);
      }
    }

  }
}
#endregion
