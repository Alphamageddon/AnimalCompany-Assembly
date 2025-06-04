namespace UnityEngine.Rendering.Universal;

internal class DebugDisplayStats : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Display Stats", order = -2147483648)]
	private class StatsPanel : DebugDisplaySettingsPanel
	{

		public virtual Flags Flags
		{
			 get { } //Length: 8
		}

		public StatsPanel(DebugFrameTiming frameTiming) { }

		public virtual Flags get_Flags() { }

	}

	private DebugFrameTiming m_DebugFrameTiming; //Field offset: 0x10

	public override bool AreAnySettingsActive
	{
		 get { } //Length: 8
	}

	public override bool IsLightingActive
	{
		 get { } //Length: 8
	}

	public override bool IsPostProcessingAllowed
	{
		 get { } //Length: 8
	}

	public DebugDisplayStats() { }

	public override IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	public override bool get_AreAnySettingsActive() { }

	public override bool get_IsLightingActive() { }

	public override bool get_IsPostProcessingAllowed() { }

	public override bool TryGetScreenClearColor(ref Color _) { }

	public void UpdateFrameTiming() { }

}

