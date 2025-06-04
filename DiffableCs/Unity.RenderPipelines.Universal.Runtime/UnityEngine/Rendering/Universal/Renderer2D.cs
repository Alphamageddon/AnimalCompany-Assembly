namespace UnityEngine.Rendering.Universal;

internal class Renderer2D : ScriptableRenderer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<ScriptableRenderPass> <>9__44_1; //Field offset: 0x8
		public static Predicate<ScriptableRenderPass> <>9__44_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Setup>b__44_0(ScriptableRenderPass x) { }

		internal bool <Setup>b__44_1(ScriptableRenderPass x) { }

	}

	private struct RenderPassInputSummary
	{
		internal bool requiresDepthTexture; //Field offset: 0x0
		internal bool requiresColorTexture; //Field offset: 0x1

	}

	internal const int k_DepthBufferBits = 32; //Field offset: 0x0
	private const int k_FinalBlitPassQueueOffset = 1; //Field offset: 0x0
	private const int k_AfterFinalBlitPassQueueOffset = 2; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x0
	private Render2DLightingPass m_Render2DLightingPass; //Field offset: 0x1A8
	private PixelPerfectBackgroundPass m_PixelPerfectBackgroundPass; //Field offset: 0x1B0
	private UpscalePass m_UpscalePass; //Field offset: 0x1B8
	private FinalBlitPass m_FinalBlitPass; //Field offset: 0x1C0
	private DrawScreenSpaceUIPass m_DrawOffscreenUIPass; //Field offset: 0x1C8
	private DrawScreenSpaceUIPass m_DrawOverlayUIPass; //Field offset: 0x1D0
	private Light2DCullResult m_LightCullResult; //Field offset: 0x1D8
	internal RenderTargetBufferSystem m_ColorBufferSystem; //Field offset: 0x1E0
	private bool m_UseDepthStencilBuffer; //Field offset: 0x1E8
	private bool m_CreateColorTexture; //Field offset: 0x1E9
	private bool m_CreateDepthTexture; //Field offset: 0x1EA
	private RTHandle m_ColorTextureHandle; //Field offset: 0x1F0
	private RTHandle m_DepthTextureHandle; //Field offset: 0x1F8
	private Material m_BlitMaterial; //Field offset: 0x200
	private Material m_BlitHDRMaterial; //Field offset: 0x208
	private Material m_SamplingMaterial; //Field offset: 0x210
	private Renderer2DData m_Renderer2DData; //Field offset: 0x218
	private PostProcessPasses m_PostProcessPasses; //Field offset: 0x220

	internal RTHandle afterPostProcessColorHandle
	{
		internal get { } //Length: 8
	}

	internal RTHandle colorGradingLutHandle
	{
		internal get { } //Length: 8
	}

	internal ColorGradingLutPass colorGradingLutPass
	{
		internal get { } //Length: 8
	}

	internal bool createColorTexture
	{
		internal get { } //Length: 8
	}

	internal bool createDepthTexture
	{
		internal get { } //Length: 8
	}

	internal PostProcessPass finalPostProcessPass
	{
		internal get { } //Length: 8
	}

	internal PostProcessPass postProcessPass
	{
		internal get { } //Length: 8
	}

	private static Renderer2D() { }

	public Renderer2D(Renderer2DData data) { }

	private void CreateRenderTextures(ref RenderPassInputSummary renderPassInputs, CommandBuffer cmd, ref CameraData cameraData, bool forceCreateColorTexture, FilterMode colorTextureFilterMode, out RTHandle colorTargetHandle, out RTHandle depthTargetHandle) { }

	protected virtual void Dispose(bool disposing) { }

	internal virtual void EnableSwapBufferMSAA(bool enable) { }

	internal RTHandle get_afterPostProcessColorHandle() { }

	internal RTHandle get_colorGradingLutHandle() { }

	internal ColorGradingLutPass get_colorGradingLutPass() { }

	internal bool get_createColorTexture() { }

	internal bool get_createDepthTexture() { }

	internal PostProcessPass get_finalPostProcessPass() { }

	internal PostProcessPass get_postProcessPass() { }

	internal virtual RTHandle GetCameraColorBackBuffer(CommandBuffer cmd) { }

	internal virtual RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd) { }

	public Renderer2DData GetRenderer2DData() { }

	private RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData, ref CameraData cameraData) { }

	internal virtual void ReleaseRenderTargets() { }

	public virtual void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	public virtual int SupportedCameraStackingTypes() { }

	internal virtual void SwapColorBuffer(CommandBuffer cmd) { }

}

