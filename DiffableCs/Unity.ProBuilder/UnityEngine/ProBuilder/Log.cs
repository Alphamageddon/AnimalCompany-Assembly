namespace UnityEngine.ProBuilder;

internal static class Log
{
	public const string k_ProBuilderLogFileName = "ProBuilderLog.txt"; //Field offset: 0x0
	private static Stack<LogLevel> s_logStack; //Field offset: 0x0
	private static LogLevel s_LogLevel; //Field offset: 0x8
	private static LogOutput s_Output; //Field offset: 0xC
	private static string s_LogFilePath; //Field offset: 0x10

	private static Log() { }

	public static void ClearLogFile() { }

	[Conditional("DEBUG")]
	public static void Debug(T value) { }

	[Conditional("DEBUG")]
	public static void Debug(string message) { }

	[Conditional("DEBUG")]
	public static void Debug(string format, Object[] values) { }

	private static void DoPrint(string message, LogType type) { }

	public static void Error(string format, Object[] values) { }

	public static void Error(string message) { }

	public static void Info(string format, Object[] values) { }

	public static void Info(string message) { }

	internal static void NotNull(T obj, string message) { }

	public static void PopLogLevel() { }

	private static void PrintToConsole(string message, LogType type = 3) { }

	private static void PrintToFile(string message, string path) { }

	public static void PushLogLevel(LogLevel level) { }

	public static void SetLogFile(string path) { }

	public static void SetLogLevel(LogLevel level) { }

	public static void SetOutput(LogOutput output) { }

	public static void Warning(string message) { }

	public static void Warning(string format, Object[] values) { }

	[Conditional("CONSOLE_PRO_ENABLED")]
	internal static void Watch(T key, K value) { }

}

