namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("ComputeBuffer ({handle.index})")]
public struct ComputeBufferHandle
{
	private static ComputeBufferHandle s_NullHandle; //Field offset: 0x0
	internal ResourceHandle handle; //Field offset: 0x0

	public static ComputeBufferHandle nullHandle
	{
		 get { } //Length: 88
	}

	private static ComputeBufferHandle() { }

	internal ComputeBufferHandle(int handle, bool shared = false) { }

	public static ComputeBufferHandle get_nullHandle() { }

	public bool IsValid() { }

	public static ComputeBuffer op_Implicit(ComputeBufferHandle buffer) { }

}

