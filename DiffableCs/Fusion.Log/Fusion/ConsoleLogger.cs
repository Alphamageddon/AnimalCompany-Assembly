namespace Fusion;

public class ConsoleLogger : TextWriterLogger
{

	public ConsoleLogger() { }

	public virtual void Log(LogType logType, object message, in LogContext logContext) { }

	public virtual void LogException(Exception ex, in LogContext logContext) { }

}

