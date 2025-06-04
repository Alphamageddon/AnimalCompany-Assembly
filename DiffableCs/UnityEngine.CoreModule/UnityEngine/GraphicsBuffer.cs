namespace UnityEngine;

[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[UsedByNativeCode]
public sealed class GraphicsBuffer : IDisposable
{
	[Flags]
	internal enum Target
	{
		Vertex = 1,
		Index = 2,
		CopySource = 4,
		CopyDestination = 8,
		Structured = 16,
		Raw = 32,
		Append = 64,
		Counter = 128,
		IndirectArguments = 256,
		Constant = 512,
	}

	[Flags]
	internal enum UsageFlags
	{
		None = 0,
		LockBufferForWrite = 1,
	}

	internal IntPtr m_Ptr; //Field offset: 0x10

	public string name
	{
		 set { } //Length: 68
	}

	public GraphicsBuffer(Target target, int count, int stride) { }

	[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
	private static void DestroyBuffer(GraphicsBuffer buf) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	[FreeFunction("GraphicsBuffer_Bindings::InitBuffer")]
	private static IntPtr InitBuffer(Target target, UsageFlags usageFlags, int count, int stride) { }

	private void InternalInitialization(Target target, UsageFlags usageFlags, int count, int stride) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	private static bool IsVertexIndexOrCopyOnly(Target target) { }

	public void Release() { }

	private static bool RequiresCompute(Target target) { }

	public void set_name(string value) { }

	public void SetData(NativeArray<T> data) { }

	public void SetData(NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::SetName", HasExplicitThis = True)]
	private void SetName(string name) { }

}

