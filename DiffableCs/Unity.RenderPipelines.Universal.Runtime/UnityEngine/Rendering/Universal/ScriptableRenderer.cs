namespace UnityEngine.Rendering.Universal;

public abstract class ScriptableRenderer : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__132_0; //Field offset: 0x8
		public static RenderFunc<VFXProcessCameraPassData> <>9__134_0; //Field offset: 0x10
		public static RenderFunc<PassData> <>9__135_0; //Field offset: 0x18
		public static RenderFunc<DrawGizmosPassData> <>9__137_0; //Field offset: 0x20
		public static RenderFunc<BeginXRPassData> <>9__139_0; //Field offset: 0x28
		public static RenderFunc<EndXRPassData> <>9__141_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal void <BeginRenderGraphXRRendering>b__139_0(BeginXRPassData data, RenderGraphContext context) { }

		internal void <DrawRenderGraphGizmos>b__137_0(DrawGizmosPassData data, RenderGraphContext rgContext) { }

		internal void <EndRenderGraphXRRendering>b__141_0(EndXRPassData data, RenderGraphContext context) { }

		internal void <InitRenderGraphFrame>b__132_0(PassData data, RenderGraphContext rgContext) { }

		internal void <ProcessVFXCameraCommand>b__134_0(VFXProcessCameraPassData data, RenderGraphContext context) { }

		internal void <SetupRenderGraphCameraProperties>b__135_0(PassData data, RenderGraphContext context) { }

	}

	private class BeginXRPassData
	{
		public RenderingData renderingData; //Field offset: 0x10
		public CameraData cameraData; //Field offset: 0x2C8

		public BeginXRPassData() { }

	}

	private class DrawGizmosPassData
	{
		public RenderingData renderingData; //Field offset: 0x10
		public ScriptableRenderer renderer; //Field offset: 0x2C8
		public GizmoSubset gizmoSubset; //Field offset: 0x2D0

		public DrawGizmosPassData() { }

	}

	private class EndXRPassData
	{
		public RenderingData renderingData; //Field offset: 0x10
		public CameraData cameraData; //Field offset: 0x2C8

		public EndXRPassData() { }

	}

	private class PassData
	{
		internal RenderingData renderingData; //Field offset: 0x10
		internal ScriptableRenderer renderer; //Field offset: 0x2C8
		internal CameraData cameraData; //Field offset: 0x2D0
		internal bool isTargetBackbuffer; //Field offset: 0x4E0

		public PassData() { }

	}

	private static class Profiling
	{
		internal static class RenderBlock
		{
			private const string k_Name = "RenderPassBlock"; //Field offset: 0x0
			public static readonly ProfilingSampler beforeRendering; //Field offset: 0x0
			public static readonly ProfilingSampler mainRenderingOpaque; //Field offset: 0x8
			public static readonly ProfilingSampler mainRenderingTransparent; //Field offset: 0x10
			public static readonly ProfilingSampler afterRendering; //Field offset: 0x18

			private static RenderBlock() { }

		}

		internal static class RenderPass
		{
			private const string k_Name = "ScriptableRenderPass"; //Field offset: 0x0
			public static readonly ProfilingSampler configure; //Field offset: 0x0
			public static readonly ProfilingSampler setRenderPassAttachments; //Field offset: 0x8

			private static RenderPass() { }

		}

		public static readonly ProfilingSampler setMRTAttachmentsList; //Field offset: 0x0
		private const string k_Name = "ScriptableRenderer"; //Field offset: 0x0
		public static readonly ProfilingSampler setAttachmentList; //Field offset: 0x8
		public static readonly ProfilingSampler execute; //Field offset: 0x10
		public static readonly ProfilingSampler setupFrameData; //Field offset: 0x18
		public static readonly ProfilingSampler setPerCameraShaderVariables; //Field offset: 0x20
		public static readonly ProfilingSampler sortRenderPasses; //Field offset: 0x28
		public static readonly ProfilingSampler setupLights; //Field offset: 0x30
		public static readonly ProfilingSampler setupCamera; //Field offset: 0x38
		public static readonly ProfilingSampler vfxProcessCamera; //Field offset: 0x40
		public static readonly ProfilingSampler addRenderPasses; //Field offset: 0x48
		public static readonly ProfilingSampler setupRenderPasses; //Field offset: 0x50
		public static readonly ProfilingSampler clearRenderingState; //Field offset: 0x58
		public static readonly ProfilingSampler internalStartRendering; //Field offset: 0x60
		public static readonly ProfilingSampler internalFinishRendering; //Field offset: 0x68
		public static readonly ProfilingSampler drawGizmos; //Field offset: 0x70
		internal static readonly ProfilingSampler beginXRRendering; //Field offset: 0x78
		internal static readonly ProfilingSampler endXRRendering; //Field offset: 0x80

		private static Profiling() { }

	}

	public struct RenderBlocks : IDisposable
	{
		internal struct BlockRange : IDisposable
		{
			private int m_Current; //Field offset: 0x0
			private int m_End; //Field offset: 0x4

			public int Current
			{
				 get { } //Length: 8
			}

			public BlockRange(int begin, int end) { }

			public override void Dispose() { }

			public int get_Current() { }

			public BlockRange GetEnumerator() { }

			public bool MoveNext() { }

		}

		private NativeArray<RenderPassEvent> m_BlockEventLimits; //Field offset: 0x0
		private NativeArray<Int32> m_BlockRanges; //Field offset: 0x10
		private NativeArray<Int32> m_BlockRangeLengths; //Field offset: 0x20

		public RenderBlocks(List<ScriptableRenderPass> activeRenderPassQueue) { }

		public override void Dispose() { }

		private void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue) { }

		public int GetLength(int index) { }

		public BlockRange GetRange(int index) { }

	}

	internal class RenderingFeatures
	{
		[CompilerGenerated]
		private bool <cameraStacking>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private bool <msaa>k__BackingField; //Field offset: 0x11

		[Obsolete("cameraStacking has been deprecated use SupportedCameraRenderTypes() in ScriptableRenderer instead.", False)]
		public bool cameraStacking
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public bool msaa
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public RenderingFeatures() { }

		[CompilerGenerated]
		public bool get_cameraStacking() { }

		[CompilerGenerated]
		public bool get_msaa() { }

		[CompilerGenerated]
		public void set_cameraStacking(bool value) { }

		[CompilerGenerated]
		public void set_msaa(bool value) { }

	}

	private static class RenderPassBlock
	{
		public static readonly int BeforeRendering; //Field offset: 0x0
		public static readonly int MainRenderingOpaque; //Field offset: 0x4
		public static readonly int MainRenderingTransparent; //Field offset: 0x8
		public static readonly int AfterRendering; //Field offset: 0xC

		private static RenderPassBlock() { }

	}

	public struct RenderPassDescriptor
	{
		internal int w; //Field offset: 0x0
		internal int h; //Field offset: 0x4
		internal int samples; //Field offset: 0x8
		internal int depthID; //Field offset: 0xC

		internal RenderPassDescriptor(int width, int height, int sampleCount, int rtID) { }

	}

	public struct RTHandleRenderTargetIdentifierCompat
	{
		public RTHandle handle; //Field offset: 0x0
		public RenderTargetIdentifier fallback; //Field offset: 0x8

		public RenderTargetIdentifier nameID
		{
			 get { } //Length: 112
		}

		public bool useRTHandle
		{
			 get { } //Length: 16
		}

		public RenderTargetIdentifier get_nameID() { }

		public bool get_useRTHandle() { }

	}

	private class VFXProcessCameraPassData
	{
		internal CullingResults cullResults; //Field offset: 0x10
		internal Camera camera; //Field offset: 0x20

		public VFXProcessCameraPassData() { }

	}

	private const int kRenderPassMapSize = 10; //Field offset: 0x0
	internal static ScriptableRenderer current; //Field offset: 0x0
	private const int k_RenderPassBlockCount = 4; //Field offset: 0x0
	private const int kRenderPassMaxCount = 20; //Field offset: 0x0
	private static bool m_UseOptimizedStoreActions; //Field offset: 0x8
	protected static readonly RTHandle k_CameraTarget; //Field offset: 0x10
	private static RenderTargetIdentifier[] m_ActiveColorAttachments; //Field offset: 0x18
	private static RenderTargetIdentifier m_ActiveDepthAttachment; //Field offset: 0x20
	private static RenderBufferStoreAction[] m_ActiveColorStoreActions; //Field offset: 0x48
	private static RenderBufferStoreAction m_ActiveDepthStoreAction; //Field offset: 0x50
	private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopies; //Field offset: 0x58
	private static Plane[] s_Planes; //Field offset: 0x60
	private static Vector4[] s_VectorPlanes; //Field offset: 0x68
	private int m_LastBeginSubpassPassIndex; //Field offset: 0x10
	private Dictionary<Hash128, Int32[]> m_MergeableRenderPassesMap; //Field offset: 0x18
	private Int32[][] m_MergeableRenderPassesMapArrays; //Field offset: 0x20
	private Hash128[] m_PassIndexToPassHash; //Field offset: 0x28
	private Dictionary<Hash128, Int32> m_RenderPassesAttachmentCount; //Field offset: 0x30
	private AttachmentDescriptor[] m_ActiveColorAttachmentDescriptors; //Field offset: 0x38
	private AttachmentDescriptor m_ActiveDepthAttachmentDescriptor; //Field offset: 0x40
	private Boolean[] m_IsActiveColorAttachmentTransient; //Field offset: 0xB8
	internal RenderBufferStoreAction[] m_FinalColorStoreAction; //Field offset: 0xC0
	internal RenderBufferStoreAction m_FinalDepthStoreAction; //Field offset: 0xC8
	[CompilerGenerated]
	private ProfilingSampler <profilingExecute>k__BackingField; //Field offset: 0xD0
	internal bool hasReleasedRTs; //Field offset: 0xD8
	[CompilerGenerated]
	private readonly DebugHandler <DebugHandler>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private RenderingFeatures <supportedRenderingFeatures>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private GraphicsDeviceType[] <unsupportedGraphicsDeviceTypes>k__BackingField; //Field offset: 0xF0
	private StoreActionsOptimization m_StoreActionsOptimizationSetting; //Field offset: 0xF8
	private List<ScriptableRenderPass> m_ActiveRenderPassQueue; //Field offset: 0x100
	private List<ScriptableRendererFeature> m_RendererFeatures; //Field offset: 0x108
	private RTHandleRenderTargetIdentifierCompat m_CameraColorTarget; //Field offset: 0x110
	private RTHandleRenderTargetIdentifierCompat m_CameraDepthTarget; //Field offset: 0x140
	private RTHandleRenderTargetIdentifierCompat m_CameraResolveTarget; //Field offset: 0x170
	private bool m_FirstTimeCameraColorTargetIsBound; //Field offset: 0x1A0
	private bool m_FirstTimeCameraDepthTargetIsBound; //Field offset: 0x1A1
	private bool m_IsPipelineExecuting; //Field offset: 0x1A2
	internal bool disableNativeRenderPassInFeatures; //Field offset: 0x1A3
	internal bool useRenderPassEnabled; //Field offset: 0x1A4
	[CompilerGenerated]
	private bool <useDepthPriming>k__BackingField; //Field offset: 0x1A5
	[CompilerGenerated]
	private bool <stripShadowsOffVariants>k__BackingField; //Field offset: 0x1A6
	[CompilerGenerated]
	private bool <stripAdditionalLightOffVariants>k__BackingField; //Field offset: 0x1A7

	protected List<ScriptableRenderPass> activeRenderPassQueue
	{
		 get { } //Length: 8
	}

	[Obsolete("Use cameraColorTargetHandle")]
	public RenderTargetIdentifier cameraColorTarget
	{
		 get { } //Length: 188
	}

	public RTHandle cameraColorTargetHandle
	{
		 get { } //Length: 132
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("cameraDepth has been renamed to cameraDepthTarget. (UnityUpgradable) -> cameraDepthTarget")]
	public RenderTargetIdentifier cameraDepth
	{
		 get { } //Length: 60
	}

	[Obsolete("Use cameraDepthTargetHandle")]
	public RenderTargetIdentifier cameraDepthTarget
	{
		 get { } //Length: 188
	}

	public RTHandle cameraDepthTargetHandle
	{
		 get { } //Length: 132
	}

	internal DebugHandler DebugHandler
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	protected ProfilingSampler profilingExecute
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected List<ScriptableRendererFeature> rendererFeatures
	{
		 get { } //Length: 8
	}

	internal bool stripAdditionalLightOffVariants
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	internal bool stripShadowsOffVariants
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public RenderingFeatures supportedRenderingFeatures
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	internal bool useDepthPriming
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	private static ScriptableRenderer() { }

	public ScriptableRenderer(ScriptableRendererData data) { }

	internal void AddRenderPasses(ref RenderingData renderingData) { }

	internal static bool AreAttachmentIndicesCompatible(ScriptableRenderPass lastSubPass, ScriptableRenderPass currentSubPass) { }

	private void BeginRenderGraphXRRendering(RenderGraph renderGraph, ref RenderingData renderingData) { }

	private void BeginXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData) { }

	private static void CalculateBillboardProperties(in Matrix4x4 worldToCameraMatrix, out Vector3 billboardTangent, out Vector3 billboardNormal, out float cameraXZAngle) { }

	internal void Clear(CameraRenderType cameraType) { }

	private static void ClearRenderingState(CommandBuffer cmd) { }

	internal static void ConfigureActiveTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment) { }

	internal void ConfigureCameraColorTarget(RTHandle colorTarget) { }

	[Obsolete("Use RTHandle for colorTarget")]
	internal void ConfigureCameraColorTarget(RenderTargetIdentifier colorTarget) { }

	[Obsolete("Use RTHandles for colorTarget, depthTarget and resolveTarget")]
	internal void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget, RenderTargetIdentifier resolveTarget) { }

	public void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget) { }

	internal void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget, RTHandle resolveTarget) { }

	[Obsolete("Use RTHandles for colorTarget and depthTarget")]
	public void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget) { }

	internal static Hash128 CreateRenderPassHash(RenderPassDescriptor desc, uint hashIndex) { }

	internal static Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	[Conditional("UNITY_EDITOR")]
	private void DrawGizmos(ScriptableRenderContext context, Camera camera, GizmoSubset gizmoSubset, ref RenderingData renderingData) { }

	internal void DrawRenderGraphGizmos(RenderGraph renderGraph, TextureHandle color, TextureHandle depth, GizmoSubset gizmoSubset, ref RenderingData renderingData) { }

	[Conditional("UNITY_EDITOR")]
	private void DrawWireOverlay(ScriptableRenderContext context, Camera camera) { }

	internal override void EnableSwapBufferMSAA(bool enable) { }

	private void EndRenderGraphXRRendering(RenderGraph renderGraph, ref RenderingData renderingData) { }

	private void EndXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData) { }

	public void EnqueuePass(ScriptableRenderPass pass) { }

	public void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private void ExecuteBlock(int blockIndex, in RenderBlocks renderBlocks, ScriptableRenderContext context, ref RenderingData renderingData, bool submit = false) { }

	internal void ExecuteNativeRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref CameraData cameraData, ref RenderingData renderingData) { }

	private void ExecuteRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref RenderingData renderingData) { }

	internal static int FindAttachmentDescriptorIndexInList(RenderTargetIdentifier target, AttachmentDescriptor[] attachmentDescriptors) { }

	internal static int FindAttachmentDescriptorIndexInList(int attachmentIdx, AttachmentDescriptor attachmentDescriptor, AttachmentDescriptor[] attachmentDescriptors) { }

	internal void FinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public override void FinishRendering(CommandBuffer cmd) { }

	protected List<ScriptableRenderPass> get_activeRenderPassQueue() { }

	public RenderTargetIdentifier get_cameraColorTarget() { }

	public RTHandle get_cameraColorTargetHandle() { }

	public RenderTargetIdentifier get_cameraDepth() { }

	public RenderTargetIdentifier get_cameraDepthTarget() { }

	public RTHandle get_cameraDepthTargetHandle() { }

	[CompilerGenerated]
	internal DebugHandler get_DebugHandler() { }

	[CompilerGenerated]
	protected ProfilingSampler get_profilingExecute() { }

	protected List<ScriptableRendererFeature> get_rendererFeatures() { }

	[CompilerGenerated]
	internal bool get_stripAdditionalLightOffVariants() { }

	[CompilerGenerated]
	internal bool get_stripShadowsOffVariants() { }

	[CompilerGenerated]
	public RenderingFeatures get_supportedRenderingFeatures() { }

	[CompilerGenerated]
	public GraphicsDeviceType[] get_unsupportedGraphicsDeviceTypes() { }

	[CompilerGenerated]
	internal bool get_useDepthPriming() { }

	protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData) { }

	internal override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd) { }

	internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd) { }

	internal static RTHandle GetFirstAllocatedRTHandle(ScriptableRenderPass pass) { }

	internal static void GetRenderTextureDescriptor(ref CameraData cameraData, ScriptableRenderPass renderPass, out RenderTextureDescriptor targetRT) { }

	internal static uint GetSubPassAttachmentIndicesCount(ScriptableRenderPass pass) { }

	internal static uint GetValidColorAttachmentCount(AttachmentDescriptor[] colorAttachments) { }

	internal static int GetValidInputAttachmentCount(ScriptableRenderPass renderPass) { }

	internal static int GetValidPassIndexCount(Int32[] array) { }

	private RenderPassDescriptor InitializeRenderPassDescriptor(ref CameraData cameraData, ScriptableRenderPass renderPass) { }

	private void InitRenderGraphFrame(RenderGraph renderGraph, ref RenderingData renderingData) { }

	private void InternalFinishRendering(bool resolveFinalTarget, RenderingData renderingData) { }

	private void InternalFinishRendering(ScriptableRenderContext context, bool resolveFinalTarget, RenderingData renderingData) { }

	private void InternalStartRendering(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private bool IsDepthOnlyRenderTexture(RenderTexture t) { }

	private bool IsRenderPassEnabled(ScriptableRenderPass renderPass) { }

	internal override void OnFinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal void OnPreCullRenderPasses(in CameraData cameraData) { }

	internal override void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal static bool PassHasInputAttachments(ScriptableRenderPass renderPass) { }

	internal void ProcessVFXCameraCommand(RenderGraph renderGraph, ref RenderingData renderingData) { }

	internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData, RenderPassEvent injectionPoint) { }

	internal void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal override void ReleaseRenderTargets() { }

	internal void ResetNativeRenderPassFrameData() { }

	[CompilerGenerated]
	protected void set_profilingExecute(ProfilingSampler value) { }

	[CompilerGenerated]
	internal void set_stripAdditionalLightOffVariants(bool value) { }

	[CompilerGenerated]
	internal void set_stripShadowsOffVariants(bool value) { }

	[CompilerGenerated]
	public void set_supportedRenderingFeatures(RenderingFeatures value) { }

	[CompilerGenerated]
	public void set_unsupportedGraphicsDeviceTypes(GraphicsDeviceType[] value) { }

	[CompilerGenerated]
	internal void set_useDepthPriming(bool value) { }

	public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices) { }

	internal static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices, bool isTargetFlipped) { }

	internal void SetNativeRenderPassAttachmentList(ScriptableRenderPass renderPass, ref CameraData cameraData, RTHandle passColorAttachment, RTHandle passDepthAttachment, ClearFlag finalClearFlag, Color finalClearColor) { }

	internal void SetNativeRenderPassMRTAttachmentList(ScriptableRenderPass renderPass, ref CameraData cameraData, bool needCustomCameraColorClear, ClearFlag cameraClearFlag) { }

	private void SetPerCameraBillboardProperties(CommandBuffer cmd, ref CameraData cameraData) { }

	private void SetPerCameraClippingPlaneProperties(CommandBuffer cmd, in CameraData cameraData, bool isTargetFlipped) { }

	private void SetPerCameraClippingPlaneProperties(CommandBuffer cmd, ref CameraData cameraData) { }

	internal void SetPerCameraProperties(ScriptableRenderContext context, ref CameraData cameraData, Camera camera, CommandBuffer cmd) { }

	private void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData, bool isTargetFlipped) { }

	private void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData) { }

	private void SetRenderPassAttachments(CommandBuffer cmd, ScriptableRenderPass renderPass, ref CameraData cameraData) { }

	[Obsolete("Use RTHandle for colorAttachments")]
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorAttachments, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction) { }

	private static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor) { }

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor) { }

	private static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor) { }

	[Obsolete("Use RTHandle for colorAttachment")]
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor) { }

	private static void SetRenderTarget(CommandBuffer cmd, RTHandle[] colorAttachments, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	[Obsolete("Use RTHandles for colorAttachments and depthAttachment")]
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction) { }

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	private static void SetShaderTimeValues(CommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime) { }

	public abstract void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	internal void SetupInputAttachmentIndices(ScriptableRenderPass pass) { }

	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal void SetupNativeRenderPassFrameData(ref CameraData cameraData, bool isRenderPassEnabled) { }

	internal void SetupRenderGraphCameraProperties(RenderGraph renderGraph, ref RenderingData renderingData, bool isTargetBackbuffer) { }

	protected void SetupRenderPasses(in RenderingData renderingData) { }

	internal void SetupTransientInputAttachments(int attachmentCount) { }

	internal static void SortStable(List<ScriptableRenderPass> list) { }

	public override int SupportedCameraStackingTypes() { }

	public bool SupportsCameraStackingType(CameraRenderType cameraRenderType) { }

	internal override void SwapColorBuffer(CommandBuffer cmd) { }

	internal void UpdateFinalStoreActions(Int32[] currentMergeablePasses, ref CameraData cameraData) { }

}

