namespace Fusion.Photon.Realtime;

internal static class Debug_
{

	[Conditional("DEBUG")]
	public static void Log(string msg) { }

	[Conditional("DEBUG")]
	public static void LogError(string msg) { }

	[Conditional("DEBUG")]
	public static void LogException(Exception ex) { }

	[Conditional("DEBUG")]
	public static void LogWarning(string msg) { }

}

