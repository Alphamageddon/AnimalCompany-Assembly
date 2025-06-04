namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/RayTracingShader.h")]
[NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[UsedByNativeCode]
public class CommandBuffer : IDisposable
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public string name
	{
		 set { } //Length: 68
	}

	public CommandBuffer() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = True)]
	public void BeginSample(string name) { }

	public void BeginSample(CustomSampler sampler) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample_CustomSampler", HasExplicitThis = True)]
	private void BeginSample_CustomSampler(CustomSampler sampler) { }

	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Identifier", HasExplicitThis = True)]
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[NativeMethod("ClearCommands")]
	public void Clear() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ClearRandomWriteTargets", HasExplicitThis = True, ThrowsException = True)]
	public void ClearRandomWriteTargets() { }

	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ClearRenderTarget", HasExplicitThis = True)]
	public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil) { }

	private void ClearRenderTarget_Injected(RTClearFlags clearFlags, ref Color backgroundColor, float depth, uint stencil) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ConfigureFoveatedRendering", HasExplicitThis = True)]
	public void ConfigureFoveatedRendering(IntPtr platformData) { }

	public GraphicsFence CreateAsyncGraphicsFence() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::CreateGPUFence_Internal", HasExplicitThis = True)]
	private IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::DisableScissorRect", HasExplicitThis = True, ThrowsException = True)]
	public void DisableScissorRect() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = True)]
	public void DisableShaderKeyword(string keyword) { }

	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	[ExcludeFromDocs]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	[ExcludeFromDocs]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[ExcludeFromDocs]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	public void DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[ExcludeFromDocs]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount) { }

	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[ExcludeFromDocs]
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	[ExcludeFromDocs]
	public void DrawRenderer(Renderer renderer, Material material) { }

	public void DrawRendererList(RendererList rendererList) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = True)]
	public void EnableShaderKeyword(string keyword) { }

	public void EndSample(CustomSampler sampler) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = True)]
	public void EndSample(string name) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample_CustomSampler", HasExplicitThis = True)]
	private void EndSample_CustomSampler(CustomSampler sampler) { }

	protected virtual void Finalize() { }

	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRTWithDescriptor", HasExplicitThis = True)]
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
	private static IntPtr InitBuffer() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchCompute", HasExplicitThis = True, ThrowsException = True)]
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = True)]
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstanced", HasExplicitThis = True)]
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawOcclusionMesh", HasExplicitThis = True)]
	private void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	private void Internal_DrawOcclusionMesh_Injected(ref RectInt normalizedCamViewport) { }

	[NativeMethod("AddDrawProcedural")]
	private void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	private void Internal_DrawProcedural_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[NativeMethod("AddDrawRenderer")]
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[NativeMethod("AddDrawRendererList")]
	private void Internal_DrawRendererList(RendererList rendererList) { }

	private void Internal_DrawRendererList_Injected(ref RendererList rendererList) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeConstantBufferParam", HasExplicitThis = True)]
	private void Internal_SetComputeConstantComputeBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeTextureParam", HasExplicitThis = True)]
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetSinglePassStereo", HasExplicitThis = True)]
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::MarkLateLatchMatrixShaderPropertyID", HasExplicitThis = True)]
	public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = True, IsThreadSafe = True)]
	private void ReleaseBuffer() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseTemporaryRT", HasExplicitThis = True)]
	public void ReleaseTemporaryRT(int nameID) { }

	public void set_name(string value) { }

	public void SetBufferData(ComputeBuffer buffer, Array data) { }

	public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt) { }

	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorArrayParam", HasExplicitThis = True)]
	public void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Vector4[] values) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorParam", HasExplicitThis = True)]
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	private void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	public void SetExecutionFlags(CommandBufferExecutionFlags flags) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetFoveatedRenderingMode", HasExplicitThis = True)]
	public void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode) { }

	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = True)]
	private void SetGlobalBufferInternal(int nameID, ComputeBuffer value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalColor", HasExplicitThis = True)]
	public void SetGlobalColor(int nameID, Color value) { }

	private void SetGlobalColor_Injected(int nameID, ref Color value) { }

	public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) { }

	public void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = True)]
	private void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = True)]
	private void SetGlobalConstantGraphicsBufferInternal(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[NativeMethod("AddSetGlobalDepthBias")]
	public void SetGlobalDepthBias(float bias, float slopeBias) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = True)]
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArray", HasExplicitThis = True, ThrowsException = True)]
	public void SetGlobalFloatArray(int nameID, Single[] values) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInt", HasExplicitThis = True)]
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInteger", HasExplicitThis = True)]
	public void SetGlobalInteger(int nameID, int value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrix", HasExplicitThis = True)]
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArray", HasExplicitThis = True, ThrowsException = True)]
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = True)]
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = True)]
	public void SetGlobalVector(int nameID, Vector4 value) { }

	public void SetGlobalVector(string name, Vector4 value) { }

	private void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArray", HasExplicitThis = True, ThrowsException = True)]
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetInstanceMultiplier", HasExplicitThis = True)]
	public void SetInstanceMultiplier(uint multiplier) { }

	public void SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetLateLatchProjectionMatrices", HasExplicitThis = True, ThrowsException = True)]
	public void SetLateLatchProjectionMatrices(Matrix4x4[] projectionMat) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetMaterialKeyword", HasExplicitThis = True)]
	private void SetMaterialKeyword(Material material, LocalKeyword keyword, bool value) { }

	private void SetMaterialKeyword_Injected(Material material, ref LocalKeyword keyword, bool value) { }

	public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt) { }

	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue) { }

	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Buffer", HasExplicitThis = True, ThrowsException = True)]
	private void SetRandomWriteTarget_GraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Texture", HasExplicitThis = True, ThrowsException = True)]
	private void SetRandomWriteTarget_Texture(int index, ref RenderTargetIdentifier rt) { }

	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel) { }

	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	private void SetRenderTargetMultiSubtarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	private void SetRenderTargetMultiSubtarget_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", HasExplicitThis = True, ThrowsException = True)]
	public void SetViewport(Rect pixelRect) { }

	private void SetViewport_Injected(ref Rect pixelRect) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewProjectionMatrices", HasExplicitThis = True, ThrowsException = True)]
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::UnmarkLateLatchMatrix", HasExplicitThis = True)]
	public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage) { }

	public void WaitOnAsyncGraphicsFence(GraphicsFence fence) { }

	public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::WaitOnGPUFence_Internal", HasExplicitThis = True)]
	private void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage) { }

}

