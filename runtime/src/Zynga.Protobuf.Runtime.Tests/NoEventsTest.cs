// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: test/no_events_test.proto
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

  /// <summary>Holder for reflection information generated from test/no_events_test.proto</summary>
  public static partial class NoEventsTestReflection {

    #region Descriptor
    /// <summary>File descriptor for test/no_events_test.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NoEventsTestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chl0ZXN0L25vX2V2ZW50c190ZXN0LnByb3RvEhpjb20uenluZ2EucnVudGlt",
            "ZS5wcm90b2J1ZhoSZXZlbnRfcGx1Z2luLnByb3RvIhgKCE5vRXZlbnRzEgwK",
            "AWEYASABKAVSAWEiHwoJSGFzRXZlbnRzEgwKAWEYASABKAVSAWE6BMi4HgFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Zynga.Protobuf.EventSource.EventPluginReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Zynga.Runtime.Protobuf.NoEvents), global::Com.Zynga.Runtime.Protobuf.NoEvents.Parser, new[]{ "A" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Zynga.Runtime.Protobuf.HasEvents), global::Com.Zynga.Runtime.Protobuf.HasEvents.Parser, new[]{ "A" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NoEvents : pb::IMessage<NoEvents> {
    private static readonly pb::MessageParser<NoEvents> _parser = new pb::MessageParser<NoEvents>(() => new NoEvents());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NoEvents> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Zynga.Runtime.Protobuf.NoEventsTestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NoEvents() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NoEvents(NoEvents other) : this() {
      a_ = other.a_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NoEvents Clone() {
      return new NoEvents(this);
    }

    public static bool IsEventSourced = false;

    /// <summary>Field number for the "a" field.</summary>
    public const int AFieldNumber = 1;
    private int a_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int A {
      get { return a_; }
      set {
        a_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NoEvents);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NoEvents other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (A != other.A) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (A != 0) hash ^= A.GetHashCode();
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
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (A != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(A);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NoEvents other) {
      if (other == null) {
        return;
      }
      if (other.A != 0) {
        A = other.A;
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
        }
      }
    }

  }

  public sealed partial class HasEvents : zpr::EventRegistry, pb::IMessage<HasEvents> {
    private static readonly pb::MessageParser<HasEvents> _parser = new pb::MessageParser<HasEvents>(() => new HasEvents());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HasEvents> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Zynga.Runtime.Protobuf.NoEventsTestReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HasEvents() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HasEvents(HasEvents other) : this() {
      a_ = other.a_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HasEvents Clone() {
      return new HasEvents(this);
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HasEvents);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HasEvents other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (A != other.A) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (A != 0) hash ^= A.GetHashCode();
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
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (A != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(A);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HasEvents other) {
      if (other == null) {
        return;
      }
      if (other.A != 0) {
        A = other.A;
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
          default:
            return false;
          break;
        }
      return true;
    }

    public override zpr.EventSource.EventSourceRoot GenerateSnapshot() {
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
