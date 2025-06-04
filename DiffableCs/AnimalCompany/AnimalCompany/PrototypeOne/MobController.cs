namespace AnimalCompany.PrototypeOne;

[NetworkBehaviourWeaved(1)]
public class MobController : NetworkBehaviour, IStateAuthorityChanged
{
	internal enum MobMoveStatus
	{
		None = 0,
		Walking = 1,
		Running = 2,
	}

	internal enum Status
	{
		Walk = 0,
		Engage = 1,
		Attack = 2,
	}

	[SerializeField]
	private Status _status; //Field offset: 0x80
	[SerializeField]
	private CharacterController _characterController; //Field offset: 0x88
	[SerializeField]
	private NavMeshAgent _navMeshAgent; //Field offset: 0x90
	[SerializeField]
	private MobView _mobView; //Field offset: 0x98
	[SerializeField]
	private Transform _colliderSight; //Field offset: 0xA0
	[SerializeField]
	private Transform _colliderNotice; //Field offset: 0xA8
	[SerializeField]
	private LayerMask _playerLayerMask; //Field offset: 0xB0
	[SerializeField]
	private LayerMask _environmentLayerMask; //Field offset: 0xB4
	[SerializeField]
	private float _sightRange; //Field offset: 0xB8
	[SerializeField]
	private float _noticeRange; //Field offset: 0xBC
	private int _attackDamage; //Field offset: 0xC0
	private int _currHitIndex; //Field offset: 0xC4
	private float _attackDelayFirstHit; //Field offset: 0xC8
	private float _attackDelay; //Field offset: 0xCC
	private float _attackTimer; //Field offset: 0xD0
	[SerializeField]
	private float _walkSpeed; //Field offset: 0xD4
	[SerializeField]
	private float _runSpeed; //Field offset: 0xD8
	[SerializeField]
	private float _maxWalkDistance; //Field offset: 0xDC
	[SerializeField]
	private float _maxRunDistance; //Field offset: 0xE0
	[SerializeField]
	private float _restTime; //Field offset: 0xE4
	[DefaultForProperty("MoveStatus", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private MobMoveStatus _MoveStatus; //Field offset: 0xE8
	private Vector3 _prevPosition; //Field offset: 0xEC
	private float _currWalkDistance; //Field offset: 0xF8
	private float _currRunDistance; //Field offset: 0xFC
	private float _lastTimeRest; //Field offset: 0x100
	[SerializeField]
	private NetPlayer _targetPlayer; //Field offset: 0x108
	private List<NetPlayer> _playersInSight; //Field offset: 0x110
	[SerializeField]
	private Transform[] _patrolPoints; //Field offset: 0x118
	[SerializeField]
	private int _patrolIndex; //Field offset: 0x120
	[SerializeField]
	private RandomSFX _hitSound; //Field offset: 0x128
	[SerializeField]
	private RandomSFX _killSound; //Field offset: 0x130

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleMoveStatusChanged")]
	public MobMoveStatus MoveStatus
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public MobController() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	public MobMoveStatus get_MoveStatus() { }

	private void HandleMoveStatusChanged() { }

	private void OnDrawGizmos() { }

	public void set_MoveStatus(MobMoveStatus value) { }

	public override void StateAuthorityChanged() { }

	private void UpdateAttack() { }

	private void UpdatePatrol() { }

}

