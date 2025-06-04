namespace System.IO;

public class StreamWriter : TextWriter
{
	public static readonly StreamWriter Null; //Field offset: 0x0
	private Stream _stream; //Field offset: 0x30
	private Encoding _encoding; //Field offset: 0x38
	private Encoder _encoder; //Field offset: 0x40
	private Byte[] _byteBuffer; //Field offset: 0x48
	private Char[] _charBuffer; //Field offset: 0x50
	private int _charPos; //Field offset: 0x58
	private int _charLen; //Field offset: 0x5C
	private bool _autoFlush; //Field offset: 0x60
	private bool _haveWrittenPreamble; //Field offset: 0x61
	private bool _closable; //Field offset: 0x62
	private Task _asyncWriteTask; //Field offset: 0x68

	public override bool AutoFlush
	{
		 set { } //Length: 68
	}

	internal bool LeaveOpen
	{
		internal get { } //Length: 16
	}

	private static Encoding UTF8NoBOM
	{
		private get { } //Length: 80
	}

	private static StreamWriter() { }

	public StreamWriter(string path, bool append, Encoding encoding, int bufferSize) { }

	public StreamWriter(string path, bool append) { }

	internal StreamWriter() { }

	public StreamWriter(Stream stream) { }

	public StreamWriter(Stream stream, Encoding encoding) { }

	public StreamWriter(Stream stream, Encoding encoding, int bufferSize) { }

	public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	public StreamWriter(string path) { }

	private void CheckAsyncTaskInProgress() { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	private void Flush(bool flushStream, bool flushEncoder) { }

	internal bool get_LeaveOpen() { }

	private static Encoding get_UTF8NoBOM() { }

	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	public override void set_AutoFlush(bool value) { }

	private static void ThrowAsyncIOInProgress() { }

	public virtual void Write(char value) { }

	public virtual void Write(Char[] buffer) { }

	public virtual void Write(Char[] buffer, int index, int count) { }

	public virtual void Write(ReadOnlySpan<Char> buffer) { }

	public virtual void Write(string value) { }

	public virtual void WriteLine(string value) { }

	private void WriteSpan(ReadOnlySpan<Char> buffer, bool appendNewLine) { }

}

