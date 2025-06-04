namespace Fusion.Statistics;

public class FusionNetworkObjectStatsGraphCombine : MonoBehaviour
{
	[SerializeField]
	private Text _titleText; //Field offset: 0x20
	[SerializeField]
	private Dropdown _statDropdown; //Field offset: 0x28
	[SerializeField]
	private NetworkObjectStat _statsToRender; //Field offset: 0x30
	[SerializeField]
	private RectTransform _rect; //Field offset: 0x38
	[SerializeField]
	private RectTransform _combinedGraphRender; //Field offset: 0x40
	[SerializeField]
	private Button _toggleButton; //Field offset: 0x48
	private float _headerHeight; //Field offset: 0x50
	private float _graphHeight; //Field offset: 0x54
	private Dictionary<NetworkObjectStat, FusionNetworkObjectStatsGraph> _statsGraphs; //Field offset: 0x58
	[SerializeField]
	private FusionNetworkObjectStatsGraph _statsGraphPrefab; //Field offset: 0x60
	private ContentSizeFitter _parentContentSizeFitter; //Field offset: 0x68
	private NetworkObject _networkObject; //Field offset: 0x70
	private FusionStatistics _fusionStatistics; //Field offset: 0x78
	private FusionNetworkObjectStatistics _objectStatisticsInstance; //Field offset: 0x80

	public NetworkId NetworkObjectID
	{
		 get { } //Length: 44
	}

	public FusionNetworkObjectStatsGraphCombine() { }

	public void DestroyCombinedGraph() { }

	private void DestroyStatGraph(NetworkObjectStat stat) { }

	public NetworkId get_NetworkObjectID() { }

	private void InstantiateStatGraph(NetworkObjectStat stat) { }

	private void OnDisable() { }

	private void OnDropDownChanged(int arg0) { }

	private void OnEnable() { }

	public void SetupNetworkObject(NetworkObject networkObject, FusionStatistics fusionStatistics, FusionNetworkObjectStatistics objectStatisticsInstance) { }

	private void Start() { }

	public void ToggleRenderDisplay() { }

	private void UpdateHeight(float overrideValue = -1) { }

}

