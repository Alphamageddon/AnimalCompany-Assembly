namespace UnityEngine.Rendering.Universal;

public sealed class UniversalRenderer : ScriptableRenderer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<ScriptableRenderPass> <>9__90_0; //Field offset: 0x8
		public static Predicate<ScriptableRenderPass> <>9__90_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Setup>b__90_0(ScriptableRenderPass x) { }

		internal bool <Setup>b__90_1(ScriptableRenderPass x) { }

	}

	private static class Profiling
	{
		private const string k_Name = "UniversalRenderer"; //Field offset: 0x0
		public static readonly ProfilingSampler createCameraRenderTarget; //Field offset: 0x0

		private static Profiling() { }

	}

	public class RenderGraphFrameResources
	{
		internal TextureHandle backBufferColor; //Field offset: 0x10
		internal TextureHandle cameraColor; //Field offset: 0x18
		internal TextureHandle cameraDepth; //Field offset: 0x20
		internal TextureHandle mainShadowsTexture; //Field offset: 0x28
		internal TextureHandle additionalShadowsTexture; //Field offset: 0x30
		internal TextureHandle[] gbuffer; //Field offset: 0x38
		internal TextureHandle cameraOpaqueTexture; //Field offset: 0x40
		internal TextureHandle cameraDepthTexture; //Field offset: 0x48
		internal TextureHandle cameraNormalsTexture; //Field offset: 0x50
		internal TextureHandle motionVectorColor; //Field offset: 0x58
		internal TextureHandle motionVectorDepth; //Field offset: 0x60
		internal TextureHandle internalColorLut; //Field offset: 0x68
		internal TextureHandle overlayUITexture; //Field offset: 0x70

		public RenderGraphFrameResources() { }

	}

	private struct RenderPassInputSummary
	{
		internal bool requiresDepthTexture; //Field offset: 0x0
		internal bool requiresDepthPrepass; //Field offset: 0x1
		internal bool requiresNormalsTexture; //Field offset: 0x2
		internal bool requiresColorTexture; //Field offset: 0x3
		internal bool requiresColorTextureCreated; //Field offset: 0x4
		internal bool requiresMotionVectors; //Field offset: 0x5
		internal RenderPassEvent requiresDepthNormalAtEvent; //Field offset: 0x8
		internal RenderPassEvent requiresDepthTextureEarliestEvent; //Field offset: 0xC

	}

	private const GraphicsFormat k_DepthStencilFormat = 92; //Field offset: 0x0
	private const int k_DepthBufferBits = 24; //Field offset: 0x0
	private const int k_FinalBlitPassQueueOffset = 1; //Field offset: 0x0
	private const int k_AfterFinalBlitPassQueueOffset = 2; //Field offset: 0x0
	private static readonly List<ShaderTagId> k_DepthNormalsOnly; //Field offset: 0x0
	private static RTHandle m_RenderGraphCameraColorHandle; //Field offset: 0x8
	private static RTHandle m_RenderGraphCameraDepthHandle; //Field offset: 0x10
	internal static TextureHandle m_ActiveRenderGraphColor; //Field offset: 0x18
	internal static TextureHandle m_ActiveRenderGraphDepth; //Field offset: 0x20
	private static bool m_UseIntermediateTexture; //Field offset: 0x28
	private bool m_Clustering; //Field offset: 0x1A8
	private DepthOnlyPass m_DepthPrepass; //Field offset: 0x1B0
	private DepthNormalOnlyPass m_DepthNormalPrepass; //Field offset: 0x1B8
	private CopyDepthPass m_PrimedDepthCopyPass; //Field offset: 0x1C0
	private MotionVectorRenderPass m_MotionVectorPass; //Field offset: 0x1C8
	private MainLightShadowCasterPass m_MainLightShadowCasterPass; //Field offset: 0x1D0
	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass; //Field offset: 0x1D8
	private GBufferPass m_GBufferPass; //Field offset: 0x1E0
	private CopyDepthPass m_GBufferCopyDepthPass; //Field offset: 0x1E8
	private DeferredPass m_DeferredPass; //Field offset: 0x1F0
	private DrawObjectsPass m_RenderOpaqueForwardOnlyPass; //Field offset: 0x1F8
	private DrawObjectsPass m_RenderOpaqueForwardPass; //Field offset: 0x200
	private DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass; //Field offset: 0x208
	private DrawSkyboxPass m_DrawSkyboxPass; //Field offset: 0x210
	private CopyDepthPass m_CopyDepthPass; //Field offset: 0x218
	private CopyColorPass m_CopyColorPass; //Field offset: 0x220
	private TransparentSettingsPass m_TransparentSettingsPass; //Field offset: 0x228
	private DrawObjectsPass m_RenderTransparentForwardPass; //Field offset: 0x230
	private InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass; //Field offset: 0x238
	private FinalBlitPass m_FinalBlitPass; //Field offset: 0x240
	private CapturePass m_CapturePass; //Field offset: 0x248
	private XROcclusionMeshPass m_XROcclusionMeshPass; //Field offset: 0x250
	private CopyDepthPass m_XRCopyDepthPass; //Field offset: 0x258
	private DrawScreenSpaceUIPass m_DrawOffscreenUIPass; //Field offset: 0x260
	private DrawScreenSpaceUIPass m_DrawOverlayUIPass; //Field offset: 0x268
	internal RenderTargetBufferSystem m_ColorBufferSystem; //Field offset: 0x270
	internal RTHandle m_ActiveCameraColorAttachment; //Field offset: 0x278
	private RTHandle m_ColorFrontBuffer; //Field offset: 0x280
	internal RTHandle m_ActiveCameraDepthAttachment; //Field offset: 0x288
	internal RTHandle m_CameraDepthAttachment; //Field offset: 0x290
	private RTHandle m_XRTargetHandleAlias; //Field offset: 0x298
	internal RTHandle m_DepthTexture; //Field offset: 0x2A0
	private RTHandle m_NormalsTexture; //Field offset: 0x2A8
	private RTHandle m_DecalLayersTexture; //Field offset: 0x2B0
	private RTHandle m_OpaqueColor; //Field offset: 0x2B8
	private RTHandle m_MotionVectorColor; //Field offset: 0x2C0
	private RTHandle m_MotionVectorDepth; //Field offset: 0x2C8
	private ForwardLights m_ForwardLights; //Field offset: 0x2D0
	private DeferredLights m_DeferredLights; //Field offset: 0x2D8
	private RenderingMode m_RenderingMode; //Field offset: 0x2E0
	private DepthPrimingMode m_DepthPrimingMode; //Field offset: 0x2E4
	private CopyDepthMode m_CopyDepthMode; //Field offset: 0x2E8
	private bool m_DepthPrimingRecommended; //Field offset: 0x2EC
	private StencilState m_DefaultStencilState; //Field offset: 0x2ED
	private LightCookieManager m_LightCookieManager; //Field offset: 0x300
	private IntermediateTextureMode m_IntermediateTextureMode; //Field offset: 0x308
	private bool m_VulkanEnablePreTransform; //Field offset: 0x30C
	private Material m_BlitMaterial; //Field offset: 0x310
	private Material m_BlitHDRMaterial; //Field offset: 0x318
	private Material m_CopyDepthMaterial; //Field offset: 0x320
	private Material m_SamplingMaterial; //Field offset: 0x328
	private Material m_StencilDeferredMaterial; //Field offset: 0x330
	private Material m_CameraMotionVecMaterial; //Field offset: 0x338
	private Material m_ObjectMotionVecMaterial; //Field offset: 0x340
	private PostProcessPasses m_PostProcessPasses; //Field offset: 0x348
	internal bool m_TargetIsBackbuffer; //Field offset: 0x388
	internal RenderGraphFrameResources frameResources; //Field offset: 0x390

	internal bool accurateGbufferNormals
	{
		internal get { } //Length: 32
	}

	internal RTHandle colorGradingLut
	{
		internal get { } //Length: 8
	}

	internal ColorGradingLutPass colorGradingLutPass
	{
		internal get { } //Length: 8
	}

	internal DeferredLights deferredLights
	{
		internal get { } //Length: 8
	}

	public DepthPrimingMode depthPrimingMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	internal PostProcessPass finalPostProcessPass
	{
		internal get { } //Length: 8
	}

	internal PostProcessPass postProcessPass
	{
		internal get { } //Length: 8
	}

	internal RenderingMode renderingModeActual
	{
		internal get { } //Length: 112
	}

	internal RenderingMode renderingModeRequested
	{
		internal get { } //Length: 8
	}

	private static UniversalRenderer() { }

	public UniversalRenderer(UniversalRendererData data) { }

	private bool CanCopyDepth(ref CameraData cameraData) { }

	private void CleanupRenderGraphResources() { }

	private void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, bool primedDepth, CommandBuffer cmd, ref CameraData cameraData) { }

	private void CreateRenderGraphCameraRenderTargets(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1) { }

	protected virtual void Dispose(bool disposing) { }

	internal virtual void EnableSwapBufferMSAA(bool enable) { }

	private void EnqueueDeferred(ref RenderingData renderingData, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow) { }

	public virtual void FinishRendering(CommandBuffer cmd) { }

	internal bool get_accurateGbufferNormals() { }

	internal RTHandle get_colorGradingLut() { }

	internal ColorGradingLutPass get_colorGradingLutPass() { }

	internal DeferredLights get_deferredLights() { }

	public DepthPrimingMode get_depthPrimingMode() { }

	internal PostProcessPass get_finalPostProcessPass() { }

	internal PostProcessPass get_postProcessPass() { }

	internal RenderingMode get_renderingModeActual() { }

	internal RenderingMode get_renderingModeRequested() { }

	internal virtual RTHandle GetCameraColorBackBuffer(CommandBuffer cmd) { }

	internal virtual RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd) { }

	private RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData) { }

	private bool IsDepthPrimingEnabled(ref CameraData cameraData) { }

	private bool IsGLDevice() { }

	private bool IsGLESDevice() { }

	public static bool IsOffscreenDepthTexture(in CameraData cameraData) { }

	private bool IsWebGL() { }

	private void OnAfterRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	private void OnBeforeRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal virtual void OnFinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private void OnMainRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	private bool PlatformRequiresExplicitMsaaResolve() { }

	internal virtual void ReleaseRenderTargets() { }

	private bool RequiresColorAndDepthTextures(out bool createColorTexture, out bool createDepthTexture, ref RenderingData renderingData, RenderPassInputSummary renderPassInputs) { }

	private bool RequiresIntermediateColorTexture(ref CameraData cameraData) { }

	public void set_depthPrimingMode(DepthPrimingMode value) { }

	public virtual void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	private void SetupFinalPassDebug(ref CameraData cameraData) { }

	public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public virtual int SupportedCameraStackingTypes() { }

	internal virtual void SwapColorBuffer(CommandBuffer cmd) { }

}

