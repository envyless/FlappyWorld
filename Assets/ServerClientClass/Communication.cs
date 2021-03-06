// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Communication.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf {

  /// <summary>Holder for reflection information generated from Communication.proto</summary>
  public static partial class CommunicationReflection {

    #region Descriptor
    /// <summary>File descriptor for Communication.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommunicationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNDb21tdW5pY2F0aW9uLnByb3RvEg9nb29nbGUucHJvdG9idWYiPQoEVXNl",
            "chIPCgd1c2VyX2lkGAEgASgJEgkKAXgYAiABKAISCQoBeRgDIAEoAhIOCgZp",
            "c0RlYWQYBCABKAgiMwoKUmVxVXNlck5ldxIPCgd1c2VyX2lkGAEgASgJEgkK",
            "AXgYAiABKAISCQoBeRgDIAEoAiI0Cg1SZXFVc2VyVXBkYXRlEiMKBHVzZXIY",
            "ASABKAsyFS5nb29nbGUucHJvdG9idWYuVXNlciI2Cg5SZXFVc2Vyc1VwZGF0",
            "ZRIkCgV1c2VycxgBIAMoCzIVLmdvb2dsZS5wcm90b2J1Zi5Vc2VyIr8BCgpS",
            "ZXF1ZXN0UlBDEjEKCnJlcVVzZXJOZXcYASABKAsyGy5nb29nbGUucHJvdG9i",
            "dWYuUmVxVXNlck5ld0gAEjcKDXJlcVVzZXJVcGRhdGUYAiABKAsyHi5nb29n",
            "bGUucHJvdG9idWYuUmVxVXNlclVwZGF0ZUgAEjkKDnJlcVVzZXJzVXBkYXRl",
            "GAMgASgLMh8uZ29vZ2xlLnByb3RvYnVmLlJlcVVzZXJzVXBkYXRlSABCCgoI",
            "cmVxdWVzdHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.User), global::Google.Protobuf.User.Parser, new[]{ "UserId", "X", "Y", "IsDead" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ReqUserNew), global::Google.Protobuf.ReqUserNew.Parser, new[]{ "UserId", "X", "Y" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ReqUserUpdate), global::Google.Protobuf.ReqUserUpdate.Parser, new[]{ "User" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ReqUsersUpdate), global::Google.Protobuf.ReqUsersUpdate.Parser, new[]{ "Users" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.RequestRPC), global::Google.Protobuf.RequestRPC.Parser, new[]{ "ReqUserNew", "ReqUserUpdate", "ReqUsersUpdate" }, new[]{ "Requests" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class User : pb::IMessage<User> {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.CommunicationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User(User other) : this() {
      userId_ = other.userId_;
      x_ = other.x_;
      y_ = other.y_;
      isDead_ = other.isDead_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 2;
    private float x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 3;
    private float y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "isDead" field.</summary>
    public const int IsDeadFieldNumber = 4;
    private bool isDead_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsDead {
      get { return isDead_; }
      set {
        isDead_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y)) return false;
      if (IsDead != other.IsDead) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (X != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
      if (Y != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
      if (IsDead != false) hash ^= IsDead.GetHashCode();
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
      if (UserId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserId);
      }
      if (X != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Y);
      }
      if (IsDead != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsDead);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (IsDead != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      if (other.IsDead != false) {
        IsDead = other.IsDead;
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
            UserId = input.ReadString();
            break;
          }
          case 21: {
            X = input.ReadFloat();
            break;
          }
          case 29: {
            Y = input.ReadFloat();
            break;
          }
          case 32: {
            IsDead = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ReqUserNew : pb::IMessage<ReqUserNew> {
    private static readonly pb::MessageParser<ReqUserNew> _parser = new pb::MessageParser<ReqUserNew>(() => new ReqUserNew());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReqUserNew> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.CommunicationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqUserNew() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqUserNew(ReqUserNew other) : this() {
      userId_ = other.userId_;
      x_ = other.x_;
      y_ = other.y_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqUserNew Clone() {
      return new ReqUserNew(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 2;
    private float x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 3;
    private float y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReqUserNew);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReqUserNew other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (X != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
      if (Y != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
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
      if (UserId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserId);
      }
      if (X != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Y);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReqUserNew other) {
      if (other == null) {
        return;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
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
            UserId = input.ReadString();
            break;
          }
          case 21: {
            X = input.ReadFloat();
            break;
          }
          case 29: {
            Y = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ReqUserUpdate : pb::IMessage<ReqUserUpdate> {
    private static readonly pb::MessageParser<ReqUserUpdate> _parser = new pb::MessageParser<ReqUserUpdate>(() => new ReqUserUpdate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReqUserUpdate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.CommunicationReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqUserUpdate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqUserUpdate(ReqUserUpdate other) : this() {
      user_ = other.user_ != null ? other.user_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqUserUpdate Clone() {
      return new ReqUserUpdate(this);
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 1;
    private global::Google.Protobuf.User user_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.User User {
      get { return user_; }
      set {
        user_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReqUserUpdate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReqUserUpdate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(User, other.User)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (user_ != null) hash ^= User.GetHashCode();
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
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (user_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(User);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReqUserUpdate other) {
      if (other == null) {
        return;
      }
      if (other.user_ != null) {
        if (user_ == null) {
          user_ = new global::Google.Protobuf.User();
        }
        User.MergeFrom(other.User);
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
            if (user_ == null) {
              user_ = new global::Google.Protobuf.User();
            }
            input.ReadMessage(user_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ReqUsersUpdate : pb::IMessage<ReqUsersUpdate> {
    private static readonly pb::MessageParser<ReqUsersUpdate> _parser = new pb::MessageParser<ReqUsersUpdate>(() => new ReqUsersUpdate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReqUsersUpdate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.CommunicationReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqUsersUpdate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqUsersUpdate(ReqUsersUpdate other) : this() {
      users_ = other.users_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqUsersUpdate Clone() {
      return new ReqUsersUpdate(this);
    }

    /// <summary>Field number for the "users" field.</summary>
    public const int UsersFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Protobuf.User> _repeated_users_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Protobuf.User.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.User> users_ = new pbc::RepeatedField<global::Google.Protobuf.User>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.User> Users {
      get { return users_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReqUsersUpdate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReqUsersUpdate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!users_.Equals(other.users_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= users_.GetHashCode();
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
      users_.WriteTo(output, _repeated_users_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += users_.CalculateSize(_repeated_users_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReqUsersUpdate other) {
      if (other == null) {
        return;
      }
      users_.Add(other.users_);
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
            users_.AddEntriesFrom(input, _repeated_users_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RequestRPC : pb::IMessage<RequestRPC> {
    private static readonly pb::MessageParser<RequestRPC> _parser = new pb::MessageParser<RequestRPC>(() => new RequestRPC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestRPC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.CommunicationReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestRPC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestRPC(RequestRPC other) : this() {
      switch (other.RequestsCase) {
        case RequestsOneofCase.ReqUserNew:
          ReqUserNew = other.ReqUserNew.Clone();
          break;
        case RequestsOneofCase.ReqUserUpdate:
          ReqUserUpdate = other.ReqUserUpdate.Clone();
          break;
        case RequestsOneofCase.ReqUsersUpdate:
          ReqUsersUpdate = other.ReqUsersUpdate.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestRPC Clone() {
      return new RequestRPC(this);
    }

    /// <summary>Field number for the "reqUserNew" field.</summary>
    public const int ReqUserNewFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.ReqUserNew ReqUserNew {
      get { return requestsCase_ == RequestsOneofCase.ReqUserNew ? (global::Google.Protobuf.ReqUserNew) requests_ : null; }
      set {
        requests_ = value;
        requestsCase_ = value == null ? RequestsOneofCase.None : RequestsOneofCase.ReqUserNew;
      }
    }

    /// <summary>Field number for the "reqUserUpdate" field.</summary>
    public const int ReqUserUpdateFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.ReqUserUpdate ReqUserUpdate {
      get { return requestsCase_ == RequestsOneofCase.ReqUserUpdate ? (global::Google.Protobuf.ReqUserUpdate) requests_ : null; }
      set {
        requests_ = value;
        requestsCase_ = value == null ? RequestsOneofCase.None : RequestsOneofCase.ReqUserUpdate;
      }
    }

    /// <summary>Field number for the "reqUsersUpdate" field.</summary>
    public const int ReqUsersUpdateFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.ReqUsersUpdate ReqUsersUpdate {
      get { return requestsCase_ == RequestsOneofCase.ReqUsersUpdate ? (global::Google.Protobuf.ReqUsersUpdate) requests_ : null; }
      set {
        requests_ = value;
        requestsCase_ = value == null ? RequestsOneofCase.None : RequestsOneofCase.ReqUsersUpdate;
      }
    }

    private object requests_;
    /// <summary>Enum of possible cases for the "requests" oneof.</summary>
    public enum RequestsOneofCase {
      None = 0,
      ReqUserNew = 1,
      ReqUserUpdate = 2,
      ReqUsersUpdate = 3,
    }
    private RequestsOneofCase requestsCase_ = RequestsOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestsOneofCase RequestsCase {
      get { return requestsCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearRequests() {
      requestsCase_ = RequestsOneofCase.None;
      requests_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestRPC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestRPC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ReqUserNew, other.ReqUserNew)) return false;
      if (!object.Equals(ReqUserUpdate, other.ReqUserUpdate)) return false;
      if (!object.Equals(ReqUsersUpdate, other.ReqUsersUpdate)) return false;
      if (RequestsCase != other.RequestsCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (requestsCase_ == RequestsOneofCase.ReqUserNew) hash ^= ReqUserNew.GetHashCode();
      if (requestsCase_ == RequestsOneofCase.ReqUserUpdate) hash ^= ReqUserUpdate.GetHashCode();
      if (requestsCase_ == RequestsOneofCase.ReqUsersUpdate) hash ^= ReqUsersUpdate.GetHashCode();
      hash ^= (int) requestsCase_;
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
      if (requestsCase_ == RequestsOneofCase.ReqUserNew) {
        output.WriteRawTag(10);
        output.WriteMessage(ReqUserNew);
      }
      if (requestsCase_ == RequestsOneofCase.ReqUserUpdate) {
        output.WriteRawTag(18);
        output.WriteMessage(ReqUserUpdate);
      }
      if (requestsCase_ == RequestsOneofCase.ReqUsersUpdate) {
        output.WriteRawTag(26);
        output.WriteMessage(ReqUsersUpdate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (requestsCase_ == RequestsOneofCase.ReqUserNew) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReqUserNew);
      }
      if (requestsCase_ == RequestsOneofCase.ReqUserUpdate) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReqUserUpdate);
      }
      if (requestsCase_ == RequestsOneofCase.ReqUsersUpdate) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReqUsersUpdate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestRPC other) {
      if (other == null) {
        return;
      }
      switch (other.RequestsCase) {
        case RequestsOneofCase.ReqUserNew:
          if (ReqUserNew == null) {
            ReqUserNew = new global::Google.Protobuf.ReqUserNew();
          }
          ReqUserNew.MergeFrom(other.ReqUserNew);
          break;
        case RequestsOneofCase.ReqUserUpdate:
          if (ReqUserUpdate == null) {
            ReqUserUpdate = new global::Google.Protobuf.ReqUserUpdate();
          }
          ReqUserUpdate.MergeFrom(other.ReqUserUpdate);
          break;
        case RequestsOneofCase.ReqUsersUpdate:
          if (ReqUsersUpdate == null) {
            ReqUsersUpdate = new global::Google.Protobuf.ReqUsersUpdate();
          }
          ReqUsersUpdate.MergeFrom(other.ReqUsersUpdate);
          break;
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
            global::Google.Protobuf.ReqUserNew subBuilder = new global::Google.Protobuf.ReqUserNew();
            if (requestsCase_ == RequestsOneofCase.ReqUserNew) {
              subBuilder.MergeFrom(ReqUserNew);
            }
            input.ReadMessage(subBuilder);
            ReqUserNew = subBuilder;
            break;
          }
          case 18: {
            global::Google.Protobuf.ReqUserUpdate subBuilder = new global::Google.Protobuf.ReqUserUpdate();
            if (requestsCase_ == RequestsOneofCase.ReqUserUpdate) {
              subBuilder.MergeFrom(ReqUserUpdate);
            }
            input.ReadMessage(subBuilder);
            ReqUserUpdate = subBuilder;
            break;
          }
          case 26: {
            global::Google.Protobuf.ReqUsersUpdate subBuilder = new global::Google.Protobuf.ReqUsersUpdate();
            if (requestsCase_ == RequestsOneofCase.ReqUsersUpdate) {
              subBuilder.MergeFrom(ReqUsersUpdate);
            }
            input.ReadMessage(subBuilder);
            ReqUsersUpdate = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
