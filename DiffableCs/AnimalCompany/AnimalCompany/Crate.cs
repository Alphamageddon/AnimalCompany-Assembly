namespace AnimalCompany;

[NetworkBehaviourWeaved(2)]
public class Crate : NetworkBehaviour, IDamageable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static NetworkObjectSpawnDelegate <>9__26_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SpawnBomb>b__26_0(NetworkSpawnOp op) { }

	}

	private const float BOMB_SPAWN_CHANCE = 0.1; //Field offset: 0x0
	private static HashSet<Crate> _allCrates; //Field offset: 0x0
	[SerializeField]
	private GameObject _aliveView; //Field offset: 0x80
	[SerializeField]
	private RandomSFX _breakSFX; //Field offset: 0x88
	[SerializeField]
	private ItemSet _lootSet; //Field offset: 0x90
	[SerializeField]
	private GameObject _bombPrefab; //Field offset: 0x98
	[SerializeField]
	private float _targetSpawnValue; //Field offset: 0xA0
	[SerializeField]
	private int _maxSpawnItems; //Field offset: 0xA4
	private float _totalItemWeight; //Field offset: 0xA8
	[DefaultForProperty("health", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _health; //Field offset: 0xAC
	[DefaultForProperty("life", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _life; //Field offset: 0xB0
	private bool _isAliveLocal; //Field offset: 0xB4

	public static HashSet<Crate> allCrates
	{
		 get { } //Length: 88
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleCurrentHealthChanged")]
	public int health
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(1, 1)]
	private TickTimer life
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	private static Crate() { }

	public Crate() { }

	[CompilerGenerated]
	private void <SpawnLoot>b__27_0(NetworkSpawnOp op) { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	public virtual void FixedUpdateNetwork() { }

	public static HashSet<Crate> get_allCrates() { }

	public int get_health() { }

	private TickTimer get_life() { }

	private void HandleCurrentHealthChanged() { }

	public override void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName, NetworkBehaviourId source) { }

	private void OnDestroy() { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_TakeHit(int damage, Vector3 position, string hitSound, string killSound, Vector3 force, string hitName) { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_TakeHit@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	public void set_health(int value) { }

	private void set_life(TickTimer value) { }

	private void SpawnBomb() { }

	public virtual void Spawned() { }

	private void SpawnLoot() { }

}

