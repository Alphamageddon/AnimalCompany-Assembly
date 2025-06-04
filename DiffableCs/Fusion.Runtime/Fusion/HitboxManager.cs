namespace Fusion;

[AddComponentMenu("Fusion/Lag Compensation/Hitbox Manager")]
[DefaultExecutionOrder(2000)]
[DisallowMultipleComponent]
public sealed class HitboxManager : SimulationBehaviour, IAfterTick, IBeforeSimulation, ISpawned
{
	[InlineHelp]
	[ReadOnly]
	public int BVHDepth; //Field offset: 0x48
	[InlineHelp]
	[ReadOnly]
	public int BVHNodes; //Field offset: 0x4C
	[InlineHelp]
	[ReadOnly]
	public int TotalHitboxes; //Field offset: 0x50
	[InlineHelp]
	[ReadOnly]
	public LagCompensationDraw DrawInfo; //Field offset: 0x58
	private readonly List<LagCompensatedHit> _raycastHits; //Field offset: 0x60
	private RaycastQuery _raycastQuery; //Field offset: 0x68
	private RaycastAllQuery _raycastAllQuery; //Field offset: 0x70
	private SphereOverlapQuery _sphereOverlapQuery; //Field offset: 0x78
	private BoxOverlapQuery _boxOverlapQuery; //Field offset: 0x80
	private LagCompensationSettings _settings; //Field offset: 0x88
	private HitboxBuffer _hitboxBuffer; //Field offset: 0x90
	private readonly List<HitboxHit> _lagCompensatedHits; //Field offset: 0x98
	private LagCompensationStatisticsManager _lagCompStatManager; //Field offset: 0xA0

	public HitboxManager() { }

	private void AdvanceAndRegister(int tick, int dataTick) { }

	private override void Fusion.IAfterTick.AfterTick() { }

	private override void Fusion.IBeforeSimulation.BeforeSimulation(int forwardTickCount) { }

	private override void Fusion.ISpawned.Spawned() { }

	private static LagCompensatedHit GetClosestHit(List<LagCompensatedHit> hits) { }

	private List<HitboxRoot> GetObjects(NetworkRunner runner) { }

	public void GetPlayerTickAndAlpha(PlayerRef player, out Nullable<Int32>& tickFrom, out Nullable<Int32>& tickTo, out Nullable<Single>& alpha) { }

	public LagCompensationStatisticsSnapshot GetStatisticsSnapshot() { }

	private void Init(List<HitboxRoot> initialObjects) { }

	private void Init() { }

	private void InitQueries() { }

	public int OverlapBox(BoxOverlapQuery query, List<LagCompensatedHit> hits, bool clearHits = true) { }

	public int OverlapBox(Vector3 center, Vector3 extents, Quaternion orientation, PlayerRef player, List<LagCompensatedHit> hits, int layerMask = -1, HitOptions options = 0, bool clearHits = true, QueryTriggerInteraction queryTriggerInteraction = 0, PreProcessingDelegate preProcessRoots = null) { }

	public int OverlapBox(Vector3 center, Vector3 extents, Quaternion orientation, int tick, Nullable<Int32> tickTo, Nullable<Single> alpha, List<LagCompensatedHit> hits, int layerMask = -1, HitOptions options = 0, bool clearHits = true, QueryTriggerInteraction queryTriggerInteraction = 0, PreProcessingDelegate preProcessRoots = null) { }

	public int OverlapSphere(SphereOverlapQuery query, List<LagCompensatedHit> hits, bool clearHits = true) { }

	public int OverlapSphere(Vector3 origin, float radius, PlayerRef player, List<LagCompensatedHit> hits, int layerMask = -1, HitOptions options = 0, bool clearHits = true, QueryTriggerInteraction queryTriggerInteraction = 0, PreProcessingDelegate preProcessRoots = null) { }

	public int OverlapSphere(Vector3 origin, float radius, int tick, Nullable<Int32> tickTo, Nullable<Single> alpha, List<LagCompensatedHit> hits, int layerMask = -1, HitOptions options = 0, bool clearHits = true, QueryTriggerInteraction queryTriggerInteraction = 0, PreProcessingDelegate preProcessRoots = null) { }

	public void PositionRotation(Hitbox hitbox, int tick, out Vector3 position, out Quaternion rotation, bool subtickAccuracy = false, Nullable<Int32> tickTo = null, Nullable<Single> alpha = null) { }

	public void PositionRotation(Hitbox hitbox, PlayerRef player, out Vector3 position, out Quaternion rotation, bool subTickAccuracy = false) { }

	private void PositionRotationInternal(ref PositionRotationQueryParams param, out Vector3 position, out Quaternion rotation) { }

	private int QueryInternal(Query query, List<LagCompensatedHit> hits, bool clearHits) { }

	public bool Raycast(RaycastQuery query, out LagCompensatedHit hit) { }

	public bool Raycast(Vector3 origin, Vector3 direction, float length, int tick, Nullable<Int32> tickTo, Nullable<Single> alpha, out LagCompensatedHit hit, int layerMask = -1, HitOptions options = 0, QueryTriggerInteraction queryTriggerInteraction = 0, PreProcessingDelegate preProcessRoots = null) { }

	public bool Raycast(Vector3 origin, Vector3 direction, float length, PlayerRef player, out LagCompensatedHit hit, int layerMask = -1, HitOptions options = 0, QueryTriggerInteraction queryTriggerInteraction = 0, PreProcessingDelegate preProcessRoots = null) { }

	public int RaycastAll(RaycastAllQuery query, List<LagCompensatedHit> hits, bool clearHits = true) { }

	public int RaycastAll(Vector3 origin, Vector3 direction, float length, int tick, Nullable<Int32> tickTo, Nullable<Single> alpha, List<LagCompensatedHit> hits, int layerMask = -1, bool clearHits = true, HitOptions options = 0, QueryTriggerInteraction queryTriggerInteraction = 0, PreProcessingDelegate preProcessRoots = null) { }

	public int RaycastAll(Vector3 origin, Vector3 direction, float length, PlayerRef player, List<LagCompensatedHit> hits, int layerMask = -1, bool clearHits = true, HitOptions options = 0, QueryTriggerInteraction queryTriggerInteraction = 0, PreProcessingDelegate preProcessRoots = null) { }

	private void RegisterHitboxSnapshot(int tick, int dataTick) { }

	internal bool Remove(HitboxRoot root) { }

}

