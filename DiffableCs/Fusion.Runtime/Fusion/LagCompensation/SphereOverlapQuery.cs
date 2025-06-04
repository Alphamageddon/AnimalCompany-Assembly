namespace Fusion.LagCompensation;

public class SphereOverlapQuery : Query
{
	public Vector3 Center; //Field offset: 0x48
	public float Radius; //Field offset: 0x54
	private Collider[] _physXOverlapHits; //Field offset: 0x58
	private Collider2D[] _box2DOverlapHits; //Field offset: 0x60

	public SphereOverlapQuery(ref SphereOverlapQueryParams sphereOverlapParams) { }

	public SphereOverlapQuery(ref SphereOverlapQueryParams sphereOverlapParams, Collider[] physXOverlapHitsCache, Collider2D[] box2DOverlapHitsCache) { }

	protected virtual bool Check(ref AABB bounds) { }

	internal virtual bool NarrowPhase(IHitboxColliderContainer container, HashSet<Int32> candidates, List<HitboxHit> hits) { }

	internal bool NarrowPhaseSphere(ref HitboxCollider c, Vector3 origin, float radius, out Vector3 point, out Vector3 normal) { }

	internal virtual void PerformStaticQuery(NetworkRunner runner, List<LagCompensatedHit> hits, HitOptions options) { }

}

