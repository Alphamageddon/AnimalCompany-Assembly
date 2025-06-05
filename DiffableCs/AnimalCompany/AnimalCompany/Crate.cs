namespace AnimalCompany;

[NetworkBehaviourWeaved(1)]
public class Crate : NetworkBehaviour, IDamageable
{
	[SerializeField]
	private GameObject _lootPrefab; //Field offset: 0x80
	[SerializeField]
	private GameObject _aliveView; //Field offset: 0x88
	[SerializeField]
	private RandomSFX _breakSFX; //Field offset: 0x90
	[DefaultForProperty("currentHealth", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _currentHealth; //Field offset: 0x98

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleCurrentHealthChanged")]
	public int currentHealth
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public Crate() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public int get_currentHealth() { }

	private void HandleCurrentHealthChanged() { }

	public override void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_TakeHit(int damage, Vector3 position, string hitSound, string killSound, Vector3 force, string hitName) { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_TakeHit@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	public void set_currentHealth(int value) { }

}

