namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
public class UniversalRenderPipelineAsset : RenderPipelineAsset, ISerializationCallbackReceiver
{
	[ReloadGroup]
	internal sealed class TextureResources
	{
		[Reload("Textures/BlueNoise64/L/LDR_LLL1_0.png", Package::Root (1))]
		public Texture2D blueNoise64LTex; //Field offset: 0x10
		[Reload("Textures/BayerMatrix.png", Package::Root (1))]
		public Texture2D bayerMatrixTex; //Field offset: 0x18

		public TextureResources() { }

		public bool NeedsReload() { }

	}

	public const int k_MinLutSize = 16; //Field offset: 0x0
	internal const int k_ShadowCascadeMinCount = 1; //Field offset: 0x0
	internal const int k_ShadowCascadeMaxCount = 4; //Field offset: 0x0
	public static readonly int AdditionalLightsDefaultShadowResolutionTierLow; //Field offset: 0x0
	public const int k_MaxLutSize = 65; //Field offset: 0x0
	public static readonly int AdditionalLightsDefaultShadowResolutionTierMedium; //Field offset: 0x4
	public static readonly int AdditionalLightsDefaultShadowResolutionTierHigh; //Field offset: 0x8
	private static GraphicsFormat[][] s_LightCookieFormatList; //Field offset: 0x10
	private Shader m_DefaultShader; //Field offset: 0x18
	private ScriptableRenderer[] m_Renderers; //Field offset: 0x20
	[SerializeField]
	private int k_AssetVersion; //Field offset: 0x28
	[SerializeField]
	private int k_AssetPreviousVersion; //Field offset: 0x2C
	[SerializeField]
	private RendererType m_RendererType; //Field offset: 0x30
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use m_RendererDataList instead.")]
	[SerializeField]
	internal ScriptableRendererData m_RendererData; //Field offset: 0x38
	[SerializeField]
	internal ScriptableRendererData[] m_RendererDataList; //Field offset: 0x40
	[SerializeField]
	internal int m_DefaultRendererIndex; //Field offset: 0x48
	[SerializeField]
	private bool m_RequireDepthTexture; //Field offset: 0x4C
	[SerializeField]
	private bool m_RequireOpaqueTexture; //Field offset: 0x4D
	[SerializeField]
	private Downsampling m_OpaqueDownsampling; //Field offset: 0x50
	[SerializeField]
	private bool m_SupportsTerrainHoles; //Field offset: 0x54
	[SerializeField]
	private bool m_SupportsHDR; //Field offset: 0x55
	[SerializeField]
	private HDRColorBufferPrecision m_HDRColorBufferPrecision; //Field offset: 0x58
	[SerializeField]
	private MsaaQuality m_MSAA; //Field offset: 0x5C
	[SerializeField]
	private float m_RenderScale; //Field offset: 0x60
	[SerializeField]
	private UpscalingFilterSelection m_UpscalingFilter; //Field offset: 0x64
	[SerializeField]
	private bool m_FsrOverrideSharpness; //Field offset: 0x68
	[SerializeField]
	private float m_FsrSharpness; //Field offset: 0x6C
	[SerializeField]
	private bool m_EnableLODCrossFade; //Field offset: 0x70
	[SerializeField]
	private LODCrossFadeDitheringType m_LODCrossFadeDitheringType; //Field offset: 0x74
	[SerializeField]
	private ShEvalMode m_ShEvalMode; //Field offset: 0x78
	[SerializeField]
	private LightRenderingMode m_MainLightRenderingMode; //Field offset: 0x7C
	[SerializeField]
	private bool m_MainLightShadowsSupported; //Field offset: 0x80
	[SerializeField]
	private ShadowResolution m_MainLightShadowmapResolution; //Field offset: 0x84
	[SerializeField]
	private LightRenderingMode m_AdditionalLightsRenderingMode; //Field offset: 0x88
	[SerializeField]
	private int m_AdditionalLightsPerObjectLimit; //Field offset: 0x8C
	[SerializeField]
	private bool m_AdditionalLightShadowsSupported; //Field offset: 0x90
	[SerializeField]
	private ShadowResolution m_AdditionalLightsShadowmapResolution; //Field offset: 0x94
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTierLow; //Field offset: 0x98
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTierMedium; //Field offset: 0x9C
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTierHigh; //Field offset: 0xA0
	[SerializeField]
	private bool m_ReflectionProbeBlending; //Field offset: 0xA4
	[SerializeField]
	private bool m_ReflectionProbeBoxProjection; //Field offset: 0xA5
	[SerializeField]
	private float m_ShadowDistance; //Field offset: 0xA8
	[SerializeField]
	private int m_ShadowCascadeCount; //Field offset: 0xAC
	[SerializeField]
	private float m_Cascade2Split; //Field offset: 0xB0
	[SerializeField]
	private Vector2 m_Cascade3Split; //Field offset: 0xB4
	[SerializeField]
	private Vector3 m_Cascade4Split; //Field offset: 0xBC
	[SerializeField]
	private float m_CascadeBorder; //Field offset: 0xC8
	[SerializeField]
	private float m_ShadowDepthBias; //Field offset: 0xCC
	[SerializeField]
	private float m_ShadowNormalBias; //Field offset: 0xD0
	[SerializeField]
	private bool m_SoftShadowsSupported; //Field offset: 0xD4
	[SerializeField]
	private bool m_ConservativeEnclosingSphere; //Field offset: 0xD5
	[SerializeField]
	private int m_NumIterationsEnclosingSphere; //Field offset: 0xD8
	[SerializeField]
	private SoftShadowQuality m_SoftShadowQuality; //Field offset: 0xDC
	[SerializeField]
	private LightCookieResolution m_AdditionalLightsCookieResolution; //Field offset: 0xE0
	[SerializeField]
	private LightCookieFormat m_AdditionalLightsCookieFormat; //Field offset: 0xE4
	[SerializeField]
	private bool m_UseSRPBatcher; //Field offset: 0xE8
	[SerializeField]
	private bool m_SupportsDynamicBatching; //Field offset: 0xE9
	[SerializeField]
	private bool m_MixedLightingSupported; //Field offset: 0xEA
	[SerializeField]
	private bool m_SupportsLightCookies; //Field offset: 0xEB
	[SerializeField]
	private bool m_SupportsLightLayers; //Field offset: 0xEC
	[Obsolete]
	[SerializeField]
	private PipelineDebugLevel m_DebugLevel; //Field offset: 0xF0
	[SerializeField]
	private StoreActionsOptimization m_StoreActionsOptimization; //Field offset: 0xF4
	[SerializeField]
	private bool m_EnableRenderGraph; //Field offset: 0xF8
	[SerializeField]
	private bool m_UseAdaptivePerformance; //Field offset: 0xF9
	[SerializeField]
	private ColorGradingMode m_ColorGradingMode; //Field offset: 0xFC
	[SerializeField]
	private int m_ColorGradingLutSize; //Field offset: 0x100
	[SerializeField]
	private bool m_UseFastSRGBLinearConversion; //Field offset: 0x104
	[SerializeField]
	private bool m_SupportDataDrivenLensFlare; //Field offset: 0x105
	[SerializeField]
	private ShadowQuality m_ShadowType; //Field offset: 0x108
	[SerializeField]
	private bool m_LocalShadowsSupported; //Field offset: 0x10C
	[SerializeField]
	private ShadowResolution m_LocalShadowsAtlasResolution; //Field offset: 0x110
	[SerializeField]
	private int m_MaxPixelLights; //Field offset: 0x114
	[SerializeField]
	private ShadowResolution m_ShadowAtlasResolution; //Field offset: 0x118
	[SerializeField]
	private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateMode; //Field offset: 0x11C
	[SerializeField]
	private TextureResources m_Textures; //Field offset: 0x120
	[SerializeField]
	private int m_ShaderVariantLogLevel; //Field offset: 0x128
	[Obsolete("This is obsolete, please use shadowCascadeCount instead.", False)]
	[SerializeField]
	private ShadowCascadesOption m_ShadowCascades; //Field offset: 0x12C

	internal GraphicsFormat additionalLightsCookieFormat
	{
		internal get { } //Length: 568
	}

	internal Vector2Int additionalLightsCookieResolution
	{
		internal get { } //Length: 12
	}

	public internal LightRenderingMode additionalLightsRenderingMode
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public internal int additionalLightsShadowmapResolution
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public internal int additionalLightsShadowResolutionTierHigh
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public internal int additionalLightsShadowResolutionTierLow
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public internal int additionalLightsShadowResolutionTierMedium
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public internal float cascade2Split
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public internal Vector2 cascade3Split
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public internal Vector3 cascade4Split
	{
		 get { } //Length: 12
		internal set { } //Length: 12
	}

	public float cascadeBorder
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int colorGradingLutSize
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public ColorGradingMode colorGradingMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool conservativeEnclosingSphere
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("PipelineDebugLevel is deprecated and replaced to use the profiler. Calling debugLevel is not necessary.", False)]
	public PipelineDebugLevel debugLevel
	{
		 get { } //Length: 8
	}

	public Material decalMaterial
	{
		 get { } //Length: 8
	}

	public virtual Material default2DMaskMaterial
	{
		 get { } //Length: 8
	}

	public virtual Material default2DMaterial
	{
		 get { } //Length: 8
	}

	public virtual Material defaultLineMaterial
	{
		 get { } //Length: 8
	}

	public virtual Material defaultMaterial
	{
		 get { } //Length: 8
	}

	public virtual Material defaultParticleMaterial
	{
		 get { } //Length: 8
	}

	public virtual Shader defaultShader
	{
		 get { } //Length: 172
	}

	public virtual Material defaultTerrainMaterial
	{
		 get { } //Length: 8
	}

	public virtual Material defaultUIETC1SupportedMaterial
	{
		 get { } //Length: 8
	}

	public virtual Material defaultUIMaterial
	{
		 get { } //Length: 8
	}

	public virtual Material defaultUIOverdrawMaterial
	{
		 get { } //Length: 8
	}

	public bool enableLODCrossFade
	{
		 get { } //Length: 8
	}

	internal bool enableRenderGraph
	{
		internal get { } //Length: 8
		internal set { } //Length: 12
	}

	public bool fsrOverrideSharpness
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float fsrSharpness
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public HDRColorBufferPrecision hdrColorBufferPrecision
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public String[] lightLayerMaskNames
	{
		 get { } //Length: 68
	}

	public LODCrossFadeDitheringType lodCrossFadeDitheringType
	{
		 get { } //Length: 8
	}

	public internal LightRenderingMode mainLightRenderingMode
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public internal int mainLightShadowmapResolution
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public int maxAdditionalLightsCount
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public int msaaSampleCount
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int numIterationsEnclosingSphere
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Downsampling opaqueDownsampling
	{
		 get { } //Length: 8
	}

	public virtual String[] prefixedRenderingLayerMaskNames
	{
		 get { } //Length: 96
	}

	public internal bool reflectionProbeBlending
	{
		 get { } //Length: 8
		internal set { } //Length: 12
	}

	public internal bool reflectionProbeBoxProjection
	{
		 get { } //Length: 8
		internal set { } //Length: 12
	}

	internal Int32[] rendererIndexList
	{
		internal get { } //Length: 156
	}

	public virtual String[] renderingLayerMaskNames
	{
		 get { } //Length: 96
	}

	public float renderScale
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public ScriptableRenderer scriptableRenderer
	{
		 get { } //Length: 556
	}

	internal ScriptableRendererData scriptableRendererData
	{
		internal get { } //Length: 192
	}

	[Obsolete("Use UniversalRenderPipelineGlobalSettings.instance.shaderVariantLogLevel", False)]
	public ShaderVariantLogLevel shaderVariantLogLevel
	{
		 get { } //Length: 96
		 set { } //Length: 100
	}

	public int shadowCascadeCount
	{
		 get { } //Length: 8
		 set { } //Length: 224
	}

	[Obsolete("This is obsolete, please use shadowCascadeCount instead.", False)]
	public ShadowCascadesOption shadowCascadeOption
	{
		 get { } //Length: 132
		 set { } //Length: 108
	}

	public float shadowDepthBias
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public float shadowDistance
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public float shadowNormalBias
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public internal ShEvalMode shEvalMode
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	internal SoftShadowQuality softShadowQuality
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public StoreActionsOptimization storeActionsOptimization
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool supportDataDrivenLensFlare
	{
		 get { } //Length: 8
	}

	public internal bool supportsAdditionalLightShadows
	{
		 get { } //Length: 8
		internal set { } //Length: 12
	}

	public bool supportsCameraDepthTexture
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool supportsCameraOpaqueTexture
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool supportsDynamicBatching
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool supportsHDR
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool supportsLightCookies
	{
		 get { } //Length: 8
	}

	[Obsolete("This is obsolete, UnityEngine.Rendering.ShaderVariantLogLevel instead.", False)]
	public bool supportsLightLayers
	{
		 get { } //Length: 8
	}

	public internal bool supportsMainLightShadows
	{
		 get { } //Length: 8
		internal set { } //Length: 12
	}

	public bool supportsMixedLighting
	{
		 get { } //Length: 8
	}

	public internal bool supportsSoftShadows
	{
		 get { } //Length: 8
		internal set { } //Length: 12
	}

	public bool supportsTerrainHoles
	{
		 get { } //Length: 8
	}

	public TextureResources textures
	{
		 get { } //Length: 100
	}

	public UpscalingFilterSelection upscalingFilter
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool useAdaptivePerformance
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool useFastSRGBLinearConversion
	{
		 get { } //Length: 8
	}

	public bool useRenderingLayers
	{
		 get { } //Length: 8
	}

	public bool useSRPBatcher
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public VolumeFrameworkUpdateMode volumeFrameworkUpdateMode
	{
		 get { } //Length: 8
	}

	private static UniversalRenderPipelineAsset() { }

	public UniversalRenderPipelineAsset() { }

	protected virtual RenderPipeline CreatePipeline() { }

	private void CreateRenderers() { }

	private void DestroyRenderer(ref ScriptableRenderer renderer) { }

	internal void DestroyRenderers() { }

	internal GraphicsFormat get_additionalLightsCookieFormat() { }

	internal Vector2Int get_additionalLightsCookieResolution() { }

	public LightRenderingMode get_additionalLightsRenderingMode() { }

	public int get_additionalLightsShadowmapResolution() { }

	public int get_additionalLightsShadowResolutionTierHigh() { }

	public int get_additionalLightsShadowResolutionTierLow() { }

	public int get_additionalLightsShadowResolutionTierMedium() { }

	public float get_cascade2Split() { }

	public Vector2 get_cascade3Split() { }

	public Vector3 get_cascade4Split() { }

	public float get_cascadeBorder() { }

	public int get_colorGradingLutSize() { }

	public ColorGradingMode get_colorGradingMode() { }

	public bool get_conservativeEnclosingSphere() { }

	public PipelineDebugLevel get_debugLevel() { }

	public Material get_decalMaterial() { }

	public virtual Material get_default2DMaskMaterial() { }

	public virtual Material get_default2DMaterial() { }

	public virtual Material get_defaultLineMaterial() { }

	public virtual Material get_defaultMaterial() { }

	public virtual Material get_defaultParticleMaterial() { }

	public virtual Shader get_defaultShader() { }

	public virtual Material get_defaultTerrainMaterial() { }

	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	public virtual Material get_defaultUIMaterial() { }

	public virtual Material get_defaultUIOverdrawMaterial() { }

	public bool get_enableLODCrossFade() { }

	internal bool get_enableRenderGraph() { }

	public bool get_fsrOverrideSharpness() { }

	public float get_fsrSharpness() { }

	public HDRColorBufferPrecision get_hdrColorBufferPrecision() { }

	public String[] get_lightLayerMaskNames() { }

	public LODCrossFadeDitheringType get_lodCrossFadeDitheringType() { }

	public LightRenderingMode get_mainLightRenderingMode() { }

	public int get_mainLightShadowmapResolution() { }

	public int get_maxAdditionalLightsCount() { }

	public int get_msaaSampleCount() { }

	public int get_numIterationsEnclosingSphere() { }

	public Downsampling get_opaqueDownsampling() { }

	public virtual String[] get_prefixedRenderingLayerMaskNames() { }

	public bool get_reflectionProbeBlending() { }

	public bool get_reflectionProbeBoxProjection() { }

	internal Int32[] get_rendererIndexList() { }

	public virtual String[] get_renderingLayerMaskNames() { }

	public float get_renderScale() { }

	public ScriptableRenderer get_scriptableRenderer() { }

	internal ScriptableRendererData get_scriptableRendererData() { }

	public ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	public int get_shadowCascadeCount() { }

	public ShadowCascadesOption get_shadowCascadeOption() { }

	public float get_shadowDepthBias() { }

	public float get_shadowDistance() { }

	public float get_shadowNormalBias() { }

	public ShEvalMode get_shEvalMode() { }

	internal SoftShadowQuality get_softShadowQuality() { }

	public StoreActionsOptimization get_storeActionsOptimization() { }

	public bool get_supportDataDrivenLensFlare() { }

	public bool get_supportsAdditionalLightShadows() { }

	public bool get_supportsCameraDepthTexture() { }

	public bool get_supportsCameraOpaqueTexture() { }

	public bool get_supportsDynamicBatching() { }

	public bool get_supportsHDR() { }

	public bool get_supportsLightCookies() { }

	public bool get_supportsLightLayers() { }

	public bool get_supportsMainLightShadows() { }

	public bool get_supportsMixedLighting() { }

	public bool get_supportsSoftShadows() { }

	public bool get_supportsTerrainHoles() { }

	public TextureResources get_textures() { }

	public UpscalingFilterSelection get_upscalingFilter() { }

	public bool get_useAdaptivePerformance() { }

	public bool get_useFastSRGBLinearConversion() { }

	public bool get_useRenderingLayers() { }

	public bool get_useSRPBatcher() { }

	public VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode() { }

	internal int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier) { }

	private Material GetMaterial(DefaultMaterialType materialType) { }

	public ScriptableRenderer GetRenderer(int index) { }

	public ScriptableRendererData LoadBuiltinRendererData(RendererType type = 1) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	protected virtual void OnDisable() { }

	internal void set_additionalLightsRenderingMode(LightRenderingMode value) { }

	internal void set_additionalLightsShadowmapResolution(int value) { }

	internal void set_additionalLightsShadowResolutionTierHigh(int value) { }

	internal void set_additionalLightsShadowResolutionTierLow(int value) { }

	internal void set_additionalLightsShadowResolutionTierMedium(int value) { }

	internal void set_cascade2Split(float value) { }

	internal void set_cascade3Split(Vector2 value) { }

	internal void set_cascade4Split(Vector3 value) { }

	public void set_cascadeBorder(float value) { }

	public void set_colorGradingLutSize(int value) { }

	public void set_colorGradingMode(ColorGradingMode value) { }

	public void set_conservativeEnclosingSphere(bool value) { }

	internal void set_enableRenderGraph(bool value) { }

	public void set_fsrOverrideSharpness(bool value) { }

	public void set_fsrSharpness(float value) { }

	public void set_hdrColorBufferPrecision(HDRColorBufferPrecision value) { }

	internal void set_mainLightRenderingMode(LightRenderingMode value) { }

	internal void set_mainLightShadowmapResolution(int value) { }

	public void set_maxAdditionalLightsCount(int value) { }

	public void set_msaaSampleCount(int value) { }

	public void set_numIterationsEnclosingSphere(int value) { }

	internal void set_reflectionProbeBlending(bool value) { }

	internal void set_reflectionProbeBoxProjection(bool value) { }

	public void set_renderScale(float value) { }

	public void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

	public void set_shadowCascadeCount(int value) { }

	public void set_shadowCascadeOption(ShadowCascadesOption value) { }

	public void set_shadowDepthBias(float value) { }

	public void set_shadowDistance(float value) { }

	public void set_shadowNormalBias(float value) { }

	internal void set_shEvalMode(ShEvalMode value) { }

	internal void set_softShadowQuality(SoftShadowQuality value) { }

	public void set_storeActionsOptimization(StoreActionsOptimization value) { }

	internal void set_supportsAdditionalLightShadows(bool value) { }

	public void set_supportsCameraDepthTexture(bool value) { }

	public void set_supportsCameraOpaqueTexture(bool value) { }

	public void set_supportsDynamicBatching(bool value) { }

	public void set_supportsHDR(bool value) { }

	internal void set_supportsMainLightShadows(bool value) { }

	internal void set_supportsSoftShadows(bool value) { }

	public void set_upscalingFilter(UpscalingFilterSelection value) { }

	public void set_useAdaptivePerformance(bool value) { }

	public void set_useSRPBatcher(bool value) { }

	private int ValidatePerObjectLights(int value) { }

	internal bool ValidateRendererData(int index) { }

	internal bool ValidateRendererDataList(bool partial = false) { }

	private float ValidateRenderScale(float value) { }

	private float ValidateShadowBias(float value) { }

}

