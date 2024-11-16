﻿using System;
using System.Buffers.Binary;

namespace DataFac.Memory
{
    public sealed class Codec_UInt16_BE : Codec_Base<UInt16>
#if NET7_0_OR_GREATER
    , ISpanCodec<UInt16>
#endif
    {
        private Codec_UInt16_BE() { }
        public static Codec_UInt16_BE Instance { get; } = new Codec_UInt16_BE();
        public override UInt16 OnRead(ReadOnlySpan<byte> source) => BinaryPrimitives.ReadUInt16BigEndian(source);
        public override void OnWrite(Span<byte> target, in UInt16 input) => BinaryPrimitives.WriteUInt16BigEndian(target, input);
        public static UInt16 ReadFromSpan(ReadOnlySpan<byte> source) => BinaryPrimitives.ReadUInt16BigEndian(source);
        public static void WriteToSpan(Span<byte> target, in UInt16 input) => BinaryPrimitives.WriteUInt16BigEndian(target, input);
    }
}
