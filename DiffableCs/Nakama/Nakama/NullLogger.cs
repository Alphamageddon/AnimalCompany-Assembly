namespace Nakama;

internal class NullLogger : ILogger
{
	public static readonly ILogger Instance; //Field offset: 0x0

	private static NullLogger() { }

	private NullLogger() { }

	public override void DebugFormat(string format, Object[] args) { }

	public override void ErrorFormat(string format, Object[] args) { }

	public override void InfoFormat(string format, Object[] args) { }

	public override void WarnFormat(string format, Object[] args) { }

}

