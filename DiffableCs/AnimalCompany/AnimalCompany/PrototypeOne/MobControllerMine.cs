namespace AnimalCompany.PrototypeOne;

[NetworkBehaviourWeaved(3)]
public class MobControllerMine : NetworkBehaviour, IDamageable
{
	private static readonly Vector3 PLUG_POS_ORIGINAL; //Field offset: 0x0
	private static readonly Vector3 PLUG_POS_TRIGGERED; //Field offset: 0xC
	private static HashSet<MobControllerMine> _allMines; //Field offset: 0x18
	[SerializeField]
	private RandomSFX _SFXStep; //Field offset: 0x80
	[SerializeField]
	private Explosion _explosionPrefab; //Field offset: 0x88
	[SerializeField]
	private GameObject _view; //Field offset: 0x90
	[SerializeField]
	private Transform _plugTransform; //Field offset: 0x98
	[DefaultForProperty("resetTimer", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _resetTimer; //Field offset: 0xA0
	[DefaultForProperty("isStepped", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isStepped; //Field offset: 0xA4
	[DefaultForProperty("isExploded", 2, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isExploded; //Field offset: 0xA5

	public static IEnumerable<MobControllerMine> allMines
	{
		 get { } //Length: 88
	}

	[Networked]
	[NetworkedWeaved(2, 1)]
	[OnChangedRender("HandleIsExplodedChanged")]
	public bool isExploded
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(1, 1)]
	public bool isStepped
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	private TickTimer resetTimer
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	private static MobControllerMine() { }

	public MobControllerMine() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	public virtual void FixedUpdateNetwork() { }

	public static IEnumerable<MobControllerMine> get_allMines() { }

	public bool get_isExploded() { }

	public bool get_isStepped() { }

	private TickTimer get_resetTimer() { }

	private void HandleIsExplodedChanged() { }

	public override void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName) { }

	private bool IsHand(Collider collider) { }

	private void OnDestroy() { }

	private void OnTriggerEnter(Collider other) { }

	private void OnTriggerExit(Collider other) { }

	private void Reset() { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_TriggerEnter() { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_TriggerEnter@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_TriggerExit() { }

	[NetworkRpcWeavedInvoker(2, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_TriggerExit@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	public void set_isExploded(bool value) { }

	public void set_isStepped(bool value) { }

	private void set_resetTimer(TickTimer value) { }

	public virtual void Spawned() { }

}

