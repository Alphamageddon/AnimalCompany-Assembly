namespace Fusion.Statistics;

public class FusionStatisticsManager
{
	private FusionStatisticsSnapshot _currentTickSnapshot; //Field offset: 0x10
	private FusionStatisticsSnapshot _previousTickSnapshot; //Field offset: 0x18
	private NetworkObjectStatisticsManager _objectStatisticsManager; //Field offset: 0x20

	public FusionStatisticsSnapshot CompleteSnapshot
	{
		 get { } //Length: 8
	}

	public NetworkObjectStatisticsManager ObjectStatisticsManager
	{
		 get { } //Length: 8
	}

	internal FusionStatisticsSnapshot PendingSnapshot
	{
		internal get { } //Length: 8
	}

	internal FusionStatisticsManager() { }

	[Conditional("DEBUG")]
	internal void FinishPendingSnapshot() { }

	public FusionStatisticsSnapshot get_CompleteSnapshot() { }

	public NetworkObjectStatisticsManager get_ObjectStatisticsManager() { }

	internal FusionStatisticsSnapshot get_PendingSnapshot() { }

}

