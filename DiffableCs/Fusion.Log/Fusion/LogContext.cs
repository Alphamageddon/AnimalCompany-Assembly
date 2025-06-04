namespace Fusion;

[IsReadOnly]
public struct LogContext
{
	public readonly string Prefix; //Field offset: 0x0
	public readonly object Source; //Field offset: 0x8

	public LogContext(string prefix, object source) { }

}

