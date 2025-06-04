namespace UnityEngine.Rendering.Universal;

[DisallowMultipleRendererFeature("Screen Space Ambient Occlusion")]
[Tooltip("The Ambient Occlusion effect darkens creases, holes, intersections and surfaces that are close to each other.")]
internal class ScreenSpaceAmbientOcclusion : ScriptableRendererFeature
{
	public class ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass
	{
		private enum BlurTypes
		{
			Bilateral = 0,
			Gaussian = 1,
			Kawase = 2,
		}

		private enum ShaderPasses
		{
			AmbientOcclusion = 0,
			BilateralBlurHorizontal = 1,
			BilateralBlurVertical = 2,
			BilateralBlurFinal = 3,
			BilateralAfterOpaque = 4,
			GaussianBlurHorizontal = 5,
			GaussianBlurVertical = 6,
			GaussianAfterOpaque = 7,
			KawaseBlur = 8,
			KawaseAfterOpaque = 9,
		}

		private const string k_AmbientOcclusionParamName = "_AmbientOcclusionParam"; //Field offset: 0x0
		private const string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture"; //Field offset: 0x0
		private const int k_FinalTexID = 3; //Field offset: 0x0
		internal static readonly int s_AmbientOcclusionParamID; //Field offset: 0x0
		private static readonly int s_SSAOParamsID; //Field offset: 0x4
		private static readonly int s_SSAOBlueNoiseParamsID; //Field offset: 0x8
		private static readonly int s_LastKawasePass; //Field offset: 0xC
		private static readonly int s_BlueNoiseTextureID; //Field offset: 0x10
		private static readonly int s_CameraViewXExtentID; //Field offset: 0x14
		private static readonly int s_CameraViewYExtentID; //Field offset: 0x18
		private static readonly int s_CameraViewZExtentID; //Field offset: 0x1C
		private static readonly int s_ProjectionParams2ID; //Field offset: 0x20
		private static readonly int s_KawaseBlurIterationID; //Field offset: 0x24
		private static readonly int s_CameraViewProjectionsID; //Field offset: 0x28
		private static readonly int s_CameraViewTopLeftCornerID; //Field offset: 0x2C
		private static readonly Int32[] m_BilateralTexturesIndices; //Field offset: 0x30
		private static readonly ShaderPasses[] m_BilateralPasses; //Field offset: 0x38
		private static readonly ShaderPasses[] m_BilateralAfterOpaquePasses; //Field offset: 0x40
		private static readonly Int32[] m_GaussianTexturesIndices; //Field offset: 0x48
		private static readonly ShaderPasses[] m_GaussianPasses; //Field offset: 0x50
		private static readonly ShaderPasses[] m_GaussianAfterOpaquePasses; //Field offset: 0x58
		private static readonly Int32[] m_KawaseTexturesIndices; //Field offset: 0x60
		private static readonly ShaderPasses[] m_KawasePasses; //Field offset: 0x68
		private static readonly ShaderPasses[] m_KawaseAfterOpaquePasses; //Field offset: 0x70
		internal string profilerTag; //Field offset: 0xE0
		private bool m_SupportsR8RenderTextureFormat; //Field offset: 0xE8
		private int m_BlueNoiseTextureIndex; //Field offset: 0xEC
		private float m_BlurRandomOffsetX; //Field offset: 0xF0
		private float m_BlurRandomOffsetY; //Field offset: 0xF4
		private Material m_Material; //Field offset: 0xF8
		private Texture2D[] m_BlueNoiseTextures; //Field offset: 0x100
		private Vector4[] m_CameraTopLeftCorner; //Field offset: 0x108
		private Vector4[] m_CameraXExtent; //Field offset: 0x110
		private Vector4[] m_CameraYExtent; //Field offset: 0x118
		private Vector4[] m_CameraZExtent; //Field offset: 0x120
		private RTHandle[] m_SSAOTextures; //Field offset: 0x128
		private BlurTypes m_BlurType; //Field offset: 0x130
		private Matrix4x4[] m_CameraViewProjections; //Field offset: 0x138
		private ProfilingSampler m_ProfilingSampler; //Field offset: 0x140
		private ScriptableRenderer m_Renderer; //Field offset: 0x148
		private RenderTextureDescriptor m_AOPassDescriptor; //Field offset: 0x150
		private ScreenSpaceAmbientOcclusionSettings m_CurrentSettings; //Field offset: 0x188

		private bool isRendererDeferred
		{
			private get { } //Length: 108
		}

		private static ScreenSpaceAmbientOcclusionPass() { }

		internal ScreenSpaceAmbientOcclusionPass() { }

		public void Dispose() { }

		public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

		private bool get_isRendererDeferred() { }

		private static void GetPassOrder(BlurTypes blurType, bool isAfterOpaque, out Int32[] textureIndices, out ShaderPasses[] shaderPasses) { }

		private static bool IsAfterOpaquePass(ref ShaderPasses pass) { }

		public virtual void OnCameraCleanup(CommandBuffer cmd) { }

		public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

		private static void RenderAndSetBaseMap(ref CommandBuffer cmd, ref RenderingData renderingData, ref ScriptableRenderer renderer, ref Material mat, ref RTHandle baseMap, ref RTHandle target, ShaderPasses pass) { }

		internal bool Setup(ref ScreenSpaceAmbientOcclusionSettings featureSettings, ref ScriptableRenderer renderer, ref Material material, ref Texture2D[] blueNoiseTextures) { }

	}

	internal const string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT"; //Field offset: 0x0
	internal const string k_AOBlueNoiseKeyword = "_BLUE_NOISE"; //Field offset: 0x0
	internal const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC"; //Field offset: 0x0
	internal const string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW"; //Field offset: 0x0
	internal const string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM"; //Field offset: 0x0
	internal const string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH"; //Field offset: 0x0
	internal const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS"; //Field offset: 0x0
	internal const string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW"; //Field offset: 0x0
	internal const string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM"; //Field offset: 0x0
	internal const string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH"; //Field offset: 0x0
	[SerializeField]
	private ScreenSpaceAmbientOcclusionSettings m_Settings; //Field offset: 0x20
	[HideInInspector]
	[Reload("Textures/BlueNoise256/LDR_LLL1_{0}.png", 0, 7, Package::Root (1))]
	[SerializeField]
	internal Texture2D[] m_BlueNoise256Textures; //Field offset: 0x28
	[HideInInspector]
	[Reload("Shaders/Utils/ScreenSpaceAmbientOcclusion.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_Shader; //Field offset: 0x30
	private Material m_Material; //Field offset: 0x38
	private ScreenSpaceAmbientOcclusionPass m_SSAOPass; //Field offset: 0x40

	internal ScreenSpaceAmbientOcclusionSettings settings
	{
		internal get { } //Length: 8
	}

	public ScreenSpaceAmbientOcclusion() { }

	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	public virtual void Create() { }

	protected virtual void Dispose(bool disposing) { }

	internal ScreenSpaceAmbientOcclusionSettings get_settings() { }

	private bool GetMaterials() { }

}

