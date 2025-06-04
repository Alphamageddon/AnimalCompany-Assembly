namespace System.Text;

public abstract class Encoder
{
	internal EncoderFallback _fallback; //Field offset: 0x10
	internal EncoderFallbackBuffer _fallbackBuffer; //Field offset: 0x18

	public EncoderFallback Fallback
	{
		 get { } //Length: 8
	}

	public EncoderFallbackBuffer FallbackBuffer
	{
		 get { } //Length: 60
	}

	internal bool InternalHasFallbackBuffer
	{
		internal get { } //Length: 16
	}

	protected Encoder() { }

	public EncoderFallback get_Fallback() { }

	public EncoderFallbackBuffer get_FallbackBuffer() { }

	internal bool get_InternalHasFallbackBuffer() { }

	public abstract int GetByteCount(Char[] chars, int index, int count, bool flush) { }

	[CLSCompliant(False)]
	public override int GetByteCount(Char* chars, int count, bool flush) { }

	public abstract int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

	[CLSCompliant(False)]
	public override int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

	public override void Reset() { }

}

