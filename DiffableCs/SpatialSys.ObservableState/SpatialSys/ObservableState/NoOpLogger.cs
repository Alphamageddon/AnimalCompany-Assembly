namespace SpatialSys.ObservableState;

public class NoOpLogger : ILogger
{

	public NoOpLogger() { }

	public override void Debug(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Error(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Error(string message, Exception exception, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Error(Exception exception, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Generic(LogLevel level, string message, Exception exception = null, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Info(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override bool IsEnabled(LogLevel level) { }

	public override void Trace(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public override void Warning(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

}

