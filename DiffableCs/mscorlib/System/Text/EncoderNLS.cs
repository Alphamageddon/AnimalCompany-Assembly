namespace System.Text;

internal class EncoderNLS : Encoder
{
	internal char _charLeftOver; //Field offset: 0x20
	private Encoding _encoding; //Field offset: 0x28
	private bool _mustFlush; //Field offset: 0x30
	internal bool _throwOnOverflow; //Field offset: 0x31
	internal int _charsUsed; //Field offset: 0x34

	public Encoding Encoding
	{
		 get { } //Length: 8
	}

	public bool MustFlush
	{
		 get { } //Length: 8
	}

	internal EncoderNLS(Encoding encoding) { }

	internal void ClearMustFlush() { }

	public Encoding get_Encoding() { }

	public bool get_MustFlush() { }

	public virtual int GetByteCount(Char[] chars, int index, int count, bool flush) { }

	public virtual int GetByteCount(Char* chars, int count, bool flush) { }

	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

	public virtual void Reset() { }

}

