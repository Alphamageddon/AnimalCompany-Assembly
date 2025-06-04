namespace UnityEngine.Rendering.Universal;

[DisallowMultipleRendererFeature("Screen Space Shadows")]
[Tooltip("Screen Space Shadows")]
internal class ScreenSpaceShadows : ScriptableRendererFeature
{
	private class ScreenSpaceShadowsPass : ScriptableRenderPass
	{
		private static string m_ProfilerTag; //Field offset: 0x0
		private static ProfilingSampler m_ProfilingSampler; //Field offset: 0x8
		private Material m_Material; //Field offset: 0xE0
		private ScreenSpaceShadowsSettings m_CurrentSettings; //Field offset: 0xE8
		private RTHandle m_RenderTarget; //Field offset: 0xF0

		private static ScreenSpaceShadowsPass() { }

		internal ScreenSpaceShadowsPass() { }

		public void Dispose() { }

		public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

		public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

		internal bool Setup(ScreenSpaceShadowsSettings featureSettings, Material material) { }

	}

	private class ScreenSpaceShadowsPostPass : ScriptableRenderPass
	{
		private static string m_ProfilerTag; //Field offset: 0x0
		private static ProfilingSampler m_ProfilingSampler; //Field offset: 0x8
		private static readonly RTHandle k_CurrentActive; //Field offset: 0x10

		private static ScreenSpaceShadowsPostPass() { }

		public ScreenSpaceShadowsPostPass() { }

		public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

		public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	}

	private const string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows"; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private Shader m_Shader; //Field offset: 0x20
	[SerializeField]
	private ScreenSpaceShadowsSettings m_Settings; //Field offset: 0x28
	private Material m_Material; //Field offset: 0x30
	private ScreenSpaceShadowsPass m_SSShadowsPass; //Field offset: 0x38
	private ScreenSpaceShadowsPostPass m_SSShadowsPostPass; //Field offset: 0x40

	public ScreenSpaceShadows() { }

	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	public virtual void Create() { }

	protected virtual void Dispose(bool disposing) { }

	private bool LoadMaterial() { }

}

