namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
[ReloadGroup]
public class Renderer2DData : ScriptableRendererData
{
	public enum Renderer2DDefaultMaterialType
	{
		Lit = 0,
		Unlit = 1,
		Custom = 2,
	}

	[SerializeField]
	private TransparencySortMode m_TransparencySortMode; //Field offset: 0x3C
	[SerializeField]
	private Vector3 m_TransparencySortAxis; //Field offset: 0x40
	[SerializeField]
	private float m_HDREmulationScale; //Field offset: 0x4C
	[Range(0.01, 1)]
	[SerializeField]
	private float m_LightRenderTextureScale; //Field offset: 0x50
	[FormerlySerializedAs("m_LightOperations")]
	[SerializeField]
	private Light2DBlendStyle[] m_LightBlendStyles; //Field offset: 0x58
	[SerializeField]
	private bool m_UseDepthStencilBuffer; //Field offset: 0x60
	[SerializeField]
	private bool m_UseCameraSortingLayersTexture; //Field offset: 0x61
	[SerializeField]
	private int m_CameraSortingLayersTextureBound; //Field offset: 0x64
	[SerializeField]
	private Downsampling m_CameraSortingLayerDownsamplingMethod; //Field offset: 0x68
	[SerializeField]
	private uint m_MaxLightRenderTextureCount; //Field offset: 0x6C
	[SerializeField]
	private uint m_MaxShadowRenderTextureCount; //Field offset: 0x70
	[Reload("Shaders/2D/Light2D-Shape.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_ShapeLightShader; //Field offset: 0x78
	[Reload("Shaders/2D/Light2D-Shape-Volumetric.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_ShapeLightVolumeShader; //Field offset: 0x80
	[Reload("Shaders/2D/Light2D-Point.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_PointLightShader; //Field offset: 0x88
	[Reload("Shaders/2D/Light2D-Point-Volumetric.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_PointLightVolumeShader; //Field offset: 0x90
	[Reload("Shaders/Utils/CoreBlit.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_CoreBlitShader; //Field offset: 0x98
	[Reload("Shaders/Utils/BlitHDROverlay.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_BlitHDROverlay; //Field offset: 0xA0
	[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_CoreBlitColorAndDepthPS; //Field offset: 0xA8
	[Reload("Shaders/Utils/Sampling.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_SamplingShader; //Field offset: 0xB0
	[Reload("Shaders/2D/Shadow2D-Projected.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_ProjectedShadowShader; //Field offset: 0xB8
	[Reload("Shaders/2D/Shadow2D-Shadow-Sprite.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_SpriteShadowShader; //Field offset: 0xC0
	[Reload("Shaders/2D/Shadow2D-Unshadow-Sprite.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_SpriteUnshadowShader; //Field offset: 0xC8
	[Reload("Shaders/2D/Shadow2D-Unshadow-Geometry.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_GeometryUnshadowShader; //Field offset: 0xD0
	[Reload("Shaders/Utils/FallbackError.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_FallbackErrorShader; //Field offset: 0xD8
	[SerializeField]
	private PostProcessData m_PostProcessData; //Field offset: 0xE0
	[HideInInspector]
	[Reload("Runtime/2D/Data/Textures/FalloffLookupTexture.png", Package::Root (1))]
	[SerializeField]
	private Texture2D m_FallOffLookup; //Field offset: 0xE8
	[CompilerGenerated]
	private readonly Dictionary<UInt32, Material> <lightMaterials>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private Material[] <spriteSelfShadowMaterial>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private Material[] <spriteUnshadowMaterial>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private Material[] <geometryUnshadowMaterial>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private Material[] <projectedShadowMaterial>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private Material[] <stencilOnlyShadowMaterial>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private bool <isNormalsRenderTargetValid>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private float <normalsRenderTargetScale>k__BackingField; //Field offset: 0x124
	internal RTHandle normalsRenderTarget; //Field offset: 0x128
	internal int normalsRenderTargetId; //Field offset: 0x130
	internal RTHandle shadowsRenderTarget; //Field offset: 0x138
	internal int shadowsRenderTargetId; //Field offset: 0x140
	internal RTHandle cameraSortingLayerRenderTarget; //Field offset: 0x148
	internal int cameraSortingLayerRenderTargetId; //Field offset: 0x150
	[CompilerGenerated]
	private ILight2DCullResult <lightCullResult>k__BackingField; //Field offset: 0x158

	internal Shader blitHDROverlay
	{
		internal get { } //Length: 8
	}

	internal Shader blitShader
	{
		internal get { } //Length: 8
	}

	internal Downsampling cameraSortingLayerDownsamplingMethod
	{
		internal get { } //Length: 8
	}

	internal int cameraSortingLayerTextureBound
	{
		internal get { } //Length: 8
	}

	internal Shader coreBlitColorAndDepthPS
	{
		internal get { } //Length: 8
	}

	internal Shader coreBlitPS
	{
		internal get { } //Length: 8
	}

	internal Texture2D fallOffLookup
	{
		internal get { } //Length: 8
	}

	internal Material[] geometryUnshadowMaterial
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal Shader geometryUnshadowShader
	{
		internal get { } //Length: 8
	}

	public float hdrEmulationScale
	{
		 get { } //Length: 8
	}

	internal bool isNormalsRenderTargetValid
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public Light2DBlendStyle[] lightBlendStyles
	{
		 get { } //Length: 8
	}

	internal ILight2DCullResult lightCullResult
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal Dictionary<UInt32, Material> lightMaterials
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	internal uint lightRenderTextureMemoryBudget
	{
		internal get { } //Length: 8
	}

	internal float lightRenderTextureScale
	{
		internal get { } //Length: 8
	}

	internal float normalsRenderTargetScale
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal Shader pointLightShader
	{
		internal get { } //Length: 8
	}

	internal Shader pointLightVolumeShader
	{
		internal get { } //Length: 8
	}

	internal PostProcessData postProcessData
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	internal Material[] projectedShadowMaterial
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal Shader projectedShadowShader
	{
		internal get { } //Length: 8
	}

	internal Shader samplingShader
	{
		internal get { } //Length: 8
	}

	internal uint shadowRenderTextureMemoryBudget
	{
		internal get { } //Length: 8
	}

	internal Shader shapeLightShader
	{
		internal get { } //Length: 8
	}

	internal Shader shapeLightVolumeShader
	{
		internal get { } //Length: 8
	}

	internal Material[] spriteSelfShadowMaterial
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal Shader spriteShadowShader
	{
		internal get { } //Length: 8
	}

	internal Material[] spriteUnshadowMaterial
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal Shader spriteUnshadowShader
	{
		internal get { } //Length: 8
	}

	internal Material[] stencilOnlyShadowMaterial
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal Vector3 transparencySortAxis
	{
		internal get { } //Length: 12
	}

	internal TransparencySortMode transparencySortMode
	{
		internal get { } //Length: 8
	}

	internal bool useCameraSortingLayerTexture
	{
		internal get { } //Length: 8
	}

	internal bool useDepthStencilBuffer
	{
		internal get { } //Length: 8
	}

	public Renderer2DData() { }

	protected virtual ScriptableRenderer Create() { }

	internal void Dispose() { }

	internal Shader get_blitHDROverlay() { }

	internal Shader get_blitShader() { }

	internal Downsampling get_cameraSortingLayerDownsamplingMethod() { }

	internal int get_cameraSortingLayerTextureBound() { }

	internal Shader get_coreBlitColorAndDepthPS() { }

	internal Shader get_coreBlitPS() { }

	internal Texture2D get_fallOffLookup() { }

	[CompilerGenerated]
	internal Material[] get_geometryUnshadowMaterial() { }

	internal Shader get_geometryUnshadowShader() { }

	public float get_hdrEmulationScale() { }

	[CompilerGenerated]
	internal bool get_isNormalsRenderTargetValid() { }

	public Light2DBlendStyle[] get_lightBlendStyles() { }

	[CompilerGenerated]
	internal ILight2DCullResult get_lightCullResult() { }

	[CompilerGenerated]
	internal Dictionary<UInt32, Material> get_lightMaterials() { }

	internal uint get_lightRenderTextureMemoryBudget() { }

	internal float get_lightRenderTextureScale() { }

	[CompilerGenerated]
	internal float get_normalsRenderTargetScale() { }

	internal Shader get_pointLightShader() { }

	internal Shader get_pointLightVolumeShader() { }

	internal PostProcessData get_postProcessData() { }

	[CompilerGenerated]
	internal Material[] get_projectedShadowMaterial() { }

	internal Shader get_projectedShadowShader() { }

	internal Shader get_samplingShader() { }

	internal uint get_shadowRenderTextureMemoryBudget() { }

	internal Shader get_shapeLightShader() { }

	internal Shader get_shapeLightVolumeShader() { }

	[CompilerGenerated]
	internal Material[] get_spriteSelfShadowMaterial() { }

	internal Shader get_spriteShadowShader() { }

	[CompilerGenerated]
	internal Material[] get_spriteUnshadowMaterial() { }

	internal Shader get_spriteUnshadowShader() { }

	[CompilerGenerated]
	internal Material[] get_stencilOnlyShadowMaterial() { }

	internal Vector3 get_transparencySortAxis() { }

	internal TransparencySortMode get_transparencySortMode() { }

	internal bool get_useCameraSortingLayerTexture() { }

	internal bool get_useDepthStencilBuffer() { }

	protected virtual void OnEnable() { }

	[CompilerGenerated]
	internal void set_geometryUnshadowMaterial(Material[] value) { }

	[CompilerGenerated]
	internal void set_isNormalsRenderTargetValid(bool value) { }

	[CompilerGenerated]
	internal void set_lightCullResult(ILight2DCullResult value) { }

	[CompilerGenerated]
	internal void set_normalsRenderTargetScale(float value) { }

	internal void set_postProcessData(PostProcessData value) { }

	[CompilerGenerated]
	internal void set_projectedShadowMaterial(Material[] value) { }

	[CompilerGenerated]
	internal void set_spriteSelfShadowMaterial(Material[] value) { }

	[CompilerGenerated]
	internal void set_spriteUnshadowMaterial(Material[] value) { }

	[CompilerGenerated]
	internal void set_stencilOnlyShadowMaterial(Material[] value) { }

}

