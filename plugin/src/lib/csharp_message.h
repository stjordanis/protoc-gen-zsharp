// Protocol Buffers - Google's data interchange format
// Copyright 2008 Google Inc.  All rights reserved.
// https://developers.google.com/protocol-buffers/
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#ifndef GOOGLE_PROTOBUF_COMPILER_CSHARP_MESSAGE_H__
#define GOOGLE_PROTOBUF_COMPILER_CSHARP_MESSAGE_H__

#include <string>
#include <vector>

#include <google/protobuf/compiler/code_generator.h>
#include "src/lib/csharp_source_generator_base.h"
#include "src/lib/csharp_helpers.h"

using namespace google::protobuf;

namespace zynga {
namespace protobuf {
namespace compiler {
namespace csharp {

class FieldGeneratorBase;

class MessageGenerator : public SourceGeneratorBase {
 public:
  MessageGenerator(const Descriptor* descriptor, const Options* options);
  ~MessageGenerator();

  void GenerateCloningCode(io::Printer* printer, bool isEventSourced);
  void GenerateFreezingCode(io::Printer* printer);
  void GenerateFrameworkMethods(io::Printer* printer);
  void Generate(io::Printer* printer, bool isEventSourced = false);

  /// The following code is Copyright 2018, Zynga
  bool IsEventSourced();
  ///

  FieldGeneratorBase* CreateFieldGeneratorInternal(
      const FieldDescriptor* descriptor);

 private:
  const Descriptor* descriptor_;
  std::vector<std::string> field_names_;
  std::vector<const FieldDescriptor*> fields_by_number_;
  bool is_event_sourced;

  void GenerateMessageSerializationMethods(io::Printer* printer);
  void GenerateMergingMethods(io::Printer* printer, bool isEventSourced);

  int GetFieldOrdinal(const FieldDescriptor* descriptor);


  bool HasNestedGeneratedTypes();

  void AddDeprecatedFlag(io::Printer* printer);
  
  std::string class_name();
  std::string full_class_name();

  // field names sorted alphabetically
  const std::vector<std::string>& field_names();

  // field descriptors sorted by number
  const std::vector<const FieldDescriptor*>& fields_by_number();

  GOOGLE_DISALLOW_EVIL_CONSTRUCTORS(MessageGenerator);
};

}  // namespace csharp
}  // namespace compiler
}  // namespace protobuf
}  // namespace google

#endif  // GOOGLE_PROTOBUF_COMPILER_CSHARP_MESSAGE_H__
