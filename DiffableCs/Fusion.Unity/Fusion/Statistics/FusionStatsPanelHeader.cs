namespace Fusion.Statistics;

public class FusionStatsPanelHeader : MonoBehaviour
{
	[CompilerGenerated]
	private Action OnRenderStatsUpdate; //Field offset: 0x20
	[SerializeField]
	private Text _statsHeaderTitle; //Field offset: 0x28
	[SerializeField]
	private Dropdown _statsDropdown; //Field offset: 0x30
	[SerializeField]
	private FusionStatsGraphDefault _defaultGraphPrefab; //Field offset: 0x38
	public RectTransform ContentRect; //Field offset: 0x40
	private Dictionary<RenderSimStats, FusionStatsGraphDefault> _defaultStatsGraph; //Field offset: 0x48
	private FusionStatistics _fusionStatistics; //Field offset: 0x50
	private RenderSimStats _statsToRender; //Field offset: 0x58

	public event Action OnRenderStatsUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 156
		[CompilerGenerated]
		 remove { } //Length: 156
	}

	public FusionStatsPanelHeader() { }

	[CompilerGenerated]
	public void add_OnRenderStatsUpdate(Action value) { }

	private void AddStat(RenderSimStats stat) { }

	private void ApplyCustomStatsConfig(FusionStatsGraphDefault graph, FusionStatisticsStatCustomConfig config) { }

	internal void ApplyStatsConfig(List<FusionStatisticsStatCustomConfig> statsConfig) { }

	private void DestroyStatGraph(RenderSimStats stat) { }

	private void InstantiateStatGraph(RenderSimStats stat) { }

	private void InvokeRenderStatsUpdate() { }

	private void OnDropDownChanged(int arg0) { }

	[CompilerGenerated]
	public void remove_OnRenderStatsUpdate(Action value) { }

	private void RemoveStat(RenderSimStats stat) { }

	internal void SetStatsToRender(RenderSimStats stats) { }

	private void SetupDropdown() { }

	public void SetupHeader(string title, FusionStatistics fusionStatistics) { }

	private void TryApplyCustomStatConfig(FusionStatsGraphDefault graph) { }

}

