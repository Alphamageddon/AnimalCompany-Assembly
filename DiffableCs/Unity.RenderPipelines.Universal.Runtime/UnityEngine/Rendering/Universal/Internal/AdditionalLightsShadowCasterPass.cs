namespace UnityEngine.Rendering.Universal.Internal;

public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__62_0; //Field offset: 0x8
		public static RenderFunc<PassData> <>9__62_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__62_0(PassData data, RenderGraphContext context) { }

		internal void <Render>b__62_1(PassData data, RenderGraphContext context) { }

	}

	private static class AdditionalShadowsConstantBuffer
	{
		public static int _AdditionalLightsWorldToShadow; //Field offset: 0x0
		public static int _AdditionalShadowParams; //Field offset: 0x4
		public static int _AdditionalShadowOffset0; //Field offset: 0x8
		public static int _AdditionalShadowOffset1; //Field offset: 0xC
		public static int _AdditionalShadowFadeParams; //Field offset: 0x10
		public static int _AdditionalShadowmapSize; //Field offset: 0x14

	}

	private class PassData
	{
		internal AdditionalLightsShadowCasterPass pass; //Field offset: 0x10
		internal RenderGraph graph; //Field offset: 0x18
		internal TextureHandle shadowmapTexture; //Field offset: 0x20
		internal RenderingData renderingData; //Field offset: 0x28
		internal int shadowmapID; //Field offset: 0x2E0
		internal bool emptyShadowmap; //Field offset: 0x2E4

		public PassData() { }

	}

	public struct ShadowResolutionRequest
	{
		public int visibleLightIndex; //Field offset: 0x0
		public int perLightShadowSliceIndex; //Field offset: 0x4
		public int requestedResolution; //Field offset: 0x8
		public bool softShadow; //Field offset: 0xC
		public bool pointLightShadow; //Field offset: 0xD
		public int offsetX; //Field offset: 0x10
		public int offsetY; //Field offset: 0x14
		public int allocatedResolution; //Field offset: 0x18

		public ShadowResolutionRequest(int _visibleLightIndex, int _perLightShadowSliceIndex, int _requestedResolution, bool _softShadow, bool _pointLightShadow) { }

	}

	[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsBufferId was deprecated. Shadow slice matrix is now passed to the GPU using an entry in buffer m_AdditionalLightsWorldToShadow_SSBO", False)]
	public static int m_AdditionalShadowsBufferId; //Field offset: 0x0
	private const int kMinimumPunctualLightHardShadowResolution = 8; //Field offset: 0x0
	private const int kMinimumPunctualLightSoftShadowResolution = 16; //Field offset: 0x0
	private const string k_EmptyAdditionalLightShadowMapTextureName = "_EmptyAdditionalLightShadowmapTexture"; //Field offset: 0x0
	private const string k_AdditionalLightShadowMapTextureName = "_AdditionalLightsShadowmapTexture"; //Field offset: 0x0
	private const int k_EmptyShadowMapDimensions = 1; //Field offset: 0x0
	private const float LightTypeIdentifierInShadowParams_Point = 1; //Field offset: 0x0
	private const float LightTypeIdentifierInShadowParams_Spot = 0; //Field offset: 0x0
	private const int k_ShadowmapBufferBits = 16; //Field offset: 0x0
	[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsIndicesId was deprecated. Shadow slice index is now passed to the GPU using last member of an entry in buffer m_AdditionalShadowParams_SSBO", False)]
	public static int m_AdditionalShadowsIndicesId; //Field offset: 0x4
	private static readonly Vector4 c_DefaultShadowParams; //Field offset: 0x8
	private static int m_AdditionalLightsWorldToShadow_SSBO; //Field offset: 0x18
	private static int m_AdditionalShadowParams_SSBO; //Field offset: 0x1C
	internal static Vector4[] s_EmptyAdditionalLightIndexToShadowParams; //Field offset: 0x20
	private bool m_UseStructuredBuffer; //Field offset: 0xE0
	private int m_AdditionalLightsShadowmapID; //Field offset: 0xE4
	internal RTHandle m_AdditionalLightsShadowmapHandle; //Field offset: 0xE8
	private bool m_CreateEmptyShadowmap; //Field offset: 0xF0
	private RTHandle m_EmptyAdditionalLightShadowmapTexture; //Field offset: 0xF8
	private float m_MaxShadowDistanceSq; //Field offset: 0x100
	private float m_CascadeBorder; //Field offset: 0x104
	private ShadowSliceData[] m_AdditionalLightsShadowSlices; //Field offset: 0x108
	private Int32[] m_VisibleLightIndexToAdditionalLightIndex; //Field offset: 0x110
	private Int32[] m_AdditionalLightIndexToVisibleLightIndex; //Field offset: 0x118
	private List<Int32> m_ShadowSliceToAdditionalLightIndex; //Field offset: 0x120
	private List<Int32> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex; //Field offset: 0x128
	private Vector4[] m_AdditionalLightIndexToShadowParams; //Field offset: 0x130
	private Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix; //Field offset: 0x138
	private List<ShadowResolutionRequest> m_ShadowResolutionRequests; //Field offset: 0x140
	private Single[] m_VisibleLightIndexToCameraSquareDistance; //Field offset: 0x148
	private ShadowResolutionRequest[] m_SortedShadowResolutionRequests; //Field offset: 0x150
	private Int32[] m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex; //Field offset: 0x158
	private List<RectInt> m_UnusedAtlasSquareAreas; //Field offset: 0x160
	private int renderTargetWidth; //Field offset: 0x168
	private int renderTargetHeight; //Field offset: 0x16C
	private ProfilingSampler m_ProfilingSetupSampler; //Field offset: 0x170
	private Dictionary<Int32, UInt64> m_ShadowRequestsHashes; //Field offset: 0x178

	private static AdditionalLightsShadowCasterPass() { }

	public AdditionalLightsShadowCasterPass(RenderPassEvent evt) { }

	private void AtlasLayout(int atlasSize, int totalShadowSlicesCount, int estimatedScaleFactor) { }

	internal static float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels) { }

	private void Clear() { }

	private ulong ComputeShadowRequestHash(ref RenderingData renderingData) { }

	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	public void Dispose() { }

	private int EstimateScaleFactorNeededToFitAllShadowsInAtlas(in ShadowResolutionRequest[] shadowResolutionRequests, int endIndex, int atlasWidth) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal static float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering) { }

	private int GetPunctualLightShadowSlicesCount(in LightType lightType) { }

	public int GetShadowLightIndexFromLightIndex(int visibleLightIndex) { }

	private void InitPassData(ref PassData passData, ref RenderingData renderingData, ref RenderGraph graph) { }

	internal void InsertionSort(ShadowResolutionRequest[] array, int startIndex, int lastIndex) { }

	private bool IsValidShadowCastingLight(ref LightData lightData, int i) { }

	private int MinimalPunctualLightShadowResolution(bool softShadow) { }

	internal TextureHandle Render(RenderGraph graph, ref RenderingData renderingData) { }

	private void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref RenderingData renderingData) { }

	private ulong ResolutionLog2ForHash(int resolution) { }

	internal static void SetEmptyAdditionalLightShadowParams(CommandBuffer cmd, Vector4[] lightIndexToShadowParams) { }

	private void SetEmptyAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref RenderingData renderingData) { }

	public bool Setup(ref RenderingData renderingData) { }

	private void SetupAdditionalLightsShadowReceiverConstants(CommandBuffer cmd, bool softShadows) { }

	private bool SetupForEmptyRendering(ref RenderingData renderingData) { }

}

