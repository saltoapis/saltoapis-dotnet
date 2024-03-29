// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/nebula/type/opening_mode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Saltoapis.Nebula.Type {

  /// <summary>Holder for reflection information generated from salto/nebula/type/opening_mode.proto</summary>
  public static partial class OpeningModeReflection {

    #region Descriptor
    /// <summary>File descriptor for salto/nebula/type/opening_mode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OpeningModeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRzYWx0by9uZWJ1bGEvdHlwZS9vcGVuaW5nX21vZGUucHJvdG8SEXNhbHRv",
            "Lm5lYnVsYS50eXBlKlYKC09wZW5pbmdNb2RlEhwKGE9QRU5JTkdfTU9ERV9V",
            "TlNQRUNJRklFRBAAEgoKBk9GRklDRRABEgoKBlRPR0dMRRACEhEKDVJJTkdf",
            "QU5EX09QRU4QDULNAQoZY29tLnNhbHRvYXBpcy5uZWJ1bGEudHlwZUIQT3Bl",
            "bmluZ01vZGVQcm90b1ABWkhnaXRodWIuY29tL3NhbHRvc3lzdGVtcy9zYWx0",
            "b2FwaXMtZ28vbmVidWxhL3R5cGUvb3BlbmluZ21vZGU7b3BlbmluZ21vZGWq",
            "AhVTYWx0b2FwaXMuTmVidWxhLlR5cGXKAhVTYWx0b2FwaXNcTmVidWxhXFR5",
            "cGXiAiFHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVidWxhXFR5cGViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Saltoapis.Nebula.Type.OpeningMode), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Represents an opening mode.
  /// </summary>
  public enum OpeningMode {
    /// <summary>
    /// Unspecified
    /// </summary>
    [pbr::OriginalName("OPENING_MODE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Office.
    /// </summary>
    [pbr::OriginalName("OFFICE")] Office = 1,
    /// <summary>
    /// Toggle.
    /// </summary>
    [pbr::OriginalName("TOGGLE")] Toggle = 2,
    /// <summary>
    /// Automatic opening for ICAD.
    /// </summary>
    [pbr::OriginalName("RING_AND_OPEN")] RingAndOpen = 13,
  }

  #endregion

}

#endregion Designer generated code
