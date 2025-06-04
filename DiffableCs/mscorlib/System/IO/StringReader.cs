namespace System.IO;

[ComVisible(True)]
public class StringReader : TextReader
{
	private string _s; //Field offset: 0x18
	private int _pos; //Field offset: 0x20
	private int _length; //Field offset: 0x24

	public StringReader(string s) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int Peek() { }

	public virtual int Read() { }

	public virtual int Read(out Char[] buffer, int index, int count) { }

	public virtual string ReadLine() { }

	public virtual string ReadToEnd() { }

}

