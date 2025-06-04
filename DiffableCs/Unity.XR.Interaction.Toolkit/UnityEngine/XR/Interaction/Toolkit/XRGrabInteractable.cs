namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Grab Interactable", 11)]
[BurstCompile]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable.html")]
[RequireComponent(typeof(Rigidbody))]
[SelectionBase]
public class XRGrabInteractable : XRBaseInteractable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal DropEventArgs <.cctor>b__285_0() { }

	}

	internal enum AttachPointCompatibilityMode
	{
		Default = 0,
		Legacy = 1,
	}

	public static class EaseAttachBurst_00000291$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static EaseAttachBurst_00000291$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, float attachEaseInTime, ref float currentAttachEaseTime) { }

	}

	internal sealed class EaseAttachBurst_00000291$PostfixBurstDelegate : MulticastDelegate
	{

		public EaseAttachBurst_00000291$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, float attachEaseInTime, ref float currentAttachEaseTime, AsyncCallback unnamed_param_7, object unnamed_param_8) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, float attachEaseInTime, ref float currentAttachEaseTime) { }

	}

	public static class StepSmoothingBurst_00000292$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static StepSmoothingBurst_00000292$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, bool smoothPos, float smoothPosAmount, float tightenPos, bool smoothRot, float smoothRotAmount, float tightenRot, bool smoothScale, float smoothScaleAmount, float tightenScale) { }

	}

	internal sealed class StepSmoothingBurst_00000292$PostfixBurstDelegate : MulticastDelegate
	{

		public StepSmoothingBurst_00000292$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, bool smoothPos, float smoothPosAmount, float tightenPos, bool smoothRot, float smoothRotAmount, float tightenRot, bool smoothScale, float smoothScaleAmount, float tightenScale, AsyncCallback unnamed_param_14, object unnamed_param_15) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, bool smoothPos, float smoothPosAmount, float tightenPos, bool smoothRot, float smoothRotAmount, float tightenRot, bool smoothScale, float smoothScaleAmount, float tightenScale) { }

	}

	private const float k_DefaultTighteningAmount = 0.1; //Field offset: 0x0
	private const float k_DefaultSmoothingAmount = 8; //Field offset: 0x0
	private const float k_LinearVelocityDamping = 1; //Field offset: 0x0
	private const float k_LinearVelocityScale = 1; //Field offset: 0x0
	private const float k_AngularVelocityDamping = 1; //Field offset: 0x0
	private const float k_AngularVelocityScale = 1; //Field offset: 0x0
	private const int k_ThrowSmoothingFrameCount = 20; //Field offset: 0x0
	private const float k_DefaultAttachEaseInTime = 0.15; //Field offset: 0x0
	private const float k_DefaultThrowSmoothingDuration = 0.25; //Field offset: 0x0
	private const float k_DefaultThrowLinearVelocityScale = 1.5; //Field offset: 0x0
	private const float k_DefaultThrowAngularVelocityScale = 1; //Field offset: 0x0
	private const float k_DeltaTimeThreshold = 0.001; //Field offset: 0x0
	private static readonly LinkedPool<DropEventArgs> s_DropEventArgs; //Field offset: 0x0
	private static readonly LinkedPool<Transform> s_DynamicAttachTransformPool; //Field offset: 0x8
	private static readonly ProfilerMarker s_ProcessGrabTransformersMarker; //Field offset: 0x10
	[SerializeField]
	private Transform m_AttachTransform; //Field offset: 0x1D0
	[SerializeField]
	private Transform m_SecondaryAttachTransform; //Field offset: 0x1D8
	[SerializeField]
	private bool m_UseDynamicAttach; //Field offset: 0x1E0
	[SerializeField]
	private bool m_MatchAttachPosition; //Field offset: 0x1E1
	[SerializeField]
	private bool m_MatchAttachRotation; //Field offset: 0x1E2
	[SerializeField]
	private bool m_SnapToColliderVolume; //Field offset: 0x1E3
	[SerializeField]
	private bool m_ReinitializeDynamicAttachEverySingleGrab; //Field offset: 0x1E4
	[SerializeField]
	private float m_AttachEaseInTime; //Field offset: 0x1E8
	[SerializeField]
	private MovementType m_MovementType; //Field offset: 0x1EC
	[Range(0, 1)]
	[SerializeField]
	private float m_VelocityDamping; //Field offset: 0x1F0
	[SerializeField]
	private float m_VelocityScale; //Field offset: 0x1F4
	[Range(0, 1)]
	[SerializeField]
	private float m_AngularVelocityDamping; //Field offset: 0x1F8
	[SerializeField]
	private float m_AngularVelocityScale; //Field offset: 0x1FC
	[SerializeField]
	private bool m_TrackPosition; //Field offset: 0x200
	[SerializeField]
	private bool m_SmoothPosition; //Field offset: 0x201
	[Range(0, 20)]
	[SerializeField]
	private float m_SmoothPositionAmount; //Field offset: 0x204
	[Range(0, 1)]
	[SerializeField]
	private float m_TightenPosition; //Field offset: 0x208
	[SerializeField]
	private bool m_TrackRotation; //Field offset: 0x20C
	[SerializeField]
	private bool m_SmoothRotation; //Field offset: 0x20D
	[Range(0, 20)]
	[SerializeField]
	private float m_SmoothRotationAmount; //Field offset: 0x210
	[Range(0, 1)]
	[SerializeField]
	private float m_TightenRotation; //Field offset: 0x214
	[SerializeField]
	private bool m_TrackScale; //Field offset: 0x218
	[SerializeField]
	private bool m_SmoothScale; //Field offset: 0x219
	[Range(0, 20)]
	[SerializeField]
	private float m_SmoothScaleAmount; //Field offset: 0x21C
	[Range(0, 1)]
	[SerializeField]
	private float m_TightenScale; //Field offset: 0x220
	[SerializeField]
	private bool m_ThrowOnDetach; //Field offset: 0x224
	[SerializeField]
	private float m_ThrowSmoothingDuration; //Field offset: 0x228
	[SerializeField]
	private AnimationCurve m_ThrowSmoothingCurve; //Field offset: 0x230
	[SerializeField]
	private float m_ThrowVelocityScale; //Field offset: 0x238
	[SerializeField]
	private float m_ThrowAngularVelocityScale; //Field offset: 0x23C
	[FormerlySerializedAs("m_GravityOnDetach")]
	[SerializeField]
	private bool m_ForceGravityOnDetach; //Field offset: 0x240
	[SerializeField]
	private bool m_RetainTransformParent; //Field offset: 0x241
	[SerializeField]
	private AttachPointCompatibilityMode m_AttachPointCompatibilityMode; //Field offset: 0x244
	[SerializeField]
	private List<XRBaseGrabTransformer> m_StartingSingleGrabTransformers; //Field offset: 0x248
	[SerializeField]
	private List<XRBaseGrabTransformer> m_StartingMultipleGrabTransformers; //Field offset: 0x250
	[SerializeField]
	private bool m_AddDefaultGrabTransformers; //Field offset: 0x258
	private readonly SmallRegistrationList<IXRGrabTransformer> m_SingleGrabTransformers; //Field offset: 0x260
	private readonly SmallRegistrationList<IXRGrabTransformer> m_MultipleGrabTransformers; //Field offset: 0x268
	private List<IXRGrabTransformer> m_GrabTransformersAddedWhenGrabbed; //Field offset: 0x270
	private bool m_GrabCountChanged; //Field offset: 0x278
	private ValueTuple<Int32, Int32> m_GrabCountBeforeAndAfterChange; //Field offset: 0x27C
	private bool m_IsProcessingGrabTransformers; //Field offset: 0x284
	private int m_DropTransformersCount; //Field offset: 0x288
	private Pose m_TargetPose; //Field offset: 0x28C
	private Vector3 m_TargetLocalScale; //Field offset: 0x2A8
	private bool m_IsTargetPoseDirty; //Field offset: 0x2B4
	private bool m_IsTargetLocalScaleDirty; //Field offset: 0x2B5
	private float m_CurrentAttachEaseTime; //Field offset: 0x2B8
	private MovementType m_CurrentMovementType; //Field offset: 0x2BC
	private bool m_DetachInLateUpdate; //Field offset: 0x2C0
	private Vector3 m_DetachLinearVelocity; //Field offset: 0x2C4
	private Vector3 m_DetachAngularVelocity; //Field offset: 0x2D0
	private int m_ThrowSmoothingCurrentFrame; //Field offset: 0x2DC
	private readonly Single[] m_ThrowSmoothingFrameTimes; //Field offset: 0x2E0
	private readonly Vector3[] m_ThrowSmoothingLinearVelocityFrames; //Field offset: 0x2E8
	private readonly Vector3[] m_ThrowSmoothingAngularVelocityFrames; //Field offset: 0x2F0
	private bool m_ThrowSmoothingFirstUpdate; //Field offset: 0x2F8
	private Pose m_LastThrowReferencePose; //Field offset: 0x2FC
	private IXRAimAssist m_ThrowAssist; //Field offset: 0x318
	private Rigidbody m_Rigidbody; //Field offset: 0x320
	private bool m_WasKinematic; //Field offset: 0x328
	private bool m_UsedGravity; //Field offset: 0x329
	private float m_OldLinearDamping; //Field offset: 0x32C
	private float m_OldAngularDamping; //Field offset: 0x330
	private bool m_IgnoringCharacterCollision; //Field offset: 0x334
	private bool m_StopIgnoringCollisionInLateUpdate; //Field offset: 0x335
	private CharacterController m_SelectingCharacterController; //Field offset: 0x338
	private readonly HashSet<IXRSelectInteractor> m_SelectingCharacterInteractors; //Field offset: 0x340
	private readonly List<Collider> m_RigidbodyColliders; //Field offset: 0x348
	private readonly HashSet<Collider> m_CollidersThatAllowedCharacterCollision; //Field offset: 0x350
	private Transform m_OriginalSceneParent; //Field offset: 0x358
	private TeleportationMonitor m_TeleportationMonitor; //Field offset: 0x360
	private readonly Dictionary<IXRSelectInteractor, Transform> m_DynamicAttachTransforms; //Field offset: 0x368

	public bool addDefaultGrabTransformers
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float angularVelocityDamping
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float angularVelocityScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float attachEaseInTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AttachPointCompatibilityMode attachPointCompatibilityMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Transform attachTransform
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool forceGravityOnDetach
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("gravityOnDetach has been deprecated. Use forceGravityOnDetach instead. (UnityUpgradable) -> forceGravityOnDetach")]
	public bool gravityOnDetach
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	private bool isTransformDirty
	{
		private get { } //Length: 32
		private set { } //Length: 16
	}

	public bool matchAttachPosition
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool matchAttachRotation
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public MovementType movementType
	{
		 get { } //Length: 8
		 set { } //Length: 88
	}

	public int multipleGrabTransformersCount
	{
		 get { } //Length: 80
	}

	public bool reinitializeDynamicAttachEverySingleGrab
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool retainTransformParent
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Transform secondaryAttachTransform
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int singleGrabTransformersCount
	{
		 get { } //Length: 80
	}

	public bool smoothPosition
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float smoothPositionAmount
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool smoothRotation
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float smoothRotationAmount
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool smoothScale
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float smoothScaleAmount
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool snapToColliderVolume
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public List<XRBaseGrabTransformer> startingMultipleGrabTransformers
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<XRBaseGrabTransformer> startingSingleGrabTransformers
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float throwAngularVelocityScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool throwOnDetach
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public AnimationCurve throwSmoothingCurve
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float throwSmoothingDuration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float throwVelocityScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float tightenPosition
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float tightenRotation
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float tightenScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool trackPosition
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool trackRotation
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool trackScale
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool useDynamicAttach
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float velocityDamping
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float velocityScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static XRGrabInteractable() { }

	public XRGrabInteractable() { }

	private void AddDefaultGrabTransformers() { }

	protected override void AddDefaultMultipleGrabTransformer() { }

	protected override void AddDefaultSingleGrabTransformer() { }

	private void AddGrabTransformer(IXRGrabTransformer transformer, BaseRegistrationList<IXRGrabTransformer> grabTransformers) { }

	public void AddMultipleGrabTransformer(IXRGrabTransformer transformer) { }

	public void AddSingleGrabTransformer(IXRGrabTransformer transformer) { }

	private void ApplyTargetScale() { }

	protected virtual void Awake() { }

	private bool CanProcessAnySingleGrabTransformer() { }

	private void ClearGrabTransformers(BaseRegistrationList<IXRGrabTransformer> grabTransformers) { }

	public void ClearMultipleGrabTransformers() { }

	public void ClearSingleGrabTransformers() { }

	private Transform CreateDynamicAttachTransform(IXRSelectInteractor interactor) { }

	protected override void Detach() { }

	protected override void Drop() { }

	[BurstCompile]
	private static void EaseAttachBurst(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, float attachEaseInTime, ref float currentAttachEaseTime) { }

	[BurstCompile]
	public static void EaseAttachBurst$BurstManaged(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, float attachEaseInTime, ref float currentAttachEaseTime) { }

	private void EndThrowSmoothing() { }

	private void FlushRegistration() { }

	public bool get_addDefaultGrabTransformers() { }

	public float get_angularVelocityDamping() { }

	public float get_angularVelocityScale() { }

	public float get_attachEaseInTime() { }

	public AttachPointCompatibilityMode get_attachPointCompatibilityMode() { }

	public Transform get_attachTransform() { }

	public bool get_forceGravityOnDetach() { }

	public bool get_gravityOnDetach() { }

	private bool get_isTransformDirty() { }

	public bool get_matchAttachPosition() { }

	public bool get_matchAttachRotation() { }

	public MovementType get_movementType() { }

	public int get_multipleGrabTransformersCount() { }

	public bool get_reinitializeDynamicAttachEverySingleGrab() { }

	public bool get_retainTransformParent() { }

	public Transform get_secondaryAttachTransform() { }

	public int get_singleGrabTransformersCount() { }

	public bool get_smoothPosition() { }

	public float get_smoothPositionAmount() { }

	public bool get_smoothRotation() { }

	public float get_smoothRotationAmount() { }

	public bool get_smoothScale() { }

	public float get_smoothScaleAmount() { }

	public bool get_snapToColliderVolume() { }

	public List<XRBaseGrabTransformer> get_startingMultipleGrabTransformers() { }

	public List<XRBaseGrabTransformer> get_startingSingleGrabTransformers() { }

	public float get_throwAngularVelocityScale() { }

	public bool get_throwOnDetach() { }

	public AnimationCurve get_throwSmoothingCurve() { }

	public float get_throwSmoothingDuration() { }

	public float get_throwVelocityScale() { }

	public float get_tightenPosition() { }

	public float get_tightenRotation() { }

	public float get_tightenScale() { }

	public bool get_trackPosition() { }

	public bool get_trackRotation() { }

	public bool get_trackScale() { }

	public bool get_useDynamicAttach() { }

	public float get_velocityDamping() { }

	public float get_velocityScale() { }

	public virtual Transform GetAttachTransform(IXRInteractor interactor) { }

	private static void GetGrabTransformers(BaseRegistrationList<IXRGrabTransformer> grabTransformers, List<IXRGrabTransformer> results) { }

	public IXRGrabTransformer GetMultipleGrabTransformerAt(int index) { }

	public void GetMultipleGrabTransformers(List<IXRGrabTransformer> results) { }

	private T GetOrAddComponent() { }

	private IXRGrabTransformer GetOrAddDefaultGrabTransformer() { }

	public IXRGrabTransformer GetSingleGrabTransformerAt(int index) { }

	public void GetSingleGrabTransformers(List<IXRGrabTransformer> results) { }

	private Vector3 GetSmoothedVelocityValue(Vector3[] velocityFrames) { }

	public Vector3 GetTargetLocalScale() { }

	public Pose GetTargetPose() { }

	protected override void Grab() { }

	protected override void InitializeDynamicAttachPose(IXRSelectInteractor interactor, Transform dynamicAttachTransform) { }

	private void InitializeDynamicAttachPoseInternal(IXRSelectInteractor interactor, Transform dynamicAttachTransform) { }

	private void InitializeDynamicAttachPoseWithStatic(IXRSelectInteractor interactor, Transform dynamicAttachTransform) { }

	private void InitializeTargetPoseAndScale(Transform thisTransform) { }

	private void InvokeGrabTransformersOnDrop(DropEventArgs args) { }

	private void InvokeGrabTransformersOnGrab() { }

	private void InvokeGrabTransformersProcess(UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale) { }

	private bool IsOutsideCharacterCollider(Collider characterCollider) { }

	private void MoveGrabTransformerTo(IXRGrabTransformer transformer, int newIndex, BaseRegistrationList<IXRGrabTransformer> grabTransformers) { }

	public void MoveMultipleGrabTransformerTo(IXRGrabTransformer transformer, int newIndex) { }

	public void MoveSingleGrabTransformerTo(IXRGrabTransformer transformer, int newIndex) { }

	private void OnAddedGrabTransformer(IXRGrabTransformer transformer) { }

	private static Transform OnCreatePooledItem() { }

	protected virtual void OnDestroy() { }

	private static void OnDestroyPooledItem(Transform item) { }

	private static void OnGetPooledItem(Transform item) { }

	private static void OnReleasePooledItem(Transform item) { }

	private void OnRemovedGrabTransformer(IXRGrabTransformer transformer) { }

	protected virtual void OnSelectEntering(SelectEnterEventArgs args) { }

	protected virtual void OnSelectExited(SelectExitEventArgs args) { }

	protected virtual void OnSelectExiting(SelectExitEventArgs args) { }

	private void OnTeleported(Pose offset) { }

	private void PerformInstantaneousUpdate(UpdatePhase updatePhase) { }

	private void PerformKinematicUpdate(UpdatePhase updatePhase) { }

	private void PerformVelocityTrackingUpdate(UpdatePhase updatePhase, float deltaTime) { }

	public virtual void ProcessInteractable(UpdatePhase updatePhase) { }

	private void ReleaseDynamicAttachTransform(IXRSelectInteractor interactor) { }

	private bool RemoveGrabTransformer(IXRGrabTransformer transformer, BaseRegistrationList<IXRGrabTransformer> grabTransformers) { }

	public bool RemoveMultipleGrabTransformer(IXRGrabTransformer transformer) { }

	public bool RemoveSingleGrabTransformer(IXRGrabTransformer transformer) { }

	private void ResetThrowSmoothing() { }

	public void set_addDefaultGrabTransformers(bool value) { }

	public void set_angularVelocityDamping(float value) { }

	public void set_angularVelocityScale(float value) { }

	public void set_attachEaseInTime(float value) { }

	public void set_attachPointCompatibilityMode(AttachPointCompatibilityMode value) { }

	public void set_attachTransform(Transform value) { }

	public void set_forceGravityOnDetach(bool value) { }

	public void set_gravityOnDetach(bool value) { }

	private void set_isTransformDirty(bool value) { }

	public void set_matchAttachPosition(bool value) { }

	public void set_matchAttachRotation(bool value) { }

	public void set_movementType(MovementType value) { }

	public void set_reinitializeDynamicAttachEverySingleGrab(bool value) { }

	public void set_retainTransformParent(bool value) { }

	public void set_secondaryAttachTransform(Transform value) { }

	public void set_smoothPosition(bool value) { }

	public void set_smoothPositionAmount(float value) { }

	public void set_smoothRotation(bool value) { }

	public void set_smoothRotationAmount(float value) { }

	public void set_smoothScale(bool value) { }

	public void set_smoothScaleAmount(float value) { }

	public void set_snapToColliderVolume(bool value) { }

	public void set_startingMultipleGrabTransformers(List<XRBaseGrabTransformer> value) { }

	public void set_startingSingleGrabTransformers(List<XRBaseGrabTransformer> value) { }

	public void set_throwAngularVelocityScale(float value) { }

	public void set_throwOnDetach(bool value) { }

	public void set_throwSmoothingCurve(AnimationCurve value) { }

	public void set_throwSmoothingDuration(float value) { }

	public void set_throwVelocityScale(float value) { }

	public void set_tightenPosition(float value) { }

	public void set_tightenRotation(float value) { }

	public void set_tightenScale(float value) { }

	public void set_trackPosition(bool value) { }

	public void set_trackRotation(bool value) { }

	public void set_trackScale(bool value) { }

	public void set_useDynamicAttach(bool value) { }

	public void set_velocityDamping(float value) { }

	public void set_velocityScale(float value) { }

	public void SetTargetLocalScale(Vector3 localScale) { }

	public void SetTargetPose(Pose pose) { }

	protected override void SetupRigidbodyDrop(Rigidbody rigidbody) { }

	protected override void SetupRigidbodyGrab(Rigidbody rigidbody) { }

	protected override bool ShouldMatchAttachPosition(IXRSelectInteractor interactor) { }

	protected override bool ShouldMatchAttachRotation(IXRSelectInteractor interactor) { }

	protected override bool ShouldSnapToColliderVolume(IXRSelectInteractor interactor) { }

	private void StartIgnoringCharacterCollision(Collider characterCollider) { }

	private void StepSmoothing(in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime) { }

	[BurstCompile]
	private static void StepSmoothingBurst(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, bool smoothPos, float smoothPosAmount, float tightenPos, bool smoothRot, float smoothRotAmount, float tightenRot, bool smoothScale, float smoothScaleAmount, float tightenScale) { }

	[BurstCompile]
	public static void StepSmoothingBurst$BurstManaged(ref Pose targetPose, ref Vector3 targetLocalScale, in Pose rawTargetPose, in Vector3 rawTargetLocalScale, float deltaTime, bool smoothPos, float smoothPosAmount, float tightenPos, bool smoothRot, float smoothRotAmount, float tightenRot, bool smoothScale, float smoothScaleAmount, float tightenScale) { }

	private void StepThrowSmoothing(Pose targetPose, float deltaTime) { }

	private void StopIgnoringCharacterCollision(Collider characterCollider) { }

	private void SubscribeTeleportationProvider(IXRInteractor interactor) { }

	private void UnsubscribeTeleportationProvider(IXRInteractor interactor) { }

	private void UpdateCurrentMovementType() { }

	private void UpdateTarget(UpdatePhase updatePhase, float deltaTime) { }

}

