namespace AnimalCompany;

[NetworkBehaviourWeaved(15)]
public class MobController : NetworkBehaviour, IDamageable, IStateAuthorityChanged, IGenMobSpawnable
{
	public static Action<MobController, Boolean> onMobDie; //Field offset: 0x0
	private const float DEBUG_THRESHOLD = 0.2; //Field offset: 0x0
	private static HashSet<MobController> _spawnedMobs; //Field offset: 0x8
	[DefaultForProperty("isDie", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isDie; //Field offset: 0x80
	[DefaultForProperty("_timerRevive", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer __timerRevive; //Field offset: 0x84
	[DefaultForProperty("health", 2, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _health; //Field offset: 0x88
	[DefaultForProperty("angerMeter", 3, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _angerMeter; //Field offset: 0x8C
	[DefaultForProperty("navAgentSpeed", 4, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _navAgentSpeed; //Field offset: 0x90
	[DefaultForProperty("navAgentAngularSpeed", 5, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _navAgentAngularSpeed; //Field offset: 0x94
	[DefaultForProperty("searchPrecision", 6, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _searchPrecision; //Field offset: 0x98
	[DefaultForProperty("searchWidth", 7, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _searchWidth; //Field offset: 0x9C
	[DefaultForProperty("targetPlayerID", 8, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _targetPlayerID; //Field offset: 0xA0
	[DefaultForProperty("_timerToChasing", 9, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float __timerToChasing; //Field offset: 0xA4
	[DefaultForProperty("_timerToSearching", 10, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float __timerToSearching; //Field offset: 0xA8
	[DefaultForProperty("_timerAttackInterval", 11, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float __timerAttackInterval; //Field offset: 0xAC
	private float _timerHoldAtNavPoint; //Field offset: 0xB0
	protected bool _isHoldAtNavPoint; //Field offset: 0xB4
	protected bool _isHoldAtNavPointChanged; //Field offset: 0xB5
	[SerializeField]
	protected MobData _mobData; //Field offset: 0xB8
	[SerializeField]
	protected MobView _mobView; //Field offset: 0xC0
	[SerializeField]
	protected NavMeshAgent _navMeshAgent; //Field offset: 0xC8
	[SerializeField]
	protected Transform _viewPoint; //Field offset: 0xD0
	[SerializeField]
	protected Transform _hearingPoint; //Field offset: 0xD8
	protected int viewDistanceIndex; //Field offset: 0xE0
	public int zoneId; //Field offset: 0xE4
	[SerializeField]
	private Nullable<NavZone> _navZone; //Field offset: 0xE8
	[SerializeField]
	private NavZone _navZoneInspector; //Field offset: 0x108
	private List<NavPoint> visitedPoints; //Field offset: 0x120
	private List<NavPoint> unvisitedPoints; //Field offset: 0x128
	[SerializeField]
	private NavPoint _nodeCurrent; //Field offset: 0x130
	[SerializeField]
	private NavPoint _nodeNext; //Field offset: 0x138
	[SerializeField]
	private NetPlayer _targetPlayer; //Field offset: 0x140
	[DefaultForProperty("_positionThatPlayerStayed", 12, 3)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Vector3 __positionThatPlayerStayed; //Field offset: 0x148
	private List<NavPoint> _pointsInRange; //Field offset: 0x158
	private float _timeUpdateStart; //Field offset: 0x160
	protected Action<String> _onUpdateFinish; //Field offset: 0x168
	private bool _isInitialized; //Field offset: 0x170

	[Networked]
	[NetworkedWeaved(12, 3)]
	public Vector3 _positionThatPlayerStayed
	{
		 get { } //Length: 100
		 set { } //Length: 100
	}

	protected Dictionary<UInt32, NetPlayer> _spawnedPlayers
	{
		 get { } //Length: 136
	}

	[Networked]
	[NetworkedWeaved(11, 1)]
	public float _timerAttackInterval
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(1, 1)]
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

	protected bool _updateValid
	{
		 get { } //Length: 68
	}

	[Networked]
	[NetworkedWeaved(3, 1)]
	public float angerMeter
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
	[NetworkedWeaved(2, 1)]
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

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	private NavPoint FindClosestNodeFromPosition(Vector3 position) { }

	public virtual void FixedUpdateNetwork() { }

	public override void GenGraphSetup(int navZone) { }

	public Vector3 get__positionThatPlayerStayed() { }

	protected Dictionary<UInt32, NetPlayer> get__spawnedPlayers() { }

	public float get__timerAttackInterval() { }

	private TickTimer get__timerRevive() { }

	public float get__timerToChasing() { }

	public float get__timerToSearching() { }

	protected bool get__updateValid() { }

	public float get_angerMeter() { }

	public MobData get_data() { }

	protected float get_deltaTime() { }

	public int get_health() { }

	public Transform get_hearingPoint() { }

	public bool get_isDie() { }

	public float get_navAgentAngularSpeed() { }

	public float get_navAgentSpeed() { }

	public NavZone get_navZone() { }

	public float get_searchPrecision() { }

	public float get_searchWidth() { }

	public static IEnumerable<MobController> get_spawnedMobs() { }

	public NetPlayer get_targetPlayer() { }

	public int get_targetPlayerID() { }

	public MobView get_view() { }

	public float get_viewDistance() { }

	public Transform get_viewPoint() { }

	protected override void HandleDie() { }

	protected override void HandleIsDieChanged() { }

	public override void HandlePlayerLeft(PlayerRef player) { }

	protected override void HandleRevive() { }

	public override void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName) { }

	private void InitializeNavMeshAgent() { }

	private void MarkExploredNodesInRange(Vector3 position, float range) { }

	private void OnDestroy() { }

	protected override void OnDrawGizmos() { }

	protected override void OnDrawGizmosSelected() { }

	private void OnUpdateFinish(string phase) { }

	private void ResetNavMeshAgent() { }

	private void ResetNavPointsVisited() { }

	protected void Respawn(Vector3 position) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_Hit(int damage) { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_Hit@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	protected override void RPC_SetViewIdle() { }

	[NetworkRpcWeavedInvoker(2, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_SetViewIdle@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	protected override void RPC_SetViewWalk(float speed) { }

	[NetworkRpcWeavedInvoker(3, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_SetViewWalk@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	public void set__positionThatPlayerStayed(Vector3 value) { }

	public void set__timerAttackInterval(float value) { }

	private void set__timerRevive(TickTimer value) { }

	public void set__timerToChasing(float value) { }

	public void set__timerToSearching(float value) { }

	public void set_angerMeter(float value) { }

	public void set_health(int value) { }

	public void set_isDie(bool value) { }

	public void set_navAgentAngularSpeed(float value) { }

	public void set_navAgentSpeed(float value) { }

	public void set_searchPrecision(float value) { }

	public void set_searchWidth(float value) { }

	public void set_targetPlayerID(int value) { }

	public void SetDie(bool isDie) { }

	protected override void SetNavAgentAngularSpeed(float speed) { }

	protected override void SetNavAgentSpeed(float speed) { }

	public override void SetRoamingTarget(bool initialize = false) { }

	public override void SetRoamingTarget(Vector3 position) { }

	public override void SetTargetPlayer(NetPlayer netPlayer) { }

	public override void Setup() { }

	protected override void SetupNavMeshValues(bool isStopped, float speed, float searchPrecision, float searchWidth) { }

	public virtual void Spawned() { }

	public override void StateAuthorityChanged() { }

	private bool TryGetRandomNavPoint(out NavPoint navPoint) { }

	private bool TryGetRandomNodeInRange(Vector3 position, float range, out NavPoint targetNode) { }

	protected override void UpdateChasing() { }

	public override void UpdateRoaming() { }

}

