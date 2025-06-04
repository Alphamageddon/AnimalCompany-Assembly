namespace Oculus.Platform;

public sealed class PlatformSettings : ScriptableObject
{
	private static PlatformSettings instance; //Field offset: 0x0
	[SerializeField]
	private string ovrAppID; //Field offset: 0x18
	[SerializeField]
	private string ovrMobileAppID; //Field offset: 0x20
	[SerializeField]
	private bool ovrUseStandalonePlatform; //Field offset: 0x28

	public static string AppID
	{
		 get { } //Length: 28
		 set { } //Length: 32
	}

	public static PlatformSettings Instance
	{
		 get { } //Length: 292
		 set { } //Length: 76
	}

	public static string MobileAppID
	{
		 get { } //Length: 28
		 set { } //Length: 32
	}

	public static bool UseStandalonePlatform
	{
		 get { } //Length: 28
		 set { } //Length: 36
	}

	public PlatformSettings() { }

	public static string get_AppID() { }

	public static PlatformSettings get_Instance() { }

	public static string get_MobileAppID() { }

	public static bool get_UseStandalonePlatform() { }

	public static void set_AppID(string value) { }

	public static void set_Instance(PlatformSettings value) { }

	public static void set_MobileAppID(string value) { }

	public static void set_UseStandalonePlatform(bool value) { }

}

