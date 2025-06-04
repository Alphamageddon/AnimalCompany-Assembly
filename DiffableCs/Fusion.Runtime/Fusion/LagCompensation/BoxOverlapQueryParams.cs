namespace Fusion.LagCompensation;

public struct BoxOverlapQueryParams
{
	public QueryParams QueryParams; //Field offset: 0x0
	public Vector3 Center; //Field offset: 0x38
	public Vector3 Extents; //Field offset: 0x44
	public Quaternion Rotation; //Field offset: 0x50
	public int StaticHitsCapacity; //Field offset: 0x60

	public BoxOverlapQueryParams(QueryParams queryParams, Vector3 center, Vector3 extents, Quaternion rotation, int staticHitsCapacity) { }

}

