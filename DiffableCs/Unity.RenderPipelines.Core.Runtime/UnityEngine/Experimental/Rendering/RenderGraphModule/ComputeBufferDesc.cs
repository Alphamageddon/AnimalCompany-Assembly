namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public struct ComputeBufferDesc
{
	public int count; //Field offset: 0x0
	public int stride; //Field offset: 0x4
	public ComputeBufferType type; //Field offset: 0x8
	public string name; //Field offset: 0x10

	public ComputeBufferDesc(int count, int stride) { }

	public ComputeBufferDesc(int count, int stride, ComputeBufferType type) { }

	public virtual int GetHashCode() { }

}

