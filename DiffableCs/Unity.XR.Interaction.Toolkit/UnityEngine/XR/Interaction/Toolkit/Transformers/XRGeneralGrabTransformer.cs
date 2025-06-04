namespace UnityEngine.XR.Interaction.Toolkit.Transformers;

[AddComponentMenu("XR/Transformers/XR General Grab Transformer", 11)]
[BurstCompile]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer.html")]
public class XRGeneralGrabTransformer : XRBaseGrabTransformer
{
	public static class AdjustPositionForPermittedAxesBurst_00000BFB$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static AdjustPositionForPermittedAxesBurst_00000BFB$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 targetPosition, in Pose originalObjectPose, ConstrainedAxisDisplacementMode axisDisplacementMode, bool hasX, bool hasY, bool hasZ, out Vector3 adjustedTargetPosition) { }

	}

	internal sealed class AdjustPositionForPermittedAxesBurst_00000BFB$PostfixBurstDelegate : MulticastDelegate
	{

		public AdjustPositionForPermittedAxesBurst_00000BFB$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 targetPosition, in Pose originalObjectPose, ConstrainedAxisDisplacementMode axisDisplacementMode, bool hasX, bool hasY, bool hasZ, out Vector3 adjustedTargetPosition, AsyncCallback unnamed_param_7, object unnamed_param_8) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 targetPosition, in Pose originalObjectPose, ConstrainedAxisDisplacementMode axisDisplacementMode, bool hasX, bool hasY, bool hasZ, out Vector3 adjustedTargetPosition) { }

	}

	public static class ComputeNewObjectPosition_00000BF7$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ComputeNewObjectPosition_00000BF7$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 interactorPosition, in quaternion interactorRotation, in quaternion objectRotation, in float3 objectScale, bool trackRotation, in float3 offsetPosition, in float3 objectLocalGrabPoint, in float3 interactorLocalGrabPoint, out Vector3 newPosition) { }

	}

	internal sealed class ComputeNewObjectPosition_00000BF7$PostfixBurstDelegate : MulticastDelegate
	{

		public ComputeNewObjectPosition_00000BF7$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 interactorPosition, in quaternion interactorRotation, in quaternion objectRotation, in float3 objectScale, bool trackRotation, in float3 offsetPosition, in float3 objectLocalGrabPoint, in float3 interactorLocalGrabPoint, out Vector3 newPosition, AsyncCallback unnamed_param_9, object unnamed_param_10) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 interactorPosition, in quaternion interactorRotation, in quaternion objectRotation, in float3 objectScale, bool trackRotation, in float3 offsetPosition, in float3 objectLocalGrabPoint, in float3 interactorLocalGrabPoint, out Vector3 newPosition) { }

	}

	public static class ComputeNewOneHandedScale_00000BFD$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ComputeNewOneHandedScale_00000BFD$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 currentScale, in Vector3 initialScaleProportions, bool clampScale, in Vector3 minScale, in Vector3 maxScale, float scaleDelta, float deltaTime, float scaleSpeed, out Vector3 newScale) { }

	}

	internal sealed class ComputeNewOneHandedScale_00000BFD$PostfixBurstDelegate : MulticastDelegate
	{

		public ComputeNewOneHandedScale_00000BFD$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 currentScale, in Vector3 initialScaleProportions, bool clampScale, in Vector3 minScale, in Vector3 maxScale, float scaleDelta, float deltaTime, float scaleSpeed, out Vector3 newScale, AsyncCallback unnamed_param_9, object unnamed_param_10) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 currentScale, in Vector3 initialScaleProportions, bool clampScale, in Vector3 minScale, in Vector3 maxScale, float scaleDelta, float deltaTime, float scaleSpeed, out Vector3 newScale) { }

	}

	public static class ComputeNewTwoHandedScale_00000BFE$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ComputeNewTwoHandedScale_00000BFE$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool clampScale, float scaleMultiplier, float thresholdMoveRatioForScale, in Vector3 minScale, in Vector3 maxScale, out Vector3 newScale) { }

	}

	internal sealed class ComputeNewTwoHandedScale_00000BFE$PostfixBurstDelegate : MulticastDelegate
	{

		public ComputeNewTwoHandedScale_00000BFE$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool clampScale, float scaleMultiplier, float thresholdMoveRatioForScale, in Vector3 minScale, in Vector3 maxScale, out Vector3 newScale, AsyncCallback unnamed_param_10, object unnamed_param_11) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool clampScale, float scaleMultiplier, float thresholdMoveRatioForScale, in Vector3 minScale, in Vector3 maxScale, out Vector3 newScale) { }

	}

	internal enum ConstrainedAxisDisplacementMode
	{
		ObjectRelative = 0,
		ObjectRelativeWithLockedWorldUp = 1,
		WorldAxisRelative = 2,
	}

	[Flags]
	internal enum ManipulationAxes
	{
		X = 1,
		Y = 2,
		Z = 4,
		All = 7,
	}

	internal enum TwoHandedRotationMode
	{
		FirstHandOnly = 0,
		FirstHandDirectedTowardsSecondHand = 1,
		TwoHandedAverage = 2,
	}

	[Header("Translation Constraints")]
	[SerializeField]
	[Tooltip("Permitted axes for translation displacement relative to the object's initial rotation.")]
	private ManipulationAxes m_PermittedDisplacementAxes; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Determines how the constrained axis displacement mode is computed.")]
	private ConstrainedAxisDisplacementMode m_ConstrainedAxisDisplacementMode; //Field offset: 0x24
	[Header("Rotation Constraints")]
	[SerializeField]
	[Tooltip("Determines how rotation is calculated when using two hands for the grab interaction.")]
	private TwoHandedRotationMode m_TwoHandedRotationMode; //Field offset: 0x28
	[Header("Scaling Constraints")]
	[SerializeField]
	[Tooltip("Allow one handed scaling using the scale value provider if available.")]
	private bool m_AllowOneHandedScaling; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("Allow scaling when using multi-grab interaction.")]
	private bool m_AllowTwoHandedScaling; //Field offset: 0x2D
	[Range(0, 32)]
	[SerializeField]
	[Tooltip("Scaling speed over time for one handed scaling based on the scale value provider.")]
	private float m_OneHandedScaleSpeed; //Field offset: 0x30
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("(Two Handed Scaling) Percentage as a measure of 0 to 1 of scaled relative hand displacement required to trigger scale operation.\nIf this value is 0f, scaling happens the moment both grab interactors move closer or further away from each other.\nOtherwise, this percentage is used as a threshold before any scaling happens.")]
	private float m_ThresholdMoveRatioForScale; //Field offset: 0x34
	[SerializeField]
	[Space]
	[Tooltip("If enabled, scaling will abide by ratio ranges defined below.")]
	private bool m_ClampScaling; //Field offset: 0x38
	[Range(0.01, 1)]
	[SerializeField]
	[Tooltip("Minimum scale multiplier applied to the initial scale captured on start.")]
	private float m_MinimumScaleRatio; //Field offset: 0x3C
	[Range(1, 10)]
	[SerializeField]
	[Tooltip("Maximum scale multiplier applied to the initial scale captured on start.")]
	private float m_MaximumScaleRatio; //Field offset: 0x40
	[Range(0.1, 5)]
	[SerializeField]
	[Space]
	[Tooltip("Scales the distance of displacement between interactors needed to modify the scale interactable.")]
	private float m_ScaleMultiplier; //Field offset: 0x44
	private Pose m_OriginalObjectPose; //Field offset: 0x48
	private Pose m_OffsetPose; //Field offset: 0x64
	private Pose m_OriginalInteractorPose; //Field offset: 0x80
	private Vector3 m_InteractorLocalGrabPoint; //Field offset: 0x9C
	private Vector3 m_ObjectLocalGrabPoint; //Field offset: 0xA8
	private IXRInteractor m_OriginalInteractor; //Field offset: 0xB8
	private int m_LastGrabCount; //Field offset: 0xC0
	private Vector3 m_StartHandleBar; //Field offset: 0xC4
	private Vector3 m_StartHandleBarNormalized; //Field offset: 0xD0
	private Quaternion m_StartHandleBarLookRotation; //Field offset: 0xDC
	private Quaternion m_InverseStartHandleBarLookRotation; //Field offset: 0xEC
	private Quaternion m_LastHandleBarLocalRotation; //Field offset: 0xFC
	private Vector3 m_ScaleAtGrabStart; //Field offset: 0x10C
	private bool m_FirstFrameSinceTwoHandedGrab; //Field offset: 0x118
	private Vector3 m_LastTwoHandedUp; //Field offset: 0x11C
	private Vector3 m_InitialScale; //Field offset: 0x128
	private Vector3 m_InitialScaleProportions; //Field offset: 0x134
	private Vector3 m_MinimumScale; //Field offset: 0x140
	private Vector3 m_MaximumScale; //Field offset: 0x14C
	private ConstrainedAxisDisplacementMode m_ConstrainedAxisDisplacementModeOnGrab; //Field offset: 0x158
	private ManipulationAxes m_PermittedDisplacementAxesOnGrab; //Field offset: 0x15C
	private IXRScaleValueProvider m_ScaleValueProvider; //Field offset: 0x160
	private bool m_HasScaleValueProvider; //Field offset: 0x168

	public bool allowOneHandedScaling
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public TwoHandedRotationMode allowTwoHandedRotation
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool allowTwoHandedScaling
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool clampScaling
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public ConstrainedAxisDisplacementMode constrainedAxisDisplacementMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float maximumScaleRatio
	{
		 get { } //Length: 8
		 set { } //Length: 44
	}

	public float minimumScaleRatio
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public float oneHandedScaleSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public ManipulationAxes permittedDisplacementAxes
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected virtual RegistrationMode registrationMode
	{
		 get { } //Length: 8
	}

	public float scaleMultiplier
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float thresholdMoveRatioForScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRGeneralGrabTransformer() { }

	private static Vector3 AdjustPositionForPermittedAxes(in Vector3 targetPosition, in Pose originalObjectPose, ManipulationAxes permittedAxes, ConstrainedAxisDisplacementMode axisDisplacementMode) { }

	[BurstCompile]
	private static void AdjustPositionForPermittedAxesBurst(in Vector3 targetPosition, in Pose originalObjectPose, ConstrainedAxisDisplacementMode axisDisplacementMode, bool hasX, bool hasY, bool hasZ, out Vector3 adjustedTargetPosition) { }

	[BurstCompile]
	public static void AdjustPositionForPermittedAxesBurst$BurstManaged(in Vector3 targetPosition, in Pose originalObjectPose, ConstrainedAxisDisplacementMode axisDisplacementMode, bool hasX, bool hasY, bool hasZ, out Vector3 adjustedTargetPosition) { }

	protected void Awake() { }

	private void ComputeAdjustedInteractorPose(XRGrabInteractable grabInteractable, out Vector3 newHandleBar, out Vector3 adjustedInteractorPosition, out Quaternion adjustedInteractorRotation) { }

	[BurstCompile]
	private static void ComputeNewObjectPosition(in float3 interactorPosition, in quaternion interactorRotation, in quaternion objectRotation, in float3 objectScale, bool trackRotation, in float3 offsetPosition, in float3 objectLocalGrabPoint, in float3 interactorLocalGrabPoint, out Vector3 newPosition) { }

	[BurstCompile]
	public static void ComputeNewObjectPosition$BurstManaged(in float3 interactorPosition, in quaternion interactorRotation, in quaternion objectRotation, in float3 objectScale, bool trackRotation, in float3 offsetPosition, in float3 objectLocalGrabPoint, in float3 interactorLocalGrabPoint, out Vector3 newPosition) { }

	private Quaternion ComputeNewObjectRotation(in Quaternion interactorRotation, bool trackRotation) { }

	[BurstCompile]
	private static void ComputeNewOneHandedScale(in Vector3 currentScale, in Vector3 initialScaleProportions, bool clampScale, in Vector3 minScale, in Vector3 maxScale, float scaleDelta, float deltaTime, float scaleSpeed, out Vector3 newScale) { }

	[BurstCompile]
	public static void ComputeNewOneHandedScale$BurstManaged(in Vector3 currentScale, in Vector3 initialScaleProportions, bool clampScale, in Vector3 minScale, in Vector3 maxScale, float scaleDelta, float deltaTime, float scaleSpeed, out Vector3 newScale) { }

	private Vector3 ComputeNewScale(in XRGrabInteractable grabInteractable, in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool trackScale) { }

	[BurstCompile]
	private static void ComputeNewTwoHandedScale(in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool clampScale, float scaleMultiplier, float thresholdMoveRatioForScale, in Vector3 minScale, in Vector3 maxScale, out Vector3 newScale) { }

	[BurstCompile]
	public static void ComputeNewTwoHandedScale$BurstManaged(in Vector3 startScale, in Vector3 currentScale, in Vector3 startHandleBar, in Vector3 newHandleBar, bool clampScale, float scaleMultiplier, float thresholdMoveRatioForScale, in Vector3 minScale, in Vector3 maxScale, out Vector3 newScale) { }

	public bool get_allowOneHandedScaling() { }

	public TwoHandedRotationMode get_allowTwoHandedRotation() { }

	public bool get_allowTwoHandedScaling() { }

	public bool get_clampScaling() { }

	public ConstrainedAxisDisplacementMode get_constrainedAxisDisplacementMode() { }

	public float get_maximumScaleRatio() { }

	public float get_minimumScaleRatio() { }

	public float get_oneHandedScaleSpeed() { }

	public ManipulationAxes get_permittedDisplacementAxes() { }

	protected virtual RegistrationMode get_registrationMode() { }

	public float get_scaleMultiplier() { }

	public float get_thresholdMoveRatioForScale() { }

	public virtual void OnGrab(XRGrabInteractable grabInteractable) { }

	public virtual void OnGrabCountChanged(XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale) { }

	public virtual void Process(XRGrabInteractable grabInteractable, UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale) { }

	private static float3 Scale(float3 a, float3 b) { }

	public void set_allowOneHandedScaling(bool value) { }

	public void set_allowTwoHandedRotation(TwoHandedRotationMode value) { }

	public void set_allowTwoHandedScaling(bool value) { }

	public void set_clampScaling(bool value) { }

	public void set_constrainedAxisDisplacementMode(ConstrainedAxisDisplacementMode value) { }

	public void set_maximumScaleRatio(float value) { }

	public void set_minimumScaleRatio(float value) { }

	public void set_oneHandedScaleSpeed(float value) { }

	public void set_permittedDisplacementAxes(ManipulationAxes value) { }

	public void set_scaleMultiplier(float value) { }

	public void set_thresholdMoveRatioForScale(float value) { }

	private void TranslateSetup(Pose interactorCentroidPose, Vector3 grabCentroid, Pose objectPose, Vector3 objectScale) { }

	private void UpdateTarget(XRGrabInteractable grabInteractable, ref Pose targetPose, ref Vector3 localScale) { }

}

