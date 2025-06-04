namespace Fusion.LagCompensation;

public struct RaycastQueryParams
{
	public QueryParams QueryParams; //Field offset: 0x0
	public Vector3 Origin; //Field offset: 0x38
	public Vector3 Direction; //Field offset: 0x44
	public float Length; //Field offset: 0x50
	public int StaticHitsCapacity; //Field offset: 0x54

	public RaycastQueryParams(QueryParams queryParams, Vector3 origin, Vector3 direction, float length, int staticHitsCapacity = 64) { }

}

