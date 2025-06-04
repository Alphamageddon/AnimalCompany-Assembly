namespace UnityEngine.XR.Interaction.Toolkit.UI;

[AddComponentMenu("Event/Tracked Device Graphic Raycaster", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.UI.TrackedDeviceGraphicRaycaster.html")]
public class TrackedDeviceGraphicRaycaster : BaseRaycaster, IPokeStateDataProvider, IMultiPokeStateDataProvider
{
	private sealed class RaycastHitComparer : IComparer<RaycastHitData>
	{

		public RaycastHitComparer() { }

		public override int Compare(RaycastHitData a, RaycastHitData b) { }

	}

	[IsReadOnly]
	private struct RaycastHitData
	{
		[CompilerGenerated]
		private readonly Graphic <graphic>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly Vector3 <worldHitPosition>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private readonly Vector2 <screenPosition>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private readonly float <distance>k__BackingField; //Field offset: 0x1C
		[CompilerGenerated]
		private readonly int <displayIndex>k__BackingField; //Field offset: 0x20

		public int displayIndex
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public float distance
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public Graphic graphic
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public Vector2 screenPosition
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public Vector3 worldHitPosition
		{
			[CompilerGenerated]
			 get { } //Length: 12
		}

		public RaycastHitData(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance, int displayIndex) { }

		[CompilerGenerated]
		public int get_displayIndex() { }

		[CompilerGenerated]
		public float get_distance() { }

		[CompilerGenerated]
		public Graphic get_graphic() { }

		[CompilerGenerated]
		public Vector2 get_screenPosition() { }

		[CompilerGenerated]
		public Vector3 get_worldHitPosition() { }

	}

	private const int k_MaxRaycastHits = 10; //Field offset: 0x0
	private static readonly RaycastHitComparer s_RaycastHitComparer; //Field offset: 0x0
	private static readonly Vector3[] s_Corners; //Field offset: 0x8
	private static readonly List<RaycastHitData> s_SortedGraphics; //Field offset: 0x10
	private static readonly Dictionary<IUIInteractor, TrackedDeviceGraphicRaycaster> s_InteractorRaycasters; //Field offset: 0x18
	private static readonly Dictionary<TrackedDeviceGraphicRaycaster, HashSet`1<IUIInteractor>> s_PokeHoverRaycasters; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Whether Graphics facing away from the ray caster are checked for ray casts. Enable this to ignore backfacing Graphics.")]
	private bool m_IgnoreReversedGraphics; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Whether or not 2D occlusion is checked when performing ray casts. Enable to make Graphics be blocked by 2D objects that exist in front of it.")]
	private bool m_CheckFor2DOcclusion; //Field offset: 0x29
	[SerializeField]
	[Tooltip("Whether or not 3D occlusion is checked when performing ray casts. Enable to make Graphics be blocked by 3D objects that exist in front of it.")]
	private bool m_CheckFor3DOcclusion; //Field offset: 0x2A
	[SerializeField]
	[Tooltip("The layers of objects that are checked to determine if they block Graphic ray casts when checking for 2D or 3D occlusion.")]
	private LayerMask m_BlockingMask; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("Specifies whether the ray cast should hit Triggers when checking for 3D occlusion.")]
	private QueryTriggerInteraction m_RaycastTriggerInteraction; //Field offset: 0x30
	private Canvas m_Canvas; //Field offset: 0x38
	private bool m_HasWarnedEventCameraNull; //Field offset: 0x40
	private readonly RaycastHit[] m_OcclusionHits3D; //Field offset: 0x48
	private readonly RaycastHit2D[] m_OcclusionHits2D; //Field offset: 0x50
	private readonly List<RaycastHitData> m_RaycastResultsCache; //Field offset: 0x58
	private XRPokeLogic m_PokeLogic; //Field offset: 0x60
	[CompilerGenerated]
	private readonly Dictionary<Transform, BindableVariable`1<PokeStateData>> <pokeStateDataDictionary>k__BackingField; //Field offset: 0x68
	private BindingsGroup m_BindingsGroup; //Field offset: 0x70
	private PhysicsScene m_LocalPhysicsScene; //Field offset: 0x78
	private PhysicsScene2D m_LocalPhysicsScene2D; //Field offset: 0x7C

	public LayerMask blockingMask
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private Canvas canvas
	{
		private get { } //Length: 156
	}

	public bool checkFor2DOcclusion
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool checkFor3DOcclusion
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public virtual Camera eventCamera
	{
		 get { } //Length: 216
	}

	public bool ignoreReversedGraphics
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override IReadOnlyBindableVariable<PokeStateData> pokeStateData
	{
		 get { } //Length: 24
	}

	private Dictionary<Transform, BindableVariable`1<PokeStateData>> pokeStateDataDictionary
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	public QueryTriggerInteraction raycastTriggerInteraction
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static TrackedDeviceGraphicRaycaster() { }

	public TrackedDeviceGraphicRaycaster() { }

	[CompilerGenerated]
	private void <SetupPoke>b__56_0(PokeStateData data) { }

	protected virtual void Awake() { }

	private void EndPokeInteraction(IUIInteractor interactor) { }

	private static RaycastHit FindClosestHit(RaycastHit[] hits, int count) { }

	public LayerMask get_blockingMask() { }

	private Canvas get_canvas() { }

	public bool get_checkFor2DOcclusion() { }

	public bool get_checkFor3DOcclusion() { }

	public virtual Camera get_eventCamera() { }

	public bool get_ignoreReversedGraphics() { }

	public override IReadOnlyBindableVariable<PokeStateData> get_pokeStateData() { }

	[CompilerGenerated]
	private Dictionary<Transform, BindableVariable`1<PokeStateData>> get_pokeStateDataDictionary() { }

	public QueryTriggerInteraction get_raycastTriggerInteraction() { }

	public override IReadOnlyBindableVariable<PokeStateData> GetPokeStateDataForTarget(Transform target) { }

	private static Plane GetRectTransformPlane(RectTransform transform, Vector4 raycastPadding, Vector3[] fourCornersArray) { }

	private static void GetRectTransformWorldCorners(RectTransform transform, Vector4 offset, Vector3[] fourCornersArray) { }

	internal static bool HasPokeSelect(IUIInteractor interactor) { }

	internal static bool IsPokeInteractingWithUI(IUIInteractor interactor) { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDisable() { }

	[Conditional("UNITY_EDITOR")]
	protected void OnDrawGizmosSelected() { }

	private bool PerformRaycast(Vector3 from, Vector3 to, LayerMask layerMask, Camera currentEventCamera, List<RaycastResult> resultAppendList) { }

	private void PerformRaycasts(TrackedDeviceEventData eventData, List<RaycastResult> resultAppendList) { }

	private bool PerformSpherecast(Vector3 origin, float radius, LayerMask layerMask, Camera currentEventCamera, List<RaycastResult> resultAppendList) { }

	private bool ProcessSortedHitsResults(Ray ray, float hitDistance, bool hitSomething, List<RaycastHitData> raycastHitDatums, List<RaycastResult> resultAppendList) { }

	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	private static bool RayIntersectsRectTransform(RectTransform transform, Vector4 raycastPadding, Ray ray, out Vector3 worldPosition, out float distance) { }

	private static bool RayIntersectsRectTransform(Ray ray, Plane plane, out Vector3 worldPosition, out float distance) { }

	public void set_blockingMask(LayerMask value) { }

	public void set_checkFor2DOcclusion(bool value) { }

	public void set_checkFor3DOcclusion(bool value) { }

	public void set_ignoreReversedGraphics(bool value) { }

	public void set_raycastTriggerInteraction(QueryTriggerInteraction value) { }

	private void SetupPoke() { }

	private static bool ShouldTestGraphic(Graphic graphic, LayerMask layerMask) { }

	private static void SortedRaycastGraphics(Canvas canvas, Ray ray, float maxDistance, LayerMask layerMask, Camera eventCamera, List<RaycastHitData> results) { }

	private static void SortedSpherecastGraphics(Canvas canvas, Vector3 origin, float radius, LayerMask layerMask, Camera eventCamera, List<RaycastHitData> results) { }

	private static bool SphereIntersectsRectTransform(RectTransform transform, Vector4 raycastPadding, Vector3 from, out Vector3 worldPosition, out float distance) { }

	internal static bool TryGetPokeStateDataForInteractor(IUIInteractor interactor, out PokeStateData data) { }

}

