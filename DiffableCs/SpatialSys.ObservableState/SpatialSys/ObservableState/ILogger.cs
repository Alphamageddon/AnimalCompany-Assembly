namespace SpatialSys.ObservableState;

public interface ILogger
{

	public void Debug(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public void Error(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public void Error(string message, Exception exception, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public void Error(Exception exception, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public void Generic(LogLevel level, string message, Exception exception = null, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public void Info(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public bool IsEnabled(LogLevel level) { }

	public void Trace(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public void Warning(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

}

