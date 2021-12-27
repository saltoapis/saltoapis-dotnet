// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/nebula/type/day_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Saltoapis.Nebula.Type {

  /// <summary>Holder for reflection information generated from salto/nebula/type/day_type.proto</summary>
  public static partial class DayTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for salto/nebula/type/day_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DayTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBzYWx0by9uZWJ1bGEvdHlwZS9kYXlfdHlwZS5wcm90bxIRc2FsdG8ubmVi",
            "dWxhLnR5cGUqWgoHRGF5VHlwZRIYChREQVlfVFlQRV9VTlNQRUNJRklFRBAA",
            "EgoKBk5PUk1BTBABEgsKB0hPTElEQVkQAhINCglTUEVDSUFMXzEQAxINCglT",
            "UEVDSUFMXzIQBEKKAQoZY29tLnNhbHRvYXBpcy5uZWJ1bGEudHlwZUIMRGF5",
            "VHlwZVByb3RvUAFaRWdpdGh1Yi5jb20vc2FsdG9hcGlzL3ByaXZhdGUtc2Fs",
            "dG9hcGlzLWdvL25lYnVsYS90eXBlL2RheXR5cGU7ZGF5dHlwZaoCFVNhbHRv",
            "YXBpcy5OZWJ1bGEuVHlwZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Saltoapis.Nebula.Type.DayType), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Represents the day types.
  /// </summary>
  public enum DayType {
    /// <summary>
    /// Unspecified
    /// </summary>
    [pbr::OriginalName("DAY_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Normal day
    /// </summary>
    [pbr::OriginalName("NORMAL")] Normal = 1,
    /// <summary>
    /// Holidays
    /// </summary>
    [pbr::OriginalName("HOLIDAY")] Holiday = 2,
    /// <summary>
    /// Special day type 1
    /// </summary>
    [pbr::OriginalName("SPECIAL_1")] Special1 = 3,
    /// <summary>
    /// Special day type 2
    /// </summary>
    [pbr::OriginalName("SPECIAL_2")] Special2 = 4,
  }

  #endregion

}

#endregion Designer generated code
