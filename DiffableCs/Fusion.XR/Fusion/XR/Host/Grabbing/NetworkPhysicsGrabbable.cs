namespace Fusion.XR.Host.Grabbing;

[DefaultExecutionOrder(130)]
[RequireComponent(typeof(PhysicsGrabbable))]
public class NetworkPhysicsGrabbable : NetworkGrabbable, IInputAuthorityLost
{
	internal struct PseudoHapticFeedbackConfiguration
	{
		public bool enablePseudoHapticFeedback; //Field offset: 0x0
		public float minNonContactingDissonance; //Field offset: 0x4
		public float minContactingDissonance; //Field offset: 0x8
		public float maxDissonanceDistance; //Field offset: 0xC
		public float vibrationDuration; //Field offset: 0x10

	}

	[HideInInspector]
	public NetworkRigidbody3D networkRigidbody; //Field offset: 0x98
	[CompilerGenerated]
	private DetailedGrabInfo <DetailedGrabInfo>k__BackingField; //Field offset: 0xA0
	private ChangeDetector changeDetector; //Field offset: 0x108
	[Header("Feedback configuration")]
	public PseudoHapticFeedbackConfiguration pseudoHapticFeedbackConfiguration; //Field offset: 0x110
	[HideInInspector]
	public bool isPseudoHapticDisplayed; //Field offset: 0x124
	[CompilerGenerated]
	private NetworkBool <IsColliding>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private Vector3 <PidLastError>k__BackingField; //Field offset: 0x12C
	[CompilerGenerated]
	private Vector3 <PidErrorIntegration>k__BackingField; //Field offset: 0x138
	[HideInInspector]
	public PhysicsGrabbable grabbable; //Field offset: 0x148
	private bool willReceiveInputAuthority; //Field offset: 0x150
	private RigPart previousGrabbingSide; //Field offset: 0x154
	private float inputAuthorityChangeRequestTime; //Field offset: 0x158
	private Tick inputAuthorityChangeRequestTick; //Field offset: 0x15C
	private GrabInfo incomingGrabInfo; //Field offset: 0x160
	private NetworkGrabber incomingGrabber; //Field offset: 0x1B8
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"player", "side"}])]
	private Dictionary<ValueTuple`2<PlayerRef, RigPart>, NetworkGrabber> cachedGrabbers; //Field offset: 0x1C0

	public virtual NetworkGrabber CurrentGrabber
	{
		 get { } //Length: 140
	}

	[Networked]
	public DetailedGrabInfo DetailedGrabInfo
	{
		[CompilerGenerated]
		 get { } //Length: 16
		[CompilerGenerated]
		 set { } //Length: 24
	}

	[Networked]
	private NetworkBool IsColliding
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[Networked]
	private Vector3 PidErrorIntegration
	{
		[CompilerGenerated]
		private get { } //Length: 16
		[CompilerGenerated]
		private set { } //Length: 16
	}

	[Networked]
	private Vector3 PidLastError
	{
		[CompilerGenerated]
		private get { } //Length: 16
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public NetworkPhysicsGrabbable() { }

	private void AdaptRenderTimeFrame(NetworkGrabber grabber) { }

	private void ApplyPseudoHapticFeedback() { }

	private void Awake() { }

	public virtual void FixedUpdateNetwork() { }

	public override void Follow(Transform followedTransform, float elapsedTime, bool isColliding) { }

	public virtual NetworkGrabber get_CurrentGrabber() { }

	[CompilerGenerated]
	public DetailedGrabInfo get_DetailedGrabInfo() { }

	[CompilerGenerated]
	private NetworkBool get_IsColliding() { }

	[CompilerGenerated]
	private Vector3 get_PidErrorIntegration() { }

	[CompilerGenerated]
	private Vector3 get_PidLastError() { }

	public virtual void Grab(NetworkGrabber newGrabber, GrabInfo newGrabInfo) { }

	public NetworkGrabber GrabberForId(NetworkBehaviourId id) { }

	public NetworkGrabber GrabberForSideAndPlayer(PlayerRef player, RigPart side) { }

	public override void InputAuthorityLost() { }

	private void OnCollisionStay(Collision collision) { }

	public virtual void Render() { }

	[CompilerGenerated]
	public void set_DetailedGrabInfo(DetailedGrabInfo value) { }

	[CompilerGenerated]
	private void set_IsColliding(NetworkBool value) { }

	[CompilerGenerated]
	private void set_PidErrorIntegration(Vector3 value) { }

	[CompilerGenerated]
	private void set_PidLastError(Vector3 value) { }

	public virtual void Spawned() { }

	private void TriggerCallbacksOnForwardGrabbingChanges() { }

	public virtual void Ungrab(NetworkGrabber previousGrabber, GrabInfo newGrabInfo) { }

}

