namespace Fusion;

public class LogSimpleUnity : ILogger
{

	public LogSimpleUnity() { }

	private override void Fusion.ILogger.Log(LogType logType, object message, in LogContext logContext) { }

	private override void Fusion.ILogger.LogException(Exception ex, in LogContext logContext) { }

	public void Log(LogType logType, object message, in LogContext logContext) { }

	public void LogException(Exception ex, in LogContext logContext) { }

}

