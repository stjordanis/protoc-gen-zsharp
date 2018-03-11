// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: test/unittest_import_public_proto3.proto
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
namespace Google.Protobuf.TestProtos {

  /// <summary>Holder for reflection information generated from test/unittest_import_public_proto3.proto</summary>
  public static partial class UnittestImportPublicProto3Reflection {

    #region Descriptor
    /// <summary>File descriptor for test/unittest_import_public_proto3.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnittestImportPublicProto3Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cih0ZXN0L3VuaXR0ZXN0X2ltcG9ydF9wdWJsaWNfcHJvdG8zLnByb3RvEhhw",
            "cm90b2J1Zl91bml0dGVzdF9pbXBvcnQaEmV2ZW50X3BsdWdpbi5wcm90byIp",
            "ChNQdWJsaWNJbXBvcnRNZXNzYWdlEgwKAWUYASABKAVSAWU6BMi4HgEiKwob",
            "UHVibGljSW1wb3J0TWVzc2FnZU5vRXZlbnRzEgwKAWUYASABKAVSAWVCHaoC",
            "Gkdvb2dsZS5Qcm90b2J1Zi5UZXN0UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Zynga.Protobuf.EventSource.EventPluginReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.TestProtos.PublicImportMessage), global::Google.Protobuf.TestProtos.PublicImportMessage.Parser, new[]{ "E" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.TestProtos.PublicImportMessageNoEvents), global::Google.Protobuf.TestProtos.PublicImportMessageNoEvents.Parser, new[]{ "E" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PublicImportMessage : zpr::EventRegistry, pb::IMessage<PublicImportMessage> {
    private static readonly pb::MessageParser<PublicImportMessage> _parser = new pb::MessageParser<PublicImportMessage>(() => new PublicImportMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PublicImportMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.TestProtos.UnittestImportPublicProto3Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublicImportMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublicImportMessage(PublicImportMessage other) : this() {
      e_ = other.e_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublicImportMessage Clone() {
      return new PublicImportMessage(this);
    }

    public static bool IsEventSourced = true;

    public override void SetParent(EventContext parent, EventPath path) {
      base.SetParent(parent, path);
    }
    /// <summary>Field number for the "e" field.</summary>
    public const int EFieldNumber = 1;
    private int e_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int E {
      get { return e_; }
      set {
        #if !DISABLE_EVENTS
        if(e_ != value) {
          Context.AddSetEvent(1, new zpr.EventSource.EventContent { I32 = value });
        }
        #endif
        e_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PublicImportMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PublicImportMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (E != other.E) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (E != 0) hash ^= E.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (E != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(E);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (E != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(E);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PublicImportMessage other) {
      if (other == null) {
        return;
      }
      if (other.E != 0) {
        E = other.E;
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
            E = input.ReadInt32();
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
            e_ = e.Set.I32;
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

  public sealed partial class PublicImportMessageNoEvents : pb::IMessage<PublicImportMessageNoEvents> {
    private static readonly pb::MessageParser<PublicImportMessageNoEvents> _parser = new pb::MessageParser<PublicImportMessageNoEvents>(() => new PublicImportMessageNoEvents());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PublicImportMessageNoEvents> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.TestProtos.UnittestImportPublicProto3Reflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublicImportMessageNoEvents() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublicImportMessageNoEvents(PublicImportMessageNoEvents other) : this() {
      e_ = other.e_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublicImportMessageNoEvents Clone() {
      return new PublicImportMessageNoEvents(this);
    }

    public static bool IsEventSourced = false;

    /// <summary>Field number for the "e" field.</summary>
    public const int EFieldNumber = 1;
    private int e_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int E {
      get { return e_; }
      set {
        e_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PublicImportMessageNoEvents);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PublicImportMessageNoEvents other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (E != other.E) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (E != 0) hash ^= E.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (E != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(E);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (E != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(E);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PublicImportMessageNoEvents other) {
      if (other == null) {
        return;
      }
      if (other.E != 0) {
        E = other.E;
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
            E = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
