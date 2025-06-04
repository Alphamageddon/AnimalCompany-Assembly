namespace AnimalCompany;

[NetworkBehaviourWeaved(94)]
public class FakeGorillaController : MobController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<NetPlayer, Boolean> <>9__49_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <RPC_Hit>b__49_1(NetPlayer player) { }

	}

	internal class BounceRequest
	{
		public bool isRequested; //Field offset: 0x10
		public float timeRequested; //Field offset: 0x14
		public float timeToBounce; //Field offset: 0x18
		public Vector3 hitPosition; //Field offset: 0x1C
		public Vector3 hitNormal; //Field offset: 0x28

		public BounceRequest() { }

		public bool ShouldPerformBounce() { }

	}

	internal enum Phase
	{
		Spawned = 0,
		Roaming = 1,
		Awared = 2,
		ChasingLoot = 3,
		ChasingPlayer = 4,
		Searching = 5,
		Die = 6,
	}

	private const float DISTANCE_TO_CHASE_PLAYER = 30; //Field offset: 0x0
	private const float TIME_TO_LOSE_ANGRY = 10; //Field offset: 0x0
	private static readonly Vector2 BOUNCE_FORCE; //Field offset: 0x0
	private const float MIN_JUMP_HEIGHT = 0; //Field offset: 0x0
	private const float MAX_JUMP_HEIGHT = 3; //Field offset: 0x0
	private const float MAX_MAGNITUDE = 48; //Field offset: 0x0
	private const float TIME_TO_REACH_TARGET = 50; //Field offset: 0x0
	private const int MAX_PLAYER_TRACKED = 8; //Field offset: 0x0
	private static readonly Vector2 TIME_TO_GET_ANGRY_WITH_LOOT; //Field offset: 0x8
	private static readonly Vector2 TIME_TO_GET_ANGRY_WITHOUT_LOOT; //Field offset: 0x10
	[DefaultForProperty("phase", 15, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Phase _phase; //Field offset: 0x1A4
	[DefaultForProperty("playerColor", 16, 4)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Color _playerColor; //Field offset: 0x1A8
	[DefaultForProperty("positionAngry", 20, 3)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Vector3 _positionAngry; //Field offset: 0x1B8
	[DefaultForProperty("_angerMetersByPlayerId", 23, 71)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private SerializableDictionary<UInt32, Single> __angerMetersByPlayerId; //Field offset: 0x1C8
	[Header("Fake Gorilla Controller")]
	[SerializeField]
	[Space(10)]
	private Collider _bodyCollider; //Field offset: 0x1D0
	[SerializeField]
	private SphereCollider _contactCollider; //Field offset: 0x1D8
	[SerializeField]
	private Collider[] _childColliders; //Field offset: 0x1E0
	[SerializeField]
	private Rigidbody _rigidbody; //Field offset: 0x1E8
	[SerializeField]
	private Transform _centerPoint; //Field offset: 0x1F0
	[Header("Fake GorillaView")]
	[SerializeField]
	[Space(5)]
	private FakeGorillaView _fakeGorillaView; //Field offset: 0x1F8
	[SerializeField]
	private Transform[] _armTargetTransforms; //Field offset: 0x200
	private List<RaycastHit> _contactPoints; //Field offset: 0x208
	private BounceRequest[] _bounceRequests; //Field offset: 0x210
	private Vector3 _forceHit; //Field offset: 0x218

	[Capacity(8)]
	[Networked]
	[NetworkedWeaved(23, 71)]
	[UnitySerializeField]
	private NetworkDictionary<UInt32, Single> _angerMetersByPlayerId
	{
		private get { } //Length: 212
	}

	private Vector3 _attackPosition
	{
		private get { } //Length: 28
	}

	private bool _isMad
	{
		private get { } //Length: 68
	}

	private float _timeToLoseAnger
	{
		private get { } //Length: 40
	}

	[Networked]
	[NetworkedWeaved(15, 1)]
	[OnChangedRender("HandlePhaseChanged")]
	public private Phase phase
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(16, 4)]
	public private Color playerColor
	{
		 get { } //Length: 100
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(20, 3)]
	public private Vector3 positionAngry
	{
		 get { } //Length: 100
		private set { } //Length: 100
	}

	public float RADIUS_ARM_RANGE
	{
		 get { } //Length: 28
	}

	public float RADIUS_BODY
	{
		 get { } //Length: 224
	}

	private static FakeGorillaController() { }

	public FakeGorillaController() { }

	[CompilerGenerated]
	private int <RPC_Hit>b__49_0(NetPlayer a, NetPlayer b) { }

	private void ApplyBounceForce(Vector3 targetPosition, Vector3 hitPosition, Vector3 hitNormal) { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private NetworkDictionary<UInt32, Single> get__angerMetersByPlayerId() { }

	private Vector3 get__attackPosition() { }

	private bool get__isMad() { }

	private float get__timeToLoseAnger() { }

	public Phase get_phase() { }

	public Color get_playerColor() { }

	public Vector3 get_positionAngry() { }

	public float get_RADIUS_ARM_RANGE() { }

	public float get_RADIUS_BODY() { }

	[ContextMenu("GetChildColliders")]
	public void GetChildColliders() { }

	protected virtual void HandleDie() { }

	private void HandlePhaseChanged() { }

	protected virtual void HandleRevive() { }

	public virtual void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName, NetworkBehaviourId source) { }

	private bool IsAnchorHoldingLoot(AttachedItemAnchor anchor) { }

	private bool IsPlayerHoldingLoot(NetPlayer player) { }

	protected virtual void OnDrawGizmos() { }

	private void RequestMoveToTarget(Vector3 hitPosition, Vector3 hitNormal, Vector3 targetPosition) { }

	public virtual void RPC_Hit(int damage) { }

	private void set_phase(Phase value) { }

	private void set_playerColor(Color value) { }

	private void set_positionAngry(Vector3 value) { }

	private void SetAwared(List<NetPlayer> players) { }

	private void SetChasing(NetPlayer player) { }

	private void SetChasingLoot(NetPlayer player) { }

	private void SetChasingPlayer(NetPlayer player) { }

	private void SetRoaming() { }

	private void SetSearching() { }

	public virtual void Setup() { }

	private void UpdateAwared() { }

	protected virtual void UpdateChasing() { }

	private void UpdateChasingLoot() { }

	private void UpdateChasingPlayer() { }

	private void UpdateGorillaMoveToTarget(Vector3 targetPosition, float forceToTarget = 0) { }

	protected virtual void UpdateMonsterBehaviour() { }

	public virtual void UpdateRoaming() { }

	private void UpdateSearching() { }

}

