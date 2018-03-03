// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: test/simple_message.proto
#pragma warning disable 1591, 0612, 3021, 162
#region Designer generated code

using System;
using System.IO;
using System.Collections.Generic;
using Google.Protobuf;
using global::Zynga.Protobuf.Runtime;
using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
using zpr = global::Zynga.Protobuf.Runtime;
namespace Com.Zynga.Runtime.Protobuf {

  /// <summary>Holder for reflection information generated from test/simple_message.proto</summary>
  public static partial class SimpleMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for test/simple_message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SimpleMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chl0ZXN0L3NpbXBsZV9tZXNzYWdlLnByb3RvEhpjb20uenluZ2EucnVudGlt",
            "ZS5wcm90b2J1ZhoSZXZlbnRfcGx1Z2luLnByb3RvIlsKDVBhcmVudE1lc3Nh",
            "Z2USDAoBYRgBIAEoBVIBYRI2CgFiGAIgASgLMiguY29tLnp5bmdhLnJ1bnRp",
            "bWUucHJvdG9idWYuQ2hpbGRNZXNzYWdlUgFiOgTIuB4BIiIKDENoaWxkTWVz",
            "c2FnZRIMCgFjGAMgASgDUgFjOgTIuB4BYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Zynga.Protobuf.EventSource.EventPluginReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Zynga.Runtime.Protobuf.ParentMessage), global::Com.Zynga.Runtime.Protobuf.ParentMessage.Parser, new[]{ "A", "B" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Zynga.Runtime.Protobuf.ChildMessage), global::Com.Zynga.Runtime.Protobuf.ChildMessage.Parser, new[]{ "C" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ParentMessage : zpr::EventRegistry, pb::IMessage<ParentMessage> {
    private static readonly pb::MessageParser<ParentMessage> _parser = new pb::MessageParser<ParentMessage>(() => new ParentMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ParentMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Zynga.Runtime.Protobuf.SimpleMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParentMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParentMessage(ParentMessage other) : this() {
      a_ = other.a_;
      b_ = other.b_ != null ? other.B.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParentMessage Clone() {
      return new ParentMessage(this);
    }

    public static bool IsEventSourced = true;

    public override void SetParent(EventContext parent, EventPath path) {
      base.SetParent(parent, path);
    }
    /// <summary>Field number for the "a" field.</summary>
    public const int AFieldNumber = 1;
    private int a_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int A {
      get { return a_; }
      set {
        #if !DISABLE_EVENTS
        if(a_ != value) {
          Context.AddSetEvent(1, new zpr.EventSource.EventContent { I32 = value });
        }
        #endif
        a_ = value;
      }
    }

    /// <summary>Field number for the "b" field.</summary>
    public const int BFieldNumber = 2;
    private global::Com.Zynga.Runtime.Protobuf.ChildMessage b_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Zynga.Runtime.Protobuf.ChildMessage B {
      get { return b_; }
      set {
        if(b_ != null) b_.ClearParent();
        value.SetParent(Context, new EventPath(Context.Path, 2));
        #if !DISABLE_EVENTS
        if(value == null || !value.Equals(b_)) {
          Context.AddSetEvent(2, new zpr.EventSource.EventContent { ByteData = value.ToByteString() });
        }
        #endif
        b_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ParentMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ParentMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (A != other.A) return false;
      if (!object.Equals(B, other.B)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (A != 0) hash ^= A.GetHashCode();
      if (b_ != null) hash ^= B.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (A != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(A);
      }
      if (b_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(B);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (A != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(A);
      }
      if (b_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(B);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ParentMessage other) {
      if (other == null) {
        return;
      }
      if (other.A != 0) {
        A = other.A;
      }
      if (other.b_ != null) {
        if (b_ == null) {
          b_ = new global::Com.Zynga.Runtime.Protobuf.ChildMessage();
        }
        B.MergeFrom(other.B);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            A = input.ReadInt32();
            break;
          }
          case 18: {
            if (b_ == null) {
              b_ = new global::Com.Zynga.Runtime.Protobuf.ChildMessage();
            }
            input.ReadMessage(b_);
            break;
          }
        }
      }
    }

    public override bool ApplyEvent(zpr.EventSource.EventData e, int pathIndex) {
        if (e.Path.Count == 0) {
          this.MergeFrom(e.Set.ByteData);
          return true;
        }
        switch (e.Path[pathIndex]) {
          case 1: {
            a_ = e.Set.I32;
          }
          break;
          case 2: {
            if (e.Path.Count - 1 != pathIndex) {
              if (b_ == null) b_ = new global::Com.Zynga.Runtime.Protobuf.ChildMessage();
              (b_ as zpr::EventRegistry)?.ApplyEvent(e, pathIndex + 1);
            } else {
              b_  = global::Com.Zynga.Runtime.Protobuf.ChildMessage.Parser.ParseFrom(e.Set.ByteData);
            }
          }
          break;
          default:
            return false;
          break;
        }
      return true;
    }

    public zpr.EventSource.EventSourceRoot GenerateSnapshot() {
      ClearEvents();
      var er = new zpr.EventSource.EventSourceRoot();
      var setEvent = new zpr.EventSource.EventData {
        Set = new zpr.EventSource.EventContent {
          ByteData = this.ToByteString()
        }
      };
      er.Events.Add(setEvent);
      return er;
    }

  }

  public sealed partial class ChildMessage : zpr::EventRegistry, pb::IMessage<ChildMessage> {
    private static readonly pb::MessageParser<ChildMessage> _parser = new pb::MessageParser<ChildMessage>(() => new ChildMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChildMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Zynga.Runtime.Protobuf.SimpleMessageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChildMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChildMessage(ChildMessage other) : this() {
      c_ = other.c_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChildMessage Clone() {
      return new ChildMessage(this);
    }

    public static bool IsEventSourced = true;

    public override void SetParent(EventContext parent, EventPath path) {
      base.SetParent(parent, path);
    }
    /// <summary>Field number for the "c" field.</summary>
    public const int CFieldNumber = 3;
    private long c_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long C {
      get { return c_; }
      set {
        #if !DISABLE_EVENTS
        if(c_ != value) {
          Context.AddSetEvent(3, new zpr.EventSource.EventContent { I64 = value });
        }
        #endif
        c_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChildMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChildMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (C != other.C) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (C != 0L) hash ^= C.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (C != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(C);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (C != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(C);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChildMessage other) {
      if (other == null) {
        return;
      }
      if (other.C != 0L) {
        C = other.C;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 24: {
            C = input.ReadInt64();
            break;
          }
        }
      }
    }

    public override bool ApplyEvent(zpr.EventSource.EventData e, int pathIndex) {
        if (e.Path.Count == 0) {
          this.MergeFrom(e.Set.ByteData);
          return true;
        }
        switch (e.Path[pathIndex]) {
          case 3: {
            c_ = e.Set.I64;
          }
          break;
          default:
            return false;
          break;
        }
      return true;
    }

    public zpr.EventSource.EventSourceRoot GenerateSnapshot() {
      ClearEvents();
      var er = new zpr.EventSource.EventSourceRoot();
      var setEvent = new zpr.EventSource.EventData {
        Set = new zpr.EventSource.EventContent {
          ByteData = this.ToByteString()
        }
      };
      er.Events.Add(setEvent);
      return er;
    }

  }

  #endregion

}

#endregion Designer generated code
