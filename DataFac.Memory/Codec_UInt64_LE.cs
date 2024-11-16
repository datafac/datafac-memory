﻿using System;
using System.Buffers.Binary;

namespace DataFac.Memory
{
    public sealed class Codec_UInt64_LE : Codec_Base<UInt64>
#if NET7_0_OR_GREATER
    , ISpanCodec<UInt64>
#endif
    {
        private Codec_UInt64_LE() { }
        public static Codec_UInt64_LE Instance { get; } = new Codec_UInt64_LE();
        public override UInt64 OnRead(ReadOnlySpan<byte> source) => BinaryPrimitives.ReadUInt64LittleEndian(source);
        public override void OnWrite(Span<byte> target, in UInt64 input) => BinaryPrimitives.WriteUInt64LittleEndian(target, input);
        public static UInt64 ReadFromSpan(ReadOnlySpan<byte> source) => BinaryPrimitives.ReadUInt64LittleEndian(source);
        public static void WriteToSpan(Span<byte> target, in UInt64 input) => BinaryPrimitives.WriteUInt64LittleEndian(target, input);
    }
}
