namespace AnimalCompany;

[NetworkBehaviourWeaved(15)]
public class MobController : NetworkBehaviour, IDamageable, IStunnable, IStateAuthorityChanged, IGenMobSpawnable
{
	[Flags]
	internal enum Status
	{
		Normal = 0,
		Stunned = 1,
	}

	private const float TIME_TO_CHANGE_TARGET_NODE = 60; //Field offset: 0x0
	private const float DIST_TO_CORNER = 1.5; //Field offset: 0x0
	private const float DIST_TO_CORNER_SQR = 2.25; //Field offset: 0x0
	public static Action<MobController, Boolean> onMobDie; //Field offset: 0x0
	private const float DEBUG_THRESHOLD = 0.2; //Field offset: 0x0
	private static HashSet<MobController> _spawnedMobs; //Field offset: 0x8
	[DefaultForProperty("isDie", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isDie; //Field offset: 0x80
	[DefaultForProperty("status", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Status _status; //Field offset: 0x84
	[DefaultForProperty("_timerRevive", 2, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer __timerRevive; //Field offset: 0x88
	[SerializeField]
	protected float _timerStun; //Field offset: 0x8C
	[DefaultForProperty("health", 3, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _health; //Field offset: 0x90
	[DefaultForProperty("navAgentSpeed", 4, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _navAgentSpeed; //Field offset: 0x94
	[DefaultForProperty("navAgentAngularSpeed", 5, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _navAgentAngularSpeed; //Field offset: 0x98
	[DefaultForProperty("searchPrecision", 6, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _searchPrecision; //Field offset: 0x9C
	[DefaultForProperty("searchWidth", 7, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _searchWidth; //Field offset: 0xA0
	[DefaultForProperty("targetPlayerID", 8, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _targetPlayerID; //Field offset: 0xA4
	[DefaultForProperty("_timerToChasing", 9, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float __timerToChasing; //Field offset: 0xA8
	[DefaultForProperty("_timerToSearching", 10, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float __timerToSearching; //Field offset: 0xAC
	[DefaultForProperty("_timerAttackInterval", 11, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float __timerAttackInterval; //Field offset: 0xB0
	protected float _timerHoldAtNavPoint; //Field offset: 0xB4
	protected float _timePastSinceLastNavPointChanged; //Field offset: 0xB8
	protected bool _isHoldAtNavPoint; //Field offset: 0xBC
	protected bool _isHoldAtNavPointChanged; //Field offset: 0xBD
	[Header("References")]
	[SerializeField]
	protected MobData _mobData; //Field offset: 0xC0
	[SerializeField]
	protected MobView _mobView; //Field offset: 0xC8
	[SerializeField]
	protected Transform _viewPoint; //Field offset: 0xD0
	[SerializeField]
	protected Transform _hearingPoint; //Field offset: 0xD8
	protected int viewDistanceIndex; //Field offset: 0xE0
	[Header("NavMeshAgent")]
	[SerializeField]
	protected NavMeshAgent _navMeshAgent; //Field offset: 0xE8
	[SerializeField]
	protected bool _isFlying; //Field offset: 0xF0
	[SerializeField]
	protected bool _isChangeTargetPlayerRandomlyWhenLost; //Field offset: 0xF1
	protected NavMeshPath _navMeshPath; //Field offset: 0xF8
	[Header("NavZone")]
	public int zoneId; //Field offset: 0x100
	[SerializeField]
	private Nullable<NavZone> _navZone; //Field offset: 0x108
	[SerializeField]
	private NavZone _navZoneInspector; //Field offset: 0x128
	private List<NavPoint> visitedPoints; //Field offset: 0x140
	private List<NavPoint> unvisitedPoints; //Field offset: 0x148
	[SerializeField]
	private NavPoint _nodeCurrent; //Field offset: 0x150
	[SerializeField]
	private NavPoint _nodeNext; //Field offset: 0x158
	[Header("Target")]
	[SerializeField]
	private NetPlayer _targetPlayer; //Field offset: 0x160
	[DefaultForProperty("_targetPosition", 12, 3)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Vector3 __targetPosition; //Field offset: 0x168
	protected List<NetPlayer> _playersInSight; //Field offset: 0x178
	[Header("VFX")]
	[SerializeField]
	private bool _disableViewWhenDie; //Field offset: 0x180
	private List<NavPoint> _pointsInRange; //Field offset: 0x188
	private float _timeUpdateStart; //Field offset: 0x190
	protected Action<String> _onUpdateFinish; //Field offset: 0x198
	private bool _isInitialized; //Field offset: 0x1A0

	protected Dictionary<UInt32, NetPlayer> _spawnedPlayers
	{
		 get { } //Length: 136
	}

	[Networked]
	[NetworkedWeaved(12, 3)]
	public Vector3 _targetPosition
	{
		 get { } //Length: 100
		 set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(11, 1)]
	public float _timerAttackInterval
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(2, 1)]
	private TickTimer _timerRevive
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(9, 1)]
	public float _timerToChasing
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(10, 1)]
	public float _timerToSearching
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public MobData data
	{
		 get { } //Length: 8
	}

	protected float deltaTime
	{
		 get { } //Length: 28
	}

	[Networked]
	[NetworkedWeaved(3, 1)]
	public int health
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public Transform hearingPoint
	{
		 get { } //Length: 8
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleIsDieChanged")]
	public bool isDie
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	public bool isStunned
	{
		 get { } //Length: 20
	}

	[Networked]
	[NetworkedWeaved(5, 1)]
	public float navAgentAngularSpeed
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(4, 1)]
	public float navAgentSpeed
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public NavZone navZone
	{
		 get { } //Length: 516
	}

	[Networked]
	[NetworkedWeaved(6, 1)]
	public float searchPrecision
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(7, 1)]
	public float searchWidth
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public static IEnumerable<MobController> spawnedMobs
	{
		 get { } //Length: 88
	}

	[Networked]
	[NetworkedWeaved(1, 1)]
	[OnChangedRender("HandleStatusChanged")]
	public Status status
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public NetPlayer targetPlayer
	{
		 get { } //Length: 8
	}

	[Networked]
	[NetworkedWeaved(8, 1)]
	public int targetPlayerID
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public MobView view
	{
		 get { } //Length: 8
	}

	public float viewDistance
	{
		 get { } //Length: 60
	}

	public Transform viewPoint
	{
		 get { } //Length: 8
	}

	private static MobController() { }

	public MobController() { }

	private void Awake() { }

	protected override void CalculatePathToCurrentNode() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	private NavPoint FindClosestNodeFromPosition(Vector3 position) { }

	public virtual void FixedUpdateNetwork() { }

	public override void GenGraphSetup(int navZone) { }

	protected Dictionary<UInt32, NetPlayer> get__spawnedPlayers() { }

	public Vector3 get__targetPosition() { }

	public float get__timerAttackInterval() { }

	private TickTimer get__timerRevive() { }

	public float get__timerToChasing() { }

	public float get__timerToSearching() { }

	public MobData get_data() { }

	protected float get_deltaTime() { }

	public int get_health() { }

	public Transform get_hearingPoint() { }

	public bool get_isDie() { }

	public bool get_isStunned() { }

	public float get_navAgentAngularSpeed() { }

	public float get_navAgentSpeed() { }

	public NavZone get_navZone() { }

	public float get_searchPrecision() { }

	public float get_searchWidth() { }

	public static IEnumerable<MobController> get_spawnedMobs() { }

	public Status get_status() { }

	public NetPlayer get_targetPlayer() { }

	public int get_targetPlayerID() { }

	public MobView get_view() { }

	public float get_viewDistance() { }

	public Transform get_viewPoint() { }

	protected override void HandleDie() { }

	protected override void HandleIsDieChanged() { }

	public override void HandlePlayerLeft(PlayerRef player) { }

	protected override void HandleRevive() { }

	protected override void HandleStatusChanged() { }

	private void HandleTargetNavPointChanged() { }

	public override void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName, NetworkBehaviourId source) { }

	private void InitializeNavMeshAgent() { }

	private void MarkExploredNodesInRange(Vector3 position, float range) { }

	private void OnDestroy() { }

	protected override void OnDrawGizmos() { }

	protected override void OnDrawGizmosSelected() { }

	private void OnUpdateFinish(string phase) { }

	private void ResetNavMeshAgent() { }

	private void ResetNavPointsVisited() { }

	protected void Respawn(Vector3 position) { }

	[Rpc(RpcSources::All (7), RpcTargets::All (7))]
	public override void RPC_Hit(int damage) { }

	[NetworkRpcWeavedInvoker(2, 7, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Hit@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	protected override void RPC_SetStunView(bool isStun, float duration = 3) { }

	[NetworkRpcWeavedInvoker(1, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_SetStunView@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	protected override void RPC_SetViewIdle() { }

	[NetworkRpcWeavedInvoker(4, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_SetViewIdle@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	protected override void RPC_SetViewWalk(float speed) { }

	[NetworkRpcWeavedInvoker(5, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_SetViewWalk@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public override void RPC_Stun(float duration) { }

	[NetworkRpcWeavedInvoker(3, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Stun@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	public void set__targetPosition(Vector3 value) { }

	public void set__timerAttackInterval(float value) { }

	private void set__timerRevive(TickTimer value) { }

	public void set__timerToChasing(float value) { }

	public void set__timerToSearching(float value) { }

	public void set_health(int value) { }

	public void set_isDie(bool value) { }

	public void set_navAgentAngularSpeed(float value) { }

	public void set_navAgentSpeed(float value) { }

	public void set_searchPrecision(float value) { }

	public void set_searchWidth(float value) { }

	public void set_status(Status value) { }

	public void set_targetPlayerID(int value) { }

	protected override void SetDie(bool isDie) { }

	protected override void SetNavAgentAngularSpeed(float speed) { }

	protected override void SetNavAgentSpeed(float speed) { }

	public override void SetRoamingTarget(Vector3 position) { }

	public override void SetRoamingTarget(bool initialize = false) { }

	protected override void SetStun(bool isStun, float duration = 3) { }

	public override void SetTargetPlayer(NetPlayer netPlayer) { }

	public override void Setup() { }

	protected override void SetupNavMeshValues(bool isStopped, float speed, float searchPrecision, float searchWidth) { }

	public virtual void Spawned() { }

	public override void StateAuthorityChanged() { }

	public override void Stun(Vector3 position, float stunRange, float duration = 3, string hitName = "", NetworkBehaviourId source = null, AttenuationType attenType = 0) { }

	private bool TryGetRandomNavPoint(out NavPoint navPoint) { }

	private bool TryGetRandomNodeInRange(Vector3 position, float range, out NavPoint targetNode) { }

	protected override void UpdateChasing() { }

	protected override void UpdateMonsterBehaviour() { }

	public override void UpdateRoaming() { }

	public override void UpdateRoamingPath() { }

}

