// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/nebula/types/v1/key_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Saltoapis.Nebula.Types.V1 {

  /// <summary>Holder for reflection information generated from salto/nebula/types/v1/key_type.proto</summary>
  public static partial class KeyTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for salto/nebula/types/v1/key_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeyTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRzYWx0by9uZWJ1bGEvdHlwZXMvdjEva2V5X3R5cGUucHJvdG8SFXNhbHRv",
            "Lm5lYnVsYS50eXBlcy52MSpRCgdLZXlUeXBlEhgKFEtFWV9UWVBFX1VOU1BF",
            "Q0lGSUVEEAASCAoEQ0FSRBABEgcKA0FQUBACEgcKA1RBRxADEgcKA1VIRhAE",
            "EgcKA1BJThAFQpUBCh1jb20uc2FsdG9hcGlzLm5lYnVsYS50eXBlcy52MUIM",
            "S2V5VHlwZVByb3RvUAFaSGdpdGxhYi5ybmQuc2FsdG9zeXN0ZW1zLmNvbS9z",
            "YWx0b2FwaXMvc2FsdG9hcGlzLWdvL25lYnVsYS90eXBlcy92MTt0eXBlc6oC",
            "GVNhbHRvYXBpcy5OZWJ1bGEuVHlwZXMuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Saltoapis.Nebula.Types.V1.KeyType), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Represents the key types.
  /// </summary>
  public enum KeyType {
    /// <summary>
    /// Unspecified
    /// </summary>
    [pbr::OriginalName("KEY_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Card Key
    /// </summary>
    [pbr::OriginalName("CARD")] Card = 1,
    /// <summary>
    /// App Key
    /// </summary>
    [pbr::OriginalName("APP")] App = 2,
    /// <summary>
    /// Tag Key
    /// </summary>
    [pbr::OriginalName("TAG")] Tag = 3,
    /// <summary>
    /// UHF Key
    /// </summary>
    [pbr::OriginalName("UHF")] Uhf = 4,
    /// <summary>
    /// Pin key
    /// </summary>
    [pbr::OriginalName("PIN")] Pin = 5,
  }

  #endregion

}

#endregion Designer generated code
