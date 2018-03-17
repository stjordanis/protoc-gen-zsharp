# protoc-gen-zsharp
The main purpose of this project is to add support for event sourcing and other modern c# features within Protobuf targeting the c# codegen. This is a standalone c# protoc plugin that will generate code compatible with the Google.Protobuf runtime provided by google.

The original C# codegen was forked from the google protobuf source (https://github.com/google/protobuf/tree/master/src/google/protobuf/compiler/csharp)

[![Build status](https://ci.appveyor.com/api/projects/status/g42go2oy0lf7r73d/branch/master?svg=true)](https://ci.appveyor.com/project/wackoisgod/protoc-gen-zsharp/branch/master)

# Usage

## Update proto files

You can configure event sourcing for all messages in a single proto file or on specific messages.  **NOTE!** You must ensure that child messages of an event sourced message are also marked as event sourced.  If you do not, only the initial set of the child message will be tracked.  Any other changes to the child message will not be tracked.

```protobuf
// enable for all messages in a file
syntax = "proto3";
import "event_plugin.proto";

package example;

option (com.zynga.runtime.protobuf.file_event_sourced) = true;

// event sourced
message Foo {
  int32 foo_id = 1;
  Bar bar = 2;
}

// event sourced
message Bar {
  int32 bar_id = 1;
  repeated Baz baz = 2;
}

// event sourced
message Baz {
  int32 baz_id = 1;
}
```

```protobuf
// enable for specific messages in a file
syntax = "proto3";
import "event_plugin.proto";

package example;

// event sourced
message Foo {
  option (com.zynga.runtime.protobuf.event_sourced) = true;
  int32 foo_id = 1;
  Bar bar = 2;
}

// event sourced
message Bar {
  option (com.zynga.runtime.protobuf.event_sourced) = true;
  int32 bar_id = 1;
  repeated Baz baz = 2;
}

// event sourced
message Baz {
  option (com.zynga.runtime.protobuf.event_sourced) = true;
  int32 baz_id = 1;
}

// NOT event sourced
message Bad {
  int32 a = 1;
}
```

## Build Protobuf Bindings

Pass in the plugin for your specific platform to generate the event sourced protobuf bindings

```bash
# Linux/OSX Example
protoc --proto_path=./proto/ --plugin=protoc-gen-zsharp=protoc-gen-zsharp \
  --zsharp_out=./out ./proto/example.proto
```

## C# Example

Below is an example of how to create and apply events

```csharp
var foo = new Foo();
foo.Bar = new Bar(); // creates set delta event
foo.Bar.Baz.Add(new Baz()); // creates add list delta event
foo.Bar.Baz[0].baz_id = 10; // creates update list delta event

// generate the events for the changes
// This is what you would persist as a journal entry
var events = foo.GenerateEvents();

// apply the events
var clientFoo = new Foo();
clientFoo.EventsEnabled = false;  // optional, useful if you do not want to generate events
clientFoo.ApplyEvents(root);
Assert.Equals(10, clientFoo.Bar.Baz[0].baz_id)

// retrieve a snapshot for storage
var snapshotEvent = blob.GenerateSnapshot();
```

Below is an approximation of the protobuf events that are generated by the above example.

```csharp
// foo.Bar = new Bar();
var setEvent = new EventData {
  Path = [2],
  Set = new EventContent {
    ByteData = bar.ToByteString()
  }
}

// foo.Bar.Baz.Add(new Baz());
var listEvent = new EventData {
  Path = [2, 2],
  ListEvent = new ListEvent {
    ListAction = AddList,
    Content = new EventContent {
      ByteData = baz.ToByteString()
    }
  }
}

// foo.Bar.Baz[0].baz_id = 10;
var listEvent = new EventData {
  Path = [2, 2],
  ListEvent = new ListEvent {
    ListAction = UpdateList,
    Index = 0,
    EventData = new EventData {
      Path = [1],
      Set = new EventContent {
        I32 = 10
      }
    }
  }
}
```

# CSharp proto-gen plugin build steps

Build instructions for protoc-gen-zsharp c++ plugin

1.) Install Bazel http://www.bazel.io/docs/install.html. We use this build tool because that's what google/protobufs uses. Bazel requires Java.

2.) Install proper development tools for the proper OS:

* OSX: Xcode 8.1+ (may also require that you have the proper OSX SDKs get from https://github.com/phracker/MacOSX-SDKs)
* Windows: Visual Studio 2015+ 
* Linux: GCC/G++ (tested and built on Ubuntu)

3.) Install protoc locally on the machine and include in your path

4.) cd into plugin folder 

5.) Build with ```bazel build :protoc-gen-zsharp```

6.) Run build_proto.sh|cmd from the root folder

# Zynga.Protobuf.Runtime

1.) Install dotnet core 2.0 and latest Mono

2.) (optional) Install c# compatible IDE (Rider or Visual Studio)
* build .sln file included in the runtime folder 

3.) Build via commandline
* cd runtime 
* run ```build.sh|cmd build``` 

