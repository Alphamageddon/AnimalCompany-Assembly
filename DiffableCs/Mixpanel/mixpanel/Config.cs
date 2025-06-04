namespace mixpanel;

internal static class Config
{
	internal static string TrackUrl; //Field offset: 0x0
	internal const int PoolFillFrames = 50; //Field offset: 0x0
	internal const int PoolFillEachFrame = 20; //Field offset: 0x0
	internal static string EngageUrl; //Field offset: 0x8
	internal static bool ShowDebug; //Field offset: 0x10
	internal static bool ManualInitialization; //Field offset: 0x11
	internal static float FlushInterval; //Field offset: 0x14
	internal static int BatchSize; //Field offset: 0x18

	private static Config() { }

}

