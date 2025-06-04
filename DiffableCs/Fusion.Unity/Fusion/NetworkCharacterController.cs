namespace Fusion;

[DisallowMultipleComponent]
[NetworkBehaviourWeaved(18)]
[RequireComponent(typeof(CharacterController))]
public sealed class NetworkCharacterController : NetworkTRSP, INetworkTRSPTeleport, IBeforeAllTicks, IAfterAllTicks, IBeforeCopyPreviousState
{
	[Header("Character Controller Settings")]
	public float gravity; //Field offset: 0x84
	public float jumpImpulse; //Field offset: 0x88
	public float acceleration; //Field offset: 0x8C
	public float braking; //Field offset: 0x90
	public float maxSpeed; //Field offset: 0x94
	public float rotationSpeed; //Field offset: 0x98
	private Tick _initial; //Field offset: 0x9C
	private CharacterController _controller; //Field offset: 0xA0

	private NetworkCCData Data
	{
		private get { } //Length: 76
	}

	public bool Grounded
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public Vector3 Velocity
	{
		 get { } //Length: 32
		 set { } //Length: 76
	}

	public NetworkCharacterController() { }

	private void Awake() { }

	private void CopyToBuffer() { }

	private void CopyToEngine() { }

	private override void Fusion.IAfterAllTicks.AfterAllTicks(bool resimulation, int tickCount) { }

	private override void Fusion.IBeforeAllTicks.BeforeAllTicks(bool resimulation, int tickCount) { }

	private override void Fusion.IBeforeCopyPreviousState.BeforeCopyPreviousState() { }

	private NetworkCCData get_Data() { }

	public bool get_Grounded() { }

	public Vector3 get_Velocity() { }

	public void Jump(bool ignoreGrounded = false, Nullable<Single> overrideImpulse = null) { }

	public void Move(Vector3 direction) { }

	public virtual void Render() { }

	public void set_Grounded(bool value) { }

	public void set_Velocity(Vector3 value) { }

	public virtual void Spawned() { }

	public override void Teleport(Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null) { }

}

