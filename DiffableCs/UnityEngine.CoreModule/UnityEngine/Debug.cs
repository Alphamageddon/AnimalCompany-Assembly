namespace UnityEngine;

[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
public class Debug
{
	internal static readonly ILogger s_DefaultLogger; //Field offset: 0x0
	internal static ILogger s_Logger; //Field offset: 0x8

	public static bool isDebugBuild
	{
		 get { } //Length: 40
	}

	public static ILogger unityLogger
	{
		 get { } //Length: 88
	}

	private static Debug() { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition) { }

	[RequiredByNativeCode]
	internal static bool CallOverridenDebugHandler(Exception exception, object obj) { }

	[ExcludeFromDocs]
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunction("DebugDrawLine", IsThreadSafe = True)]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

	[ExcludeFromDocs]
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	[ThreadSafe]
	public static int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	public static bool get_isDebugBuild() { }

	public static ILogger get_unityLogger() { }

	[RequiredByNativeCode]
	internal static bool IsLoggingEnabled() { }

	public static void Log(object message) { }

	public static void Log(object message, object context) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertion(object message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertionFormat(string format, Object[] args) { }

	public static void LogError(object message) { }

	public static void LogError(object message, object context) { }

	public static void LogErrorFormat(string format, Object[] args) { }

	public static void LogErrorFormat(object context, string format, Object[] args) { }

	public static void LogException(Exception exception) { }

	public static void LogException(Exception exception, object context) { }

	public static void LogFormat(string format, Object[] args) { }

	public static void LogFormat(object context, string format, Object[] args) { }

	public static void LogWarning(object message, object context) { }

	public static void LogWarning(object message) { }

	public static void LogWarningFormat(object context, string format, Object[] args) { }

	public static void LogWarningFormat(string format, Object[] args) { }

}

