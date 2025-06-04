namespace Unity.XR.Oculus;

public static class Performance
{
	private static Single[] cachedDisplayAvailableFrequencies; //Field offset: 0x0

	public static bool TryGetAvailableDisplayRefreshRates(out Single[] refreshRates) { }

	public static bool TryGetDisplayRefreshRate(out float refreshRate) { }

	public static bool TrySetCPULevel(int level) { }

	public static bool TrySetDisplayRefreshRate(float refreshRate) { }

	public static bool TrySetGPULevel(int level) { }

}

