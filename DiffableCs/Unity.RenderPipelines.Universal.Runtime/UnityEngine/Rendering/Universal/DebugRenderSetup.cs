namespace UnityEngine.Rendering.Universal;

internal class DebugRenderSetup : IDisposable
{
	private readonly DebugHandler m_DebugHandler; //Field offset: 0x10
	private readonly ScriptableRenderContext m_Context; //Field offset: 0x18
	private readonly CommandBuffer m_CommandBuffer; //Field offset: 0x20
	private readonly int m_Index; //Field offset: 0x28
	private readonly FilteringSettings m_FilteringSettings; //Field offset: 0x2C

	private DebugDisplaySettingsLighting LightingSettings
	{
		private get { } //Length: 36
	}

	private DebugDisplaySettingsMaterial MaterialSettings
	{
		private get { } //Length: 36
	}

	private DebugDisplaySettingsRendering RenderingSettings
	{
		private get { } //Length: 36
	}

	internal DebugRenderSetup(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, int index, FilteringSettings filteringSettings) { }

	private void Begin() { }

	internal DrawingSettings CreateDrawingSettings(DrawingSettings drawingSettings) { }

	public override void Dispose() { }

	private void End() { }

	private DebugDisplaySettingsLighting get_LightingSettings() { }

	private DebugDisplaySettingsMaterial get_MaterialSettings() { }

	private DebugDisplaySettingsRendering get_RenderingSettings() { }

	internal RenderStateBlock GetRenderStateBlock(RenderStateBlock renderStateBlock) { }

}

