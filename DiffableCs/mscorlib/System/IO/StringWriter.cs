namespace System.IO;

[ComVisible(True)]
public class StringWriter : TextWriter
{
	private StringBuilder _sb; //Field offset: 0x30
	private bool _isOpen; //Field offset: 0x38

	public StringWriter() { }

	public StringWriter(StringBuilder sb) { }

	public StringWriter(StringBuilder sb, IFormatProvider formatProvider) { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual string ToString() { }

	public virtual void Write(char value) { }

	public virtual void Write(Char[] buffer, int index, int count) { }

	public virtual void Write(string value) { }

}

