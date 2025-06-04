namespace Fusion;

[Extension]
public static class NetworkObjectFlagsExtensions
{
	private const NetworkObjectFlags CurrentVersion = 1; //Field offset: 0x0

	[Extension]
	public static int GetVersion(NetworkObjectFlags flags) { }

	[Extension]
	public static bool IsIgnored(NetworkObjectFlags flags) { }

	[Extension]
	public static bool IsVersionCurrent(NetworkObjectFlags flags) { }

	[Extension]
	public static NetworkObjectFlags SetCurrentVersion(NetworkObjectFlags flags) { }

	[Extension]
	public static NetworkObjectFlags SetIgnored(NetworkObjectFlags flags, bool value) { }

	private static NetworkObjectFlags SetWithMask(NetworkObjectFlags flags, NetworkObjectFlags value, NetworkObjectFlags mask) { }

}

