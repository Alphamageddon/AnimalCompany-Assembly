namespace UnityEngine;

public class Logger : ILogger, ILogHandler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ILogHandler <logHandler>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <logEnabled>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LogType <filterLogType>k__BackingField; //Field offset: 0x1C

	public override LogType filterLogType
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override bool logEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public override ILogHandler logHandler
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Logger(ILogHandler logHandler) { }

	[CompilerGenerated]
	public override LogType get_filterLogType() { }

	[CompilerGenerated]
	public override bool get_logEnabled() { }

	[CompilerGenerated]
	public override ILogHandler get_logHandler() { }

	private static string GetString(object message) { }

	public override bool IsLogTypeAllowed(LogType logType) { }

	public override void Log(LogType logType, object message) { }

	public override void Log(LogType logType, object message, object context) { }

	public override void LogError(string tag, object message) { }

	public override void LogException(Exception exception, object context) { }

	public override void LogFormat(LogType logType, string format, Object[] args) { }

	public override void LogFormat(LogType logType, object context, string format, Object[] args) { }

	[CompilerGenerated]
	public override void set_filterLogType(LogType value) { }

	[CompilerGenerated]
	public override void set_logEnabled(bool value) { }

	[CompilerGenerated]
	public override void set_logHandler(ILogHandler value) { }

}

