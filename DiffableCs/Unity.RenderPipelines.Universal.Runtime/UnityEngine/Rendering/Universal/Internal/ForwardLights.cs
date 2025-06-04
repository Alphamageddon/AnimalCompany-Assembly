namespace UnityEngine.Rendering.Universal.Internal;

public class ForwardLights
{
	public struct InitParams
	{
		public LightCookieManager lightCookieManager; //Field offset: 0x0
		public bool forwardPlus; //Field offset: 0x8

		internal static InitParams Create() { }

	}

	private static class LightConstantBuffer
	{
		public static int _MainLightPosition; //Field offset: 0x0
		public static int _MainLightColor; //Field offset: 0x4
		public static int _MainLightOcclusionProbesChannel; //Field offset: 0x8
		public static int _MainLightLayerMask; //Field offset: 0xC
		public static int _AdditionalLightsCount; //Field offset: 0x10
		public static int _AdditionalLightsPosition; //Field offset: 0x14
		public static int _AdditionalLightsColor; //Field offset: 0x18
		public static int _AdditionalLightsAttenuation; //Field offset: 0x1C
		public static int _AdditionalLightsSpotDir; //Field offset: 0x20
		public static int _AdditionalLightOcclusionProbeChannel; //Field offset: 0x24
		public static int _AdditionalLightsLayerMasks; //Field offset: 0x28

	}

	private const string k_SetupLightConstants = "Setup Light Constants"; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingSamplerFPSetup; //Field offset: 0x8
	private static readonly ProfilingSampler m_ProfilingSamplerFPComplete; //Field offset: 0x10
	private static readonly ProfilingSampler m_ProfilingSamplerFPUpload; //Field offset: 0x18
	private int m_AdditionalLightsBufferId; //Field offset: 0x10
	private int m_AdditionalLightsIndicesId; //Field offset: 0x14
	private MixedLightingSetup m_MixedLightingSetup; //Field offset: 0x18
	private Vector4[] m_AdditionalLightPositions; //Field offset: 0x20
	private Vector4[] m_AdditionalLightColors; //Field offset: 0x28
	private Vector4[] m_AdditionalLightAttenuations; //Field offset: 0x30
	private Vector4[] m_AdditionalLightSpotDirections; //Field offset: 0x38
	private Vector4[] m_AdditionalLightOcclusionProbeChannels; //Field offset: 0x40
	private Single[] m_AdditionalLightsLayerMasks; //Field offset: 0x48
	private bool m_UseStructuredBuffer; //Field offset: 0x50
	private bool m_UseForwardPlus; //Field offset: 0x51
	private int m_DirectionalLightCount; //Field offset: 0x54
	private int m_ActualTileWidth; //Field offset: 0x58
	private int2 m_TileResolution; //Field offset: 0x5C
	private JobHandle m_CullingHandle; //Field offset: 0x68
	private NativeArray<UInt32> m_ZBins; //Field offset: 0x78
	private GraphicsBuffer m_ZBinsBuffer; //Field offset: 0x88
	private NativeArray<UInt32> m_TileMasks; //Field offset: 0x90
	private GraphicsBuffer m_TileMasksBuffer; //Field offset: 0xA0
	private LightCookieManager m_LightCookieManager; //Field offset: 0xA8
	private ReflectionProbeManager m_ReflectionProbeManager; //Field offset: 0xB0
	private int m_WordsPerTile; //Field offset: 0x130
	private float m_ZBinScale; //Field offset: 0x134
	private float m_ZBinOffset; //Field offset: 0x138
	private int m_LightCount; //Field offset: 0x13C
	private int m_BinCount; //Field offset: 0x140

	internal ReflectionProbeManager reflectionProbeManager
	{
		internal get { } //Length: 16
	}

	private static ForwardLights() { }

	public ForwardLights() { }

	internal ForwardLights(InitParams initParams) { }

	[CompilerGenerated]
	internal static bool <PreSetup>g__IsProbeGreater|40_0(VisibleReflectionProbe probe, VisibleReflectionProbe otherProbe) { }

	private static int AlignByteCount(int count, int align) { }

	internal void Cleanup() { }

	private void CreateForwardPlusBuffers() { }

	internal ReflectionProbeManager get_reflectionProbeManager() { }

	private void GetViewParams(Camera camera, float4x4 viewToClip, out float viewPlaneBot, out float viewPlaneTop, out float4 viewToViewportScaleBias) { }

	private void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel, out uint lightLayerMask, out bool isSubtractive) { }

	internal void PreSetup(ref RenderingData renderingData) { }

	public void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private void SetupAdditionalLightConstants(CommandBuffer cmd, ref RenderingData renderingData) { }

	private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData) { }

	private int SetupPerObjectLightIndices(CullingResults cullResults, ref LightData lightData) { }

	private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData) { }

}

