namespace Fusion.LagCompensation;

public class BoxOverlapQuery : Query
{
	public Vector3 Center; //Field offset: 0x48
	public Vector3 Extents; //Field offset: 0x54
	public Quaternion Rotation; //Field offset: 0x60
	private Collider[] _physXOverlapHits; //Field offset: 0x70
	private Collider2D[] _box2DOverlapHits; //Field offset: 0x78
	internal Vector3 AabbExtents; //Field offset: 0x80
	internal Vector3 _min; //Field offset: 0x8C
	internal Vector3 _max; //Field offset: 0x98
	internal BoxNarrowData _queryNarrowData; //Field offset: 0xA4

	public BoxOverlapQuery(ref BoxOverlapQueryParams boxOverlapParams) { }

	public BoxOverlapQuery(ref BoxOverlapQueryParams boxOverlapParams, Collider[] physXOverlapHitsCache, Collider2D[] box2DOverlapHitsCache) { }

	protected virtual bool Check(ref AABB bounds) { }

	internal virtual bool NarrowPhase(IHitboxColliderContainer container, HashSet<Int32> candidates, List<HitboxHit> hits) { }

	internal bool NarrowPhaseBox(ref BoxNarrowData boxQueryNarrowData, ref HitboxCollider c, bool computeDetailedInfo, out Vector3 hitPoint, out Vector3 hitNormal) { }

	internal virtual void PerformStaticQuery(NetworkRunner runner, List<LagCompensatedHit> hits, HitOptions options) { }

	internal BoxNarrowData PreComputeNarrowData() { }

	internal void SetTestSettings(Vector3 center, Vector3 extents) { }

}

