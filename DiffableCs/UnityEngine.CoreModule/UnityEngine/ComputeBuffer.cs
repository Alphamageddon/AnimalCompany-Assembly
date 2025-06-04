namespace UnityEngine;

[NativeClass("GraphicsBuffer")]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[UsedByNativeCode]
public sealed class ComputeBuffer : IDisposable
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public int count
	{
		 get { } //Length: 60
	}

	public string name
	{
		 set { } //Length: 68
	}

	public int stride
	{
		 get { } //Length: 60
	}

	private ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	public ComputeBuffer(int count, int stride) { }

	public ComputeBuffer(int count, int stride, ComputeBufferType type) { }

	[FreeFunction("GraphicsBuffer_Bindings::DestroyComputeBuffer")]
	private static void DestroyBuffer(ComputeBuffer buf) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public int get_count() { }

	public int get_stride() { }

	public void GetData(Array data) { }

	[FreeFunction("GraphicsBuffer_Bindings::InitComputeBuffer")]
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalGetData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	public void Release() { }

	public void set_name(string value) { }

	public void SetData(Array data) { }

	public void SetData(NativeArray<T> data) { }

	public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::SetName", HasExplicitThis = True)]
	private void SetName(string name) { }

}

