# Used for bundling up binaries that were built on the host system
FROM ubuntu:xenial

RUN apt-get update && \
  apt-get install -y openjdk-8-jdk curl && \
  echo "deb [arch=amd64] http://storage.googleapis.com/bazel-apt stable jdk1.8" | tee /etc/apt/sources.list.d/bazel.list && \
  curl https://bazel.build/bazel-release.pub.gpg | apt-key add - && \
  apt-get update && \
  apt-get install -y bazel && \
  apt-get clean && \
  mkdir -p /opt/zsharp

WORKDIR /opt/zsharp
