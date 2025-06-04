namespace UnityEngine.Rendering.Universal;

internal class PostProcessPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Light, Camera, Vector3, Single> <>9__78_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <LensFlareDataDriven>b__78_0(Light light, Camera cam, Vector3 wo) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass69_0
	{
		public RTHandle source; //Field offset: 0x0
		public RTHandle destination; //Field offset: 0x8
		public PostProcessPass <>4__this; //Field offset: 0x10
		public int amountOfPassesRemaining; //Field offset: 0x18
		public CommandBuffer cmd; //Field offset: 0x20

	}

	private class MaterialLibrary
	{
		public readonly Material stopNaN; //Field offset: 0x10
		public readonly Material subpixelMorphologicalAntialiasing; //Field offset: 0x18
		public readonly Material gaussianDepthOfField; //Field offset: 0x20
		public readonly Material bokehDepthOfField; //Field offset: 0x28
		public readonly Material cameraMotionBlur; //Field offset: 0x30
		public readonly Material paniniProjection; //Field offset: 0x38
		public readonly Material bloom; //Field offset: 0x40
		public readonly Material temporalAntialiasing; //Field offset: 0x48
		public readonly Material scalingSetup; //Field offset: 0x50
		public readonly Material easu; //Field offset: 0x58
		public readonly Material uber; //Field offset: 0x60
		public readonly Material finalPass; //Field offset: 0x68
		public readonly Material lensFlareDataDriven; //Field offset: 0x70

		public MaterialLibrary(PostProcessData data) { }

		internal void Cleanup() { }

		private Material Load(Shader shader) { }

	}

	private static class ShaderConstants
	{
		public static readonly int _TempTarget; //Field offset: 0x0
		public static readonly int _TempTarget2; //Field offset: 0x4
		public static readonly int _StencilRef; //Field offset: 0x8
		public static readonly int _StencilMask; //Field offset: 0xC
		public static readonly int _FullCoCTexture; //Field offset: 0x10
		public static readonly int _HalfCoCTexture; //Field offset: 0x14
		public static readonly int _DofTexture; //Field offset: 0x18
		public static readonly int _CoCParams; //Field offset: 0x1C
		public static readonly int _BokehKernel; //Field offset: 0x20
		public static readonly int _BokehConstants; //Field offset: 0x24
		public static readonly int _PongTexture; //Field offset: 0x28
		public static readonly int _PingTexture; //Field offset: 0x2C
		public static readonly int _Metrics; //Field offset: 0x30
		public static readonly int _AreaTexture; //Field offset: 0x34
		public static readonly int _SearchTexture; //Field offset: 0x38
		public static readonly int _EdgeTexture; //Field offset: 0x3C
		public static readonly int _BlendTexture; //Field offset: 0x40
		public static readonly int _ColorTexture; //Field offset: 0x44
		public static readonly int _Params; //Field offset: 0x48
		public static readonly int _SourceTexLowMip; //Field offset: 0x4C
		public static readonly int _Bloom_Params; //Field offset: 0x50
		public static readonly int _Bloom_RGBM; //Field offset: 0x54
		public static readonly int _Bloom_Texture; //Field offset: 0x58
		public static readonly int _LensDirt_Texture; //Field offset: 0x5C
		public static readonly int _LensDirt_Params; //Field offset: 0x60
		public static readonly int _LensDirt_Intensity; //Field offset: 0x64
		public static readonly int _Distortion_Params1; //Field offset: 0x68
		public static readonly int _Distortion_Params2; //Field offset: 0x6C
		public static readonly int _Chroma_Params; //Field offset: 0x70
		public static readonly int _Vignette_Params1; //Field offset: 0x74
		public static readonly int _Vignette_Params2; //Field offset: 0x78
		public static readonly int _Vignette_ParamsXR; //Field offset: 0x7C
		public static readonly int _Lut_Params; //Field offset: 0x80
		public static readonly int _UserLut_Params; //Field offset: 0x84
		public static readonly int _InternalLut; //Field offset: 0x88
		public static readonly int _UserLut; //Field offset: 0x8C
		public static readonly int _DownSampleScaleFactor; //Field offset: 0x90
		public static readonly int _FlareOcclusionRemapTex; //Field offset: 0x94
		public static readonly int _FlareOcclusionTex; //Field offset: 0x98
		public static readonly int _FlareOcclusionIndex; //Field offset: 0x9C
		public static readonly int _FlareTex; //Field offset: 0xA0
		public static readonly int _FlareColorValue; //Field offset: 0xA4
		public static readonly int _FlareData0; //Field offset: 0xA8
		public static readonly int _FlareData1; //Field offset: 0xAC
		public static readonly int _FlareData2; //Field offset: 0xB0
		public static readonly int _FlareData3; //Field offset: 0xB4
		public static readonly int _FlareData4; //Field offset: 0xB8
		public static readonly int _FlareData5; //Field offset: 0xBC
		public static readonly int _FullscreenProjMat; //Field offset: 0xC0
		public static Int32[] _BloomMipUp; //Field offset: 0xC8
		public static Int32[] _BloomMipDown; //Field offset: 0xD0

		private static ShaderConstants() { }

	}

	private const int k_MaxPyramidSize = 16; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingRenderPostProcessing; //Field offset: 0x0
	private const string k_RenderFinalPostProcessingTag = "Render Final PostProcessing Pass"; //Field offset: 0x0
	private const string k_RenderPostProcessingTag = "Render PostProcessing Effects"; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingRenderFinalPostProcessing; //Field offset: 0x8
	internal static readonly int k_ShaderPropertyId_ViewProjM; //Field offset: 0x10
	internal static readonly int k_ShaderPropertyId_PrevViewProjM; //Field offset: 0x14
	internal static readonly int k_ShaderPropertyId_ViewProjMStereo; //Field offset: 0x18
	internal static readonly int k_ShaderPropertyId_PrevViewProjMStereo; //Field offset: 0x1C
	private RenderTextureDescriptor m_Descriptor; //Field offset: 0xE0
	private RTHandle m_Source; //Field offset: 0x118
	private RTHandle m_Destination; //Field offset: 0x120
	private RTHandle m_Depth; //Field offset: 0x128
	private RTHandle m_InternalLut; //Field offset: 0x130
	private RTHandle m_MotionVectors; //Field offset: 0x138
	private RTHandle m_FullCoCTexture; //Field offset: 0x140
	private RTHandle m_HalfCoCTexture; //Field offset: 0x148
	private RTHandle m_PingTexture; //Field offset: 0x150
	private RTHandle m_PongTexture; //Field offset: 0x158
	private RTHandle[] m_BloomMipDown; //Field offset: 0x160
	private RTHandle[] m_BloomMipUp; //Field offset: 0x168
	private RTHandle m_BlendTexture; //Field offset: 0x170
	private RTHandle m_EdgeColorTexture; //Field offset: 0x178
	private RTHandle m_EdgeStencilTexture; //Field offset: 0x180
	private RTHandle m_TempTarget; //Field offset: 0x188
	private RTHandle m_TempTarget2; //Field offset: 0x190
	private MaterialLibrary m_Materials; //Field offset: 0x198
	private PostProcessData m_Data; //Field offset: 0x1A0
	private DepthOfField m_DepthOfField; //Field offset: 0x1A8
	private MotionBlur m_MotionBlur; //Field offset: 0x1B0
	private PaniniProjection m_PaniniProjection; //Field offset: 0x1B8
	private Bloom m_Bloom; //Field offset: 0x1C0
	private LensDistortion m_LensDistortion; //Field offset: 0x1C8
	private ChromaticAberration m_ChromaticAberration; //Field offset: 0x1D0
	private Vignette m_Vignette; //Field offset: 0x1D8
	private ColorLookup m_ColorLookup; //Field offset: 0x1E0
	private ColorAdjustments m_ColorAdjustments; //Field offset: 0x1E8
	private Tonemapping m_Tonemapping; //Field offset: 0x1F0
	private FilmGrain m_FilmGrain; //Field offset: 0x1F8
	private readonly GraphicsFormat m_DefaultHDRFormat; //Field offset: 0x200
	private bool m_UseRGBM; //Field offset: 0x204
	private readonly GraphicsFormat m_SMAAEdgeFormat; //Field offset: 0x208
	private readonly GraphicsFormat m_GaussianCoCFormat; //Field offset: 0x20C
	private int m_DitheringTextureIndex; //Field offset: 0x210
	private RenderTargetIdentifier[] m_MRT2; //Field offset: 0x218
	private Vector4[] m_BokehKernel; //Field offset: 0x220
	private int m_BokehHash; //Field offset: 0x228
	private float m_BokehMaxRadius; //Field offset: 0x22C
	private float m_BokehRCPAspect; //Field offset: 0x230
	private bool m_IsFinalPass; //Field offset: 0x234
	private bool m_HasFinalPass; //Field offset: 0x235
	private bool m_EnableColorEncodingIfNeeded; //Field offset: 0x236
	private bool m_UseFastSRGBLinearConversion; //Field offset: 0x237
	private bool m_SupportDataDrivenLensFlare; //Field offset: 0x238
	private bool m_ResolveToScreen; //Field offset: 0x239
	private bool m_UseSwapBuffer; //Field offset: 0x23A
	private RTHandle m_ScalingSetupTarget; //Field offset: 0x240
	private RTHandle m_UpscaledTarget; //Field offset: 0x248
	private Material m_BlitMaterial; //Field offset: 0x250

	private static PostProcessPass() { }

	public PostProcessPass(RenderPassEvent evt, PostProcessData data, ref PostProcessParams postProcessParams) { }

	[CompilerGenerated]
	private RTHandle <Render>g__GetDestination|69_1(ref <>c__DisplayClass69_0 unnamed_param_0) { }

	[CompilerGenerated]
	private RTHandle <Render>g__GetSource|69_0(ref <>c__DisplayClass69_0 unnamed_param_0) { }

	[CompilerGenerated]
	private void <Render>g__Swap|69_2(ref ScriptableRenderer r, ref <>c__DisplayClass69_0 unnamed_param_1) { }

	private Vector2 CalcCropExtents(Camera camera, float d) { }

	private Vector2 CalcViewExtents(Camera camera) { }

	public bool CanRunOnTile() { }

	public void Cleanup() { }

	public void Dispose() { }

	private void DoBokehDepthOfField(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect) { }

	private void DoDepthOfField(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect) { }

	private void DoGaussianDepthOfField(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect) { }

	private void DoMotionBlur(CommandBuffer cmd, RTHandle source, RTHandle destination, ref CameraData cameraData) { }

	private void DoPaniniProjection(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination) { }

	private void DoSubpixelMorphologicalAntialiasing(ref CameraData cameraData, CommandBuffer cmd, RTHandle source, RTHandle destination) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal static RenderTextureDescriptor GetCompatibleDescriptor(RenderTextureDescriptor desc, int width, int height, GraphicsFormat format, DepthBits depthBufferBits = 0) { }

	private RenderTextureDescriptor GetCompatibleDescriptor() { }

	private RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, GraphicsFormat format, DepthBits depthBufferBits = 0) { }

	private static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo) { }

	private static float GetMaxBokehRadiusInPixels(float viewportHeight) { }

	private void LensFlareDataDriven(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit) { }

	private void LensFlareDataDrivenComputeOcclusion(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit) { }

	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	private void PrepareBokehKernel(float maxRadius, float rcpAspect) { }

	private void Render(CommandBuffer cmd, ref RenderingData renderingData) { }

	private void RenderFinalPass(CommandBuffer cmd, ref RenderingData renderingData) { }

	private bool RequireHDROutput(ref CameraData cameraData) { }

	private bool RequireSRGBConversionBlitToBackBuffer(ref CameraData cameraData) { }

	public void Setup(in RenderTextureDescriptor baseDescriptor, in RTHandle source, RTHandle destination, in RTHandle depth, in RTHandle internalLut, bool hasFinalPass, bool enableColorEncoding) { }

	public void Setup(in RenderTextureDescriptor baseDescriptor, in RTHandle source, bool resolveToScreen, in RTHandle depth, in RTHandle internalLut, in RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding) { }

	private void SetupBloom(CommandBuffer cmd, RTHandle source, Material uberMaterial) { }

	private void SetupChromaticAberration(Material material) { }

	private void SetupColorGrading(CommandBuffer cmd, ref RenderingData renderingData, Material material) { }

	private void SetupDithering(ref CameraData cameraData, Material material) { }

	public void SetupFinalPass(in RTHandle source, bool useSwapBuffer = false, bool enableColorEncoding = true) { }

	private void SetupGrain(ref CameraData cameraData, Material material) { }

	private void SetupHDROutput(HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Material material, Operation hdrOperations) { }

	private void SetupLensDistortion(Material material, bool isSceneView) { }

	private void SetupVignette(Material material, XRPass xrPass) { }

	internal static void UpdateMotionBlurMatrices(ref Material material, Camera camera, XRPass xr) { }

}

