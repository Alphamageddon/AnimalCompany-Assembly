namespace Fusion.Statistics;

public class FusionStatsCanvas : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler, IBeginDragHandler
{
	private enum DragMode
	{
		None = 0,
		DragCanvas = 1,
		ResizeContent = 2,
	}

	private static int _statsCanvasActiveCount; //Field offset: 0x0
	[Header("General References")]
	[SerializeField]
	private Canvas _canvas; //Field offset: 0x20
	[SerializeField]
	private CanvasScaler _canvasScaler; //Field offset: 0x28
	[SerializeField]
	private RectTransform _canvasPanel; //Field offset: 0x30
	[Header("Panel References")]
	[SerializeField]
	[Space]
	private RectTransform _contentPanel; //Field offset: 0x38
	[SerializeField]
	private RectTransform _contentContainer; //Field offset: 0x40
	[SerializeField]
	private RectTransform _bottomPanel; //Field offset: 0x48
	[SerializeField]
	private FusionStatsPanelHeader _header; //Field offset: 0x50
	[Header("Misc")]
	[SerializeField]
	[Space]
	private Button _hideButton; //Field offset: 0x58
	[SerializeField]
	private Button _closeButton; //Field offset: 0x60
	[Header("World Anchor Panel Settings")]
	[SerializeField]
	[Space]
	private FusionStatsConfig _config; //Field offset: 0x68
	private CanvasAnchor _anchor; //Field offset: 0x70
	private DragMode _dragMode; //Field offset: 0x74

	private bool _isColapsed
	{
		private get { } //Length: 52
	}

	public FusionStatsCanvas() { }

	private void AdaptContentHeightToGraphs() { }

	private bool CheckDraggableRectVisibility(RectTransform rectTransform) { }

	private bool get__isColapsed() { }

	private Vector2 GetDefinedAnchorPosition() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	private void OnDisable() { }

	public override void OnDrag(PointerEventData eventData) { }

	private void OnEnable() { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public void SetCanvasAnchor(CanvasAnchor anchor) { }

	private void SetContentPanelHeight(float value) { }

	internal void SetupStatsCanvas(FusionStatistics fusionStatistics, CanvasAnchor canvasAnchor, UnityAction closeButtonAction) { }

	public void SnapPanelBackToOriginPos() { }

	internal void ToggleHide() { }

	private void UpdateContentContainerHeight(float yDelta) { }

}

