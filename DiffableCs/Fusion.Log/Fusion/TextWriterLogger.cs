namespace Fusion;

public class TextWriterLogger : ILogger, IDisposable
{
	private StringBuilder _builder; //Field offset: 0x10
	private TextWriter _writer; //Field offset: 0x18
	private bool _disposeWriter; //Field offset: 0x20

	public TextWriterLogger(TextWriter writer, bool disposeWriter) { }

	public override void Dispose() { }

	public override void Log(LogType logType, object message, in LogContext logContext) { }

	public override void LogException(Exception ex, in LogContext logContext) { }

}

