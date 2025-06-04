namespace System.Diagnostics;

public sealed class Trace
{

	[Conditional("TRACE")]
	public static void WriteLine(string message) { }

	[Conditional("TRACE")]
	public static void WriteLine(string message, string category) { }

}

