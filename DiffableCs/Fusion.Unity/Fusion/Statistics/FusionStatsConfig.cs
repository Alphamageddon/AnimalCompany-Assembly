namespace Fusion.Statistics;

public class FusionStatsConfig : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Transform candidate; //Field offset: 0x10
		public FusionStatsConfig <>4__this; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <UpdateWorldAnchorButtons>b__0() { }

	}

	private static List<Transform> _worldAnchorCandidates; //Field offset: 0x0
	[CompilerGenerated]
	private static Action _onWorldAnchorCandidatesUpdate; //Field offset: 0x8
	[SerializeField]
	private Button _worldAnchorButtonPrefab; //Field offset: 0x20
	[SerializeField]
	private Transform _worldAnchorListContainer; //Field offset: 0x28
	[SerializeField]
	private GameObject _configPanel; //Field offset: 0x30
	[SerializeField]
	private Canvas _canvas; //Field offset: 0x38
	[SerializeField]
	private RectTransform _renderPanelRectTransform; //Field offset: 0x40
	private Transform _worldTransformAnchor; //Field offset: 0x48
	private float _worldCanvasScale; //Field offset: 0x50
	private FusionStatistics _fusionStatistics; //Field offset: 0x58

	private static event Action _onWorldAnchorCandidatesUpdate
	{
		[CompilerGenerated]
		private add { } //Length: 220
		[CompilerGenerated]
		private remove { } //Length: 220
	}

	public bool IsWorldAnchored
	{
		 get { } //Length: 96
	}

	private static FusionStatsConfig() { }

	public FusionStatsConfig() { }

	[CompilerGenerated]
	private static void add__onWorldAnchorCandidatesUpdate(Action value) { }

	public bool get_IsWorldAnchored() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private static void remove__onWorldAnchorCandidatesUpdate(Action value) { }

	internal void ResetToCanvasAnchor() { }

	internal void SetupStatisticReference(FusionStatistics fusionStatistics) { }

	internal void SetWorldAnchor(Transform worldTransformAnchor) { }

	internal static void SetWorldAnchorCandidate(Transform candidate, bool register) { }

	public void SetWorldCanvasScale(float value) { }

	public void ToggleConfigPanel() { }

	public void ToggleUseWorldAnchor(bool value) { }

	private void UpdateWorldAnchorButtons() { }

}

