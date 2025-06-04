namespace UnityEngine.Rendering.Universal;

internal class UniversalRenderPipelineGlobalSettings : RenderPipelineGlobalSettings, ISerializationCallbackReceiver, IShaderVariantSettings
{
	private static UniversalRenderPipelineGlobalSettings cachedInstance; //Field offset: 0x0
	public static readonly string defaultAssetName; //Field offset: 0x8
	[SerializeField]
	private int k_AssetVersion; //Field offset: 0x18
	[SerializeField]
	private String[] m_RenderingLayerNames; //Field offset: 0x20
	private String[] m_PrefixedRenderingLayerNames; //Field offset: 0x28
	[SerializeField]
	private uint m_ValidRenderingLayers; //Field offset: 0x30
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName0; //Field offset: 0x38
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName1; //Field offset: 0x40
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName2; //Field offset: 0x48
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName3; //Field offset: 0x50
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName4; //Field offset: 0x58
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName5; //Field offset: 0x60
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName6; //Field offset: 0x68
	[Obsolete("This is obsolete, please use renderingLayerNames instead.", False)]
	public string lightLayerName7; //Field offset: 0x70
	[SerializeField]
	private bool m_StripDebugVariants; //Field offset: 0x78
	[SerializeField]
	private bool m_StripUnusedPostProcessingVariants; //Field offset: 0x79
	[SerializeField]
	private bool m_StripUnusedVariants; //Field offset: 0x7A
	[SerializeField]
	private bool m_StripUnusedLODCrossFadeVariants; //Field offset: 0x7B
	[SerializeField]
	private bool m_StripScreenCoordOverrideVariants; //Field offset: 0x7C
	[Obsolete("Please use stripRuntimeDebugShaders instead.", False)]
	public bool supportRuntimeDebugDisplay; //Field offset: 0x7D
	[SerializeField]
	internal ShaderVariantLogLevel m_ShaderVariantLogLevel; //Field offset: 0x80
	[SerializeField]
	internal bool m_ExportShaderVariants; //Field offset: 0x84

	public override bool exportShaderVariants
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public static UniversalRenderPipelineGlobalSettings instance
	{
		 get { } //Length: 300
	}

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public String[] lightLayerNames
	{
		 get { } //Length: 68
	}

	[Obsolete("This is obsolete, please use prefixedRenderingLayerMaskNames instead.", False)]
	public String[] prefixedLightLayerNames
	{
		 get { } //Length: 68
	}

	public String[] prefixedRenderingLayerMaskNames
	{
		 get { } //Length: 36
	}

	private String[] prefixedRenderingLayerNames
	{
		private get { } //Length: 36
	}

	public String[] renderingLayerMaskNames
	{
		 get { } //Length: 36
	}

	private String[] renderingLayerNames
	{
		private get { } //Length: 36
	}

	public override ShaderVariantLogLevel shaderVariantLogLevel
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool stripDebugVariants
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool stripScreenCoordOverrideVariants
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("No longer used as Shader Prefiltering automatically strips out unused LOD Crossfade variants. Please use the LOD Crossfade setting in the URP Asset to disable the feature if not used.", False)]
	public bool stripUnusedLODCrossFadeVariants
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool stripUnusedPostProcessingVariants
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool stripUnusedVariants
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public uint validRenderingLayers
	{
		 get { } //Length: 36
	}

	private static UniversalRenderPipelineGlobalSettings() { }

	public UniversalRenderPipelineGlobalSettings() { }

	public override bool get_exportShaderVariants() { }

	public static UniversalRenderPipelineGlobalSettings get_instance() { }

	public String[] get_lightLayerNames() { }

	public String[] get_prefixedLightLayerNames() { }

	public String[] get_prefixedRenderingLayerMaskNames() { }

	private String[] get_prefixedRenderingLayerNames() { }

	public String[] get_renderingLayerMaskNames() { }

	private String[] get_renderingLayerNames() { }

	public override ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	public bool get_stripDebugVariants() { }

	public bool get_stripScreenCoordOverrideVariants() { }

	public bool get_stripUnusedLODCrossFadeVariants() { }

	public bool get_stripUnusedPostProcessingVariants() { }

	public bool get_stripUnusedVariants() { }

	public uint get_validRenderingLayers() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	private void Reset() { }

	internal void ResetRenderingLayerNames() { }

	public override void set_exportShaderVariants(bool value) { }

	public override void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

	public void set_stripDebugVariants(bool value) { }

	public void set_stripScreenCoordOverrideVariants(bool value) { }

	public void set_stripUnusedLODCrossFadeVariants(bool value) { }

	public void set_stripUnusedPostProcessingVariants(bool value) { }

	public void set_stripUnusedVariants(bool value) { }

	internal static void UpdateGraphicsSettings(UniversalRenderPipelineGlobalSettings newSettings) { }

	internal void UpdateRenderingLayerNames() { }

}

