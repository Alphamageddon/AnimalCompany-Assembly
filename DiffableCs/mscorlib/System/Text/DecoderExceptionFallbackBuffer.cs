namespace System.Text;

public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
{

	public DecoderExceptionFallbackBuffer() { }

	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	public virtual char GetNextChar() { }

	private void Throw(Byte[] bytesUnknown, int index) { }

}

