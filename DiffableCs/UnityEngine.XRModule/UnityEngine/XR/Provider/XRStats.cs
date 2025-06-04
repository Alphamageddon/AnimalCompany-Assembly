namespace UnityEngine.XR.Provider;

public static class XRStats
{

	public static bool TryGetStat(IntegratedSubsystem xrSubsystem, string tag, out float value) { }

	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Modules/XR/Stats/XRStats.h")]
	[NativeMethod("TryGetStatByName_Internal")]
	[StaticAccessor("XRStats::Get()", StaticAccessorType::Dot (0))]
	private static bool TryGetStat_Internal(IntPtr ptr, string tag, out float value) { }

}

