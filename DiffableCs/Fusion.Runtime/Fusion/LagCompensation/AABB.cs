namespace Fusion.LagCompensation;

[IsReadOnly]
public struct AABB
{
	public readonly Vector3 Center; //Field offset: 0x0
	public readonly Vector3 Extents; //Field offset: 0xC
	public readonly Vector3 Min; //Field offset: 0x18
	public readonly Vector3 Max; //Field offset: 0x24

	public AABB(Bounds bounds) { }

	public AABB(Vector3 center, Vector3 extents) { }

}

