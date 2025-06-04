namespace UnityEngine.Rendering.Universal;

public static class ShadowUtils
{
	internal static readonly bool m_ForceShadowPointSampling; //Field offset: 0x0
	internal const int kMinimumPunctualLightHardShadowResolution = 8; //Field offset: 0x0
	internal const int kMinimumPunctualLightSoftShadowResolution = 16; //Field offset: 0x0
	private static int _ShadowBias; //Field offset: 0x4
	private static int _LightDirection; //Field offset: 0x8
	private static int _LightPosition; //Field offset: 0xC

	private static ShadowUtils() { }

	public static RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name) { }

	public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight) { }

	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix) { }

	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData) { }

	public static bool ExtractPointLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	public static bool ExtractSpotLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount) { }

	internal static int GetPunctualLightShadowSlicesCount(in LightType lightType) { }

	internal static void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, out float scale, out float bias) { }

	public static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution) { }

	private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view) { }

	[Obsolete("Use AllocShadowRT or ShadowRTReAllocateIfNeeded")]
	public static RenderTexture GetTemporaryShadowTexture(int width, int height, int bits) { }

	private static RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits) { }

	internal static bool IsValidShadowCastingLight(ref LightData lightData, int i) { }

	internal static int MinimalPunctualLightShadowResolution(bool softShadow) { }

	public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings) { }

	public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings, Matrix4x4 proj, Matrix4x4 view) { }

	internal static void SetCameraPosition(CommandBuffer cmd, Vector3 worldSpaceCameraPos) { }

	internal static void SetLightDirection(CommandBuffer cmd, Vector3 lightDirection) { }

	internal static void SetLightPosition(CommandBuffer cmd, Vector3 lightPosition) { }

	internal static void SetPerLightSoftShadowKeyword(CommandBuffer cmd, bool hasSoftShadows) { }

	internal static void SetShadowBias(CommandBuffer cmd, Vector4 shadowBias) { }

	internal static void SetSoftShadowQualityShaderKeywords(CommandBuffer cmd, ref ShadowData shadowData) { }

	public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias) { }

	internal static void SetWorldToCameraMatrix(CommandBuffer cmd, Matrix4x4 viewMatrix) { }

	public static bool ShadowRTNeedsReAlloc(RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name) { }

	public static bool ShadowRTReAllocateIfNeeded(ref RTHandle handle, int width, int height, int bits, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	internal static float SoftShadowQualityToShaderProperty(Light light, bool softShadowsEnabled) { }

	internal static bool SupportsPerLightSoftShadowQuality() { }

}

