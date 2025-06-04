namespace UnityEngine.XR.Interaction.Toolkit.UI;

[AddComponentMenu("Event/Canvas Optimizer", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.UI.CanvasOptimizer.html")]
public class CanvasOptimizer : MonoBehaviour
{
	private class CanvasState
	{
		private class CanvasScalerSettings
		{
			[CompilerGenerated]
			private bool <present>k__BackingField; //Field offset: 0x10
			private float m_DefaultSpriteDPI; //Field offset: 0x14
			private float m_DynamicPixelsPerUnit; //Field offset: 0x18
			private float m_FallbackScreenDPI; //Field offset: 0x1C
			private float m_MatchWidthOrHeight; //Field offset: 0x20
			private Unit m_PhysicalUnit; //Field offset: 0x24
			private float m_ReferencePixelsPerUnit; //Field offset: 0x28
			private Vector2 m_ReferenceResolution; //Field offset: 0x2C
			private float m_ScaleFactor; //Field offset: 0x34
			private ScreenMatchMode m_ScreenMatchMode; //Field offset: 0x38
			private ScaleMode m_UiScaleMode; //Field offset: 0x3C

			public bool present
			{
				[CompilerGenerated]
				 get { } //Length: 8
				[CompilerGenerated]
				 set { } //Length: 12
			}

			public CanvasScalerSettings() { }

			public void CopyFrom(CanvasScaler source) { }

			public void CopyTo(CanvasScaler dest) { }

			[CompilerGenerated]
			public bool get_present() { }

			[CompilerGenerated]
			public void set_present(bool value) { }

		}

		private class CanvasSettings
		{
			[CompilerGenerated]
			private bool <present>k__BackingField; //Field offset: 0x10
			private AdditionalCanvasShaderChannels m_AdditionalShaderChannels; //Field offset: 0x14
			private float m_NormalizedSortingGridSize; //Field offset: 0x18
			private bool m_OverridePixelPerfect; //Field offset: 0x1C
			private bool m_OverrideSorting; //Field offset: 0x1D
			private float m_PlaneDistance; //Field offset: 0x20
			private float m_ReferencePixelsPerUnit; //Field offset: 0x24
			private RenderMode m_RenderMode; //Field offset: 0x28
			private float m_ScaleFactor; //Field offset: 0x2C
			private int m_SortingLayerID; //Field offset: 0x30
			private string m_SortingLayerName; //Field offset: 0x38
			private int m_SortingOrder; //Field offset: 0x40
			private int m_TargetDisplay; //Field offset: 0x44

			public bool present
			{
				[CompilerGenerated]
				 get { } //Length: 8
				[CompilerGenerated]
				 set { } //Length: 12
			}

			public CanvasSettings() { }

			public void CopyFrom(Canvas source) { }

			public void CopyTo(Canvas dest) { }

			[CompilerGenerated]
			public bool get_present() { }

			[CompilerGenerated]
			public void set_present(bool value) { }

		}

		private class GraphicRaycasterSettings
		{
			[CompilerGenerated]
			private bool <present>k__BackingField; //Field offset: 0x10
			private LayerMask m_BlockingMask; //Field offset: 0x14
			private BlockingObjects m_BlockingObjects; //Field offset: 0x18
			private bool m_IgnoreReversedGraphics; //Field offset: 0x1C

			public bool present
			{
				[CompilerGenerated]
				 get { } //Length: 8
				[CompilerGenerated]
				 set { } //Length: 12
			}

			public GraphicRaycasterSettings() { }

			public void CopyFrom(GraphicRaycaster source) { }

			public void CopyTo(GraphicRaycaster dest) { }

			[CompilerGenerated]
			public bool get_present() { }

			[CompilerGenerated]
			public void set_present(bool value) { }

		}

		private const float k_CanvasCheckInterval = 0.5; //Field offset: 0x0
		private CanvasTracker m_Tracker; //Field offset: 0x10
		private readonly CanvasSettings m_CanvasSettings; //Field offset: 0x18
		private readonly CanvasScalerSettings m_CanvasScalerSettings; //Field offset: 0x20
		private readonly GraphicRaycasterSettings m_GraphicRaycasterSettings; //Field offset: 0x28
		private bool m_WasNested; //Field offset: 0x30
		private bool m_Nested; //Field offset: 0x31
		private bool m_RaysDisabled; //Field offset: 0x32
		private Canvas m_Canvas; //Field offset: 0x38
		private GraphicRaycaster m_Raycaster; //Field offset: 0x40
		private TrackedDeviceGraphicRaycaster m_TrackedDeviceGraphicRaycaster; //Field offset: 0x48
		private float m_CheckTimer; //Field offset: 0x50

		public CanvasState() { }

		internal void CheckForNestedChanges(bool force = false) { }

		internal void CheckForOutOfView(Transform gazeSource, float fovAngle, float facingAngle, float maxDistance) { }

		internal void Initialize(CanvasTracker tracker) { }

	}

	[SerializeField]
	[Tooltip("How wide of an field-of-view to use when determining if a canvas is in view.")]
	private float m_RayPositionIgnoreAngle; //Field offset: 0x20
	[SerializeField]
	[Tooltip("How much the camera and canvas rotate away from one another and still be considered facing.")]
	private float m_RayFacingIgnoreAngle; //Field offset: 0x24
	[SerializeField]
	[Tooltip("How far away a canvas can be from this camera and still receive input.")]
	private float m_RayPositionIgnoreDistance; //Field offset: 0x28
	private Camera m_CullingCamera; //Field offset: 0x30
	private Transform m_CullingCameraTransform; //Field offset: 0x38
	private readonly Dictionary<CanvasTracker, CanvasState> m_CanvasTrackers; //Field offset: 0x40

	public float rayFacingIgnoreAngle
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float rayPositionIgnoreAngle
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float rayPositionIgnoreDistance
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public CanvasOptimizer() { }

	protected void Awake() { }

	private void CheckForNestedCanvasChanges() { }

	private void CheckForOutOfViewCanvases() { }

	private void FindCullingCamera() { }

	public float get_rayFacingIgnoreAngle() { }

	public float get_rayPositionIgnoreAngle() { }

	public float get_rayPositionIgnoreDistance() { }

	private static CanvasTracker InitializeCanvasTracking(Canvas target) { }

	public void RegisterCanvas(Canvas canvas) { }

	public void set_rayFacingIgnoreAngle(float value) { }

	public void set_rayPositionIgnoreAngle(float value) { }

	public void set_rayPositionIgnoreDistance(float value) { }

	public void UnregisterCanvas(Canvas canvas) { }

	protected void Update() { }

}

