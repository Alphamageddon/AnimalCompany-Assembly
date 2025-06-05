namespace AnimalCompany;

[NetworkBehaviourWeaved(5)]
public class HandGrenade : NetworkBehaviour, IDamageable
{
	[SerializeField]
	private GrabbableItem _grabbable; //Field offset: 0x80
	[SerializeField]
	private GameObject _pin; //Field offset: 0x88
	[SerializeField]
	private GameObject _handle; //Field offset: 0x90
	[SerializeField]
	private RandomSFX _SFXactivate; //Field offset: 0x98
	[SerializeField]
	private Explosion _explosionPrefab; //Field offset: 0xA0
	[SerializeField]
	private GameObject _pinHandleParent; //Field offset: 0xA8
	[SerializeField]
	private GameObject _viewGO; //Field offset: 0xB0
	[SerializeField]
	private Rigidbody _rigidbody; //Field offset: 0xB8
	[DefaultForProperty("life", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _life; //Field offset: 0xC0
	[DefaultForProperty("pausedRemainingTicks", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private int _pausedRemainingTicks; //Field offset: 0xC4
	[DefaultForProperty("timerPins", 2, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _timerPins; //Field offset: 0xC8
	[DefaultForProperty("isPinPulled", 3, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isPinPulled; //Field offset: 0xCC
	[DefaultForProperty("isExploded", 4, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isExploded; //Field offset: 0xCD

	[Networked]
	[NetworkedWeaved(4, 1)]
	[OnChangedRender("HandleIsExplodedChanged")]
	public bool isExploded
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(3, 1)]
	[OnChangedRender("HandleIsPinPulledChanged")]
	public bool isPinPulled
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	private TickTimer life
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(1, 1)]
	private int pausedRemainingTicks
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(2, 1)]
	private TickTimer timerPins
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	public HandGrenade() { }

	private void AddRigibodyAndForce(GameObject go) { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	private void ExplodeInternal() { }

	public virtual void FixedUpdateNetwork() { }

	public bool get_isExploded() { }

	public bool get_isPinPulled() { }

	private TickTimer get_life() { }

	private int get_pausedRemainingTicks() { }

	private TickTimer get_timerPins() { }

	private void HandleDroppedFromDeath() { }

	private void HandleIsExplodedChanged() { }

	private void HandleIsPinPulledChanged() { }

	private void HandleRespawned() { }

	private void HandleToggleUse() { }

	public override void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName) { }

	private void OnDestroy() { }

	private void RemoveRigidbody(GameObject go) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_Explode() { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Explode@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_Use(bool shortTimer = false) { }

	[NetworkRpcWeavedInvoker(2, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Use@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	public void set_isExploded(bool value) { }

	public void set_isPinPulled(bool value) { }

	private void set_life(TickTimer value) { }

	private void set_pausedRemainingTicks(int value) { }

	private void set_timerPins(TickTimer value) { }

	public virtual void Spawned() { }

}

