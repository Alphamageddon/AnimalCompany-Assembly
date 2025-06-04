namespace Fusion.LagCompensation;

public struct SphereOverlapQueryParams
{
	public QueryParams QueryParams; //Field offset: 0x0
	public Vector3 Center; //Field offset: 0x38
	public float Radius; //Field offset: 0x44
	public int StaticHitsCapacity; //Field offset: 0x48

	public SphereOverlapQueryParams(QueryParams queryParams, Vector3 center, float radius, int staticHitsCapacity) { }

}

