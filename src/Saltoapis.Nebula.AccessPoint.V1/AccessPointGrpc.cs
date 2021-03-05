// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/nebula/accesspoint/v1/access_point.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Saltoapis.Nebula.AccessPoint.V1 {
  /// <summary>
  /// An access point is a smart electronic locking device capable of granting or
  /// denying access to a secured area. This service is responsible for managing
  /// access point resources.
  /// </summary>
  public static partial class AccessPointService
  {
    static readonly string __ServiceName = "salto.nebula.accesspoint.v1.AccessPointService";

    static readonly grpc::Marshaller<global::Saltoapis.Nebula.AccessPoint.V1.CreateAccessPointRequest> __Marshaller_salto_nebula_accesspoint_v1_CreateAccessPointRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.AccessPoint.V1.CreateAccessPointRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint> __Marshaller_salto_nebula_accesspoint_v1_AccessPoint = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.AccessPoint.V1.GetAccessPointRequest> __Marshaller_salto_nebula_accesspoint_v1_GetAccessPointRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.AccessPoint.V1.GetAccessPointRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsRequest> __Marshaller_salto_nebula_accesspoint_v1_ListAccessPointsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsResponse> __Marshaller_salto_nebula_accesspoint_v1_ListAccessPointsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.AccessPoint.V1.UpdateAccessPointRequest> __Marshaller_salto_nebula_accesspoint_v1_UpdateAccessPointRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.AccessPoint.V1.UpdateAccessPointRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.AccessPoint.V1.DeleteAccessPointRequest> __Marshaller_salto_nebula_accesspoint_v1_DeleteAccessPointRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Saltoapis.Nebula.AccessPoint.V1.DeleteAccessPointRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Saltoapis.Nebula.AccessPoint.V1.CreateAccessPointRequest, global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint> __Method_CreateAccessPoint = new grpc::Method<global::Saltoapis.Nebula.AccessPoint.V1.CreateAccessPointRequest, global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateAccessPoint",
        __Marshaller_salto_nebula_accesspoint_v1_CreateAccessPointRequest,
        __Marshaller_salto_nebula_accesspoint_v1_AccessPoint);

    static readonly grpc::Method<global::Saltoapis.Nebula.AccessPoint.V1.GetAccessPointRequest, global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint> __Method_GetAccessPoint = new grpc::Method<global::Saltoapis.Nebula.AccessPoint.V1.GetAccessPointRequest, global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccessPoint",
        __Marshaller_salto_nebula_accesspoint_v1_GetAccessPointRequest,
        __Marshaller_salto_nebula_accesspoint_v1_AccessPoint);

    static readonly grpc::Method<global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsRequest, global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsResponse> __Method_ListAccessPoints = new grpc::Method<global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsRequest, global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListAccessPoints",
        __Marshaller_salto_nebula_accesspoint_v1_ListAccessPointsRequest,
        __Marshaller_salto_nebula_accesspoint_v1_ListAccessPointsResponse);

    static readonly grpc::Method<global::Saltoapis.Nebula.AccessPoint.V1.UpdateAccessPointRequest, global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint> __Method_UpdateAccessPoint = new grpc::Method<global::Saltoapis.Nebula.AccessPoint.V1.UpdateAccessPointRequest, global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateAccessPoint",
        __Marshaller_salto_nebula_accesspoint_v1_UpdateAccessPointRequest,
        __Marshaller_salto_nebula_accesspoint_v1_AccessPoint);

    static readonly grpc::Method<global::Saltoapis.Nebula.AccessPoint.V1.DeleteAccessPointRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAccessPoint = new grpc::Method<global::Saltoapis.Nebula.AccessPoint.V1.DeleteAccessPointRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteAccessPoint",
        __Marshaller_salto_nebula_accesspoint_v1_DeleteAccessPointRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Saltoapis.Nebula.AccessPoint.V1.AccessPointReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for AccessPointService</summary>
    public partial class AccessPointServiceClient : grpc::ClientBase<AccessPointServiceClient>
    {
      /// <summary>Creates a new client for AccessPointService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AccessPointServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AccessPointService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AccessPointServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AccessPointServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AccessPointServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Create an access point
      ///
      /// Creates a new access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint CreateAccessPoint(global::Saltoapis.Nebula.AccessPoint.V1.CreateAccessPointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAccessPoint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create an access point
      ///
      /// Creates a new access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint CreateAccessPoint(global::Saltoapis.Nebula.AccessPoint.V1.CreateAccessPointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateAccessPoint, null, options, request);
      }
      /// <summary>
      /// Create an access point
      ///
      /// Creates a new access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint> CreateAccessPointAsync(global::Saltoapis.Nebula.AccessPoint.V1.CreateAccessPointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAccessPointAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create an access point
      ///
      /// Creates a new access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint> CreateAccessPointAsync(global::Saltoapis.Nebula.AccessPoint.V1.CreateAccessPointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateAccessPoint, null, options, request);
      }
      /// <summary>
      /// Get an access point
      ///
      /// Retrieves an existing access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint GetAccessPoint(global::Saltoapis.Nebula.AccessPoint.V1.GetAccessPointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccessPoint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get an access point
      ///
      /// Retrieves an existing access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint GetAccessPoint(global::Saltoapis.Nebula.AccessPoint.V1.GetAccessPointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAccessPoint, null, options, request);
      }
      /// <summary>
      /// Get an access point
      ///
      /// Retrieves an existing access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint> GetAccessPointAsync(global::Saltoapis.Nebula.AccessPoint.V1.GetAccessPointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccessPointAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get an access point
      ///
      /// Retrieves an existing access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint> GetAccessPointAsync(global::Saltoapis.Nebula.AccessPoint.V1.GetAccessPointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAccessPoint, null, options, request);
      }
      /// <summary>
      /// List access points
      ///
      /// Returns a list of access points that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsResponse ListAccessPoints(global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAccessPoints(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List access points
      ///
      /// Returns a list of access points that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsResponse ListAccessPoints(global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListAccessPoints, null, options, request);
      }
      /// <summary>
      /// List access points
      ///
      /// Returns a list of access points that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsResponse> ListAccessPointsAsync(global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAccessPointsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List access points
      ///
      /// Returns a list of access points that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsResponse> ListAccessPointsAsync(global::Saltoapis.Nebula.AccessPoint.V1.ListAccessPointsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListAccessPoints, null, options, request);
      }
      /// <summary>
      /// Update an access point
      ///
      /// Updates an existing access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint UpdateAccessPoint(global::Saltoapis.Nebula.AccessPoint.V1.UpdateAccessPointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAccessPoint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update an access point
      ///
      /// Updates an existing access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint UpdateAccessPoint(global::Saltoapis.Nebula.AccessPoint.V1.UpdateAccessPointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateAccessPoint, null, options, request);
      }
      /// <summary>
      /// Update an access point
      ///
      /// Updates an existing access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint> UpdateAccessPointAsync(global::Saltoapis.Nebula.AccessPoint.V1.UpdateAccessPointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAccessPointAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update an access point
      ///
      /// Updates an existing access point.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.AccessPoint.V1.AccessPoint> UpdateAccessPointAsync(global::Saltoapis.Nebula.AccessPoint.V1.UpdateAccessPointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateAccessPoint, null, options, request);
      }
      /// <summary>
      /// Delete an access point
      ///
      /// Permanently deletes an access point. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteAccessPoint(global::Saltoapis.Nebula.AccessPoint.V1.DeleteAccessPointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAccessPoint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete an access point
      ///
      /// Permanently deletes an access point. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteAccessPoint(global::Saltoapis.Nebula.AccessPoint.V1.DeleteAccessPointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteAccessPoint, null, options, request);
      }
      /// <summary>
      /// Delete an access point
      ///
      /// Permanently deletes an access point. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAccessPointAsync(global::Saltoapis.Nebula.AccessPoint.V1.DeleteAccessPointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAccessPointAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete an access point
      ///
      /// Permanently deletes an access point. This cannot be undone.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAccessPointAsync(global::Saltoapis.Nebula.AccessPoint.V1.DeleteAccessPointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteAccessPoint, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AccessPointServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccessPointServiceClient(configuration);
      }
    }

  }
}
#endregion
