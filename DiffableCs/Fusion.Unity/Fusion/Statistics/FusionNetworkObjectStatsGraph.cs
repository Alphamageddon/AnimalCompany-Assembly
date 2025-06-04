namespace Fusion.Statistics;

public class FusionNetworkObjectStatsGraph : FusionStatsGraphBase
{
	[SerializeField]
	private Text _description; //Field offset: 0x120
	private NetworkId _id; //Field offset: 0x128
	private NetworkObjectStat _stat; //Field offset: 0x12C
	private FusionNetworkObjectStatsGraphCombine _combineParentGraph; //Field offset: 0x130

	public FusionNetworkObjectStatsGraph() { }

	private float GetNetworkObjectStatValue(FusionStatisticsManager statisticsManager) { }

	internal void SetupNetworkObjectStat(NetworkId id, NetworkObjectStat stat) { }

	public virtual void UpdateGraph(NetworkRunner runner, FusionStatisticsManager statisticsManager, ref DateTime now) { }

}

