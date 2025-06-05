namespace AnimalCompany;

[NetworkBehaviourWeaved(40)]
public class CystController : NetworkBehaviour, IDamageable
{
	private const float MAX_TETHER_DIST = 15; //Field offset: 0x0
	private const int MAX_HP = 100; //Field offset: 0x0
	private const float RESPAWN_TIME = 20; //Field offset: 0x0
	public GameObject view; //Field offset: 0x80
	public Transform lookAtTransform; //Field offset: 0x88
	public Transform eyeTransform; //Field offset: 0x90
	public Transform spikeTransform; //Field offset: 0x98
	public RandomSFX tetherAttachSFX; //Field offset: 0xA0
	public RandomSFX tetherBreakSFX; //Field offset: 0xA8
	public RandomSFX wakeupSFX; //Field offset: 0xB0
	private double lastWakeupTime; //Field offset: 0xB8
	public RandomSFX sleepSFX; //Field offset: 0xC0
	public RandomSFX attackSFX; //Field offset: 0xC8
	public RandomSFX dieSFX; //Field offset: 0xD0
	public List<CystTether> tethers; //Field offset: 0xD8
	[DefaultForProperty("tetherAttachmentPoints", 0, 30)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Vector3[] _tetherAttachmentPoints; //Field offset: 0xE0
	[DefaultForProperty("target", 30, 2)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private NetPlayer _target; //Field offset: 0xE8
	[DefaultForProperty("attacked", 32, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private bool _attacked; //Field offset: 0xF0
	[DefaultForProperty("attackVector", 33, 3)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private Vector3 _attackVector; //Field offset: 0xF4
	[DefaultForProperty("attackTimer", 36, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private float _attackTimer; //Field offset: 0x100
	[DefaultForProperty("health", 37, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private int _health; //Field offset: 0x104
	[DefaultForProperty("isDie", 38, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private bool _isDie; //Field offset: 0x108
	[DefaultForProperty("respawnTimer", 39, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _respawnTimer; //Field offset: 0x10C
	private float checkForAttachTimer; //Field offset: 0x110

	[Networked]
	[NetworkedWeaved(32, 1)]
	private bool attacked
	{
		private get { } //Length: 104
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(36, 1)]
	private float attackTimer
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(33, 3)]
	private Vector3 attackVector
	{
		private get { } //Length: 100
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(37, 1)]
	private int health
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(38, 1)]
	[OnChangedRender("HandleIsDieChanged")]
	private bool isDie
	{
		private get { } //Length: 104
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(39, 1)]
	private TickTimer respawnTimer
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(30, 2)]
	private NetPlayer target
	{
		private get { } //Length: 256
		private set { } //Length: 172
	}

	[Capacity(10)]
	[Networked]
	[NetworkedWeaved(0, 30)]
	public NetworkArray<Vector3> tetherAttachmentPoints
	{
		 get { } //Length: 184
	}

	public CystController() { }

	public void AttachTether(CystTether tether) { }

	public void BreakTether(CystTether tether, NetPlayer player) { }

	public void BreakTetherInternal(CystTether tether, NetPlayer player) { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private void Die() { }

	public virtual void FixedUpdateNetwork() { }

	private bool get_attacked() { }

	private float get_attackTimer() { }

	private Vector3 get_attackVector() { }

	private int get_health() { }

	private bool get_isDie() { }

	private TickTimer get_respawnTimer() { }

	private NetPlayer get_target() { }

	public NetworkArray<Vector3> get_tetherAttachmentPoints() { }

	private void HandleIsDieChanged() { }

	public override void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName) { }

	private void OnDrawGizmosSelected() { }

	private void ResetAllTethers() { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_Hit(int damage) { }

	[NetworkRpcWeavedInvoker(2, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Hit@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_ServerBreakTether(int id, uint playerID) { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_ServerBreakTether@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	private void set_attacked(bool value) { }

	private void set_attackTimer(float value) { }

	private void set_attackVector(Vector3 value) { }

	private void set_health(int value) { }

	private void set_isDie(bool value) { }

	private void set_respawnTimer(TickTimer value) { }

	private void set_target(NetPlayer value) { }

	public virtual void Spawned() { }

}

