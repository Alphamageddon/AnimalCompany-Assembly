namespace System.IO;

public class StreamReader : TextReader
{
	private class NullStreamReader : StreamReader
	{

		public virtual Stream BaseStream
		{
			 get { } //Length: 88
		}

		public virtual Encoding CurrentEncoding
		{
			 get { } //Length: 8
		}

		internal NullStreamReader() { }

		protected virtual void Dispose(bool disposing) { }

		public virtual Stream get_BaseStream() { }

		public virtual Encoding get_CurrentEncoding() { }

		public virtual int Peek() { }

		public virtual int Read() { }

		public virtual int Read(Char[] buffer, int index, int count) { }

		internal virtual int ReadBuffer() { }

		public virtual string ReadLine() { }

		public virtual string ReadToEnd() { }

	}

	public static readonly StreamReader Null; //Field offset: 0x0
	private Stream _stream; //Field offset: 0x18
	private Encoding _encoding; //Field offset: 0x20
	private Decoder _decoder; //Field offset: 0x28
	private Byte[] _byteBuffer; //Field offset: 0x30
	private Char[] _charBuffer; //Field offset: 0x38
	private int _charPos; //Field offset: 0x40
	private int _charLen; //Field offset: 0x44
	private int _byteLen; //Field offset: 0x48
	private int _bytePos; //Field offset: 0x4C
	private int _maxCharsPerBuffer; //Field offset: 0x50
	private bool _detectEncoding; //Field offset: 0x54
	private bool _checkPreamble; //Field offset: 0x55
	private bool _isBlocked; //Field offset: 0x56
	private bool _closable; //Field offset: 0x57
	private Task _asyncReadTask; //Field offset: 0x58

	public override Stream BaseStream
	{
		 get { } //Length: 8
	}

	public override Encoding CurrentEncoding
	{
		 get { } //Length: 8
	}

	internal bool LeaveOpen
	{
		internal get { } //Length: 16
	}

	private static StreamReader() { }

	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	internal StreamReader() { }

	public StreamReader(Stream stream, Encoding encoding) { }

	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	public StreamReader(string path) { }

	public StreamReader(string path, bool detectEncodingFromByteOrderMarks) { }

	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	private void CheckAsyncTaskInProgress() { }

	private void CompressBuffer(int n) { }

	internal bool DataAvailable() { }

	private void DetectEncoding() { }

	protected virtual void Dispose(bool disposing) { }

	public override Stream get_BaseStream() { }

	public override Encoding get_CurrentEncoding() { }

	internal bool get_LeaveOpen() { }

	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	internal void Init(Stream stream) { }

	private bool IsPreamble() { }

	public virtual int Peek() { }

	public virtual int Read(Char[] buffer, int index, int count) { }

	public virtual int Read() { }

	internal override int ReadBuffer() { }

	private int ReadBuffer(Span<Char> userBuffer, out bool readToUserBuffer) { }

	public virtual string ReadLine() { }

	private int ReadSpan(Span<Char> buffer) { }

	public virtual string ReadToEnd() { }

	private static void ThrowAsyncIOInProgress() { }

}

