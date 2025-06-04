namespace UnityEngine.Rendering.Universal.UTess;

internal struct UTriangle
{
	public float2 va; //Field offset: 0x0
	public float2 vb; //Field offset: 0x8
	public float2 vc; //Field offset: 0x10
	public UCircle c; //Field offset: 0x18
	public float area; //Field offset: 0x24
	public int3 indices; //Field offset: 0x28

}

