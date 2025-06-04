namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Ray Interactor", 11)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRRayInteractor.html")]
public class XRRayInteractor : XRBaseControllerInteractor, IAdvancedLineRenderable, ILineRenderable, IUIHoverInteractor, IUIInteractor, IXRRayProvider, IXRScaleValueProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<XRInteractableSnapVolume, Boolean> <>9__275_0; //Field offset: 0x8
		public static Func<XRInteractableSnapVolume, Boolean> <>9__275_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CheckCollidersBetweenPoints>b__275_0(XRInteractableSnapVolume snapVolume) { }

		internal bool <CheckCollidersBetweenPoints>b__275_1(XRInteractableSnapVolume snapVolume) { }

	}

	internal enum AnchorRotationMode
	{
		RotateOverTime = 0,
		MatchDirection = 1,
	}

	internal enum HitDetectionType
	{
		Raycast = 0,
		SphereCast = 1,
		ConeCast = 2,
	}

	internal enum LineType
	{
		StraightLine = 0,
		ProjectileCurve = 1,
		BezierCurve = 2,
	}

	internal enum QuerySnapVolumeInteraction
	{
		Ignore = 0,
		Collide = 1,
	}

	internal sealed class RaycastHitComparer : IComparer<RaycastHit>
	{

		public RaycastHitComparer() { }

		public override int Compare(RaycastHit a, RaycastHit b) { }

	}

	private struct SamplePoint
	{
		[CompilerGenerated]
		private float3 <position>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private float <parameter>k__BackingField; //Field offset: 0xC

		public float parameter
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public float3 position
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 12
			[CompilerGenerated]
			 set { } //Length: 12
		}

		[CompilerGenerated]
		[IsReadOnly]
		public float get_parameter() { }

		[CompilerGenerated]
		[IsReadOnly]
		public float3 get_position() { }

		[CompilerGenerated]
		public void set_parameter(float value) { }

		[CompilerGenerated]
		public void set_position(float3 value) { }

	}

	private const int k_MaxRaycastHits = 10; //Field offset: 0x0
	private const int k_MaxSpherecastHits = 10; //Field offset: 0x0
	private const int k_MinSampleFrequency = 2; //Field offset: 0x0
	private const int k_MaxSampleFrequency = 100; //Field offset: 0x0
	private static readonly List<IXRInteractable> s_Results; //Field offset: 0x0
	private static readonly RaycastHit[] s_SpherecastScratch; //Field offset: 0x8
	private static readonly HashSet<Collider> s_OptimalHits; //Field offset: 0x10
	private static List<SamplePoint> s_ScratchSamplePoints; //Field offset: 0x18
	private static readonly float3[] s_ScratchControlPoints; //Field offset: 0x20
	[SerializeField]
	private LineType m_LineType; //Field offset: 0x290
	[SerializeField]
	private bool m_BlendVisualLinePoints; //Field offset: 0x294
	[SerializeField]
	private float m_MaxRaycastDistance; //Field offset: 0x298
	[SerializeField]
	private Transform m_RayOriginTransform; //Field offset: 0x2A0
	[SerializeField]
	private Transform m_ReferenceFrame; //Field offset: 0x2A8
	[SerializeField]
	private float m_Velocity; //Field offset: 0x2B0
	[SerializeField]
	private float m_Acceleration; //Field offset: 0x2B4
	[SerializeField]
	private float m_AdditionalGroundHeight; //Field offset: 0x2B8
	[SerializeField]
	private float m_AdditionalFlightTime; //Field offset: 0x2BC
	[SerializeField]
	private float m_EndPointDistance; //Field offset: 0x2C0
	[SerializeField]
	private float m_EndPointHeight; //Field offset: 0x2C4
	[SerializeField]
	private float m_ControlPointDistance; //Field offset: 0x2C8
	[SerializeField]
	private float m_ControlPointHeight; //Field offset: 0x2CC
	[Range(2, 100)]
	[SerializeField]
	private int m_SampleFrequency; //Field offset: 0x2D0
	[SerializeField]
	private HitDetectionType m_HitDetectionType; //Field offset: 0x2D4
	[Range(0.01, 0.25)]
	[SerializeField]
	private float m_SphereCastRadius; //Field offset: 0x2D8
	[Range(0, 180)]
	[SerializeField]
	private float m_ConeCastAngle; //Field offset: 0x2DC
	[SerializeField]
	private LayerMask m_RaycastMask; //Field offset: 0x2E0
	[SerializeField]
	private QueryTriggerInteraction m_RaycastTriggerInteraction; //Field offset: 0x2E4
	[SerializeField]
	private QuerySnapVolumeInteraction m_RaycastSnapVolumeInteraction; //Field offset: 0x2E8
	[SerializeField]
	private bool m_HitClosestOnly; //Field offset: 0x2EC
	[SerializeField]
	private bool m_HoverToSelect; //Field offset: 0x2ED
	[SerializeField]
	private float m_HoverTimeToSelect; //Field offset: 0x2F0
	[SerializeField]
	private bool m_AutoDeselect; //Field offset: 0x2F4
	[SerializeField]
	private float m_TimeToAutoDeselect; //Field offset: 0x2F8
	[SerializeField]
	private bool m_EnableUIInteraction; //Field offset: 0x2FC
	[SerializeField]
	private bool m_BlockUIOnInteractableSelection; //Field offset: 0x2FD
	[SerializeField]
	private bool m_AllowAnchorControl; //Field offset: 0x2FE
	[SerializeField]
	private bool m_UseForceGrab; //Field offset: 0x2FF
	[SerializeField]
	private float m_RotateSpeed; //Field offset: 0x300
	[SerializeField]
	private float m_TranslateSpeed; //Field offset: 0x304
	[SerializeField]
	private Transform m_AnchorRotateReferenceFrame; //Field offset: 0x308
	[SerializeField]
	private AnchorRotationMode m_AnchorRotationMode; //Field offset: 0x310
	[SerializeField]
	private UIHoverEnterEvent m_UIHoverEntered; //Field offset: 0x318
	[SerializeField]
	private UIHoverExitEvent m_UIHoverExited; //Field offset: 0x320
	[SerializeField]
	private bool m_EnableARRaycasting; //Field offset: 0x328
	[SerializeField]
	private bool m_OccludeARHitsWith3DObjects; //Field offset: 0x329
	[SerializeField]
	private bool m_OccludeARHitsWith2DObjects; //Field offset: 0x32A
	[CompilerGenerated]
	private IXRInteractable <currentNearestValidTarget>k__BackingField; //Field offset: 0x330
	[CompilerGenerated]
	private Vector3 <rayEndPoint>k__BackingField; //Field offset: 0x338
	[CompilerGenerated]
	private Transform <rayEndTransform>k__BackingField; //Field offset: 0x348
	[SerializeField]
	private ScaleMode m_ScaleMode; //Field offset: 0x350
	[CompilerGenerated]
	private float <scaleValue>k__BackingField; //Field offset: 0x354
	private bool m_HasRayOriginTransform; //Field offset: 0x358
	private bool m_HasReferenceFrame; //Field offset: 0x359
	private bool m_ScaleInputActive; //Field offset: 0x35A
	private readonly List<IXRInteractable> m_ValidTargets; //Field offset: 0x360
	private float m_LastTimeHoveredObjectChanged; //Field offset: 0x368
	private bool m_PassedHoverTimeToSelect; //Field offset: 0x36C
	private float m_LastTimeAutoSelected; //Field offset: 0x370
	private bool m_PassedTimeToAutoDeselect; //Field offset: 0x374
	private GameObject m_LastUIObject; //Field offset: 0x378
	private float m_LastTimeHoveredUIChanged; //Field offset: 0x380
	private bool m_HoverUISelectActive; //Field offset: 0x384
	private bool m_BlockUIAutoDeselect; //Field offset: 0x385
	private readonly RaycastHit[] m_RaycastHits; //Field offset: 0x388
	private int m_RaycastHitsCount; //Field offset: 0x390
	private readonly RaycastHitComparer m_RaycastHitComparer; //Field offset: 0x398
	private List<SamplePoint> m_SamplePoints; //Field offset: 0x3A0
	private int m_SamplePointsFrameUpdated; //Field offset: 0x3A8
	private int m_RaycastHitEndpointIndex; //Field offset: 0x3AC
	private int m_UIRaycastHitEndpointIndex; //Field offset: 0x3B0
	private readonly float3[] m_ControlPoints; //Field offset: 0x3B8
	private readonly float3[] m_HitChordControlPoints; //Field offset: 0x3C0
	private PhysicsScene m_LocalPhysicsScene; //Field offset: 0x3C8
	private RegisteredUIInteractorCache m_RegisteredUIInteractorCache; //Field offset: 0x3D0
	private bool m_RaycastHitOccurred; //Field offset: 0x3D8
	private RaycastHit m_RaycastHit; //Field offset: 0x3DC
	private RaycastResult m_UIRaycastHit; //Field offset: 0x408
	private bool m_IsUIHitClosest; //Field offset: 0x458
	private IXRInteractable m_RaycastInteractable; //Field offset: 0x460
	private ActionBasedController m_ActionBasedController; //Field offset: 0x468
	private XRController m_DeviceBasedController; //Field offset: 0x470
	private XRScreenSpaceController m_ScreenSpaceController; //Field offset: 0x478
	private bool m_IsActionBasedController; //Field offset: 0x480
	private bool m_IsDeviceBasedController; //Field offset: 0x481
	private bool m_IsScreenSpaceController; //Field offset: 0x482

	public float acceleration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("Acceleration has been deprecated. Use acceleration instead. (UnityUpgradable) -> acceleration")]
	public float Acceleration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float additionalFlightTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("AdditionalFlightTime has been deprecated. Use additionalFlightTime instead. (UnityUpgradable) -> additionalFlightTime")]
	public float AdditionalFlightTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float additionalGroundHeight
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool allowAnchorControl
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Transform anchorRotateReferenceFrame
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AnchorRotationMode anchorRotationMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float angle
	{
		 get { } //Length: 64
	}

	[Obsolete("Angle has been deprecated. Use angle instead. (UnityUpgradable) -> angle")]
	public float Angle
	{
		 get { } //Length: 4
	}

	public bool autoDeselect
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool blendVisualLinePoints
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool blockUIOnInteractableSelection
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	private int closestAnyHitIndex
	{
		private get { } //Length: 44
	}

	public float coneCastAngle
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float controlPointDistance
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float controlPointHeight
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected private IXRInteractable currentNearestValidTarget
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private Transform effectiveRayOrigin
	{
		private get { } //Length: 24
	}

	public bool enableARRaycasting
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableUIInteraction
	{
		 get { } //Length: 8
		 set { } //Length: 48
	}

	public float endPointDistance
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float endPointHeight
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool hitClosestOnly
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public HitDetectionType hitDetectionType
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hoverTimeToSelect
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool hoverToSelect
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public virtual bool isSelectActive
	{
		 get { } //Length: 28
	}

	protected virtual bool isUISelectActive
	{
		 get { } //Length: 28
	}

	public LineType lineType
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float maxRaycastDistance
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool occludeARHitsWith2DObjects
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool occludeARHitsWith3DObjects
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("originalAttachTransform has been deprecated. Use rayOriginTransform instead. (UnityUpgradable) -> rayOriginTransform")]
	protected Transform originalAttachTransform
	{
		 get { } //Length: 8
		 set { } //Length: 4
	}

	public LayerMask raycastMask
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public QuerySnapVolumeInteraction raycastSnapVolumeInteraction
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public QueryTriggerInteraction raycastTriggerInteraction
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public private override Vector3 rayEndPoint
	{
		[CompilerGenerated]
		 get { } //Length: 16
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private override Transform rayEndTransform
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Transform rayOriginTransform
	{
		 get { } //Length: 8
		 set { } //Length: 120
	}

	public Transform referenceFrame
	{
		 get { } //Length: 8
		 set { } //Length: 120
	}

	private Vector3 referencePosition
	{
		private get { } //Length: 100
	}

	private Vector3 referenceUp
	{
		private get { } //Length: 100
	}

	public float rotateSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int sampleFrequency
	{
		 get { } //Length: 8
		 set { } //Length: 108
	}

	public override ScaleMode scaleMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override float scaleValue
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float sphereCastRadius
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float timeToAutoDeselect
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float translateSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override UIHoverEnterEvent uiHoverEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override UIHoverExitEvent uiHoverExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool useForceGrab
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float velocity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("Velocity has been deprecated. Use velocity instead. (UnityUpgradable) -> velocity")]
	public float Velocity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static XRRayInteractor() { }

	public XRRayInteractor() { }

	protected virtual void Awake() { }

	private void CacheRaycastHit() { }

	[BurstCompile]
	private void CalculateProjectileParameters(in float3 lineOrigin, in float3 lineDirection, out float3 initialVelocity, out float3 constantAcceleration, out float flightTime) { }

	public virtual bool CanHover(IXRHoverInteractable interactable) { }

	[Obsolete("CanHover(XRBaseInteractable) has been deprecated. Use CanHover(IXRHoverInteractable) instead.")]
	public virtual bool CanHover(XRBaseInteractable interactable) { }

	[Obsolete("CanSelect(XRBaseInteractable) has been deprecated. Use CanSelect(IXRSelectInteractable) instead.")]
	public virtual bool CanSelect(XRBaseInteractable interactable) { }

	public virtual bool CanSelect(IXRSelectInteractable interactable) { }

	private void CheckCollidersBetweenPoints(Vector3 from, Vector3 to, Vector3 origin) { }

	private void CreateBezierCurve(List<SamplePoint> samplePoints, int endSamplePointIndex, float3[] quadraticControlPoints, Nullable<Ray> rayOriginOverride = null) { }

	private void CreateRayOrigin() { }

	private void CreateSamplePointsListsIfNecessary() { }

	private static void DrawQuadraticBezierGizmo(Vector3 p0, Vector3 p1, Vector3 p2) { }

	private static void EnsureCapacity(ref NativeArray<Vector3>& linePoints, int numPoints) { }

	private int FilteredConecast(in Vector3 from, float coneCastAngleDegrees, in Vector3 direction, in Vector3 origin, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	private static int FilterTriggerColliders(XRInteractionManager interactionManager, RaycastHit[] raycastHits, int count, Func<XRInteractableSnapVolume, Boolean> removeRule) { }

	private void FindReferenceFrame() { }

	public float get_acceleration() { }

	public float get_Acceleration() { }

	public float get_additionalFlightTime() { }

	public float get_AdditionalFlightTime() { }

	public float get_additionalGroundHeight() { }

	public bool get_allowAnchorControl() { }

	public Transform get_anchorRotateReferenceFrame() { }

	public AnchorRotationMode get_anchorRotationMode() { }

	public float get_angle() { }

	public float get_Angle() { }

	public bool get_autoDeselect() { }

	public bool get_blendVisualLinePoints() { }

	public bool get_blockUIOnInteractableSelection() { }

	private int get_closestAnyHitIndex() { }

	public float get_coneCastAngle() { }

	public float get_controlPointDistance() { }

	public float get_controlPointHeight() { }

	[CompilerGenerated]
	protected IXRInteractable get_currentNearestValidTarget() { }

	private Transform get_effectiveRayOrigin() { }

	public bool get_enableARRaycasting() { }

	public bool get_enableUIInteraction() { }

	public float get_endPointDistance() { }

	public float get_endPointHeight() { }

	public bool get_hitClosestOnly() { }

	public HitDetectionType get_hitDetectionType() { }

	public float get_hoverTimeToSelect() { }

	public bool get_hoverToSelect() { }

	public virtual bool get_isSelectActive() { }

	protected virtual bool get_isUISelectActive() { }

	public LineType get_lineType() { }

	public float get_maxRaycastDistance() { }

	public bool get_occludeARHitsWith2DObjects() { }

	public bool get_occludeARHitsWith3DObjects() { }

	protected Transform get_originalAttachTransform() { }

	public LayerMask get_raycastMask() { }

	public QuerySnapVolumeInteraction get_raycastSnapVolumeInteraction() { }

	public QueryTriggerInteraction get_raycastTriggerInteraction() { }

	[CompilerGenerated]
	public override Vector3 get_rayEndPoint() { }

	[CompilerGenerated]
	public override Transform get_rayEndTransform() { }

	public Transform get_rayOriginTransform() { }

	public Transform get_referenceFrame() { }

	private Vector3 get_referencePosition() { }

	private Vector3 get_referenceUp() { }

	public float get_rotateSpeed() { }

	public int get_sampleFrequency() { }

	public override ScaleMode get_scaleMode() { }

	[CompilerGenerated]
	public override float get_scaleValue() { }

	public float get_sphereCastRadius() { }

	public float get_timeToAutoDeselect() { }

	public float get_translateSpeed() { }

	public override UIHoverEnterEvent get_uiHoverEntered() { }

	public override UIHoverExitEvent get_uiHoverExited() { }

	public bool get_useForceGrab() { }

	public float get_velocity() { }

	public float get_Velocity() { }

	[Obsolete("GetCurrentRaycastHit has been deprecated. Use TryGetCurrent3DRaycastHit instead. (UnityUpgradable) -> TryGetCurrent3DRaycastHit(*)")]
	public bool GetCurrentRaycastHit(out RaycastHit raycastHit) { }

	protected override float GetHoverTimeToSelect(IXRInteractable interactable) { }

	public override void GetLineOriginAndDirection(out Vector3 origin, out Vector3 direction) { }

	private void GetLineOriginAndDirection(Nullable<Ray> rayOriginOverride, out Vector3 origin, out Vector3 direction) { }

	private static void GetLineOriginAndDirection(Transform rayOrigin, out Vector3 origin, out Vector3 direction) { }

	public override bool GetLinePoints(ref Vector3[] linePoints, out int numPoints) { }

	public override bool GetLinePoints(ref NativeArray<Vector3>& linePoints, out int numPoints, Nullable<Ray> rayOriginOverride = null) { }

	[Obsolete("GetLinePoints with ref int parameter has been deprecated. Use signature with out int parameter instead.", True)]
	public bool GetLinePoints(ref Vector3[] linePoints, ref int numPoints, int _ = 0) { }

	private float GetProjectileAngle(Vector3 lineDirection) { }

	protected override float GetTimeToAutoDeselect(IXRInteractable interactable) { }

	public virtual void GetValidTargets(List<IXRInteractable> targets) { }

	public bool IsOverUIGameObject() { }

	protected virtual void OnDisable() { }

	protected override void OnDrawGizmosSelected() { }

	protected virtual void OnEnable() { }

	protected virtual void OnSelectEntering(SelectEnterEventArgs args) { }

	protected virtual void OnSelectExiting(SelectExitEventArgs args) { }

	protected override void OnUIHoverEntered(UIHoverEventArgs args) { }

	protected override void OnUIHoverExited(UIHoverEventArgs args) { }

	protected void OnValidate() { }

	virtual void OnXRControllerChanged() { }

	public virtual void PreprocessInteractor(UpdatePhase updatePhase) { }

	public virtual void ProcessInteractor(UpdatePhase updatePhase) { }

	private static void RemoveAt(T[] array, int index, int count) { }

	private void RestoreAttachTransform() { }

	protected override void RotateAnchor(Transform anchor, float directionAmount) { }

	protected override void RotateAnchor(Transform anchor, Vector2 direction, Quaternion referenceRotation) { }

	private static int SanitizeSampleFrequency(int value) { }

	public void set_acceleration(float value) { }

	public void set_Acceleration(float value) { }

	public void set_additionalFlightTime(float value) { }

	public void set_AdditionalFlightTime(float value) { }

	public void set_additionalGroundHeight(float value) { }

	public void set_allowAnchorControl(bool value) { }

	public void set_anchorRotateReferenceFrame(Transform value) { }

	public void set_anchorRotationMode(AnchorRotationMode value) { }

	public void set_autoDeselect(bool value) { }

	public void set_blendVisualLinePoints(bool value) { }

	public void set_blockUIOnInteractableSelection(bool value) { }

	public void set_coneCastAngle(float value) { }

	public void set_controlPointDistance(float value) { }

	public void set_controlPointHeight(float value) { }

	[CompilerGenerated]
	private void set_currentNearestValidTarget(IXRInteractable value) { }

	public void set_enableARRaycasting(bool value) { }

	public void set_enableUIInteraction(bool value) { }

	public void set_endPointDistance(float value) { }

	public void set_endPointHeight(float value) { }

	public void set_hitClosestOnly(bool value) { }

	public void set_hitDetectionType(HitDetectionType value) { }

	public void set_hoverTimeToSelect(float value) { }

	public void set_hoverToSelect(bool value) { }

	public void set_lineType(LineType value) { }

	public void set_maxRaycastDistance(float value) { }

	public void set_occludeARHitsWith2DObjects(bool value) { }

	public void set_occludeARHitsWith3DObjects(bool value) { }

	protected void set_originalAttachTransform(Transform value) { }

	public void set_raycastMask(LayerMask value) { }

	public void set_raycastSnapVolumeInteraction(QuerySnapVolumeInteraction value) { }

	public void set_raycastTriggerInteraction(QueryTriggerInteraction value) { }

	[CompilerGenerated]
	private void set_rayEndPoint(Vector3 value) { }

	[CompilerGenerated]
	private void set_rayEndTransform(Transform value) { }

	public void set_rayOriginTransform(Transform value) { }

	public void set_referenceFrame(Transform value) { }

	public void set_rotateSpeed(float value) { }

	public void set_sampleFrequency(int value) { }

	public override void set_scaleMode(ScaleMode value) { }

	[CompilerGenerated]
	protected void set_scaleValue(float value) { }

	public void set_sphereCastRadius(float value) { }

	public void set_timeToAutoDeselect(float value) { }

	public void set_translateSpeed(float value) { }

	public void set_uiHoverEntered(UIHoverEnterEvent value) { }

	public void set_uiHoverExited(UIHoverExitEvent value) { }

	public void set_useForceGrab(bool value) { }

	public void set_velocity(float value) { }

	public void set_Velocity(float value) { }

	protected override void TranslateAnchor(Transform rayOrigin, Transform anchor, float directionAmount) { }

	public bool TryGetCurrent3DRaycastHit(out RaycastHit raycastHit, out int raycastEndpointIndex) { }

	public bool TryGetCurrent3DRaycastHit(out RaycastHit raycastHit) { }

	public bool TryGetCurrentRaycast(out Nullable<RaycastHit>& raycastHit, out int raycastHitIndex, out Nullable<RaycastResult>& uiRaycastHit, out int uiRaycastHitIndex, out bool isUIHitClosest) { }

	public bool TryGetCurrentUIRaycastResult(out RaycastResult raycastResult, out int raycastEndpointIndex) { }

	public bool TryGetCurrentUIRaycastResult(out RaycastResult raycastResult) { }

	public override bool TryGetHitInfo(out Vector3 position, out Vector3 normal, out int positionInLine, out bool isValidTarget) { }

	[Obsolete("TryGetHitInfo with ref parameters has been deprecated. Use signature with out parameters instead.", True)]
	public bool TryGetHitInfo(ref Vector3 position, ref Vector3 normal, ref int positionInLine, ref bool isValidTarget, int _ = 0) { }

	public override bool TryGetUIModel(out TrackedDeviceModel model) { }

	private static bool TryRead2DAxis(InputAction action, out Vector2 output) { }

	private static bool TryReadButton(InputAction action) { }

	private override Transform UnityEngine.XR.Interaction.Toolkit.IXRRayProvider.GetOrCreateAttachTransform() { }

	private override Transform UnityEngine.XR.Interaction.Toolkit.IXRRayProvider.GetOrCreateRayOrigin() { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRRayProvider.SetAttachTransform(Transform newAttach) { }

	private override void UnityEngine.XR.Interaction.Toolkit.IXRRayProvider.SetRayOrigin(Transform newOrigin) { }

	private override void UnityEngine.XR.Interaction.Toolkit.UI.IUIHoverInteractor.OnUIHoverEntered(UIHoverEventArgs args) { }

	private override void UnityEngine.XR.Interaction.Toolkit.UI.IUIHoverInteractor.OnUIHoverExited(UIHoverEventArgs args) { }

	private void UpdateBezierControlPoints(in float3 lineOrigin, in float3 lineDirection, in float3 curveReferenceUp) { }

	private void UpdateRaycastHits() { }

	private void UpdateSamplePoints(int count, List<SamplePoint> samplePoints, Nullable<Ray> rayOriginOverride = null) { }

	private void UpdateSamplePointsIfNecessary() { }

	private void UpdateUIHover() { }

	public override void UpdateUIModel(ref TrackedDeviceModel model) { }

}

