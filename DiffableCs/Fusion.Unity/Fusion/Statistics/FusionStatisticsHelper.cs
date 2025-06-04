namespace Fusion.Statistics;

internal static class FusionStatisticsHelper
{
	public const float DEFAULT_GRAPH_HEIGHT = 150; //Field offset: 0x0
	public const float DEFAULT_HEADER_HEIGHT = 50; //Field offset: 0x0

	internal static float GetStatDataFromSnapshot(RenderSimStats stat, FusionStatisticsSnapshot simulationStatsSnapshot) { }

	internal static void GetStatGraphDefaultSettings(RenderSimStats stat, out string valueTextFormat, out float valueTextMultiplier, out bool ignoreZeroOnAverage, out bool ignoreZeroOnBuffer, out int accumulateTimeMs) { }

}

