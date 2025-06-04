namespace UnityEngine.Rendering.Universal;

internal class CapturePass : ScriptableRenderPass
{
	private const string m_ProfilerTag = "Capture Pass"; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x0
	private RTHandle m_CameraColorHandle; //Field offset: 0xE0

	private static CapturePass() { }

	public CapturePass(RenderPassEvent evt) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

}

