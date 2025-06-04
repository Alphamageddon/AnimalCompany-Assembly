namespace AnimalCompany.API;

public class NakamaLogger : ILogger
{
	private LogChannel _channel; //Field offset: 0x10

	public NakamaLogger(LogChannel channel) { }

	public override void DebugFormat(string format, Object[] args) { }

	public override void ErrorFormat(string format, Object[] args) { }

	public override void InfoFormat(string format, Object[] args) { }

	public override void WarnFormat(string format, Object[] args) { }

}

