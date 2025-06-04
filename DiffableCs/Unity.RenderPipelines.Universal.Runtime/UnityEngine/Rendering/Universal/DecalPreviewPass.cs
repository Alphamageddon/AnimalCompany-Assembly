namespace UnityEngine.Rendering.Universal;

internal class DecalPreviewPass : ScriptableRenderPass
{
	private FilteringSettings m_FilteringSettings; //Field offset: 0xE0
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0xF8
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0x100

	public DecalPreviewPass() { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

}

