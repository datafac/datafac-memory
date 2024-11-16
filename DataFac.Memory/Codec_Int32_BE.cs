﻿using System;
using System.Buffers.Binary;

namespace DataFac.Memory
{
    public sealed class Codec_Int32_BE : Codec_Base<Int32>
#if NET7_0_OR_GREATER
    , ISpanCodec<Int32>
#endif
    {
        private Codec_Int32_BE() { }
        public static Codec_Int32_BE Instance { get; } = new Codec_Int32_BE();
        public override Int32 OnRead(ReadOnlySpan<byte> source) => BinaryPrimitives.ReadInt32BigEndian(source);
        public override void OnWrite(Span<byte> target, in Int32 input) => BinaryPrimitives.WriteInt32BigEndian(target, input);
        public static Int32 ReadFromSpan(ReadOnlySpan<byte> source) => BinaryPrimitives.ReadInt32BigEndian(source);
        public static void WriteToSpan(Span<byte> target, in Int32 input) => BinaryPrimitives.WriteInt32BigEndian(target, input);
    }
}
