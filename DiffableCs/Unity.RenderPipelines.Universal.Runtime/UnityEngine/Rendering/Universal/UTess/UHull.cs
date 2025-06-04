namespace UnityEngine.Rendering.Universal.UTess;

internal struct UHull
{
	public float2 a; //Field offset: 0x0
	public float2 b; //Field offset: 0x8
	public int idx; //Field offset: 0x10
	public ArraySlice<Int32> ilarray; //Field offset: 0x18
	public int ilcount; //Field offset: 0x28
	public ArraySlice<Int32> iuarray; //Field offset: 0x30
	public int iucount; //Field offset: 0x40

}

