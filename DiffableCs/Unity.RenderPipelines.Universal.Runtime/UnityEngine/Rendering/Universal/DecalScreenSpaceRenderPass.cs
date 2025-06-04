namespace UnityEngine.Rendering.Universal;

internal class DecalScreenSpaceRenderPass : ScriptableRenderPass
{
	private FilteringSettings m_FilteringSettings; //Field offset: 0xE0
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0xF8
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x100
	private DecalDrawScreenSpaceSystem m_DrawSystem; //Field offset: 0x108
	private DecalScreenSpaceSettings m_Settings; //Field offset: 0x110
	private bool m_DecalLayers; //Field offset: 0x118

	public DecalScreenSpaceRenderPass(DecalScreenSpaceSettings settings, DecalDrawScreenSpaceSystem drawSystem, bool decalLayers) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

}

