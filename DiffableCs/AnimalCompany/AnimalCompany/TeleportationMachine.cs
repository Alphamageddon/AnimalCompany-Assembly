namespace AnimalCompany;

[NetworkBehaviourWeaved(2)]
public class TeleportationMachine : NetworkBehaviour
{
	internal enum TeleportationState
	{
		Ready = 0,
		Activating = 1,
		Recharging = 2,
	}

	public float radius; //Field offset: 0x80
	public float activationDelay; //Field offset: 0x84
	public float rechargeDelay; //Field offset: 0x88
	public ParticleSystem chargingParticles; //Field offset: 0x90
	public RandomSFX activateSFX; //Field offset: 0x98
	public RandomSFX teleportSFX; //Field offset: 0xA0
	public RandomSFX rechargedSFX; //Field offset: 0xA8
	public Transform soundTransform; //Field offset: 0xB0
	public Light chargingLight; //Field offset: 0xB8
	public float maxLightIntensity; //Field offset: 0xC0
	[DefaultForProperty("charge", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _charge; //Field offset: 0xC4
	[DefaultForProperty("state", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private TeleportationState _state; //Field offset: 0xC8
	public TerminalKeyInputListener keyInputListener; //Field offset: 0xD0

	[Networked]
	[NetworkedWeaved(0, 1)]
	public private float charge
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(1, 1)]
	public private TeleportationState state
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	public TeleportationMachine() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	public float get_charge() { }

	public TeleportationState get_state() { }

	private void HandleKeyInput(KeyCode keyCode, TerminalKeyType keyType) { }

	private void MasterTeleport() { }

	public void OnDrawGizmos() { }

	public virtual void Render() { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	private void RPC_PlayChargingParticles() { }

	[NetworkRpcWeavedInvoker(2, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayChargingParticles@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	private void RPC_RechargeFinished() { }

	[NetworkRpcWeavedInvoker(4, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_RechargeFinished@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	private void RPC_RequestActivation() { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_RequestActivation@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	private void RPC_Teleport() { }

	[NetworkRpcWeavedInvoker(3, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Teleport@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	private void set_charge(float value) { }

	private void set_state(TeleportationState value) { }

	private void Start() { }

}

