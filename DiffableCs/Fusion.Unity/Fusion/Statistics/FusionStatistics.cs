namespace Fusion.Statistics;

[AddComponentMenu("Fusion/Statistics/Fusion Statistics")]
[RequireComponent(typeof(NetworkRunner))]
public class FusionStatistics : SimulationBehaviour, ISpawned
{
	internal struct FusionStatisticsStatCustomConfig
	{
		public RenderSimStats Stat; //Field offset: 0x0
		public float Threshold1; //Field offset: 0x4
		public float Threshold2; //Field offset: 0x8
		public float Threshold3; //Field offset: 0xC
		public bool IgnoreZeroOnBuffer; //Field offset: 0x10
		public bool IgnoreZeroOnAverageCalculation; //Field offset: 0x11
		public int AccumulateTimeMs; //Field offset: 0x14

	}

	private const string STATS_CANVAS_PREFAB_PATH = "FusionStatsResources/FusionStatsRenderPanel"; //Field offset: 0x0
	private const string STATS_OBJECT_COMBINE_PREFAB_PATH = "FusionStatsResources/NetworkObjectStatistics"; //Field offset: 0x0
	private GameObject _statsCanvasPrefab; //Field offset: 0x48
	private FusionNetworkObjectStatsGraphCombine _objectGraphCombinePrefab; //Field offset: 0x50
	private List<FusionStatsGraphBase> _statsGraph; //Field offset: 0x58
	private FusionStatsPanelHeader _header; //Field offset: 0x60
	private FusionStatsConfig _config; //Field offset: 0x68
	private FusionStatsCanvas _statsCanvas; //Field offset: 0x70
	private GameObject _statsPanelObject; //Field offset: 0x78
	private Dictionary<FusionNetworkObjectStatistics, FusionNetworkObjectStatsGraphCombine> _objectStatsGraphCombines; //Field offset: 0x80
	[ExpandableEnum]
	[InlineHelp]
	[SerializeField]
	private RenderSimStats _statsEnabled; //Field offset: 0x88
	[InlineHelp]
	[SerializeField]
	private CanvasAnchor _canvasAnchor; //Field offset: 0x8C
	[FormerlySerializedAs("_statsConfig")]
	[Header("Custom configuration to override default values.\nSelect only one stat flag per configuration.")]
	[SerializeField]
	private List<FusionStatisticsStatCustomConfig> _statsCustomConfig; //Field offset: 0x90

	internal List<FusionStatsGraphBase> ActiveGraphs
	{
		internal get { } //Length: 8
	}

	public bool IsPanelActive
	{
		 get { } //Length: 92
	}

	internal List<FusionStatisticsStatCustomConfig> StatsCustomConfig
	{
		internal get { } //Length: 8
	}

	public FusionStatistics() { }

	private void ApplyCustomConfig() { }

	private void Awake() { }

	public void DestroyStatisticsPanel() { }

	private override void Fusion.ISpawned.Spawned() { }

	internal List<FusionStatsGraphBase> get_ActiveGraphs() { }

	public bool get_IsPanelActive() { }

	internal List<FusionStatisticsStatCustomConfig> get_StatsCustomConfig() { }

	public bool MonitorNetworkObject(NetworkObject networkObject, FusionNetworkObjectStatistics objectStatisticsInstance, bool monitor) { }

	public void OnEditorChange() { }

	public void RegisterGraph(FusionStatsGraphBase graph) { }

	private void RenderEnabledStats() { }

	public void SetCanvasAnchor(CanvasAnchor anchor) { }

	public void SetStatsCustomConfig(List<FusionStatisticsStatCustomConfig> customConfig) { }

	public void SetupStatisticsPanel() { }

	public void SetWorldAnchor(FusionStatsWorldAnchor anchor, float scale) { }

	public void UnregisterGraph(FusionStatsGraphBase graph) { }

	private void Update() { }

	private void UpdateAllGraphs(FusionStatisticsManager statisticsManager) { }

	internal void UpdateStatsEnabled(RenderSimStats stats) { }

}

