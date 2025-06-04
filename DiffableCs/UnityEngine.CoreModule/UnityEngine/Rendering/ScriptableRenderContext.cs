namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
{
	private static readonly ShaderTagId kRenderTypeTag; //Field offset: 0x0
	private IntPtr m_Ptr; //Field offset: 0x0

	private static ScriptableRenderContext() { }

	internal ScriptableRenderContext(IntPtr ptr) { }

	public void BeginRenderPass(int width, int height, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1) { }

	[FreeFunction("ScriptableRenderContext::BeginRenderPass")]
	private static void BeginRenderPass_Internal(IntPtr self, int width, int height, int volumeDepth, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex) { }

	public void BeginSubPass(NativeArray<Int32> colors, NativeArray<Int32> inputs, bool isDepthStencilReadOnly = false) { }

	public void BeginSubPass(NativeArray<Int32> colors, bool isDepthStencilReadOnly = false) { }

	[FreeFunction("ScriptableRenderContext::BeginSubPass")]
	private static void BeginSubPass_Internal(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly) { }

	public RendererList CreateRendererList(ref RendererListParams param) { }

	public RendererList CreateRendererList(RendererListDesc desc) { }

	private RendererList CreateRendererList_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	private static void CreateRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, out RendererList ret) { }

	public RendererList CreateSkyboxRendererList(Camera camera) { }

	public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix) { }

	public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR) { }

	private RendererList CreateSkyboxRendererList_Internal(Camera camera, int mode, Matrix4x4 proj, Matrix4x4 view, Matrix4x4 projR, Matrix4x4 viewR) { }

	private static void CreateSkyboxRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int mode, ref Matrix4x4 proj, ref Matrix4x4 view, ref Matrix4x4 projR, ref Matrix4x4 viewR, out RendererList ret) { }

	public CullingResults Cull(ref ScriptableCullingParameters parameters) { }

	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock stateBlock) { }

	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, NativeArray<ShaderTagId> tagValues, NativeArray<RenderStateBlock> stateBlocks) { }

	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings) { }

	private void DrawRenderers_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	private static void DrawRenderers_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	public void DrawShadows(ref ShadowDrawingSettings settings) { }

	private void DrawShadows_Internal(IntPtr shadowDrawingSettings) { }

	private static void DrawShadows_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawingSettings) { }

	public void DrawUIOverlay(Camera camera) { }

	private void DrawUIOverlay_Internal(Camera camera) { }

	private static void DrawUIOverlay_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera) { }

	public void DrawWireOverlay(Camera camera) { }

	private void DrawWireOverlay_Impl(Camera camera) { }

	private static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, Camera camera) { }

	[FreeFunction("PlayerEmitCanvasGeometryForCamera")]
	public static void EmitGeometryForCamera(Camera camera) { }

	public void EndRenderPass() { }

	[FreeFunction("ScriptableRenderContext::EndRenderPass")]
	private static void EndRenderPass_Internal(IntPtr self) { }

	public void EndSubPass() { }

	[FreeFunction("ScriptableRenderContext::EndSubPass")]
	private static void EndSubPass_Internal(IntPtr self) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ScriptableRenderContext other) { }

	public void ExecuteCommandBuffer(CommandBuffer commandBuffer) { }

	[NativeThrows]
	private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) { }

	private static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer) { }

	public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	[NativeThrows]
	private void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	private static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	internal void GetCameras(List<Camera> results) { }

	private void GetCameras_Internal(Type listType, object resultList) { }

	private static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, object resultList) { }

	public virtual int GetHashCode() { }

	[FreeFunction("InitializeSortSettings")]
	internal static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::Internal_Cull")]
	private static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	private static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, ref ScriptableRenderContext renderLoop, IntPtr results) { }

	public void InvokeOnRenderObjectCallback() { }

	private void InvokeOnRenderObjectCallback_Internal() { }

	private static void InvokeOnRenderObjectCallback_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	public void PrepareRendererListsAsync(List<RendererList> rendererLists) { }

	private void PrepareRendererListsAsync_Internal(object rendererLists) { }

	private static void PrepareRendererListsAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, object rendererLists) { }

	public RendererListStatus QueryRendererListStatus(RendererList rendererList) { }

	private RendererListStatus QueryRendererListStatus_Internal(RendererList handle) { }

	private static RendererListStatus QueryRendererListStatus_Internal_Injected(ref ScriptableRenderContext _unity_self, ref RendererList handle) { }

	public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye) { }

	public void SetupCameraProperties(Camera camera, bool stereoSetup = false) { }

	private void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye) { }

	private static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye) { }

	public void Submit() { }

	private void Submit_Internal() { }

	private static void Submit_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	public bool SubmitForRenderPassValidation() { }

	private bool SubmitForRenderPassValidation_Internal() { }

	private static bool SubmitForRenderPassValidation_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

}

