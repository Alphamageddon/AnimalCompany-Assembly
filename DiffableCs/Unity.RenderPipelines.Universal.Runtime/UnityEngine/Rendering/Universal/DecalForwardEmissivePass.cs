namespace UnityEngine.Rendering.Universal;

internal class DecalForwardEmissivePass : ScriptableRenderPass
{
	private FilteringSettings m_FilteringSettings; //Field offset: 0xE0
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0xF8
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x100
	private DecalDrawFowardEmissiveSystem m_DrawSystem; //Field offset: 0x108

	public DecalForwardEmissivePass(DecalDrawFowardEmissiveSystem drawSystem) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

}

