// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/nebula/installation/v1/encrypted_payload.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Saltoapis.Nebula.Installation.V1 {

  /// <summary>Holder for reflection information generated from salto/nebula/installation/v1/encrypted_payload.proto</summary>
  public static partial class EncryptedPayloadReflection {

    #region Descriptor
    /// <summary>File descriptor for salto/nebula/installation/v1/encrypted_payload.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncryptedPayloadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRzYWx0by9uZWJ1bGEvaW5zdGFsbGF0aW9uL3YxL2VuY3J5cHRlZF9wYXls",
            "b2FkLnByb3RvEhxzYWx0by5uZWJ1bGEuaW5zdGFsbGF0aW9uLnYxIlIKHklu",
            "Z2VzdEVuY3J5cHRlZFBheWxvYWRzUmVxdWVzdBIUCgxpbnN0YWxsYXRpb24Y",
            "ASABKAkSGgoSZW5jcnlwdGVkX3BheWxvYWRzGAIgAygMIiEKH0luZ2VzdEVu",
            "Y3J5cHRlZFBheWxvYWRzUmVzcG9uc2UysgEKF0VuY3J5cHRlZFBheWxvYWRT",
            "ZXJ2aWNlEpYBChdJbmdlc3RFbmNyeXB0ZWRQYXlsb2FkcxI8LnNhbHRvLm5l",
            "YnVsYS5pbnN0YWxsYXRpb24udjEuSW5nZXN0RW5jcnlwdGVkUGF5bG9hZHNS",
            "ZXF1ZXN0Gj0uc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5Jbmdlc3RF",
            "bmNyeXB0ZWRQYXlsb2Fkc1Jlc3BvbnNlQoQCCiRjb20uc2FsdG9hcGlzLm5l",
            "YnVsYS5pbnN0YWxsYXRpb24udjFCFUVuY3J5cHRlZFBheWxvYWRQcm90b1AB",
            "Wk5naXRodWIuY29tL3NhbHRvYXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28v",
            "bmVidWxhL2luc3RhbGxhdGlvbi92MTtpbnN0YWxsYXRpb26qAiBTYWx0b2Fw",
            "aXMuTmVidWxhLkluc3RhbGxhdGlvbi5WMcoCIFNhbHRvYXBpc1xOZWJ1bGFc",
            "SW5zdGFsbGF0aW9uXFYx4gIsR1BCTWV0YWRhdGFcU2FsdG9hcGlzXE5lYnVs",
            "YVxJbnN0YWxsYXRpb25cVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Saltoapis.Nebula.Installation.V1.IngestEncryptedPayloadsRequest), global::Saltoapis.Nebula.Installation.V1.IngestEncryptedPayloadsRequest.Parser, new[]{ "Installation", "EncryptedPayloads" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Saltoapis.Nebula.Installation.V1.IngestEncryptedPayloadsResponse), global::Saltoapis.Nebula.Installation.V1.IngestEncryptedPayloadsResponse.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message for [`IngestEncryptedPayloads`][salto.nebula.installation.v1.EncryptedPayloadService.IngestEncryptedPayloads]
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class IngestEncryptedPayloadsRequest : pb::IMessage<IngestEncryptedPayloadsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IngestEncryptedPayloadsRequest> _parser = new pb::MessageParser<IngestEncryptedPayloadsRequest>(() => new IngestEncryptedPayloadsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IngestEncryptedPayloadsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Saltoapis.Nebula.Installation.V1.EncryptedPayloadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IngestEncryptedPayloadsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IngestEncryptedPayloadsRequest(IngestEncryptedPayloadsRequest other) : this() {
      installation_ = other.installation_;
      encryptedPayloads_ = other.encryptedPayloads_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IngestEncryptedPayloadsRequest Clone() {
      return new IngestEncryptedPayloadsRequest(this);
    }

    /// <summary>Field number for the "installation" field.</summary>
    public const int InstallationFieldNumber = 1;
    private string installation_ = "";
    /// <summary>
    /// The parent installation resource name.
    /// For example: `installations/surelock-homes-hq`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Installation {
      get { return installation_; }
      set {
        installation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "encrypted_payloads" field.</summary>
    public const int EncryptedPayloadsFieldNumber = 2;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_encryptedPayloads_codec
        = pb::FieldCodec.ForBytes(18);
    private readonly pbc::RepeatedField<pb::ByteString> encryptedPayloads_ = new pbc::RepeatedField<pb::ByteString>();
    /// <summary>
    /// The encrypted payloads to be ingested.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<pb::ByteString> EncryptedPayloads {
      get { return encryptedPayloads_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IngestEncryptedPayloadsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IngestEncryptedPayloadsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Installation != other.Installation) return false;
      if(!encryptedPayloads_.Equals(other.encryptedPayloads_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Installation.Length != 0) hash ^= Installation.GetHashCode();
      hash ^= encryptedPayloads_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Installation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Installation);
      }
      encryptedPayloads_.WriteTo(output, _repeated_encryptedPayloads_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Installation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Installation);
      }
      encryptedPayloads_.WriteTo(ref output, _repeated_encryptedPayloads_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Installation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Installation);
      }
      size += encryptedPayloads_.CalculateSize(_repeated_encryptedPayloads_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IngestEncryptedPayloadsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Installation.Length != 0) {
        Installation = other.Installation;
      }
      encryptedPayloads_.Add(other.encryptedPayloads_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Installation = input.ReadString();
            break;
          }
          case 18: {
            encryptedPayloads_.AddEntriesFrom(input, _repeated_encryptedPayloads_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Installation = input.ReadString();
            break;
          }
          case 18: {
            encryptedPayloads_.AddEntriesFrom(ref input, _repeated_encryptedPayloads_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The response message for [`IngestEncryptedPayloads`][salto.nebula.installation.v1.EncryptedPayloadService.IngestEncryptedPayloads]
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class IngestEncryptedPayloadsResponse : pb::IMessage<IngestEncryptedPayloadsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IngestEncryptedPayloadsResponse> _parser = new pb::MessageParser<IngestEncryptedPayloadsResponse>(() => new IngestEncryptedPayloadsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IngestEncryptedPayloadsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Saltoapis.Nebula.Installation.V1.EncryptedPayloadReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IngestEncryptedPayloadsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IngestEncryptedPayloadsResponse(IngestEncryptedPayloadsResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IngestEncryptedPayloadsResponse Clone() {
      return new IngestEncryptedPayloadsResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IngestEncryptedPayloadsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IngestEncryptedPayloadsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IngestEncryptedPayloadsResponse other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
