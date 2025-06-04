namespace UnityEngine.XR.Interaction.Toolkit;

public abstract class BaseTeleportationInteractable : XRBaseInteractable, IXRReticleDirectionProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TeleportingEventArgs> <>9__45_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal TeleportingEventArgs <.ctor>b__45_0() { }

	}

	internal enum TeleportTrigger
	{
		OnSelectExited = 0,
		OnSelectEntered = 1,
		OnActivated = 2,
		OnDeactivated = 3,
		OnSelectExit = 0,
		OnSelectEnter = 1,
		OnActivate = 2,
		OnDeactivate = 3,
	}

	private const float k_DefaultNormalToleranceDegrees = 30; //Field offset: 0x0
	[SerializeField]
	[Tooltip("The teleportation provider that this teleportation interactable will communicate teleport requests to. If no teleportation provider is configured, will attempt to find a teleportation provider.")]
	private TeleportationProvider m_TeleportationProvider; //Field offset: 0x1D0
	[SerializeField]
	[Tooltip("How to orient the rig after teleportation.\nSet to:\n\nWorld Space Up to stay oriented according to the world space up vector.\n\nSet to Target Up to orient according to the target BaseTeleportationInteractable Transform's up vector.\n\nSet to Target Up And Forward to orient according to the target BaseTeleportationInteractable Transform's rotation.\n\nSet to None to maintain the same orientation before and after teleporting.")]
	private MatchOrientation m_MatchOrientation; //Field offset: 0x1D8
	[SerializeField]
	[Tooltip("Whether or not to rotate the rig to match the forward direction of the attach transform of the selecting interactor.")]
	private bool m_MatchDirectionalInput; //Field offset: 0x1DC
	[SerializeField]
	[Tooltip("Specify when the teleportation will be triggered. Options map to when the trigger is pressed or when it is released.")]
	private TeleportTrigger m_TeleportTrigger; //Field offset: 0x1E0
	[SerializeField]
	[Tooltip("When enabled, this teleportation interactable will only be selectable by a ray interactor if its current hit normal is aligned with this object's up vector.")]
	private bool m_FilterSelectionByHitNormal; //Field offset: 0x1E4
	[SerializeField]
	[Tooltip("Sets the tolerance in degrees from this object's up vector for a hit normal to be considered aligned with the up vector.")]
	private float m_UpNormalToleranceDegrees; //Field offset: 0x1E8
	[SerializeField]
	private TeleportingEvent m_Teleporting; //Field offset: 0x1F0
	private readonly LinkedPool<TeleportingEventArgs> m_TeleportingEventArgs; //Field offset: 0x1F8
	private readonly Dictionary<IXRInteractor, Vector3> m_TeleportForwardPerInteractor; //Field offset: 0x200

	public bool filterSelectionByHitNormal
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool matchDirectionalInput
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public MatchOrientation matchOrientation
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public TeleportationProvider teleportationProvider
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public TeleportingEvent teleporting
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public TeleportTrigger teleportTrigger
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float upNormalToleranceDegrees
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected BaseTeleportationInteractable() { }

	[CompilerGenerated]
	private void <ProcessInteractable>g__CalculateTeleportForward|37_0(IXRInteractor interactor) { }

	protected virtual void Awake() { }

	[Obsolete("GenerateTeleportRequest(XRBaseInteractor, RaycastHit, ref TeleportRequest) has been deprecated. Use GenerateTeleportRequest(IXRInteractor, RaycastHit, ref TeleportRequest) instead.")]
	protected override bool GenerateTeleportRequest(XRBaseInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest) { }

	protected override bool GenerateTeleportRequest(IXRInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest) { }

	public bool get_filterSelectionByHitNormal() { }

	public bool get_matchDirectionalInput() { }

	public MatchOrientation get_matchOrientation() { }

	public TeleportationProvider get_teleportationProvider() { }

	public TeleportingEvent get_teleporting() { }

	public TeleportTrigger get_teleportTrigger() { }

	public float get_upNormalToleranceDegrees() { }

	public override void GetReticleDirection(IXRInteractor interactor, Vector3 hitNormal, out Vector3 reticleUp, out Nullable<Vector3>& optionalReticleForward) { }

	public virtual bool IsSelectableBy(IXRSelectInteractor interactor) { }

	protected virtual void OnActivated(ActivateEventArgs args) { }

	protected virtual void OnDeactivated(DeactivateEventArgs args) { }

	protected virtual void OnSelectEntered(SelectEnterEventArgs args) { }

	protected virtual void OnSelectExited(SelectExitEventArgs args) { }

	public virtual void ProcessInteractable(UpdatePhase updatePhase) { }

	protected virtual void Reset() { }

	private void SendTeleportRequest(IXRInteractor interactor) { }

	public void set_filterSelectionByHitNormal(bool value) { }

	public void set_matchDirectionalInput(bool value) { }

	public void set_matchOrientation(MatchOrientation value) { }

	public void set_teleportationProvider(TeleportationProvider value) { }

	public void set_teleporting(TeleportingEvent value) { }

	public void set_teleportTrigger(TeleportTrigger value) { }

	public void set_upNormalToleranceDegrees(float value) { }

	private void UpdateTeleportRequestRotation(IXRInteractor interactor, ref TeleportRequest teleportRequest) { }

}

