namespace Oculus.Platform;

public sealed class Core
{
	private static bool IsPlatformInitialized; //Field offset: 0x0
	public static bool LogMessages; //Field offset: 0x1
	public static string PlatformUninitializedError; //Field offset: 0x8

	private static Core() { }

	public Core() { }

	public static Request<PlatformInitialize> AsyncInitialize(string appId = null) { }

	public static Request<PlatformInitialize> AsyncInitialize(string accessToken, Dictionary<InitConfigOptions, Boolean> initConfigOptions, string appId = null) { }

	internal static void ForceInitialized() { }

	private static string getAppID(string appId = null) { }

	private static string GetAppIDFromConfig() { }

	public static void Initialize(string appId = null) { }

	public static bool IsInitialized() { }

}

