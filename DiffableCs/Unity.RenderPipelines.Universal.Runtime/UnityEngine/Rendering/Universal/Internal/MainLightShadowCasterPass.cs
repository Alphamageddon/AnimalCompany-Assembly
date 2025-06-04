namespace UnityEngine.Rendering.Universal.Internal;

public class MainLightShadowCasterPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__33_0; //Field offset: 0x8
		public static RenderFunc<PassData> <>9__33_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__33_0(PassData data, RenderGraphContext context) { }

		internal void <Render>b__33_1(PassData data, RenderGraphContext context) { }

	}

	private static class MainLightShadowConstantBuffer
	{
		public static int _WorldToShadow; //Field offset: 0x0
		public static int _ShadowParams; //Field offset: 0x4
		public static int _CascadeShadowSplitSpheres0; //Field offset: 0x8
		public static int _CascadeShadowSplitSpheres1; //Field offset: 0xC
		public static int _CascadeShadowSplitSpheres2; //Field offset: 0x10
		public static int _CascadeShadowSplitSpheres3; //Field offset: 0x14
		public static int _CascadeShadowSplitSphereRadii; //Field offset: 0x18
		public static int _ShadowOffset0; //Field offset: 0x1C
		public static int _ShadowOffset1; //Field offset: 0x20
		public static int _ShadowmapSize; //Field offset: 0x24

	}

	private class PassData
	{
		internal MainLightShadowCasterPass pass; //Field offset: 0x10
		internal RenderGraph graph; //Field offset: 0x18
		internal TextureHandle shadowmapTexture; //Field offset: 0x20
		internal RenderingData renderingData; //Field offset: 0x28
		internal int shadowmapID; //Field offset: 0x2E0
		internal bool emptyShadowmap; //Field offset: 0x2E4

		public PassData() { }

	}

	private const int k_MaxCascades = 4; //Field offset: 0x0
	private static readonly Vector4 s_EmptyShadowParams; //Field offset: 0x0
	private const string k_EmptyMainLightShadowMapTextureName = "_EmptyMainLightShadowmapTexture"; //Field offset: 0x0
	private const int k_EmptyShadowMapDimensions = 1; //Field offset: 0x0
	private const string k_MainLightShadowMapTextureName = "_MainLightShadowmapTexture"; //Field offset: 0x0
	private const int k_ShadowmapBufferBits = 16; //Field offset: 0x0
	private static readonly Vector4 s_EmptyShadowmapSize; //Field offset: 0x10
	private float m_CascadeBorder; //Field offset: 0xE0
	private float m_MaxShadowDistanceSq; //Field offset: 0xE4
	private int m_ShadowCasterCascadesCount; //Field offset: 0xE8
	private int m_MainLightShadowmapID; //Field offset: 0xEC
	internal RTHandle m_MainLightShadowmapTexture; //Field offset: 0xF0
	private RTHandle m_EmptyMainLightShadowmapTexture; //Field offset: 0xF8
	private Matrix4x4[] m_MainLightShadowMatrices; //Field offset: 0x100
	private ShadowSliceData[] m_CascadeSlices; //Field offset: 0x108
	private Vector4[] m_CascadeSplitDistances; //Field offset: 0x110
	private bool m_CreateEmptyShadowmap; //Field offset: 0x118
	private int renderTargetWidth; //Field offset: 0x11C
	private int renderTargetHeight; //Field offset: 0x120
	private ProfilingSampler m_ProfilingSetupSampler; //Field offset: 0x128

	private static MainLightShadowCasterPass() { }

	public MainLightShadowCasterPass(RenderPassEvent evt) { }

	private void Clear() { }

	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	public void Dispose() { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private void InitPassData(ref PassData passData, ref RenderingData renderingData, ref RenderGraph graph) { }

	internal TextureHandle Render(RenderGraph graph, ref RenderingData renderingData) { }

	private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref RenderingData renderingData) { }

	private void SetEmptyMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal static void SetEmptyMainLightShadowParams(CommandBuffer cmd) { }

	public bool Setup(ref RenderingData renderingData) { }

	private bool SetupForEmptyRendering(ref RenderingData renderingData) { }

	private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref VisibleLight shadowLight, ref ShadowData shadowData) { }

}

