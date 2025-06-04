namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Gaze Assistance", 11)]
[BurstCompile]
[DefaultExecutionOrder(-29980)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRGazeAssistance.html")]
public class XRGazeAssistance : MonoBehaviour, IXRAimAssist
{
	public static class GetAssistedVelocityInternal_00000691$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static GetAssistedVelocityInternal_00000691$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 source, in Vector3 target, in Vector3 velocity, float gravity, float maxAngle, float requiredSpeed, float maxSpeedPercent, float assistPercent, float epsilon, out Vector3 adjustedVelocity) { }

	}

	internal sealed class GetAssistedVelocityInternal_00000691$PostfixBurstDelegate : MulticastDelegate
	{

		public GetAssistedVelocityInternal_00000691$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 source, in Vector3 target, in Vector3 velocity, float gravity, float maxAngle, float requiredSpeed, float maxSpeedPercent, float assistPercent, float epsilon, out Vector3 adjustedVelocity, AsyncCallback unnamed_param_10, object unnamed_param_11) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 source, in Vector3 target, in Vector3 velocity, float gravity, float maxAngle, float requiredSpeed, float maxSpeedPercent, float assistPercent, float epsilon, out Vector3 adjustedVelocity) { }

	}

	internal sealed class InteractorData
	{
		[RequireInterface(typeof(IXRRayProvider))]
		[SerializeField]
		[Tooltip("The interactor that can fall back to gaze data.")]
		private object m_Interactor; //Field offset: 0x10
		[SerializeField]
		[Tooltip("Changes mediation behavior to account for teleportation controls.")]
		private bool m_TeleportRay; //Field offset: 0x18
		[CompilerGenerated]
		private bool <fallback>k__BackingField; //Field offset: 0x19
		private bool m_Initialized; //Field offset: 0x1A
		private IXRRayProvider m_RayProvider; //Field offset: 0x20
		private IXRSelectInteractor m_SelectInteractor; //Field offset: 0x28
		private bool m_RestoreVisuals; //Field offset: 0x30
		private XRInteractorLineVisual m_LineVisual; //Field offset: 0x38
		private bool m_HasLineVisual; //Field offset: 0x40
		private Transform m_OriginalRayOrigin; //Field offset: 0x48
		private Transform m_OriginalAttach; //Field offset: 0x50
		private Transform m_OriginalVisualLineOrigin; //Field offset: 0x58
		private bool m_OriginalOverrideVisualLineOrigin; //Field offset: 0x60
		private Transform m_FallbackRayOrigin; //Field offset: 0x68
		private Transform m_FallbackAttach; //Field offset: 0x70
		private Transform m_FallbackVisualLineOrigin; //Field offset: 0x78

		public private bool fallback
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public object interactor
		{
			 get { } //Length: 8
			 set { } //Length: 8
		}

		public bool teleportRay
		{
			 get { } //Length: 8
			 set { } //Length: 12
		}

		public InteractorData() { }

		[CompilerGenerated]
		public bool get_fallback() { }

		public object get_interactor() { }

		public bool get_teleportRay() { }

		internal void Initialize() { }

		internal void RestoreVisuals() { }

		[CompilerGenerated]
		private void set_fallback(bool value) { }

		public void set_interactor(object value) { }

		public void set_teleportRay(bool value) { }

		internal void UpdateFallbackRayOrigin(Transform gazeTransform) { }

		internal bool UpdateFallbackState(Transform gazeTransform, float fallbackDivergence, bool selectionLocked) { }

		internal void UpdateLineVisualOrigin() { }

	}

	private const float k_MinAttachDistance = 0.5; //Field offset: 0x0
	private const float k_MinFallbackDivergence = 0; //Field offset: 0x0
	private const float k_MaxFallbackDivergence = 90; //Field offset: 0x0
	private const float k_MinAimAssistRequiredAngle = 0; //Field offset: 0x0
	private const float k_MaxAimAssistRequiredAngle = 90; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Eye data source used as fallback data and to determine if fallback data should be used.")]
	private XRGazeInteractor m_GazeInteractor; //Field offset: 0x20
	[Range(0, 90)]
	[SerializeField]
	[Tooltip("How far an interactor must point away from the user's view area before eye gaze will be used instead.")]
	private float m_FallbackDivergence; //Field offset: 0x28
	[SerializeField]
	[Tooltip("If the eye reticle should be hidden when all interactors are using their original data.")]
	private bool m_HideCursorWithNoActiveRays; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("Interactors that can fall back to gaze data.")]
	private List<InteractorData> m_RayInteractors; //Field offset: 0x30
	[Range(0, 90)]
	[SerializeField]
	[Tooltip("How far projectiles can aim outside of eye gaze and still be considered for aim assist.")]
	private float m_AimAssistRequiredAngle; //Field offset: 0x38
	[SerializeField]
	[Tooltip("How fast a projectile must be moving to be considered for aim assist.")]
	private float m_AimAssistRequiredSpeed; //Field offset: 0x3C
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("How much of the corrected aim velocity to use, as a percentage.")]
	private float m_AimAssistPercent; //Field offset: 0x40
	[SerializeField]
	[Tooltip("How much additional speed a projectile can receive from aim assistance, as a percentage.")]
	private float m_AimAssistMaxSpeedPercent; //Field offset: 0x44
	private InteractorData m_SelectingInteractorData; //Field offset: 0x48
	private XRInteractorReticleVisual m_GazeReticleVisual; //Field offset: 0x50
	private bool m_HasGazeReticleVisual; //Field offset: 0x58

	public float aimAssistMaxSpeedPercent
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float aimAssistPercent
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float aimAssistRequiredAngle
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public float aimAssistRequiredSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float fallbackDivergence
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public XRGazeInteractor gazeInteractor
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool hideCursorWithNoActiveRays
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public List<InteractorData> rayInteractors
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRGazeAssistance() { }

	public float get_aimAssistMaxSpeedPercent() { }

	public float get_aimAssistPercent() { }

	public float get_aimAssistRequiredAngle() { }

	public float get_aimAssistRequiredSpeed() { }

	public float get_fallbackDivergence() { }

	public XRGazeInteractor get_gazeInteractor() { }

	public bool get_hideCursorWithNoActiveRays() { }

	public List<InteractorData> get_rayInteractors() { }

	public Vector3 GetAssistedVelocity(in Vector3 source, in Vector3 velocity, float gravity, float maxAngle) { }

	public Vector3 GetAssistedVelocity(in Vector3 source, in Vector3 velocity, float gravity) { }

	[BurstCompile]
	private static void GetAssistedVelocityInternal(in Vector3 source, in Vector3 target, in Vector3 velocity, float gravity, float maxAngle, float requiredSpeed, float maxSpeedPercent, float assistPercent, float epsilon, out Vector3 adjustedVelocity) { }

	[BurstCompile]
	public static void GetAssistedVelocityInternal$BurstManaged(in Vector3 source, in Vector3 target, in Vector3 velocity, float gravity, float maxAngle, float requiredSpeed, float maxSpeedPercent, float assistPercent, float epsilon, out Vector3 adjustedVelocity) { }

	private void Initialize() { }

	protected void LateUpdate() { }

	[BeforeRenderOrder(95)]
	private void OnBeforeRender() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	public void set_aimAssistMaxSpeedPercent(float value) { }

	public void set_aimAssistPercent(float value) { }

	public void set_aimAssistRequiredAngle(float value) { }

	public void set_aimAssistRequiredSpeed(float value) { }

	public void set_fallbackDivergence(float value) { }

	public void set_gazeInteractor(XRGazeInteractor value) { }

	public void set_hideCursorWithNoActiveRays(bool value) { }

	public void set_rayInteractors(List<InteractorData> value) { }

	protected void Start() { }

	private override Vector3 UnityEngine.XR.Interaction.Toolkit.IXRAimAssist.GetAssistedVelocity(in Vector3 source, in Vector3 velocity, float gravity, float maxAngle) { }

	private override Vector3 UnityEngine.XR.Interaction.Toolkit.IXRAimAssist.GetAssistedVelocity(in Vector3 source, in Vector3 velocity, float gravity) { }

	protected void Update() { }

}

