﻿using System;

namespace DataFac.Memory
{
    public sealed class Codec_Byte_LE : Codec_Base<Byte>
#if NET7_0_OR_GREATER
    , ISpanCodec<Byte>
#endif
    {
        private Codec_Byte_LE() { }
        public static Codec_Byte_LE Instance { get; } = new Codec_Byte_LE();
        public override Byte OnRead(ReadOnlySpan<byte> source) => (Byte)source[0];
        public override void OnWrite(Span<byte> target, in Byte input) => target[0] = (byte)input;
        public static Byte ReadFromSpan(ReadOnlySpan<byte> source) => (Byte)source[0];
        public static void WriteToSpan(Span<byte> target, in Byte input) => target[0] = (byte)input;
    }
}
