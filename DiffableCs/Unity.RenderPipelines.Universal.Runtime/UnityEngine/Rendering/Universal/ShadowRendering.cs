namespace UnityEngine.Rendering.Universal;

[Extension]
internal static class ShadowRendering
{
	private static readonly int k_LightPosID; //Field offset: 0x0
	private static readonly int k_SelfShadowingID; //Field offset: 0x4
	private static readonly int k_ShadowStencilGroupID; //Field offset: 0x8
	private static readonly int k_ShadowIntensityID; //Field offset: 0xC
	private static readonly int k_ShadowVolumeIntensityID; //Field offset: 0x10
	private static readonly int k_ShadowRadiusID; //Field offset: 0x14
	private static readonly int k_ShadowColorMaskID; //Field offset: 0x18
	private static readonly int k_ShadowModelMatrixID; //Field offset: 0x1C
	private static readonly int k_ShadowModelInvMatrixID; //Field offset: 0x20
	private static readonly int k_ShadowModelScaleID; //Field offset: 0x24
	private static readonly ProfilingSampler m_ProfilingSamplerShadows; //Field offset: 0x28
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsA; //Field offset: 0x30
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsR; //Field offset: 0x38
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsG; //Field offset: 0x40
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsB; //Field offset: 0x48
	private static RTHandle[] m_RenderTargets; //Field offset: 0x50
	private static Int32[] m_RenderTargetIds; //Field offset: 0x58
	private static RenderTargetIdentifier[] m_LightInputTextures; //Field offset: 0x60
	private static readonly Color[] k_ColorLookup; //Field offset: 0x68
	private static readonly ProfilingSampler[] m_ProfilingSamplerShadowColorsLookup; //Field offset: 0x70
	[CompilerGenerated]
	private static uint <maxTextureCount>k__BackingField; //Field offset: 0x78

	public private static uint maxTextureCount
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		private set { } //Length: 92
	}

	private static ShadowRendering() { }

	private static Material[] CreateMaterials(Shader shader, int pass = 0) { }

	private static void CreateShadowRenderTexture(IRenderPass2D pass, int handleId, RenderingData renderingData, CommandBuffer cmdBuffer) { }

	public static void CreateShadowRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int shadowIndex) { }

	public static void DisableGlobalShadowTexture(CommandBuffer cmdBuffer) { }

	[CompilerGenerated]
	public static uint get_maxTextureCount() { }

	[Extension]
	private static Material GetGeometryUnshadowMaterial(Renderer2DData rendererData, int colorIndex) { }

	[Extension]
	private static Material GetProjectedShadowMaterial(Renderer2DData rendererData, int colorIndex) { }

	[Extension]
	private static Material GetSpriteSelfShadowMaterial(Renderer2DData rendererData, int colorIndex) { }

	[Extension]
	private static Material GetSpriteUnshadowMaterial(Renderer2DData rendererData, int colorIndex) { }

	[Extension]
	private static Material GetStencilOnlyShadowMaterial(Renderer2DData rendererData, int colorIndex) { }

	public static void InitializeBudget(uint maxTextureCount) { }

	public static bool PrerenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, int shadowIndex, float shadowIntensity) { }

	public static void ReleaseShadowRenderTexture(CommandBuffer cmdBuffer, int shadowIndex) { }

	public static bool RenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, float shadowIntensity, RenderTargetIdentifier renderTexture, int colorBit) { }

	[CompilerGenerated]
	private static void set_maxTextureCount(uint value) { }

	public static void SetGlobalShadowTexture(CommandBuffer cmdBuffer, Light2D light, int shadowIndex) { }

	public static void SetShadowProjectionGlobals(CommandBuffer cmdBuffer, ShadowCaster2D shadowCaster) { }

}

