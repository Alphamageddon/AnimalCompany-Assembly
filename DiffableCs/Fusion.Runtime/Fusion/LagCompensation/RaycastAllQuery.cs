namespace Fusion.LagCompensation;

public class RaycastAllQuery : RaycastQuery
{
	private RaycastHit[] _physXRaycastHits; //Field offset: 0xB8
	private RaycastHit2D[] _box2DRaycastHits; //Field offset: 0xC0

	public RaycastAllQuery(ref RaycastQueryParams raycastQueryParams) { }

	public RaycastAllQuery(ref RaycastQueryParams raycastQueryParams, RaycastHit[] physXRaycastHitsCache, RaycastHit2D[] box2DRaycastHitCache) { }

	internal virtual bool NarrowPhase(IHitboxColliderContainer container, HashSet<Int32> candidates, List<HitboxHit> hits) { }

	internal virtual void PerformStaticQuery(NetworkRunner runner, List<LagCompensatedHit> hits, HitOptions options) { }

}

