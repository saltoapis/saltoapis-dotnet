// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/nebula/type/device_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Saltoapis.Nebula.Type {

  /// <summary>Holder for reflection information generated from salto/nebula/type/device_type.proto</summary>
  public static partial class DeviceTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for salto/nebula/type/device_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeviceTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNzYWx0by9uZWJ1bGEvdHlwZS9kZXZpY2VfdHlwZS5wcm90bxIRc2FsdG8u",
            "bmVidWxhLnR5cGUqmwEKCkRldmljZVR5cGUSGwoXREVWSUNFX1RZUEVfVU5T",
            "UEVDSUZJRUQQABITCg9FTEVDVFJPTklDX0xPQ0sQARILCgdHQVRFV0FZEAIS",
            "DAoIRVhURU5ERVIQAxILCgdFTkNPREVSEAQSDgoKQ09OVFJPTExFUhAFEhQK",
            "EElOVEVSQ09NX0FEQVBUT1IQBhINCglVTk5BTUVEXzEQB0LQAQoZY29tLnNh",
            "bHRvYXBpcy5uZWJ1bGEudHlwZUIPRGV2aWNlVHlwZVByb3RvUAFaTGdpdGh1",
            "Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3NhbHRvYXBpcy1nby9uZWJ1bGEv",
            "dHlwZS9kZXZpY2V0eXBlO2RldmljZXR5cGWqAhVTYWx0b2FwaXMuTmVidWxh",
            "LlR5cGXKAhVTYWx0b2FwaXNcTmVidWxhXFR5cGXiAiFHUEJNZXRhZGF0YVxT",
            "YWx0b2FwaXNcTmVidWxhXFR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Saltoapis.Nebula.Type.DeviceType), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Represents the device types.
  /// </summary>
  public enum DeviceType {
    /// <summary>
    /// Unspecified
    /// </summary>
    [pbr::OriginalName("DEVICE_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Electronic lock
    /// </summary>
    [pbr::OriginalName("ELECTRONIC_LOCK")] ElectronicLock = 1,
    /// <summary>
    /// Gateway
    /// </summary>
    [pbr::OriginalName("GATEWAY")] Gateway = 2,
    /// <summary>
    /// Extender
    /// </summary>
    [pbr::OriginalName("EXTENDER")] Extender = 3,
    /// <summary>
    /// Encoder
    /// </summary>
    [pbr::OriginalName("ENCODER")] Encoder = 4,
    /// <summary>
    /// Controller
    /// </summary>
    [pbr::OriginalName("CONTROLLER")] Controller = 5,
    /// <summary>
    /// Intercom Adaptor
    /// </summary>
    [pbr::OriginalName("INTERCOM_ADAPTOR")] IntercomAdaptor = 6,
    [pbr::OriginalName("UNNAMED_1")] Unnamed1 = 7,
  }

  #endregion

}

#endregion Designer generated code
