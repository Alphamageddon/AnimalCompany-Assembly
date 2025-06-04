namespace Fusion.LagCompensation;

public class RaycastQuery : Query
{
	public Vector3 Direction; //Field offset: 0x48
	public Vector3 Origin; //Field offset: 0x54
	public float Length; //Field offset: 0x60
	private RaycastHit _raycastHit; //Field offset: 0x64
	private RaycastHit2D _raycastHit2D; //Field offset: 0x90

	public RaycastQuery(ref RaycastQueryParams raycastQueryParams) { }

	protected virtual bool Check(ref AABB bounds) { }

	internal virtual bool NarrowPhase(IHitboxColliderContainer container, HashSet<Int32> candidates, List<HitboxHit> hits) { }

	internal bool NarrowPhaseRay(ref HitboxCollider c, Vector3 origin, Vector3 direction, float length, out Vector3 point, out Vector3 normal, out float distance) { }

	internal virtual void PerformStaticQuery(NetworkRunner runner, List<LagCompensatedHit> hits, HitOptions options) { }

}

