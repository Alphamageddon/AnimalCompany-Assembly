namespace UnityEngine.Rendering.Universal;

internal class UpscalePass : ScriptableRenderPass
{
	private static readonly ProfilingSampler m_ProfilingScope; //Field offset: 0x0
	private static Material m_BlitMaterial; //Field offset: 0x8
	private RTHandle m_Source; //Field offset: 0xE0
	private RTHandle m_UpscaleHandle; //Field offset: 0xE8

	private static UpscalePass() { }

	public UpscalePass(RenderPassEvent evt, Material blitMaterial) { }

	public void Dispose() { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public void Setup(RTHandle colorTargetHandle, int width, int height, FilterMode mode, ref RenderingData renderingData, out RTHandle upscaleHandle) { }

}

