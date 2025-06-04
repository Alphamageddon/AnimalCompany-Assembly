namespace Fusion.LagCompensation;

internal class HitboxBuffer
{
	public class HitboxSnapshot : IHitboxColliderContainer
	{
		private const int HIGH_COLLIDERS_CAPACITY = 1024; //Field offset: 0x0
		private HitboxCollider[] _colliders; //Field offset: 0x10
		private int _collidersCount; //Field offset: 0x18
		private int _collidersTempCount; //Field offset: 0x1C
		private int _collidersFreeHead; //Field offset: 0x20
		internal ILagCompensationBroadphase _broadphase; //Field offset: 0x28
		internal int Tick; //Field offset: 0x30
		internal int DataTick; //Field offset: 0x34

		internal int CollidersCapacity
		{
			internal get { } //Length: 28
		}

		internal int CollidersCount
		{
			internal get { } //Length: 12
		}

		internal HitboxSnapshot(Mapper mapper, List<HitboxRoot> initialObjects, int hitboxCapacity, float expansionFactor) { }

		internal void Add(HitboxRoot h, LagCompensationStatisticsManager lagCompStatManager) { }

		internal void CopyFrom(int tick, int dataTick, HitboxSnapshot from) { }

		internal int get_CollidersCapacity() { }

		internal int get_CollidersCount() { }

		public override HitboxCollider GetCollider(int index) { }

		public override HitboxCollider GetNextCollider(out int index) { }

		public override HitboxCollider GetNextTempCollider(out int tmpIndex) { }

		public static void ProcessBroadphaseRootCandidates(Query query, IHitboxColliderContainer fromContainer, HashSet<HitboxRoot> rootCandidates, HashSet<Int32> processedColliderIndices, IHitboxColliderContainer toContainer = null) { }

		public void QueryBroadphase(Query query, HashSet<HitboxRoot> broadphaseCandidates) { }

		public override void ReleaseCollider(int index) { }

		public override void ReleaseTempColliders() { }

		internal bool Remove(HitboxRoot hr) { }

		private void ResizeCollidersArray(int minimumIncrease) { }

		internal void Update(HitboxRoot h, LagCompensationStatisticsManager lagCompStatManager) { }

	}

	internal HitboxSnapshot[] _buffer; //Field offset: 0x10
	private Mapper _mapper; //Field offset: 0x18
	private int _head; //Field offset: 0x20
	private int _advanced; //Field offset: 0x24
	internal int Tick; //Field offset: 0x28
	private readonly HashSet<HitboxRoot> _broadphaseCandidates; //Field offset: 0x30
	private readonly HashSet<Int32> _colliderCandidates; //Field offset: 0x38

	internal BVH BVH
	{
		internal get { } //Length: 168
	}

	internal HitboxSnapshot Current
	{
		internal get { } //Length: 52
	}

	internal int Length
	{
		internal get { } //Length: 28
	}

	internal HitboxBuffer(List<HitboxRoot> initialObjects, int bufferSize, int hitboxCapacity, float expansionFactor) { }

	internal void Add(HitboxRoot root, LagCompensationStatisticsManager lagCompStatManager) { }

	internal void Advance(int tick, int dataTick) { }

	internal BVH get_BVH() { }

	internal HitboxSnapshot get_Current() { }

	internal int get_Length() { }

	private void GetClosestSnapshotForTick(int tick, out HitboxSnapshot snapshot) { }

	private int GetClosestTick(Query query) { }

	private void InitColliderCandidatesForNarrowPhase(IHitboxColliderContainer container, HashSet<Int32> candidates) { }

	internal bool PerformQuery(Query query, List<HitboxHit> hits) { }

	internal void PositionQueryInternal(ref PositionRotationQueryParams param, out Vector3 position, out Quaternion rotation) { }

	internal void PosUpdateRefit() { }

	internal static Quaternion QuaternionFromMatrix(Matrix4x4 m) { }

	private void QueryBroadphase(Query query, HashSet<Int32> processedColliderIndices, out IHitboxColliderContainer container) { }

	internal bool Remove(HitboxRoot root) { }

	internal void Update(HitboxRoot root, LagCompensationStatisticsManager lagCompStatManager) { }

}

