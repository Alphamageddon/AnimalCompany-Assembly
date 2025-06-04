namespace UnityEngine.Rendering.Universal;

internal class TransparentSettingsPass : ScriptableRenderPass
{
	private const string m_ProfilerTag = "Transparent Settings Pass"; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x0
	private bool m_shouldReceiveShadows; //Field offset: 0xE0

	private static TransparentSettingsPass() { }

	public TransparentSettingsPass(RenderPassEvent evt, bool shadowReceiveSupported) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public static void ExecutePass(CommandBuffer cmd, bool shouldReceiveShadows) { }

	public bool Setup() { }

}

