namespace UnityEngine.Rendering.Universal;

internal class DecalGBufferRenderPass : ScriptableRenderPass
{
	private FilteringSettings m_FilteringSettings; //Field offset: 0xE0
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0xF8
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x100
	private DecalDrawGBufferSystem m_DrawSystem; //Field offset: 0x108
	private DecalScreenSpaceSettings m_Settings; //Field offset: 0x110
	private DeferredLights m_DeferredLights; //Field offset: 0x118
	private RTHandle[] m_GbufferAttachments; //Field offset: 0x120
	private bool m_DecalLayers; //Field offset: 0x128

	public DecalGBufferRenderPass(DecalScreenSpaceSettings settings, DecalDrawGBufferSystem drawSystem, bool decalLayers) { }

	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	internal void Setup(DeferredLights deferredLights) { }

}

