namespace UnityEngine.Rendering.Universal;

public sealed class UniversalRenderPipeline : RenderPipeline
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Camera> <>9__33_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__99_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

		internal int <.ctor>b__33_0(Camera camera1, Camera camera2) { }

	}

	public static class Profiling
	{
		internal static class Pipeline
		{
			internal static class Context
			{
				private const string k_Name = "ScriptableRenderContext"; //Field offset: 0x0
				public static readonly ProfilingSampler submit; //Field offset: 0x0

				private static Context() { }

			}

			internal static class Renderer
			{
				private const string k_Name = "ScriptableRenderer"; //Field offset: 0x0
				public static readonly ProfilingSampler setupCullingParameters; //Field offset: 0x0
				public static readonly ProfilingSampler setup; //Field offset: 0x8

				private static Renderer() { }

			}

			public static readonly ProfilingSampler beginContextRendering; //Field offset: 0x0
			private const string k_Name = "UniversalRenderPipeline"; //Field offset: 0x0
			public static readonly ProfilingSampler endContextRendering; //Field offset: 0x8
			public static readonly ProfilingSampler beginCameraRendering; //Field offset: 0x10
			public static readonly ProfilingSampler endCameraRendering; //Field offset: 0x18
			public static readonly ProfilingSampler initializeCameraData; //Field offset: 0x20
			public static readonly ProfilingSampler initializeStackedCameraData; //Field offset: 0x28
			public static readonly ProfilingSampler initializeAdditionalCameraData; //Field offset: 0x30
			public static readonly ProfilingSampler initializeRenderingData; //Field offset: 0x38
			public static readonly ProfilingSampler initializeShadowData; //Field offset: 0x40
			public static readonly ProfilingSampler initializeLightData; //Field offset: 0x48
			public static readonly ProfilingSampler getPerObjectLightFlags; //Field offset: 0x50
			public static readonly ProfilingSampler getMainLightIndex; //Field offset: 0x58
			public static readonly ProfilingSampler setupPerFrameShaderConstants; //Field offset: 0x60
			public static readonly ProfilingSampler setupPerCameraShaderConstants; //Field offset: 0x68

			private static Pipeline() { }

		}

		private static Dictionary<Int32, ProfilingSampler> s_HashSamplerCache; //Field offset: 0x0
		public static readonly ProfilingSampler unknownSampler; //Field offset: 0x8

		private static Profiling() { }

		public static ProfilingSampler TryGetOrAddCameraSampler(Camera camera) { }

	}

	internal class SingleCameraRequest
	{
		public RenderTexture destination; //Field offset: 0x10
		public int mipLevel; //Field offset: 0x18
		public CubemapFace face; //Field offset: 0x1C
		public int slice; //Field offset: 0x20

		public SingleCameraRequest() { }

	}

	public const string k_ShaderTagName = "UniversalPipeline"; //Field offset: 0x0
	internal const int k_DefaultRenderingLayerMask = 1; //Field offset: 0x0
	internal static bool cameraStackRequiresDepthForPostprocessing; //Field offset: 0x0
	internal static RenderGraph s_RenderGraph; //Field offset: 0x8
	internal static RTHandleResourcePool s_RTHandlePool; //Field offset: 0x10
	private static bool useRenderGraph; //Field offset: 0x18
	private static Vector4 k_DefaultLightPosition; //Field offset: 0x1C
	private static Vector4 k_DefaultLightColor; //Field offset: 0x2C
	private static Vector4 k_DefaultLightAttenuation; //Field offset: 0x3C
	private static Vector4 k_DefaultLightSpotDirection; //Field offset: 0x4C
	private static Vector4 k_DefaultLightsProbeChannel; //Field offset: 0x5C
	private static List<Vector4> m_ShadowBiasData; //Field offset: 0x70
	private static List<Int32> m_ShadowResolutionData; //Field offset: 0x78
	private static RequestLightsDelegate lightsDelegate; //Field offset: 0x80
	private readonly DebugDisplaySettingsUI m_DebugDisplaySettingsUI; //Field offset: 0x18
	private UniversalRenderPipelineGlobalSettings m_GlobalSettings; //Field offset: 0x20
	private readonly UniversalRenderPipelineAsset pipelineAsset; //Field offset: 0x28
	internal bool enableHDROnce; //Field offset: 0x30
	private Comparison<Camera> cameraComparison; //Field offset: 0x38

	public static UniversalRenderPipelineAsset asset
	{
		 get { } //Length: 116
	}

	public virtual RenderPipelineGlobalSettings defaultSettings
	{
		 get { } //Length: 8
	}

	internal static int lightsPerTile
	{
		internal get { } //Length: 100
	}

	public static int maxNumIterationsEnclosingSphere
	{
		 get { } //Length: 8
	}

	public static int maxPerObjectLights
	{
		 get { } //Length: 36
	}

	public static float maxRenderScale
	{
		 get { } //Length: 8
	}

	public static float maxShadowBias
	{
		 get { } //Length: 8
	}

	internal static int maxTileWords
	{
		internal get { } //Length: 96
	}

	public static int maxVisibleAdditionalLights
	{
		 get { } //Length: 196
	}

	internal static int maxVisibleReflectionProbes
	{
		internal get { } //Length: 136
	}

	internal static int maxZBinWords
	{
		internal get { } //Length: 8
	}

	public static float minRenderScale
	{
		 get { } //Length: 12
	}

	private static UniversalRenderPipeline() { }

	public UniversalRenderPipeline(UniversalRenderPipelineAsset asset) { }

	private static void ApplyTaaRenderingDebugOverrides(ref Settings taaSettings) { }

	private static void CheckAndApplyDebugSettings(ref RenderingData renderingData) { }

	private static bool CheckPostProcessForDepth() { }

	private static bool CheckPostProcessForDepth(ref CameraData cameraData) { }

	internal static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, ref CameraData cameraData, bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture) { }

	protected virtual void Dispose(bool disposing) { }

	private void DisposeAdditionalCameraData() { }

	public static UniversalRenderPipelineAsset get_asset() { }

	public virtual RenderPipelineGlobalSettings get_defaultSettings() { }

	internal static int get_lightsPerTile() { }

	public static int get_maxNumIterationsEnclosingSphere() { }

	public static int get_maxPerObjectLights() { }

	public static float get_maxRenderScale() { }

	public static float get_maxShadowBias() { }

	internal static int get_maxTileWords() { }

	public static int get_maxVisibleAdditionalLights() { }

	internal static int get_maxVisibleReflectionProbes() { }

	internal static int get_maxZBinWords() { }

	public static float get_minRenderScale() { }

	internal static void GetHDROutputGradingParameters(Tonemapping tonemapping, out Vector4 hdrOutputParameters) { }

	internal static void GetHDROutputLuminanceParameters(HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Tonemapping tonemapping, out Vector4 hdrOutputParameters) { }

	public static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, Nullable<Single> innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir) { }

	private static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights) { }

	private static PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus) { }

	internal static void GetPunctualLightDistanceAttenuation(float lightRange, ref Vector4 lightAttenuation) { }

	internal static void GetSpotAngleAttenuation(float spotAngle, Nullable<Single> innerSpotAngle, ref Vector4 lightAttenuation) { }

	internal static void GetSpotDirection(ref Matrix4x4 lightLocalToWorldMatrix, out Vector4 lightSpotDir) { }

	internal static bool HDROutputForAnyDisplayIsActive() { }

	internal static bool HDROutputForMainDisplayIsActive() { }

	private static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref CameraData cameraData) { }

	private static void InitializeCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, out CameraData cameraData) { }

	public static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel) { }

	private static void InitializeLightData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, int mainLightIndex, out LightData lightData) { }

	private static void InitializePostProcessingData(UniversalRenderPipelineAsset settings, bool isHDROutputActive, out PostProcessingData postProcessingData) { }

	private static void InitializeRenderingData(UniversalRenderPipelineAsset settings, ref CameraData cameraData, ref CullingResults cullResults, CommandBuffer cmd, out RenderingData renderingData) { }

	private static void InitializeShadowData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, bool mainLightCastShadows, bool additionalLightsCastShadows, bool isForwardPlus, out ShadowData shadowData) { }

	private static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, ref CameraData cameraData) { }

	public static bool IsGameCamera(Camera camera) { }

	protected virtual bool IsRenderRequestSupported(Camera camera, RequestData data) { }

	[Obsolete("Please use CameraData.xr.enabled instead.", True)]
	public static bool IsStereoEnabled(Camera camera) { }

	internal static GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha) { }

	internal static GraphicsFormat MakeUnormRenderTextureGraphicsFormat() { }

	protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	private static void RecordAndExecuteRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	protected virtual void Render(ScriptableRenderContext renderContext, List<Camera> cameras) { }

	protected virtual void Render(ScriptableRenderContext renderContext, Camera[] cameras) { }

	private static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera) { }

	private static void RenderSingleCamera(ScriptableRenderContext context, ref CameraData cameraData) { }

	[Obsolete("RenderSingleCamera is obsolete, please use RenderPipeline.SubmitRenderRequest with UniversalRenderer.SingleCameraRequest as RequestData type", False)]
	public static void RenderSingleCamera(ScriptableRenderContext context, Camera camera) { }

	internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, ref UniversalAdditionalCameraData additionalCameraData) { }

	internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera) { }

	private static ImageUpscalingFilter ResolveUpscalingFilterSelection(Vector2 imageSize, float renderScale, UpscalingFilterSelection selection) { }

	private void SetHDRState(List<Camera> cameras) { }

	private static void SetSupportedRenderingFeatures(UniversalRenderPipelineAsset pipelineAsset) { }

	private static void SetupPerCameraShaderConstants(CommandBuffer cmd) { }

	private static void SetupPerFrameShaderConstants() { }

	private void SortCameras(List<Camera> cameras) { }

	public virtual string ToString() { }

	private static bool TryGetCullingParameters(CameraData cameraData, out ScriptableCullingParameters cullingParams) { }

	private static void UpdateCameraData(ref CameraData baseCameraData, in XRPass xr) { }

	private static void UpdateCameraStereoMatrices(Camera camera, XRPass xr) { }

	private static void UpdateTemporalAAData(ref CameraData cameraData, UniversalAdditionalCameraData additionalCameraData) { }

	private static void UpdateTemporalAATargets(ref CameraData cameraData) { }

	private static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData) { }

}

