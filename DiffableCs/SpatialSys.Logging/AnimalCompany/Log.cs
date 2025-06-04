namespace AnimalCompany;

public class Log : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static LogCallback <>9__26_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__26_0(string condition, string stackTrace, LogType type) { }

	}

	private const float UNCAUGHT_EXCEPTION_LOGGING_INTERVAL_SECONDS = 30; //Field offset: 0x0
	[CompilerGenerated]
	private static LogLevel <logLevel>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static LogChannel <logChannelFlags>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static LogLevel <remoteLogLevel>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static LogChannel <remoteLogChannelFlags>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private static bool <disableUncaughtExceptionLogging>k__BackingField; //Field offset: 0x10
	public static Dictionary<String, Object> defaultMetadataFields; //Field offset: 0x18
	private static int _frameNumber; //Field offset: 0x20
	private static Thread _mainThread; //Field offset: 0x28
	private static string _logFilePathPrefix; //Field offset: 0x30
	private static Dictionary<UncaughtException, UncaughtExceptionInfo> _uncaughtExceptions; //Field offset: 0x38

	public static bool disableUncaughtExceptionLogging
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		 set { } //Length: 96
	}

	public static LogChannel logChannelFlags
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		 set { } //Length: 92
	}

	public static LogLevel logLevel
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		 set { } //Length: 92
	}

	public static LogChannel remoteLogChannelFlags
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		 set { } //Length: 92
	}

	public static LogLevel remoteLogLevel
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		 set { } //Length: 92
	}

	private static Log() { }

	public Log() { }

	private static void AddFields(JSONObject json, IDictionary data) { }

	private void Awake() { }

	private static int Color32ToRGB24(Color32 c) { }

	private static string Color32ToRGBString(Color32 c) { }

	public static void Debug(LogChannel channel, string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Debug(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	private static void DoLog(LogLevel level, LogChannel channel, string message, Exception exception, Dictionary<String, Object> data, string filePath, string memberName, int lineNumber) { }

	public static void Error(string message, Exception exception, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Error(Exception exception, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Error(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Error(LogChannel channel, Exception exception, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Error(LogChannel channel, string message, Exception exception, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Error(LogChannel channel, string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	private static JSONObject ExceptionToJSON(Exception exception) { }

	private static StringBuilder FormatDictionary(IDictionary dictionary) { }

	private static StringBuilder FormatException(Exception exception) { }

	public static void Generic(LogLevel level, string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Generic(LogLevel level, string message, Exception exception = null, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Generic(LogLevel level, LogChannel channel, string message, Exception exception = null, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	[CompilerGenerated]
	public static bool get_disableUncaughtExceptionLogging() { }

	[CompilerGenerated]
	public static LogChannel get_logChannelFlags() { }

	[CompilerGenerated]
	public static LogLevel get_logLevel() { }

	[CompilerGenerated]
	public static LogChannel get_remoteLogChannelFlags() { }

	[CompilerGenerated]
	public static LogLevel get_remoteLogLevel() { }

	public static void Info(LogChannel channel, string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Info(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	private static void InitializeCodebaseFilePathPrefix(string filePath = "") { }

	public static bool IsEnabled(LogLevel level, LogChannel channel) { }

	private static bool LocalLogEnabled(LogLevel level, LogChannel channel) { }

	private static void LogLocal(LogLevel level, LogChannel channel, string message, Exception exception, Dictionary<String, Object> data) { }

	private static void LogRemote(LogLevel level, LogChannel channel, string message, Exception exception, Dictionary<String, Object> data, string filePath, string memberName, int lineNumber) { }

	public static void ProcessUncaughtException(string message, string stackTrace) { }

	private static bool RemoteLogEnabled(LogLevel level, LogChannel channel) { }

	[CompilerGenerated]
	public static void set_disableUncaughtExceptionLogging(bool value) { }

	[CompilerGenerated]
	public static void set_logChannelFlags(LogChannel value) { }

	[CompilerGenerated]
	public static void set_logLevel(LogLevel value) { }

	[CompilerGenerated]
	public static void set_remoteLogChannelFlags(LogChannel value) { }

	[CompilerGenerated]
	public static void set_remoteLogLevel(LogLevel value) { }

	public static void Trace(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Trace(LogChannel channel, string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	private void Update() { }

	public static void Warning(string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

	public static void Warning(LogChannel channel, string message, Dictionary<String, Object> data = null, string filePath = "", string memberName = "", int lineNumber = -1) { }

}

