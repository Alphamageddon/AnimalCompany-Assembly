namespace Fusion.Statistics;

public class FusionStatsGraphDefault : FusionStatsGraphBase
{
	private RenderSimStats _selectedStats; //Field offset: 0x11C
	[SerializeField]
	private Text _descriptionText; //Field offset: 0x120
	private Dictionary<RenderSimStats, String> _statsAdditionalInfo; //Field offset: 0x128

	internal RenderSimStats Stat
	{
		internal get { } //Length: 8
	}

	public FusionStatsGraphDefault() { }

	public override void ApplyCustomStatsConfig(FusionStatisticsStatCustomConfig config) { }

	internal RenderSimStats get_Stat() { }

	protected virtual void Initialize(int accumulateTimeMs) { }

	internal void SetupDefaultGraph(RenderSimStats stat) { }

	public virtual void UpdateGraph(NetworkRunner runner, FusionStatisticsManager statisticsManager, ref DateTime now) { }

}

