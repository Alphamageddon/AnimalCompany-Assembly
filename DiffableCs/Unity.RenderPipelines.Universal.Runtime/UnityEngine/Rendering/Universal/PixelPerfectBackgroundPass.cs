namespace UnityEngine.Rendering.Universal;

internal class PixelPerfectBackgroundPass : ScriptableRenderPass
{
	private static readonly ProfilingSampler m_ProfilingScope; //Field offset: 0x0

	private static PixelPerfectBackgroundPass() { }

	public PixelPerfectBackgroundPass(RenderPassEvent evt) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

}

