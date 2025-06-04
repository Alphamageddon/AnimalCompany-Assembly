namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Visual/XR Interactor Line Visual", 11)]
[BurstCompile]
[DefaultExecutionOrder(100)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual.html")]
[RequireComponent(typeof(LineRenderer))]
public class XRInteractorLineVisual : MonoBehaviour, IXRCustomReticleProvider
{
	public static class CalculateLineCurveRenderPoints_0000037D$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static CalculateLineCurveRenderPoints_0000037D$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(int numTargetPoints, float curveRatio, in Vector3 lineOrigin, in Vector3 lineDirection, in Vector3 endPoint, ref NativeArray<Vector3>& targetPoints) { }

	}

	internal sealed class CalculateLineCurveRenderPoints_0000037D$PostfixBurstDelegate : MulticastDelegate
	{

		public CalculateLineCurveRenderPoints_0000037D$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(int numTargetPoints, float curveRatio, in Vector3 lineOrigin, in Vector3 lineDirection, in Vector3 endPoint, ref NativeArray<Vector3>& targetPoints, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(int numTargetPoints, float curveRatio, in Vector3 lineOrigin, in Vector3 lineDirection, in Vector3 endPoint, ref NativeArray<Vector3>& targetPoints) { }

	}

	public static class ComputeNewRenderPoints_0000037E$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ComputeNewRenderPoints_0000037E$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static int Invoke(int numRenderPoints, int numTargetPoints, float targetLineLength, bool shouldSmoothPoints, bool shouldOverwritePoints, float pointSmoothIncrement, ref NativeArray<float3>& targetPoints, ref NativeArray<float3>& previousRenderPoints, ref NativeArray<float3>& renderPoints) { }

	}

	internal sealed class ComputeNewRenderPoints_0000037E$PostfixBurstDelegate : MulticastDelegate
	{

		public ComputeNewRenderPoints_0000037E$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(int numRenderPoints, int numTargetPoints, float targetLineLength, bool shouldSmoothPoints, bool shouldOverwritePoints, float pointSmoothIncrement, ref NativeArray<float3>& targetPoints, ref NativeArray<float3>& previousRenderPoints, ref NativeArray<float3>& renderPoints, AsyncCallback unnamed_param_9, object unnamed_param_10) { }

		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		public override int Invoke(int numRenderPoints, int numTargetPoints, float targetLineLength, bool shouldSmoothPoints, bool shouldOverwritePoints, float pointSmoothIncrement, ref NativeArray<float3>& targetPoints, ref NativeArray<float3>& previousRenderPoints, ref NativeArray<float3>& renderPoints) { }

	}

	public static class EvaluateLineEndPoint_0000037F$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static EvaluateLineEndPoint_0000037F$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static bool Invoke(float targetLineLength, bool shouldSmoothPoint, in float3 unsmoothedTargetPoint, in float3 lastRenderPoint, ref float3 newRenderPoint, ref float lineLength) { }

	}

	internal sealed class EvaluateLineEndPoint_0000037F$PostfixBurstDelegate : MulticastDelegate
	{

		public EvaluateLineEndPoint_0000037F$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float targetLineLength, bool shouldSmoothPoint, in float3 unsmoothedTargetPoint, in float3 lastRenderPoint, ref float3 newRenderPoint, ref float lineLength, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		public override bool EndInvoke(IAsyncResult unnamed_param_0) { }

		public override bool Invoke(float targetLineLength, bool shouldSmoothPoint, in float3 unsmoothedTargetPoint, in float3 lastRenderPoint, ref float3 newRenderPoint, ref float lineLength) { }

	}

	private const float k_MinLineWidth = 0.0001; //Field offset: 0x0
	private const float k_MaxLineBendRatio = 1; //Field offset: 0x0
	private const int k_NumberOfSegmentsForBendableLine = 20; //Field offset: 0x0
	private const float k_MaxLineWidth = 0.05; //Field offset: 0x0
	private const float k_MinLineBendRatio = 0.01; //Field offset: 0x0
	[Range(0.0001, 0.05)]
	[SerializeField]
	private float m_LineWidth; //Field offset: 0x20
	[SerializeField]
	private bool m_OverrideInteractorLineLength; //Field offset: 0x24
	[SerializeField]
	private float m_LineLength; //Field offset: 0x28
	[SerializeField]
	private bool m_AutoAdjustLineLength; //Field offset: 0x2C
	[SerializeField]
	private float m_MinLineLength; //Field offset: 0x30
	[SerializeField]
	private bool m_UseDistanceToHitAsMaxLineLength; //Field offset: 0x34
	[SerializeField]
	private float m_LineRetractionDelay; //Field offset: 0x38
	[SerializeField]
	private float m_LineLengthChangeSpeed; //Field offset: 0x3C
	[SerializeField]
	private AnimationCurve m_WidthCurve; //Field offset: 0x40
	[SerializeField]
	private bool m_SetLineColorGradient; //Field offset: 0x48
	[SerializeField]
	private Gradient m_ValidColorGradient; //Field offset: 0x50
	[SerializeField]
	private Gradient m_InvalidColorGradient; //Field offset: 0x58
	[SerializeField]
	private Gradient m_BlockedColorGradient; //Field offset: 0x60
	[SerializeField]
	private bool m_TreatSelectionAsValidState; //Field offset: 0x68
	[SerializeField]
	private bool m_SmoothMovement; //Field offset: 0x69
	[SerializeField]
	private float m_FollowTightness; //Field offset: 0x6C
	[SerializeField]
	private float m_SnapThresholdDistance; //Field offset: 0x70
	[SerializeField]
	private GameObject m_Reticle; //Field offset: 0x78
	[SerializeField]
	private GameObject m_BlockedReticle; //Field offset: 0x80
	[SerializeField]
	private bool m_StopLineAtFirstRaycastHit; //Field offset: 0x88
	[SerializeField]
	private bool m_StopLineAtSelection; //Field offset: 0x89
	[SerializeField]
	private bool m_SnapEndpointIfAvailable; //Field offset: 0x8A
	[Range(0.01, 1)]
	[SerializeField]
	private float m_LineBendRatio; //Field offset: 0x8C
	[SerializeField]
	private bool m_OverrideInteractorLineOrigin; //Field offset: 0x90
	[SerializeField]
	private Transform m_LineOriginTransform; //Field offset: 0x98
	[SerializeField]
	private float m_LineOriginOffset; //Field offset: 0xA0
	private float m_SquareSnapThresholdDistance; //Field offset: 0xA4
	private Vector3 m_ReticlePos; //Field offset: 0xA8
	private Vector3 m_ReticleNormal; //Field offset: 0xB4
	private int m_EndPositionInLine; //Field offset: 0xC0
	private bool m_SnapCurve; //Field offset: 0xC4
	private bool m_PerformSetup; //Field offset: 0xC5
	private GameObject m_ReticleToUse; //Field offset: 0xC8
	private LineRenderer m_LineRenderer; //Field offset: 0xD0
	private ILineRenderable m_LineRenderable; //Field offset: 0xD8
	private IAdvancedLineRenderable m_AdvancedLineRenderable; //Field offset: 0xE0
	private bool m_HasAdvancedLineRenderable; //Field offset: 0xE8
	private IXRSelectInteractor m_LineRenderableAsSelectInteractor; //Field offset: 0xF0
	private IXRHoverInteractor m_LineRenderableAsHoverInteractor; //Field offset: 0xF8
	private XRBaseInteractor m_LineRenderableAsBaseInteractor; //Field offset: 0x100
	private XRRayInteractor m_LineRenderableAsRayInteractor; //Field offset: 0x108
	private NativeArray<Vector3> m_TargetPoints; //Field offset: 0x110
	private int m_NumTargetPoints; //Field offset: 0x120
	private Vector3[] m_TargetPointsFallback; //Field offset: 0x128
	private NativeArray<Vector3> m_RenderPoints; //Field offset: 0x130
	private int m_NumRenderPoints; //Field offset: 0x140
	private NativeArray<Vector3> m_PreviousRenderPoints; //Field offset: 0x148
	private int m_NumPreviousRenderPoints; //Field offset: 0x158
	private readonly Vector3[] m_ClearArray; //Field offset: 0x160
	private GameObject m_CustomReticle; //Field offset: 0x168
	private bool m_CustomReticleAttached; //Field offset: 0x170
	private XRInteractableSnapVolume m_XRInteractableSnapVolume; //Field offset: 0x178
	private bool m_PreviousShouldBendLine; //Field offset: 0x180
	private Vector3 m_PreviousLineDirection; //Field offset: 0x184
	private Vector3 m_CurrentHitPoint; //Field offset: 0x190
	private bool m_HasHitInfo; //Field offset: 0x19C
	private bool m_ValidHit; //Field offset: 0x19D
	private float m_LastValidHitTime; //Field offset: 0x1A0
	private float m_LastValidLineLength; //Field offset: 0x1A4
	private Collider m_PreviousCollider; //Field offset: 0x1A8
	private XROrigin m_XROrigin; //Field offset: 0x1B0
	private bool m_HasRayInteractor; //Field offset: 0x1B8
	private bool m_HasBaseInteractor; //Field offset: 0x1B9
	private bool m_HasHoverInteractor; //Field offset: 0x1BA
	private bool m_HasSelectInteractor; //Field offset: 0x1BB
	private readonly BindableVariable<Single> m_UserScaleVar; //Field offset: 0x1C0
	private readonly FloatTweenableVariable m_LineLengthOverrideTweenableVariable; //Field offset: 0x1C8
	private readonly BindingsGroup m_BindingsGroup; //Field offset: 0x1D0

	public bool autoAdjustLineLength
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Gradient blockedColorGradient
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public GameObject blockedReticle
	{
		 get { } //Length: 8
		 set { } //Length: 128
	}

	public float followTightness
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Gradient invalidColorGradient
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float lineBendRatio
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public float lineLength
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float lineLengthChangeSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float lineOriginOffset
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Transform lineOriginTransform
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float lineRetractionDelay
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float lineWidth
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public float minLineLength
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool overrideInteractorLineLength
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool overrideInteractorLineOrigin
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public GameObject reticle
	{
		 get { } //Length: 8
		 set { } //Length: 128
	}

	public bool setLineColorGradient
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool smoothMovement
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool snapEndpointIfAvailable
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float snapThresholdDistance
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public bool stopLineAtFirstRaycastHit
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool stopLineAtSelection
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool treatSelectionAsValidState
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool useDistanceToHitAsMaxLineLength
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Gradient validColorGradient
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AnimationCurve widthCurve
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public XRInteractorLineVisual() { }

	[CompilerGenerated]
	private void <OnEnable>b__154_0(float userScale) { }

	private void AdjustLineAndReticle(bool hasSelection, bool bendLine, in Vector3 lineOrigin, in Vector3 targetEndPoint) { }

	private void AssignReticle(bool useBlockedVisuals) { }

	public override bool AttachCustomReticle(GameObject reticleInstance) { }

	protected void Awake() { }

	[BurstCompile]
	private static void CalculateLineCurveRenderPoints(int numTargetPoints, float curveRatio, in Vector3 lineOrigin, in Vector3 lineDirection, in Vector3 endPoint, ref NativeArray<Vector3>& targetPoints) { }

	[BurstCompile]
	public static void CalculateLineCurveRenderPoints$BurstManaged(int numTargetPoints, float curveRatio, in Vector3 lineOrigin, in Vector3 lineDirection, in Vector3 endPoint, ref NativeArray<Vector3>& targetPoints) { }

	private void ClearLineRenderer() { }

	private void ClearReticle() { }

	[BurstCompile]
	private static int ComputeNewRenderPoints(int numRenderPoints, int numTargetPoints, float targetLineLength, bool shouldSmoothPoints, bool shouldOverwritePoints, float pointSmoothIncrement, ref NativeArray<float3>& targetPoints, ref NativeArray<float3>& previousRenderPoints, ref NativeArray<float3>& renderPoints) { }

	[BurstCompile]
	public static int ComputeNewRenderPoints$BurstManaged(int numRenderPoints, int numTargetPoints, float targetLineLength, bool shouldSmoothPoints, bool shouldOverwritePoints, float pointSmoothIncrement, ref NativeArray<float3>& targetPoints, ref NativeArray<float3>& previousRenderPoints, ref NativeArray<float3>& renderPoints) { }

	private static bool EnsureSize(ref NativeArray<Vector3>& array, int targetSize) { }

	[BurstCompile]
	private static bool EvaluateLineEndPoint(float targetLineLength, bool shouldSmoothPoint, in float3 unsmoothedTargetPoint, in float3 lastRenderPoint, ref float3 newRenderPoint, ref float lineLength) { }

	[BurstCompile]
	public static bool EvaluateLineEndPoint$BurstManaged(float targetLineLength, bool shouldSmoothPoint, in float3 unsmoothedTargetPoint, in float3 lastRenderPoint, ref float3 newRenderPoint, ref float lineLength) { }

	private bool ExtractHitInformation(ref NativeArray<Vector3>& targetPoints, int numTargetPoints, out Vector3 targetEndPoint, out bool hitSnapVolume) { }

	private void FindClosestInteractableAttachPoint(in Vector3 lineOrigin, out Vector3 closestPoint) { }

	private void FindXROrigin() { }

	public bool get_autoAdjustLineLength() { }

	public Gradient get_blockedColorGradient() { }

	public GameObject get_blockedReticle() { }

	public float get_followTightness() { }

	public Gradient get_invalidColorGradient() { }

	public float get_lineBendRatio() { }

	public float get_lineLength() { }

	public float get_lineLengthChangeSpeed() { }

	public float get_lineOriginOffset() { }

	public Transform get_lineOriginTransform() { }

	public float get_lineRetractionDelay() { }

	public float get_lineWidth() { }

	public float get_minLineLength() { }

	public bool get_overrideInteractorLineLength() { }

	public bool get_overrideInteractorLineOrigin() { }

	public GameObject get_reticle() { }

	public bool get_setLineColorGradient() { }

	public bool get_smoothMovement() { }

	public bool get_snapEndpointIfAvailable() { }

	public float get_snapThresholdDistance() { }

	public bool get_stopLineAtFirstRaycastHit() { }

	public bool get_stopLineAtSelection() { }

	public bool get_treatSelectionAsValidState() { }

	public bool get_useDistanceToHitAsMaxLineLength() { }

	public Gradient get_validColorGradient() { }

	public AnimationCurve get_widthCurve() { }

	private void GetLineOriginAndDirection(ref NativeArray<Vector3>& targetPoints, int numTargetPoints, bool isLineStraight, out Vector3 lineOrigin, out Vector3 lineDirection) { }

	private bool GetLinePoints(ref NativeArray<Vector3>& linePoints, out int numPoints) { }

	protected void LateUpdate() { }

	[BeforeRenderOrder(101)]
	private void OnBeforeRenderLineVisual() { }

	protected void OnDestroy() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	protected void OnValidate() { }

	public override bool RemoveCustomReticle() { }

	protected void Reset() { }

	public void set_autoAdjustLineLength(bool value) { }

	public void set_blockedColorGradient(Gradient value) { }

	public void set_blockedReticle(GameObject value) { }

	public void set_followTightness(float value) { }

	public void set_invalidColorGradient(Gradient value) { }

	public void set_lineBendRatio(float value) { }

	public void set_lineLength(float value) { }

	public void set_lineLengthChangeSpeed(float value) { }

	public void set_lineOriginOffset(float value) { }

	public void set_lineOriginTransform(Transform value) { }

	public void set_lineRetractionDelay(float value) { }

	public void set_lineWidth(float value) { }

	public void set_minLineLength(float value) { }

	public void set_overrideInteractorLineLength(bool value) { }

	public void set_overrideInteractorLineOrigin(bool value) { }

	public void set_reticle(GameObject value) { }

	public void set_setLineColorGradient(bool value) { }

	public void set_smoothMovement(bool value) { }

	public void set_snapEndpointIfAvailable(bool value) { }

	public void set_snapThresholdDistance(float value) { }

	public void set_stopLineAtFirstRaycastHit(bool value) { }

	public void set_stopLineAtSelection(bool value) { }

	public void set_treatSelectionAsValidState(bool value) { }

	public void set_useDistanceToHitAsMaxLineLength(bool value) { }

	public void set_validColorGradient(Gradient value) { }

	public void set_widthCurve(AnimationCurve value) { }

	private void SetColorGradient(Gradient colorGradient) { }

	private void SetupBlockedReticle() { }

	private void SetupReticle() { }

	private bool TryFindLineRenderer() { }

	internal void UpdateLineVisual() { }

	private void UpdateSettings() { }

	private float UpdateTargetLineLength(in Vector3 lineOrigin, in Vector3 hitPoint, float minimumLineLength, float maximumLineLength, float lineRetractionDelaySeconds, float lineRetractionScalar, bool hasHit, bool deriveMaxLineLength) { }

}

