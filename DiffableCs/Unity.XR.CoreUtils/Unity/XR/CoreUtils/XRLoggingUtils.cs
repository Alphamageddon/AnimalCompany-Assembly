namespace Unity.XR.CoreUtils;

public static class XRLoggingUtils
{
	private static readonly bool k_DontLogAnything; //Field offset: 0x0

	private static XRLoggingUtils() { }

	public static void Log(string message, object context = null) { }

	public static void LogError(string message, object context = null) { }

	public static void LogException(Exception exception, object context = null) { }

	public static void LogWarning(string message, object context = null) { }

}

