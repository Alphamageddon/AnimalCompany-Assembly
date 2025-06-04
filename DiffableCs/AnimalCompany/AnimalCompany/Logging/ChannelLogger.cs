namespace AnimalCompany.Logging;

public class ChannelLogger : ILogger
{
	[CompilerGenerated]
	private LogChannel <logChannel>k__BackingField; //Field offset: 0x10

	public private LogChannel logChannel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public ChannelLogger(LogChannel logChannel) { }

	private LogLevel ConvertLogLevel(LogLevel level) { }

	public override void Debug(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Error(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Error(string message, Exception exception, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Error(Exception exception, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Generic(LogLevel level, string message, Exception exception = null, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	[CompilerGenerated]
	public LogChannel get_logChannel() { }

	public override void Info(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override bool IsEnabled(LogLevel level) { }

	[CompilerGenerated]
	private void set_logChannel(LogChannel value) { }

	public override void Trace(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Warning(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

}

