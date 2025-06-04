namespace System.IO;

public abstract class TextWriter : MarshalByRefObject, IDisposable
{
	private sealed class NullTextWriter : TextWriter
	{

		internal NullTextWriter() { }

		public virtual void Write(Char[] buffer, int index, int count) { }

		public virtual void Write(string value) { }

		public virtual void Write(char value) { }

		public virtual void WriteLine() { }

		public virtual void WriteLine(string value) { }

	}

	public sealed class SyncTextWriter : TextWriter, IDisposable
	{
		private readonly TextWriter _out; //Field offset: 0x30

		public virtual IFormatProvider FormatProvider
		{
			 get { } //Length: 32
		}

		public virtual string NewLine
		{
			 get { } //Length: 32
		}

		internal SyncTextWriter(TextWriter t) { }

		public virtual void Close() { }

		protected virtual void Dispose(bool disposing) { }

		public virtual void Flush() { }

		public virtual IFormatProvider get_FormatProvider() { }

		public virtual string get_NewLine() { }

		public virtual void Write(char value) { }

		public virtual void Write(Char[] buffer) { }

		public virtual void Write(Char[] buffer, int index, int count) { }

		public virtual void Write(int value) { }

		public virtual void Write(string value) { }

		public virtual void WriteLine() { }

		public virtual void WriteLine(int value) { }

		public virtual void WriteLine(string value) { }

	}

	public static readonly TextWriter Null; //Field offset: 0x0
	private static readonly Char[] s_coreNewLine; //Field offset: 0x8
	protected Char[] CoreNewLine; //Field offset: 0x18
	private string CoreNewLineStr; //Field offset: 0x20
	private IFormatProvider _internalFormatProvider; //Field offset: 0x28

	public override IFormatProvider FormatProvider
	{
		 get { } //Length: 104
	}

	public override string NewLine
	{
		 get { } //Length: 8
	}

	private static TextWriter() { }

	protected TextWriter() { }

	protected TextWriter(IFormatProvider formatProvider) { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public override void Flush() { }

	public override IFormatProvider get_FormatProvider() { }

	public override string get_NewLine() { }

	public static TextWriter Synchronized(TextWriter writer) { }

	public override void Write(string value) { }

	public override void Write(int value) { }

	public override void Write(Char[] buffer, int index, int count) { }

	public override void Write(char value) { }

	public override void Write(ReadOnlySpan<Char> buffer) { }

	public override void Write(Char[] buffer) { }

	public override void WriteLine() { }

	public override void WriteLine(int value) { }

	public override void WriteLine(string value) { }

}

