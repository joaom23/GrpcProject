// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/administradores.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcServer {

  /// <summary>Holder for reflection information generated from Protos/administradores.proto</summary>
  public static partial class AdministradoresReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/administradores.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdministradoresReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQcm90b3MvYWRtaW5pc3RyYWRvcmVzLnByb3RvGh9nb29nbGUvcHJvdG9i",
            "dWYvdGltZXN0YW1wLnByb3RvIiYKFkFkbW5pc3RyYWRvcklkZW50aWRhZGUS",
            "DAoETm9tZRgBIAEoCSIoChRBZG1uaXN0cmFkb3JNZW5zYWdlbRIQCghtZW5z",
            "YWdlbRgBIAEoCSIRCg9WaXN1YWxpemFyVmF6aW8i1AEKGVJlc3Bvc3RhVmlz",
            "dWFsaXphckFwb3N0YXMSDQoFTm9tZXMYASABKAkSDwoHTnVtZXJvMRgCIAEo",
            "BRIPCgdOdW1lcm8yGAMgASgFEg8KB051bWVybzMYBCABKAUSDwoHTnVtZXJv",
            "NBgFIAEoBRIPCgdOdW1lcm81GAYgASgFEhAKCEVzdHJlbGExGAcgASgFEhAK",
            "CEVzdHJlbGEyGAggASgFEi8KC0RhdGFfQXBvc3RhGAkgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLlRpbWVzdGFtcCIPCg1BcnF1aXZhclZhemlvIiQKEEFycXVp",
            "dmFyTWVuc2FnZW0SEAoIbWVuc2FnZW0YASABKAky1wEKDUFkbWluaXN0cmFk",
            "b3ISTQobVmVyaWZpY2FFbnRyYWRhQWRtbmlzdHJhZG9yEhcuQWRtbmlzdHJh",
            "ZG9ySWRlbnRpZGFkZRoVLkFkbW5pc3RyYWRvck1lbnNhZ2VtEkIKEFZpc3Vh",
            "bGl6YXJDaGF2ZXMSEC5WaXN1YWxpemFyVmF6aW8aGi5SZXNwb3N0YVZpc3Vh",
            "bGl6YXJBcG9zdGFzMAESMwoOQXJxdWl2YXJDaGF2ZXMSDi5BcnF1aXZhclZh",
            "emlvGhEuQXJxdWl2YXJNZW5zYWdlbUINqgIKR3JwY1NlcnZlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.AdmnistradorIdentidade), global::GrpcServer.AdmnistradorIdentidade.Parser, new[]{ "Nome" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.AdmnistradorMensagem), global::GrpcServer.AdmnistradorMensagem.Parser, new[]{ "Mensagem" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.VisualizarVazio), global::GrpcServer.VisualizarVazio.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.RespostaVisualizarApostas), global::GrpcServer.RespostaVisualizarApostas.Parser, new[]{ "Nomes", "Numero1", "Numero2", "Numero3", "Numero4", "Numero5", "Estrela1", "Estrela2", "DataAposta" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.ArquivarVazio), global::GrpcServer.ArquivarVazio.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.ArquivarMensagem), global::GrpcServer.ArquivarMensagem.Parser, new[]{ "Mensagem" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AdmnistradorIdentidade : pb::IMessage<AdmnistradorIdentidade> {
    private static readonly pb::MessageParser<AdmnistradorIdentidade> _parser = new pb::MessageParser<AdmnistradorIdentidade>(() => new AdmnistradorIdentidade());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdmnistradorIdentidade> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.AdministradoresReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdmnistradorIdentidade() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdmnistradorIdentidade(AdmnistradorIdentidade other) : this() {
      nome_ = other.nome_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdmnistradorIdentidade Clone() {
      return new AdmnistradorIdentidade(this);
    }

    /// <summary>Field number for the "Nome" field.</summary>
    public const int NomeFieldNumber = 1;
    private string nome_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nome {
      get { return nome_; }
      set {
        nome_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdmnistradorIdentidade);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdmnistradorIdentidade other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Nome != other.Nome) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Nome.Length != 0) hash ^= Nome.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Nome.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Nome);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Nome.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nome);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdmnistradorIdentidade other) {
      if (other == null) {
        return;
      }
      if (other.Nome.Length != 0) {
        Nome = other.Nome;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Nome = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AdmnistradorMensagem : pb::IMessage<AdmnistradorMensagem> {
    private static readonly pb::MessageParser<AdmnistradorMensagem> _parser = new pb::MessageParser<AdmnistradorMensagem>(() => new AdmnistradorMensagem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdmnistradorMensagem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.AdministradoresReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdmnistradorMensagem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdmnistradorMensagem(AdmnistradorMensagem other) : this() {
      mensagem_ = other.mensagem_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdmnistradorMensagem Clone() {
      return new AdmnistradorMensagem(this);
    }

    /// <summary>Field number for the "mensagem" field.</summary>
    public const int MensagemFieldNumber = 1;
    private string mensagem_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Mensagem {
      get { return mensagem_; }
      set {
        mensagem_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdmnistradorMensagem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdmnistradorMensagem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Mensagem != other.Mensagem) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Mensagem.Length != 0) hash ^= Mensagem.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Mensagem.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Mensagem);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Mensagem.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Mensagem);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdmnistradorMensagem other) {
      if (other == null) {
        return;
      }
      if (other.Mensagem.Length != 0) {
        Mensagem = other.Mensagem;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Mensagem = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class VisualizarVazio : pb::IMessage<VisualizarVazio> {
    private static readonly pb::MessageParser<VisualizarVazio> _parser = new pb::MessageParser<VisualizarVazio>(() => new VisualizarVazio());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VisualizarVazio> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.AdministradoresReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisualizarVazio() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisualizarVazio(VisualizarVazio other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisualizarVazio Clone() {
      return new VisualizarVazio(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VisualizarVazio);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VisualizarVazio other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VisualizarVazio other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class RespostaVisualizarApostas : pb::IMessage<RespostaVisualizarApostas> {
    private static readonly pb::MessageParser<RespostaVisualizarApostas> _parser = new pb::MessageParser<RespostaVisualizarApostas>(() => new RespostaVisualizarApostas());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RespostaVisualizarApostas> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.AdministradoresReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RespostaVisualizarApostas() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RespostaVisualizarApostas(RespostaVisualizarApostas other) : this() {
      nomes_ = other.nomes_;
      numero1_ = other.numero1_;
      numero2_ = other.numero2_;
      numero3_ = other.numero3_;
      numero4_ = other.numero4_;
      numero5_ = other.numero5_;
      estrela1_ = other.estrela1_;
      estrela2_ = other.estrela2_;
      dataAposta_ = other.dataAposta_ != null ? other.dataAposta_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RespostaVisualizarApostas Clone() {
      return new RespostaVisualizarApostas(this);
    }

    /// <summary>Field number for the "Nomes" field.</summary>
    public const int NomesFieldNumber = 1;
    private string nomes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nomes {
      get { return nomes_; }
      set {
        nomes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Numero1" field.</summary>
    public const int Numero1FieldNumber = 2;
    private int numero1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Numero1 {
      get { return numero1_; }
      set {
        numero1_ = value;
      }
    }

    /// <summary>Field number for the "Numero2" field.</summary>
    public const int Numero2FieldNumber = 3;
    private int numero2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Numero2 {
      get { return numero2_; }
      set {
        numero2_ = value;
      }
    }

    /// <summary>Field number for the "Numero3" field.</summary>
    public const int Numero3FieldNumber = 4;
    private int numero3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Numero3 {
      get { return numero3_; }
      set {
        numero3_ = value;
      }
    }

    /// <summary>Field number for the "Numero4" field.</summary>
    public const int Numero4FieldNumber = 5;
    private int numero4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Numero4 {
      get { return numero4_; }
      set {
        numero4_ = value;
      }
    }

    /// <summary>Field number for the "Numero5" field.</summary>
    public const int Numero5FieldNumber = 6;
    private int numero5_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Numero5 {
      get { return numero5_; }
      set {
        numero5_ = value;
      }
    }

    /// <summary>Field number for the "Estrela1" field.</summary>
    public const int Estrela1FieldNumber = 7;
    private int estrela1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Estrela1 {
      get { return estrela1_; }
      set {
        estrela1_ = value;
      }
    }

    /// <summary>Field number for the "Estrela2" field.</summary>
    public const int Estrela2FieldNumber = 8;
    private int estrela2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Estrela2 {
      get { return estrela2_; }
      set {
        estrela2_ = value;
      }
    }

    /// <summary>Field number for the "Data_Aposta" field.</summary>
    public const int DataApostaFieldNumber = 9;
    private global::Google.Protobuf.WellKnownTypes.Timestamp dataAposta_;
    /// <summary>
    ///int32 NrApostas = 9;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DataAposta {
      get { return dataAposta_; }
      set {
        dataAposta_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RespostaVisualizarApostas);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RespostaVisualizarApostas other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Nomes != other.Nomes) return false;
      if (Numero1 != other.Numero1) return false;
      if (Numero2 != other.Numero2) return false;
      if (Numero3 != other.Numero3) return false;
      if (Numero4 != other.Numero4) return false;
      if (Numero5 != other.Numero5) return false;
      if (Estrela1 != other.Estrela1) return false;
      if (Estrela2 != other.Estrela2) return false;
      if (!object.Equals(DataAposta, other.DataAposta)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Nomes.Length != 0) hash ^= Nomes.GetHashCode();
      if (Numero1 != 0) hash ^= Numero1.GetHashCode();
      if (Numero2 != 0) hash ^= Numero2.GetHashCode();
      if (Numero3 != 0) hash ^= Numero3.GetHashCode();
      if (Numero4 != 0) hash ^= Numero4.GetHashCode();
      if (Numero5 != 0) hash ^= Numero5.GetHashCode();
      if (Estrela1 != 0) hash ^= Estrela1.GetHashCode();
      if (Estrela2 != 0) hash ^= Estrela2.GetHashCode();
      if (dataAposta_ != null) hash ^= DataAposta.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Nomes.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Nomes);
      }
      if (Numero1 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Numero1);
      }
      if (Numero2 != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Numero2);
      }
      if (Numero3 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Numero3);
      }
      if (Numero4 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Numero4);
      }
      if (Numero5 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Numero5);
      }
      if (Estrela1 != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Estrela1);
      }
      if (Estrela2 != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Estrela2);
      }
      if (dataAposta_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(DataAposta);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Nomes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nomes);
      }
      if (Numero1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Numero1);
      }
      if (Numero2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Numero2);
      }
      if (Numero3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Numero3);
      }
      if (Numero4 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Numero4);
      }
      if (Numero5 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Numero5);
      }
      if (Estrela1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Estrela1);
      }
      if (Estrela2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Estrela2);
      }
      if (dataAposta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DataAposta);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RespostaVisualizarApostas other) {
      if (other == null) {
        return;
      }
      if (other.Nomes.Length != 0) {
        Nomes = other.Nomes;
      }
      if (other.Numero1 != 0) {
        Numero1 = other.Numero1;
      }
      if (other.Numero2 != 0) {
        Numero2 = other.Numero2;
      }
      if (other.Numero3 != 0) {
        Numero3 = other.Numero3;
      }
      if (other.Numero4 != 0) {
        Numero4 = other.Numero4;
      }
      if (other.Numero5 != 0) {
        Numero5 = other.Numero5;
      }
      if (other.Estrela1 != 0) {
        Estrela1 = other.Estrela1;
      }
      if (other.Estrela2 != 0) {
        Estrela2 = other.Estrela2;
      }
      if (other.dataAposta_ != null) {
        if (dataAposta_ == null) {
          DataAposta = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DataAposta.MergeFrom(other.DataAposta);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Nomes = input.ReadString();
            break;
          }
          case 16: {
            Numero1 = input.ReadInt32();
            break;
          }
          case 24: {
            Numero2 = input.ReadInt32();
            break;
          }
          case 32: {
            Numero3 = input.ReadInt32();
            break;
          }
          case 40: {
            Numero4 = input.ReadInt32();
            break;
          }
          case 48: {
            Numero5 = input.ReadInt32();
            break;
          }
          case 56: {
            Estrela1 = input.ReadInt32();
            break;
          }
          case 64: {
            Estrela2 = input.ReadInt32();
            break;
          }
          case 74: {
            if (dataAposta_ == null) {
              DataAposta = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DataAposta);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ArquivarVazio : pb::IMessage<ArquivarVazio> {
    private static readonly pb::MessageParser<ArquivarVazio> _parser = new pb::MessageParser<ArquivarVazio>(() => new ArquivarVazio());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArquivarVazio> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.AdministradoresReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArquivarVazio() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArquivarVazio(ArquivarVazio other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArquivarVazio Clone() {
      return new ArquivarVazio(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArquivarVazio);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArquivarVazio other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArquivarVazio other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class ArquivarMensagem : pb::IMessage<ArquivarMensagem> {
    private static readonly pb::MessageParser<ArquivarMensagem> _parser = new pb::MessageParser<ArquivarMensagem>(() => new ArquivarMensagem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArquivarMensagem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.AdministradoresReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArquivarMensagem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArquivarMensagem(ArquivarMensagem other) : this() {
      mensagem_ = other.mensagem_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArquivarMensagem Clone() {
      return new ArquivarMensagem(this);
    }

    /// <summary>Field number for the "mensagem" field.</summary>
    public const int MensagemFieldNumber = 1;
    private string mensagem_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Mensagem {
      get { return mensagem_; }
      set {
        mensagem_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArquivarMensagem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArquivarMensagem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Mensagem != other.Mensagem) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Mensagem.Length != 0) hash ^= Mensagem.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Mensagem.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Mensagem);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Mensagem.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Mensagem);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArquivarMensagem other) {
      if (other == null) {
        return;
      }
      if (other.Mensagem.Length != 0) {
        Mensagem = other.Mensagem;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Mensagem = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
