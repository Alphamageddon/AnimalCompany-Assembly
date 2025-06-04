namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Direct Interactor", 11)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRDirectInteractor.html")]
public class XRDirectInteractor : XRBaseControllerInteractor
{
	[CompilerGenerated]
	private sealed class <UpdateCollidersAfterOnTriggerStay>d__36 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public XRDirectInteractor <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <UpdateCollidersAfterOnTriggerStay>d__36(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly WaitForFixedUpdate s_WaitForFixedUpdate; //Field offset: 0x0
	[SerializeField]
	private bool m_ImproveAccuracyWithSphereCollider; //Field offset: 0x290
	[SerializeField]
	private LayerMask m_PhysicsLayerMask; //Field offset: 0x294
	[SerializeField]
	private QueryTriggerInteraction m_PhysicsTriggerInteraction; //Field offset: 0x298
	[CompilerGenerated]
	private readonly List<IXRInteractable> <unsortedValidTargets>k__BackingField; //Field offset: 0x2A0
	private readonly HashSet<Collider> m_StayedColliders; //Field offset: 0x2A8
	private readonly TriggerContactMonitor m_TriggerContactMonitor; //Field offset: 0x2B0
	private IEnumerator m_UpdateCollidersAfterTriggerStay; //Field offset: 0x2B8
	private bool m_UsingSphereColliderAccuracyImprovement; //Field offset: 0x2C0
	private SphereCollider m_SphereCollider; //Field offset: 0x2C8
	private PhysicsScene m_LocalPhysicsScene; //Field offset: 0x2D0
	private Vector3 m_LastSphereCastOrigin; //Field offset: 0x2D4
	private readonly Collider[] m_OverlapSphereHits; //Field offset: 0x2E0
	private readonly RaycastHit[] m_SphereCastHits; //Field offset: 0x2E8
	private bool m_FirstFrame; //Field offset: 0x2F0
	private bool m_ContactsSortedThisFrame; //Field offset: 0x2F1
	private readonly List<IXRInteractable> m_SortedValidTargets; //Field offset: 0x2F8

	public bool improveAccuracyWithSphereCollider
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public LayerMask physicsLayerMask
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public QueryTriggerInteraction physicsTriggerInteraction
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected List<IXRInteractable> unsortedValidTargets
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool usingSphereColliderAccuracyImprovement
	{
		 get { } //Length: 8
	}

	private static XRDirectInteractor() { }

	public XRDirectInteractor() { }

	protected virtual void Awake() { }

	[Obsolete("CanHover(XRBaseInteractable) has been deprecated. Use CanHover(IXRHoverInteractable) instead.")]
	public virtual bool CanHover(XRBaseInteractable interactable) { }

	public virtual bool CanHover(IXRHoverInteractable interactable) { }

	[Obsolete("CanSelect(XRBaseInteractable) has been deprecated. Use CanSelect(IXRSelectInteractable) instead.")]
	public virtual bool CanSelect(XRBaseInteractable interactable) { }

	public virtual bool CanSelect(IXRSelectInteractable interactable) { }

	private void EvaluateSphereOverlap() { }

	public bool get_improveAccuracyWithSphereCollider() { }

	public LayerMask get_physicsLayerMask() { }

	public QueryTriggerInteraction get_physicsTriggerInteraction() { }

	[CompilerGenerated]
	protected List<IXRInteractable> get_unsortedValidTargets() { }

	public bool get_usingSphereColliderAccuracyImprovement() { }

	public virtual void GetValidTargets(List<IXRInteractable> targets) { }

	private void OnContactAdded(IXRInteractable interactable) { }

	private void OnContactRemoved(IXRInteractable interactable) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void OnInteractableRegistered(InteractableRegisteredEventArgs args) { }

	private void OnInteractableUnregistered(InteractableUnregisteredEventArgs args) { }

	protected virtual void OnRegistered(InteractorRegisteredEventArgs args) { }

	protected void OnTriggerEnter(Collider other) { }

	protected void OnTriggerExit(Collider other) { }

	protected void OnTriggerStay(Collider other) { }

	protected virtual void OnUnregistered(InteractorUnregisteredEventArgs args) { }

	public virtual void PreprocessInteractor(UpdatePhase updatePhase) { }

	public virtual void ProcessInteractor(UpdatePhase updatePhase) { }

	private void ResetCollidersAndValidTargets() { }

	public void set_improveAccuracyWithSphereCollider(bool value) { }

	public void set_physicsLayerMask(LayerMask value) { }

	public void set_physicsTriggerInteraction(QueryTriggerInteraction value) { }

	[IteratorStateMachine(typeof(<UpdateCollidersAfterOnTriggerStay>d__36))]
	private IEnumerator UpdateCollidersAfterOnTriggerStay() { }

	private void ValidateColliderConfiguration() { }

}

