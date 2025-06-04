namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public sealed class MaterialPropertyBlock
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public MaterialPropertyBlock() { }

	public void Clear() { }

	[ThreadSafe]
	private void Clear(bool keepMemory) { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = True)]
	private static IntPtr CreateImpl() { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = True, IsThreadSafe = True)]
	private static void DestroyImpl(IntPtr mpb) { }

	private void Dispose() { }

	protected virtual void Finalize() { }

	public void SetColor(int nameID, Color value) { }

	[NativeName("SetColorFromScript")]
	[ThreadSafe]
	private void SetColorImpl(int name, Color value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int nameID, float value) { }

	public void SetFloatArray(string name, Single[] values) { }

	private void SetFloatArray(int name, Single[] values, int count) { }

	[NativeName("SetFloatArrayFromScript")]
	[ThreadSafe]
	private void SetFloatArrayImpl(int name, Single[] values, int count) { }

	[NativeName("SetFloatFromScript")]
	[ThreadSafe]
	private void SetFloatImpl(int name, float value) { }

	public void SetInt(string name, int value) { }

	public void SetInt(int nameID, int value) { }

	public void SetInteger(int nameID, int value) { }

	[NativeName("SetIntFromScript")]
	[ThreadSafe]
	private void SetIntImpl(int name, int value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	public void SetMatrix(string name, Matrix4x4 value) { }

	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	[NativeName("SetMatrixArrayFromScript")]
	[ThreadSafe]
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[NativeName("SetMatrixFromScript")]
	[ThreadSafe]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	[NativeName("SetRenderTextureFromScript")]
	[ThreadSafe]
	private void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	public void SetTexture(int nameID, Texture value) { }

	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	[NativeName("SetTextureFromScript")]
	[ThreadSafe]
	private void SetTextureImpl(int name, Texture value) { }

	public void SetVector(string name, Vector4 value) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetVectorArray(string name, Vector4[] values) { }

	public void SetVectorArray(int nameID, Vector4[] values) { }

	private void SetVectorArray(int name, Vector4[] values, int count) { }

	[NativeName("SetVectorArrayFromScript")]
	[ThreadSafe]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[NativeName("SetVectorFromScript")]
	[ThreadSafe]
	private void SetVectorImpl(int name, Vector4 value) { }

	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

}

