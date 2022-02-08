// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: salto/nebula/type/device_metadata.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Saltoapis.Nebula.Type {

  /// <summary>Holder for reflection information generated from salto/nebula/type/device_metadata.proto</summary>
  public static partial class DeviceMetadataReflection {

    #region Descriptor
    /// <summary>File descriptor for salto/nebula/type/device_metadata.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeviceMetadataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidzYWx0by9uZWJ1bGEvdHlwZS9kZXZpY2VfbWV0YWRhdGEucHJvdG8SEXNh",
            "bHRvLm5lYnVsYS50eXBlGhVzYWx0by90eXBlL2RhdGUucHJvdG8ipQIKDkRl",
            "dmljZU1ldGFkYXRhEkYKDmNpcmN1aXRfYm9hcmRzGAEgAygLMi4uc2FsdG8u",
            "bmVidWxhLnR5cGUuRGV2aWNlTWV0YWRhdGEuQ2lyY3VpdEJvYXJkGsoBCgxD",
            "aXJjdWl0Qm9hcmQSKgoQbWFudWZhY3R1cmVfZGF0ZRgCIAEoCzIQLnNhbHRv",
            "LnR5cGUuRGF0ZRIVCg1zZXJpYWxfbnVtYmVyGAMgASgJEkoKCWZpcm13YXJl",
            "cxgEIAMoCzI3LnNhbHRvLm5lYnVsYS50eXBlLkRldmljZU1ldGFkYXRhLkNp",
            "cmN1aXRCb2FyZC5GaXJtd2FyZRorCghGaXJtd2FyZRIOCgZudW1iZXIYASAB",
            "KAkSDwoHdmVyc2lvbhgCIAEoCUKfAQoZY29tLnNhbHRvYXBpcy5uZWJ1bGEu",
            "dHlwZUITRGV2aWNlTWV0YWRhdGFQcm90b1ABWlNnaXRodWIuY29tL3ByaXZh",
            "dGUtc2FsdG9hcGlzL3NhbHRvYXBpcy1nby9uZWJ1bGEvdHlwZS9kZXZpY2Vt",
            "ZXRhZGF0YTtkZXZpY2VtZXRhZGF0YaoCFVNhbHRvYXBpcy5OZWJ1bGEuVHlw",
            "ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Saltoapis.Type.DateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Saltoapis.Nebula.Type.DeviceMetadata), global::Saltoapis.Nebula.Type.DeviceMetadata.Parser, new[]{ "CircuitBoards" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard), global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard.Parser, new[]{ "ManufactureDate", "SerialNumber", "Firmwares" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard.Types.Firmware), global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard.Types.Firmware.Parser, new[]{ "Number", "Version" }, null, null, null, null)})})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Metadata contains information about a device. Most metadata is immutable.
  /// </summary>
  public sealed partial class DeviceMetadata : pb::IMessage<DeviceMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DeviceMetadata> _parser = new pb::MessageParser<DeviceMetadata>(() => new DeviceMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DeviceMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Saltoapis.Nebula.Type.DeviceMetadataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeviceMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeviceMetadata(DeviceMetadata other) : this() {
      circuitBoards_ = other.circuitBoards_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeviceMetadata Clone() {
      return new DeviceMetadata(this);
    }

    /// <summary>Field number for the "circuit_boards" field.</summary>
    public const int CircuitBoardsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard> _repeated_circuitBoards_codec
        = pb::FieldCodec.ForMessage(10, global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard.Parser);
    private readonly pbc::RepeatedField<global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard> circuitBoards_ = new pbc::RepeatedField<global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard>();
    /// <summary>
    /// Circuit boards present in this device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard> CircuitBoards {
      get { return circuitBoards_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DeviceMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DeviceMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!circuitBoards_.Equals(other.circuitBoards_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= circuitBoards_.GetHashCode();
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
      circuitBoards_.WriteTo(output, _repeated_circuitBoards_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      circuitBoards_.WriteTo(ref output, _repeated_circuitBoards_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += circuitBoards_.CalculateSize(_repeated_circuitBoards_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DeviceMetadata other) {
      if (other == null) {
        return;
      }
      circuitBoards_.Add(other.circuitBoards_);
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            circuitBoards_.AddEntriesFrom(input, _repeated_circuitBoards_codec);
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            circuitBoards_.AddEntriesFrom(ref input, _repeated_circuitBoards_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DeviceMetadata message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Metadata of a circuit board present on a device.
      /// </summary>
      public sealed partial class CircuitBoard : pb::IMessage<CircuitBoard>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<CircuitBoard> _parser = new pb::MessageParser<CircuitBoard>(() => new CircuitBoard());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<CircuitBoard> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Saltoapis.Nebula.Type.DeviceMetadata.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CircuitBoard() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CircuitBoard(CircuitBoard other) : this() {
          manufactureDate_ = other.manufactureDate_ != null ? other.manufactureDate_.Clone() : null;
          serialNumber_ = other.serialNumber_;
          firmwares_ = other.firmwares_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CircuitBoard Clone() {
          return new CircuitBoard(this);
        }

        /// <summary>Field number for the "manufacture_date" field.</summary>
        public const int ManufactureDateFieldNumber = 2;
        private global::Saltoapis.Type.Date manufactureDate_;
        /// <summary>
        /// Date manufactured
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Saltoapis.Type.Date ManufactureDate {
          get { return manufactureDate_; }
          set {
            manufactureDate_ = value;
          }
        }

        /// <summary>Field number for the "serial_number" field.</summary>
        public const int SerialNumberFieldNumber = 3;
        private string serialNumber_ = "";
        /// <summary>
        /// Hardware serial number, for example, `2.000.0020`
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string SerialNumber {
          get { return serialNumber_; }
          set {
            serialNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "firmwares" field.</summary>
        public const int FirmwaresFieldNumber = 4;
        private static readonly pb::FieldCodec<global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard.Types.Firmware> _repeated_firmwares_codec
            = pb::FieldCodec.ForMessage(34, global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard.Types.Firmware.Parser);
        private readonly pbc::RepeatedField<global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard.Types.Firmware> firmwares_ = new pbc::RepeatedField<global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard.Types.Firmware>();
        /// <summary>
        /// Firmwares present in this circuit board.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard.Types.Firmware> Firmwares {
          get { return firmwares_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as CircuitBoard);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(CircuitBoard other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(ManufactureDate, other.ManufactureDate)) return false;
          if (SerialNumber != other.SerialNumber) return false;
          if(!firmwares_.Equals(other.firmwares_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (manufactureDate_ != null) hash ^= ManufactureDate.GetHashCode();
          if (SerialNumber.Length != 0) hash ^= SerialNumber.GetHashCode();
          hash ^= firmwares_.GetHashCode();
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
          if (manufactureDate_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(ManufactureDate);
          }
          if (SerialNumber.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(SerialNumber);
          }
          firmwares_.WriteTo(output, _repeated_firmwares_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (manufactureDate_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(ManufactureDate);
          }
          if (SerialNumber.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(SerialNumber);
          }
          firmwares_.WriteTo(ref output, _repeated_firmwares_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (manufactureDate_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(ManufactureDate);
          }
          if (SerialNumber.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(SerialNumber);
          }
          size += firmwares_.CalculateSize(_repeated_firmwares_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(CircuitBoard other) {
          if (other == null) {
            return;
          }
          if (other.manufactureDate_ != null) {
            if (manufactureDate_ == null) {
              ManufactureDate = new global::Saltoapis.Type.Date();
            }
            ManufactureDate.MergeFrom(other.ManufactureDate);
          }
          if (other.SerialNumber.Length != 0) {
            SerialNumber = other.SerialNumber;
          }
          firmwares_.Add(other.firmwares_);
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
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 18: {
                if (manufactureDate_ == null) {
                  ManufactureDate = new global::Saltoapis.Type.Date();
                }
                input.ReadMessage(ManufactureDate);
                break;
              }
              case 26: {
                SerialNumber = input.ReadString();
                break;
              }
              case 34: {
                firmwares_.AddEntriesFrom(input, _repeated_firmwares_codec);
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
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 18: {
                if (manufactureDate_ == null) {
                  ManufactureDate = new global::Saltoapis.Type.Date();
                }
                input.ReadMessage(ManufactureDate);
                break;
              }
              case 26: {
                SerialNumber = input.ReadString();
                break;
              }
              case 34: {
                firmwares_.AddEntriesFrom(ref input, _repeated_firmwares_codec);
                break;
              }
            }
          }
        }
        #endif

        #region Nested types
        /// <summary>Container for nested types declared in the CircuitBoard message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          /// <summary>
          /// Firmware contains the firmware number and version.
          /// </summary>
          public sealed partial class Firmware : pb::IMessage<Firmware>
          #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
              , pb::IBufferMessage
          #endif
          {
            private static readonly pb::MessageParser<Firmware> _parser = new pb::MessageParser<Firmware>(() => new Firmware());
            private pb::UnknownFieldSet _unknownFields;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public static pb::MessageParser<Firmware> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::Saltoapis.Nebula.Type.DeviceMetadata.Types.CircuitBoard.Descriptor.NestedTypes[0]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public Firmware() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public Firmware(Firmware other) : this() {
              number_ = other.number_;
              version_ = other.version_;
              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public Firmware Clone() {
              return new Firmware(this);
            }

            /// <summary>Field number for the "number" field.</summary>
            public const int NumberFieldNumber = 1;
            private string number_ = "";
            /// <summary>
            /// Firmware number, for example '0180'.
            /// </summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public string Number {
              get { return number_; }
              set {
                number_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
              }
            }

            /// <summary>Field number for the "version" field.</summary>
            public const int VersionFieldNumber = 2;
            private string version_ = "";
            /// <summary>
            /// Firmware version of a specific firmware number.
            /// </summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public string Version {
              get { return version_; }
              set {
                version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public override bool Equals(object other) {
              return Equals(other as Firmware);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public bool Equals(Firmware other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (Number != other.Number) return false;
              if (Version != other.Version) return false;
              return Equals(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public override int GetHashCode() {
              int hash = 1;
              if (Number.Length != 0) hash ^= Number.GetHashCode();
              if (Version.Length != 0) hash ^= Version.GetHashCode();
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
              if (Number.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(Number);
              }
              if (Version.Length != 0) {
                output.WriteRawTag(18);
                output.WriteString(Version);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
            #endif
            }

            #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
              if (Number.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(Number);
              }
              if (Version.Length != 0) {
                output.WriteRawTag(18);
                output.WriteString(Version);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(ref output);
              }
            }
            #endif

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public int CalculateSize() {
              int size = 0;
              if (Number.Length != 0) {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Number);
              }
              if (Version.Length != 0) {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
              }
              if (_unknownFields != null) {
                size += _unknownFields.CalculateSize();
              }
              return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public void MergeFrom(Firmware other) {
              if (other == null) {
                return;
              }
              if (other.Number.Length != 0) {
                Number = other.Number;
              }
              if (other.Version.Length != 0) {
                Version = other.Version;
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
                switch(tag) {
                  default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                    break;
                  case 10: {
                    Number = input.ReadString();
                    break;
                  }
                  case 18: {
                    Version = input.ReadString();
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
                switch(tag) {
                  default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                  case 10: {
                    Number = input.ReadString();
                    break;
                  }
                  case 18: {
                    Version = input.ReadString();
                    break;
                  }
                }
              }
            }
            #endif

          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
