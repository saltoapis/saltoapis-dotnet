// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/nebula/mobilekey/v1/mobile_key.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Saltoapis.Nebula.MobileKey.V1 {
  /// <summary>
  /// MobileKeyService is the service responsible for managing mobile key
  /// resources. This service manages resources for the different types of keys
  /// that exisit on mobile devices such as app keys.
  /// </summary>
  public static partial class MobileKeyService
  {
    static readonly string __ServiceName = "salto.nebula.mobilekey.v1.MobileKeyService";

    static readonly grpc::Marshaller<global::Saltoapis.Nebula.MobileKey.V1.CreateMobileKeyRequest> __Marshaller_salto_nebula_mobilekey_v1_CreateMobileKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.MobileKey.V1.CreateMobileKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.MobileKey.V1.MobileKey> __Marshaller_salto_nebula_mobilekey_v1_MobileKey = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.MobileKey.V1.MobileKey.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.MobileKey.V1.GetMobileKeyRequest> __Marshaller_salto_nebula_mobilekey_v1_GetMobileKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.MobileKey.V1.GetMobileKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysRequest> __Marshaller_salto_nebula_mobilekey_v1_ListMobileKeysRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysResponse> __Marshaller_salto_nebula_mobilekey_v1_ListMobileKeysResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.MobileKey.V1.UpdateMobileKeyRequest> __Marshaller_salto_nebula_mobilekey_v1_UpdateMobileKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.MobileKey.V1.UpdateMobileKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.MobileKey.V1.DeleteMobileKeyRequest> __Marshaller_salto_nebula_mobilekey_v1_DeleteMobileKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.MobileKey.V1.DeleteMobileKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Saltoapis.Nebula.MobileKey.V1.CreateMobileKeyRequest, global::Saltoapis.Nebula.MobileKey.V1.MobileKey> __Method_CreateMobileKey = new grpc::Method<global::Saltoapis.Nebula.MobileKey.V1.CreateMobileKeyRequest, global::Saltoapis.Nebula.MobileKey.V1.MobileKey>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateMobileKey",
        __Marshaller_salto_nebula_mobilekey_v1_CreateMobileKeyRequest,
        __Marshaller_salto_nebula_mobilekey_v1_MobileKey);

    static readonly grpc::Method<global::Saltoapis.Nebula.MobileKey.V1.GetMobileKeyRequest, global::Saltoapis.Nebula.MobileKey.V1.MobileKey> __Method_GetMobileKey = new grpc::Method<global::Saltoapis.Nebula.MobileKey.V1.GetMobileKeyRequest, global::Saltoapis.Nebula.MobileKey.V1.MobileKey>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMobileKey",
        __Marshaller_salto_nebula_mobilekey_v1_GetMobileKeyRequest,
        __Marshaller_salto_nebula_mobilekey_v1_MobileKey);

    static readonly grpc::Method<global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysRequest, global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysResponse> __Method_ListMobileKeys = new grpc::Method<global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysRequest, global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListMobileKeys",
        __Marshaller_salto_nebula_mobilekey_v1_ListMobileKeysRequest,
        __Marshaller_salto_nebula_mobilekey_v1_ListMobileKeysResponse);

    static readonly grpc::Method<global::Saltoapis.Nebula.MobileKey.V1.UpdateMobileKeyRequest, global::Saltoapis.Nebula.MobileKey.V1.MobileKey> __Method_UpdateMobileKey = new grpc::Method<global::Saltoapis.Nebula.MobileKey.V1.UpdateMobileKeyRequest, global::Saltoapis.Nebula.MobileKey.V1.MobileKey>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateMobileKey",
        __Marshaller_salto_nebula_mobilekey_v1_UpdateMobileKeyRequest,
        __Marshaller_salto_nebula_mobilekey_v1_MobileKey);

    static readonly grpc::Method<global::Saltoapis.Nebula.MobileKey.V1.DeleteMobileKeyRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteMobileKey = new grpc::Method<global::Saltoapis.Nebula.MobileKey.V1.DeleteMobileKeyRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteMobileKey",
        __Marshaller_salto_nebula_mobilekey_v1_DeleteMobileKeyRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Saltoapis.Nebula.MobileKey.V1.MobileKeyReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for MobileKeyService</summary>
    public partial class MobileKeyServiceClient : grpc::ClientBase<MobileKeyServiceClient>
    {
      /// <summary>Creates a new client for MobileKeyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MobileKeyServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MobileKeyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MobileKeyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MobileKeyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MobileKeyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Create a mobile key
      ///
      /// Creates a new mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.MobileKey.V1.MobileKey CreateMobileKey(global::Saltoapis.Nebula.MobileKey.V1.CreateMobileKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateMobileKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create a mobile key
      ///
      /// Creates a new mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.MobileKey.V1.MobileKey CreateMobileKey(global::Saltoapis.Nebula.MobileKey.V1.CreateMobileKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateMobileKey, null, options, request);
      }
      /// <summary>
      /// Create a mobile key
      ///
      /// Creates a new mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.MobileKey.V1.MobileKey> CreateMobileKeyAsync(global::Saltoapis.Nebula.MobileKey.V1.CreateMobileKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateMobileKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create a mobile key
      ///
      /// Creates a new mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.MobileKey.V1.MobileKey> CreateMobileKeyAsync(global::Saltoapis.Nebula.MobileKey.V1.CreateMobileKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateMobileKey, null, options, request);
      }
      /// <summary>
      /// Get a mobile key
      ///
      /// Gets an existing mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.MobileKey.V1.MobileKey GetMobileKey(global::Saltoapis.Nebula.MobileKey.V1.GetMobileKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMobileKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a mobile key
      ///
      /// Gets an existing mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.MobileKey.V1.MobileKey GetMobileKey(global::Saltoapis.Nebula.MobileKey.V1.GetMobileKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetMobileKey, null, options, request);
      }
      /// <summary>
      /// Get a mobile key
      ///
      /// Gets an existing mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.MobileKey.V1.MobileKey> GetMobileKeyAsync(global::Saltoapis.Nebula.MobileKey.V1.GetMobileKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMobileKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a mobile key
      ///
      /// Gets an existing mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.MobileKey.V1.MobileKey> GetMobileKeyAsync(global::Saltoapis.Nebula.MobileKey.V1.GetMobileKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetMobileKey, null, options, request);
      }
      /// <summary>
      /// List mobile keys
      ///
      /// Returns a list of mobile keys that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysResponse ListMobileKeys(global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListMobileKeys(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List mobile keys
      ///
      /// Returns a list of mobile keys that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysResponse ListMobileKeys(global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListMobileKeys, null, options, request);
      }
      /// <summary>
      /// List mobile keys
      ///
      /// Returns a list of mobile keys that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysResponse> ListMobileKeysAsync(global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListMobileKeysAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List mobile keys
      ///
      /// Returns a list of mobile keys that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysResponse> ListMobileKeysAsync(global::Saltoapis.Nebula.MobileKey.V1.ListMobileKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListMobileKeys, null, options, request);
      }
      /// <summary>
      /// Update a mobile key
      ///
      /// Updates an existing mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.MobileKey.V1.MobileKey UpdateMobileKey(global::Saltoapis.Nebula.MobileKey.V1.UpdateMobileKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateMobileKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update a mobile key
      ///
      /// Updates an existing mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.MobileKey.V1.MobileKey UpdateMobileKey(global::Saltoapis.Nebula.MobileKey.V1.UpdateMobileKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateMobileKey, null, options, request);
      }
      /// <summary>
      /// Update a mobile key
      ///
      /// Updates an existing mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.MobileKey.V1.MobileKey> UpdateMobileKeyAsync(global::Saltoapis.Nebula.MobileKey.V1.UpdateMobileKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateMobileKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update a mobile key
      ///
      /// Updates an existing mobile key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.MobileKey.V1.MobileKey> UpdateMobileKeyAsync(global::Saltoapis.Nebula.MobileKey.V1.UpdateMobileKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateMobileKey, null, options, request);
      }
      /// <summary>
      /// Delete a mobile key
      ///
      /// Permanently deletes a mobile key. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteMobileKey(global::Saltoapis.Nebula.MobileKey.V1.DeleteMobileKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteMobileKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete a mobile key
      ///
      /// Permanently deletes a mobile key. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteMobileKey(global::Saltoapis.Nebula.MobileKey.V1.DeleteMobileKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteMobileKey, null, options, request);
      }
      /// <summary>
      /// Delete a mobile key
      ///
      /// Permanently deletes a mobile key. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteMobileKeyAsync(global::Saltoapis.Nebula.MobileKey.V1.DeleteMobileKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteMobileKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete a mobile key
      ///
      /// Permanently deletes a mobile key. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteMobileKeyAsync(global::Saltoapis.Nebula.MobileKey.V1.DeleteMobileKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteMobileKey, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MobileKeyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MobileKeyServiceClient(configuration);
      }
    }

  }
}
#endregion
