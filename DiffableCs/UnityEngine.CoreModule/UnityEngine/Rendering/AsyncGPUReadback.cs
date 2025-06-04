namespace UnityEngine.Rendering;

[StaticAccessor("AsyncGPUReadbackManager::GetInstance()", StaticAccessorType::Dot (0))]
public static class AsyncGPUReadback
{

	public static AsyncGPUReadbackRequest Request(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback = null) { }

	[NativeMethod("Request")]
	private static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(GraphicsBuffer buffer, AsyncRequestNativeArrayData* data) { }

	private static void Request_Internal_GraphicsBuffer_1_Injected(GraphicsBuffer buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret) { }

}

