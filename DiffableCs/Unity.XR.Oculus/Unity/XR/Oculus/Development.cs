namespace Unity.XR.Oculus;

public static class Development
{
	private enum UserDeveloperModeSettingCache
	{
		NoUserSettingCached = 0,
		UserSettingFalse = 1,
		UserSettingTrue = 2,
	}

	private static UserDeveloperModeSettingCache s_CachedMode; //Field offset: 0x0

	internal static void OverrideDeveloperModeStart() { }

	internal static void OverrideDeveloperModeStop() { }

	public static void TrySetDeveloperMode(bool active) { }

}

