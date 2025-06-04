namespace AnimalCompany;

[NetworkBehaviourWeaved(1)]
public class BombController : NetworkBehaviour, IDamageable
{
	private const float EXPLOSION_TIME = 3; //Field offset: 0x0
	private static readonly int PROP_EMISSION_COLOR; //Field offset: 0x0
	private static readonly Color BOMB_EMISSION_COLOR; //Field offset: 0x4
	[DefaultForProperty("_timerExplosion", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer __timerExplosion; //Field offset: 0x80
	[SerializeField]
	private MeshRenderer _bombRenderer; //Field offset: 0x88
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0x90
	[SerializeField]
	private GameObject _explosionPrefab; //Field offset: 0x98
	private bool _isExplodedLocal; //Field offset: 0xA0

	[Networked]
	[NetworkedWeaved(0, 1)]
	private TickTimer _timerExplosion
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	private static BombController() { }

	public BombController() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	private TickTimer get__timerExplosion() { }

	public override void Hit(int damage, Vector3 hitPosition, RandomSFX hitSFX, RandomSFX deathSFX, Vector3 force, string instigator, NetworkBehaviourId instigatorId) { }

	[Rpc(RpcSources::All (7), RpcTargets::All (7))]
	private void RPC_TriggerExplosion() { }

	[NetworkRpcWeavedInvoker(1, 7, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_TriggerExplosion@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	private void set__timerExplosion(TickTimer value) { }

	public void TriggerExplosion() { }

}

