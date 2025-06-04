namespace Fusion;

public interface ILogger
{

	public void Log(LogType logType, object message, in LogContext logContext) { }

	public void LogException(Exception ex, in LogContext logContext) { }

}

