namespace UnityEngine.Rendering.Universal;

[Extension]
internal static class RendererLighting
{
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x0
	private static readonly ShaderTagId k_NormalsRenderingPassName; //Field offset: 0x8
	private static readonly Color k_NormalClearColor; //Field offset: 0xC
	private static readonly string k_SpriteLightKeyword; //Field offset: 0x20
	private static readonly string k_UsePointLightCookiesKeyword; //Field offset: 0x28
	private static readonly string k_LightQualityFastKeyword; //Field offset: 0x30
	private static readonly string k_UseNormalMap; //Field offset: 0x38
	private static readonly string k_UseAdditiveBlendingKeyword; //Field offset: 0x40
	private static readonly String[] k_UseBlendStyleKeywords; //Field offset: 0x48
	private static readonly Int32[] k_BlendFactorsPropIDs; //Field offset: 0x50
	private static readonly Int32[] k_MaskFilterPropIDs; //Field offset: 0x58
	private static readonly Int32[] k_InvertedFilterPropIDs; //Field offset: 0x60
	private static GraphicsFormat s_RenderTextureFormatToUse; //Field offset: 0x68
	private static bool s_HasSetupRenderTextureFormatToUse; //Field offset: 0x6C
	private static readonly int k_SrcBlendID; //Field offset: 0x70
	private static readonly int k_DstBlendID; //Field offset: 0x74
	private static readonly int k_FalloffIntensityID; //Field offset: 0x78
	private static readonly int k_FalloffDistanceID; //Field offset: 0x7C
	private static readonly int k_LightColorID; //Field offset: 0x80
	private static readonly int k_VolumeOpacityID; //Field offset: 0x84
	private static readonly int k_CookieTexID; //Field offset: 0x88
	private static readonly int k_FalloffLookupID; //Field offset: 0x8C
	private static readonly int k_LightPositionID; //Field offset: 0x90
	private static readonly int k_LightInvMatrixID; //Field offset: 0x94
	private static readonly int k_InnerRadiusMultID; //Field offset: 0x98
	private static readonly int k_OuterAngleID; //Field offset: 0x9C
	private static readonly int k_InnerAngleMultID; //Field offset: 0xA0
	private static readonly int k_LightLookupID; //Field offset: 0xA4
	private static readonly int k_IsFullSpotlightID; //Field offset: 0xA8
	private static readonly int k_LightZDistanceID; //Field offset: 0xAC
	private static readonly int k_PointLightCookieTexID; //Field offset: 0xB0

	private static RendererLighting() { }

	private static bool CanCastShadows(Light2D light, int layerToRender) { }

	private static bool CanCastVolumetricShadows(Light2D light, int endLayerValue) { }

	[Extension]
	public static void ClearDirtyLighting(IRenderPass2D pass, CommandBuffer cmd, uint blendStylesUsed) { }

	[Extension]
	public static void CreateCameraSortingLayerRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, Downsampling downsamplingMethod) { }

	private static Material CreateLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume) { }

	[Extension]
	public static void CreateNormalMapRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, float renderScale) { }

	[Extension]
	public static void DisableAllKeywords(IRenderPass2D pass, CommandBuffer cmd) { }

	public static void DrawPointLight(CommandBuffer cmd, Light2D light, Mesh lightMesh, Material material) { }

	public static void EnableBlendStyle(CommandBuffer cmd, int blendStyleIndex, bool enabled) { }

	[Extension]
	public static RenderTextureDescriptor GetBlendStyleRenderTextureDesc(IRenderPass2D pass, RenderingData renderingData) { }

	[Extension]
	private static Material GetLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume) { }

	private static uint GetLightMaterialIndex(Light2D light, bool isVolume) { }

	private static float GetNormalizedAngle(float angle) { }

	private static float GetNormalizedInnerRadius(Light2D light) { }

	private static GraphicsFormat GetRenderTextureFormat() { }

	private static void GetScaledLightInvMatrix(Light2D light, out Matrix4x4 retMatrix) { }

	[Extension]
	public static void ReleaseRenderTextures(IRenderPass2D pass, CommandBuffer cmd) { }

	[Extension]
	public static void RenderLights(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, ref LayerBatch layerBatch, ref RenderTextureDescriptor rtDesc) { }

	private static void RenderLightSet(IRenderPass2D pass, RenderingData renderingData, int blendStyleIndex, CommandBuffer cmd, int layerToRender, RenderTargetIdentifier renderTexture, List<Light2D> lights) { }

	[Extension]
	public static void RenderLightVolumes(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, int endLayerValue, RenderTargetIdentifier renderTexture, RenderTargetIdentifier depthTexture, RenderBufferStoreAction intermediateStoreAction, RenderBufferStoreAction finalStoreAction, bool requiresRTInit, List<Light2D> lights) { }

	[Extension]
	internal static void RenderNormals(IRenderPass2D pass, ScriptableRenderContext context, RenderingData renderingData, DrawingSettings drawSettings, FilteringSettings filterSettings, RenderTargetIdentifier depthTarget, ref bool bFirstClear) { }

	private static void SetBlendModes(Material material, BlendMode src, BlendMode dst) { }

	private static void SetGeneralLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd, Light2D light) { }

	private static void SetPointLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd, Light2D light) { }

	[Extension]
	public static void SetShapeLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd) { }

	private static bool ShouldRenderLight(Light2D light, int blendStyleIndex, int layerToRender) { }

}

