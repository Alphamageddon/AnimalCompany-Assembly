namespace System.IO;

public abstract class TextReader : MarshalByRefObject, IDisposable
{
	private sealed class NullTextReader : TextReader
	{

		public NullTextReader() { }

		public virtual int Read(Char[] buffer, int index, int count) { }

		public virtual string ReadLine() { }

	}

	public sealed class SyncTextReader : TextReader
	{
		internal readonly TextReader _in; //Field offset: 0x18

		internal SyncTextReader(TextReader t) { }

		protected virtual void Dispose(bool disposing) { }

		public virtual int Peek() { }

		public virtual int Read() { }

		public virtual int Read(Char[] buffer, int index, int count) { }

		public virtual string ReadLine() { }

		public virtual string ReadToEnd() { }

	}

	public static readonly TextReader Null; //Field offset: 0x0

	private static TextReader() { }

	protected TextReader() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override int Peek() { }

	public override int Read() { }

	public override int Read(Char[] buffer, int index, int count) { }

	public override string ReadLine() { }

	public override string ReadToEnd() { }

	public static TextReader Synchronized(TextReader reader) { }

}

