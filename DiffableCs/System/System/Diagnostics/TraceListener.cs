namespace System.Diagnostics;

public abstract class TraceListener : MarshalByRefObject, IDisposable
{
	private int indentLevel; //Field offset: 0x18
	private int indentSize; //Field offset: 0x1C
	private bool needIndent; //Field offset: 0x20
	private string listenerName; //Field offset: 0x28
	private TraceFilter filter; //Field offset: 0x30

	[ComVisible(False)]
	public TraceFilter Filter
	{
		 get { } //Length: 8
	}

	public int IndentLevel
	{
		 set { } //Length: 28
	}

	public int IndentSize
	{
		 set { } //Length: 168
	}

	public override bool IsThreadSafe
	{
		 get { } //Length: 8
	}

	protected bool NeedIndent
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	protected TraceListener(string name) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	public TraceFilter get_Filter() { }

	public override bool get_IsThreadSafe() { }

	protected bool get_NeedIndent() { }

	public void set_IndentLevel(int value) { }

	public void set_IndentSize(int value) { }

	protected void set_NeedIndent(bool value) { }

	public abstract void Write(string message) { }

	protected override void WriteIndent() { }

	public abstract void WriteLine(string message) { }

	public override void WriteLine(string message, string category) { }

}

