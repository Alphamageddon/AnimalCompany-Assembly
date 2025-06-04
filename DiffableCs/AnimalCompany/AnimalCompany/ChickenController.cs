namespace AnimalCompany;

[NetworkBehaviourWeaved(21)]
public class ChickenController : MobController
{
	internal enum Phase
	{
		Spawned = 0,
		Incubating = 1,
		Noticed = 2,
		Chasing = 3,
		BackToNest = 4,
		Searching = 5,
		Die = 6,
	}

	private const int MAX_EGG_SPAWN_COUNT = 10; //Field offset: 0x0
	private const float RANGE_TO_BACK_TO_NEST = 35; //Field offset: 0x0
	private const float RANGE_TO_START_CHASE = 6; //Field offset: 0x0
	private const float RANGE_TO_NOTICE = 12; //Field offset: 0x0
	private const float SAFE_DISTANCE_FROM_NEST_TO_EGG_SQR = 1; //Field offset: 0x0
	private const float TIME_TO_SPAWN_EGG = 600; //Field offset: 0x0
	[DefaultForProperty("phase", 15, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Phase _phase; //Field offset: 0x1A4
	[DefaultForProperty("eggID", 16, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private NetworkId _eggID; //Field offset: 0x1A8
	[DefaultForProperty("nestPosition", 17, 3)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Vector3 _nestPosition; //Field offset: 0x1AC
	[DefaultForProperty("_timerToSpawnEgg", 20, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer __timerToSpawnEgg; //Field offset: 0x1B8
	[SerializeField]
	private ChickenView _chickenView; //Field offset: 0x1C0
	[SerializeField]
	private RandomSFX _angrySFX; //Field offset: 0x1C8
	[Header("Nest")]
	[SerializeField]
	private GameObject _nestPrefab; //Field offset: 0x1D0
	[SerializeField]
	private GameObject _nestInstance; //Field offset: 0x1D8
	[Header("Egg")]
	[SerializeField]
	private GameObject _eggPrefab; //Field offset: 0x1E0
	[SerializeField]
	private Transform _eggTransform; //Field offset: 0x1E8
	private Collider[] _chickenColliders; //Field offset: 0x1F0

	private Vector3 _attackPosition
	{
		private get { } //Length: 244
	}

	private Vector3 _eggSpawnPosition
	{
		private get { } //Length: 132
	}

	private Quaternion _eggSpawnRotation
	{
		private get { } //Length: 60
	}

	[Networked]
	[NetworkedWeaved(20, 1)]
	private TickTimer _timerToSpawnEgg
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	private float distanceToNest
	{
		private get { } //Length: 188
	}

	[Networked]
	[NetworkedWeaved(16, 1)]
	[OnChangedRender("HandleEggIDChanged")]
	public private NetworkId eggID
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(17, 3)]
	public private Vector3 nestPosition
	{
		 get { } //Length: 100
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(15, 1)]
	[OnChangedRender("HandlePhaseChanged")]
	public private Phase phase
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	public ChickenController() { }

	[CompilerGenerated]
	private void <SpawnEgg>b__46_0(NetworkRunner runner, NetworkObject o) { }

	[CompilerGenerated]
	private int <UpdateIncubating>b__50_0(NetPlayer a, NetPlayer b) { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private Vector3 get__attackPosition() { }

	private Vector3 get__eggSpawnPosition() { }

	private Quaternion get__eggSpawnRotation() { }

	private TickTimer get__timerToSpawnEgg() { }

	private float get_distanceToNest() { }

	public NetworkId get_eggID() { }

	public Vector3 get_nestPosition() { }

	public Phase get_phase() { }

	private bool GetIsEggStolen() { }

	protected virtual void HandleDie() { }

	private void HandleEggIDChanged() { }

	private void HandlePhaseChanged() { }

	protected virtual void HandleRevive() { }

	private void OnDestroy() { }

	protected virtual void OnDrawGizmos() { }

	private void set__timerToSpawnEgg(TickTimer value) { }

	private void set_eggID(NetworkId value) { }

	private void set_nestPosition(Vector3 value) { }

	private void set_phase(Phase value) { }

	private void SetBackToNest() { }

	private void SetChasing(NetPlayer targetPlayer) { }

	private void SetIncubating() { }

	private void SetNoticed(NetPlayer targetPlayer) { }

	private void SetSearching() { }

	public virtual void SetTargetPlayer(NetPlayer netPlayer) { }

	public virtual void Setup() { }

	private void SpawnEgg(Vector3 position, Quaternion rotation) { }

	private void SpawnEggIfNecessary(bool initialize = false) { }

	private void UpdateBackToNest() { }

	protected virtual void UpdateChasing() { }

	private void UpdateIncubating() { }

	protected virtual void UpdateMonsterBehaviour() { }

	private void UpdateNoticed() { }

	private void UpdateSearching() { }

}

