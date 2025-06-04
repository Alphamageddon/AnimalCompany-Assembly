namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/Texture.h")]
[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[UsedByNativeCode]
public struct AsyncGPUReadbackRequest
{
	internal IntPtr m_Ptr; //Field offset: 0x0
	internal int m_Version; //Field offset: 0x8

	public bool done
	{
		 get { } //Length: 60
	}

	public bool hasError
	{
		 get { } //Length: 60
	}

	public int layerCount
	{
		 get { } //Length: 60
	}

	public int layerDataSize
	{
		 get { } //Length: 60
	}

	public bool get_done() { }

	public bool get_hasError() { }

	public int get_layerCount() { }

	public int get_layerDataSize() { }

	public NativeArray<T> GetData(int layer = 0) { }

	private IntPtr GetDataRaw(int layer) { }

	private static IntPtr GetDataRaw_Injected(ref AsyncGPUReadbackRequest _unity_self, int layer) { }

	private int GetLayerCount() { }

	private static int GetLayerCount_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	private int GetLayerDataSize() { }

	private static int GetLayerDataSize_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	private bool HasError() { }

	private static bool HasError_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	private bool IsDone() { }

	private static bool IsDone_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback) { }

	private static void SetScriptingCallback_Injected(ref AsyncGPUReadbackRequest _unity_self, Action<AsyncGPUReadbackRequest> callback) { }

	public void WaitForCompletion() { }

	private static void WaitForCompletion_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

}

