// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/nebula/device/v1/device.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Saltoapis.Nebula.Device.V1 {
  /// <summary>
  /// A device could be an electronic lock, gateway, extender or any piece of
  /// hardware manufactured by SALTO. This service provides access to an aggregated
  /// view of all of them in an eventual consistent way.
  /// </summary>
  public static partial class DeviceService
  {
    static readonly string __ServiceName = "salto.nebula.device.v1.DeviceService";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::Saltoapis.Nebula.Device.V1.GetDeviceRequest> __Marshaller_salto_nebula_device_v1_GetDeviceRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.Device.V1.GetDeviceRequest.Parser));
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.Device.V1.Device> __Marshaller_salto_nebula_device_v1_Device = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.Device.V1.Device.Parser));
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.Device.V1.ListDevicesRequest> __Marshaller_salto_nebula_device_v1_ListDevicesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.Device.V1.ListDevicesRequest.Parser));
    static readonly grpc::Marshaller<global::Saltoapis.Nebula.Device.V1.ListDevicesResponse> __Marshaller_salto_nebula_device_v1_ListDevicesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Saltoapis.Nebula.Device.V1.ListDevicesResponse.Parser));

    static readonly grpc::Method<global::Saltoapis.Nebula.Device.V1.GetDeviceRequest, global::Saltoapis.Nebula.Device.V1.Device> __Method_GetDevice = new grpc::Method<global::Saltoapis.Nebula.Device.V1.GetDeviceRequest, global::Saltoapis.Nebula.Device.V1.Device>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetDevice",
        __Marshaller_salto_nebula_device_v1_GetDeviceRequest,
        __Marshaller_salto_nebula_device_v1_Device);

    static readonly grpc::Method<global::Saltoapis.Nebula.Device.V1.ListDevicesRequest, global::Saltoapis.Nebula.Device.V1.ListDevicesResponse> __Method_ListDevices = new grpc::Method<global::Saltoapis.Nebula.Device.V1.ListDevicesRequest, global::Saltoapis.Nebula.Device.V1.ListDevicesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListDevices",
        __Marshaller_salto_nebula_device_v1_ListDevicesRequest,
        __Marshaller_salto_nebula_device_v1_ListDevicesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Saltoapis.Nebula.Device.V1.DeviceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for DeviceService</summary>
    public partial class DeviceServiceClient : grpc::ClientBase<DeviceServiceClient>
    {
      /// <summary>Creates a new client for DeviceService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DeviceServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DeviceService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DeviceServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DeviceServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DeviceServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Get a device
      ///
      /// Gets an existing device.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.Device.V1.Device GetDevice(global::Saltoapis.Nebula.Device.V1.GetDeviceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDevice(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a device
      ///
      /// Gets an existing device.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.Device.V1.Device GetDevice(global::Saltoapis.Nebula.Device.V1.GetDeviceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetDevice, null, options, request);
      }
      /// <summary>
      /// Get a device
      ///
      /// Gets an existing device.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.Device.V1.Device> GetDeviceAsync(global::Saltoapis.Nebula.Device.V1.GetDeviceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDeviceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a device
      ///
      /// Gets an existing device.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.Device.V1.Device> GetDeviceAsync(global::Saltoapis.Nebula.Device.V1.GetDeviceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetDevice, null, options, request);
      }
      /// <summary>
      /// List devices
      ///
      /// Returns a list of devices that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.Device.V1.ListDevicesResponse ListDevices(global::Saltoapis.Nebula.Device.V1.ListDevicesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDevices(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List devices
      ///
      /// Returns a list of devices that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Saltoapis.Nebula.Device.V1.ListDevicesResponse ListDevices(global::Saltoapis.Nebula.Device.V1.ListDevicesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListDevices, null, options, request);
      }
      /// <summary>
      /// List devices
      ///
      /// Returns a list of devices that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.Device.V1.ListDevicesResponse> ListDevicesAsync(global::Saltoapis.Nebula.Device.V1.ListDevicesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDevicesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List devices
      ///
      /// Returns a list of devices that have been previously created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Saltoapis.Nebula.Device.V1.ListDevicesResponse> ListDevicesAsync(global::Saltoapis.Nebula.Device.V1.ListDevicesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListDevices, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DeviceServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DeviceServiceClient(configuration);
      }
    }

  }
}
#endregion
