namespace System.Text;

public abstract class Decoder
{
	internal DecoderFallback _fallback; //Field offset: 0x10
	internal DecoderFallbackBuffer _fallbackBuffer; //Field offset: 0x18

	public DecoderFallback Fallback
	{
		 get { } //Length: 8
	}

	public DecoderFallbackBuffer FallbackBuffer
	{
		 get { } //Length: 60
	}

	internal bool InternalHasFallbackBuffer
	{
		internal get { } //Length: 16
	}

	protected Decoder() { }

	public DecoderFallback get_Fallback() { }

	public DecoderFallbackBuffer get_FallbackBuffer() { }

	internal bool get_InternalHasFallbackBuffer() { }

	public abstract int GetCharCount(Byte[] bytes, int index, int count) { }

	public override int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	[CLSCompliant(False)]
	public override int GetCharCount(Byte* bytes, int count, bool flush) { }

	public abstract int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, bool flush) { }

	[CLSCompliant(False)]
	public override int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush) { }

	public override int GetChars(ReadOnlySpan<Byte> bytes, Span<Char> chars, bool flush) { }

	public override void Reset() { }

}

