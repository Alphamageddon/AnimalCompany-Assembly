namespace Fusion.Statistics;

internal class LagCompensationStatisticsManager
{
	private LagCompensationStatisticsSnapshot _previousUpdateSnapshot; //Field offset: 0x10
	private LagCompensationStatisticsSnapshot _currentUpdateSnapshot; //Field offset: 0x18

	public LagCompensationStatisticsSnapshot CompletedSnapshot
	{
		 get { } //Length: 8
	}

	internal LagCompensationStatisticsSnapshot PendingSnapshot
	{
		internal get { } //Length: 8
	}

	internal LagCompensationStatisticsManager() { }

	[Conditional("DEBUG")]
	internal void FinishPendingSnapshot() { }

	public LagCompensationStatisticsSnapshot get_CompletedSnapshot() { }

	internal LagCompensationStatisticsSnapshot get_PendingSnapshot() { }

}

