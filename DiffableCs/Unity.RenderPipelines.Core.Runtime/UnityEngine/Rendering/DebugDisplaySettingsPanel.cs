namespace UnityEngine.Rendering;

public abstract class DebugDisplaySettingsPanel : IDebugDisplaySettingsPanelDisposable, IDebugDisplaySettingsPanel, IDisposable
{
	private readonly List<Widget> m_Widgets; //Field offset: 0x10
	private readonly DisplayInfoAttribute m_DisplayInfo; //Field offset: 0x18

	public override Flags Flags
	{
		 get { } //Length: 8
	}

	public override int Order
	{
		 get { } //Length: 24
	}

	public override string PanelName
	{
		 get { } //Length: 92
	}

	public override Widget[] Widgets
	{
		 get { } //Length: 80
	}

	protected DebugDisplaySettingsPanel() { }

	protected void AddWidget(Widget widget) { }

	protected void Clear() { }

	public override void Dispose() { }

	public override Flags get_Flags() { }

	public override int get_Order() { }

	public override string get_PanelName() { }

	public override Widget[] get_Widgets() { }

}

