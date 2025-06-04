namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[UsedByNativeCode]
public sealed class ComputeShader : object
{

	[FreeFunction("ComputeShaderScripting::DisableKeyword", HasExplicitThis = True)]
	public void DisableKeyword(string keyword) { }

	[NativeName("DispatchComputeShader")]
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[FreeFunction("ComputeShaderScripting::EnableKeyword", HasExplicitThis = True)]
	public void EnableKeyword(string keyword) { }

	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[RequiredByNativeCode]
	public int FindKernel(string name) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = True)]
	private void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetConstantBuffer", HasExplicitThis = True)]
	private void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<float>", HasExplicitThis = True)]
	public void SetFloat(int nameID, float val) { }

	public void SetFloat(string name, float val) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<int>", HasExplicitThis = True)]
	public void SetInt(int nameID, int val) { }

}

