namespace Fusion.LagCompensation;

public abstract class Query : IBoundsTraversalTest
{
	public QueryTriggerInteraction TriggerInteraction; //Field offset: 0x10
	public HitOptions Options; //Field offset: 0x14
	public LayerMask LayerMask; //Field offset: 0x18
	public PlayerRef Player; //Field offset: 0x1C
	public Nullable<Int32> Tick; //Field offset: 0x20
	public Void* UserArgs; //Field offset: 0x28
	public Nullable<Single> Alpha; //Field offset: 0x30
	public Nullable<Int32> TickTo; //Field offset: 0x38
	public PreProcessingDelegate PreProcessingDelegate; //Field offset: 0x40

	protected Query(ref QueryParams qParams) { }

	protected abstract bool Check(ref AABB bounds) { }

	internal HitboxHit CreateHitboxHit(ref HitboxCollider collider, Vector3 point, float distance, Vector3 normal) { }

	private override bool Fusion.LagCompensation.IBoundsTraversalTest.Check(ref AABB bounds) { }

	internal abstract bool NarrowPhase(IHitboxColliderContainer container, HashSet<Int32> candidates, List<HitboxHit> hits) { }

	internal abstract void PerformStaticQuery(NetworkRunner runner, List<LagCompensatedHit> hits, HitOptions options) { }

}

