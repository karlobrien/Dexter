#!/usr/bin/env bash

PROTOC=$HOME/.nuget/packages/Google.Protobuf.Tools/3.4.0/tools/macosx_x64/protoc
SRC=Dexter.Dto
DEST=Dexter.Dto/Generated

echo ${PROTOC}
echo ${SRC}
echo ${DEST}

${PROTOC} -I=${SRC} --csharp_out=${DEST} ${SRC}/MarketData.proto

