namespace Fusion.Statistics;

public class BehaviourStatisticsManager
{
	private BehaviourStatisticsSnapshot _previousUpdateSnapshot; //Field offset: 0x10
	private BehaviourStatisticsSnapshot _currentUpdateSnapshot; //Field offset: 0x18

	public BehaviourStatisticsSnapshot CompletedSnapshot
	{
		 get { } //Length: 8
	}

	internal BehaviourStatisticsSnapshot PendingSnapshot
	{
		internal get { } //Length: 8
	}

	internal BehaviourStatisticsManager() { }

	[Conditional("DEBUG")]
	internal void FinishPendingSnapshot() { }

	public BehaviourStatisticsSnapshot get_CompletedSnapshot() { }

	internal BehaviourStatisticsSnapshot get_PendingSnapshot() { }

}

