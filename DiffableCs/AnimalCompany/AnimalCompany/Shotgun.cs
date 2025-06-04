namespace AnimalCompany;

[NetworkBehaviourWeaved(2)]
public class Shotgun : NetworkBehaviour
{
	private class HitDamage
	{
		public int damage; //Field offset: 0x10
		public Vector3 point; //Field offset: 0x14
		public Vector3 force; //Field offset: 0x20

		public HitDamage() { }

	}

	private const int RELOAD_AMMO = 2; //Field offset: 0x0
	private const float RECOIL_FORCE_MAG = 9; //Field offset: 0x0
	private const float HIT_FORCE_MAG = 50; //Field offset: 0x0
	private const float SHOOT_SPREAD = 0.07; //Field offset: 0x0
	private const int NUM_RAYS = 19; //Field offset: 0x0
	private const int HIT_DAMAGE = 10; //Field offset: 0x0
	private const float RELOAD_TIME_S = 1; //Field offset: 0x0
	[SerializeField]
	private GrabbableItem _grabbable; //Field offset: 0x80
	[SerializeField]
	private Transform _barrelTip; //Field offset: 0x88
	[SerializeField]
	private RandomSFX _sfxShoot; //Field offset: 0x90
	[SerializeField]
	private RandomSFX _sfxShootEmpty; //Field offset: 0x98
	[SerializeField]
	private RandomSFX _sfxReload; //Field offset: 0xA0
	[SerializeField]
	private LayerMask _hitLayer; //Field offset: 0xA8
	[SerializeField]
	private GameObject _muzzleFlashGO; //Field offset: 0xB0
	[SerializeField]
	private RayMeshController _rayMeshController; //Field offset: 0xB8
	private List<Vector3> _rayDirections; //Field offset: 0xC0
	[DefaultForProperty("_ammoLeft", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private int __ammoLeft; //Field offset: 0xC8
	[DefaultForProperty("reloadTimer", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private TickTimer _reloadTimer; //Field offset: 0xCC
	private Rigidbody _rigidbody; //Field offset: 0xD0
	private int _muzzleFlashRemainingFrames; //Field offset: 0xD8

	[Networked]
	[NetworkedWeaved(0, 1)]
	private int _ammoLeft
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(1, 1)]
	public TickTimer reloadTimer
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public Shotgun() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private int get__ammoLeft() { }

	public TickTimer get_reloadTimer() { }

	private void HandleRespawned() { }

	private void HandleUse() { }

	private void OnDestroy() { }

	public void Reload() { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	public void RPC_MuzzleFlash() { }

	[NetworkRpcWeavedInvoker(2, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_MuzzleFlash@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_Reload() { }

	[NetworkRpcWeavedInvoker(3, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Reload@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_Shoot() { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Shoot@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	private void set__ammoLeft(int value) { }

	public void set_reloadTimer(TickTimer value) { }

	private void ShootInternal() { }

	private void ShootRandomRay(Dictionary<IDamageable, HitDamage> damageToApply, List<Vector3> rayDirections) { }

	public virtual void Spawned() { }

	private void Update() { }

}

