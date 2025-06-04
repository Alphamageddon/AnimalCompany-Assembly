namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

[InputControlLayout(stateType = typeof(XRSimulatedControllerState), commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}], isGenericTypeOfDevice = False, displayName = "XR Simulated Controller", updateBeforeRender = True)]
[Preserve]
public class XRSimulatedController : XRController
{
	[CompilerGenerated]
	private Vector2Control <primary2DAxis>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private Vector2Control <secondary2DAxis>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private ButtonControl <primaryButton>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private ButtonControl <primaryTouch>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private ButtonControl <secondaryButton>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private ButtonControl <secondaryTouch>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private ButtonControl <gripButton>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private ButtonControl <triggerButton>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private ButtonControl <menuButton>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private ButtonControl <primary2DAxisClick>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private ButtonControl <primary2DAxisTouch>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private ButtonControl <secondary2DAxisClick>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	private ButtonControl <secondary2DAxisTouch>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	private AxisControl <batteryLevel>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	private ButtonControl <userPresence>k__BackingField; //Field offset: 0x210

	public private AxisControl batteryLevel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private AxisControl grip
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl gripButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl menuButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Vector2Control primary2DAxis
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl primary2DAxisClick
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl primary2DAxisTouch
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl primaryButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl primaryTouch
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Vector2Control secondary2DAxis
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl secondary2DAxisClick
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl secondary2DAxisTouch
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl secondaryButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl secondaryTouch
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private AxisControl trigger
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl triggerButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ButtonControl userPresence
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public XRSimulatedController() { }

	protected virtual long ExecuteCommand(InputDeviceCommand* commandPtr) { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_batteryLevel() { }

	[CompilerGenerated]
	public AxisControl get_grip() { }

	[CompilerGenerated]
	public ButtonControl get_gripButton() { }

	[CompilerGenerated]
	public ButtonControl get_menuButton() { }

	[CompilerGenerated]
	public Vector2Control get_primary2DAxis() { }

	[CompilerGenerated]
	public ButtonControl get_primary2DAxisClick() { }

	[CompilerGenerated]
	public ButtonControl get_primary2DAxisTouch() { }

	[CompilerGenerated]
	public ButtonControl get_primaryButton() { }

	[CompilerGenerated]
	public ButtonControl get_primaryTouch() { }

	[CompilerGenerated]
	public Vector2Control get_secondary2DAxis() { }

	[CompilerGenerated]
	public ButtonControl get_secondary2DAxisClick() { }

	[CompilerGenerated]
	public ButtonControl get_secondary2DAxisTouch() { }

	[CompilerGenerated]
	public ButtonControl get_secondaryButton() { }

	[CompilerGenerated]
	public ButtonControl get_secondaryTouch() { }

	[CompilerGenerated]
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	public ButtonControl get_triggerButton() { }

	[CompilerGenerated]
	public ButtonControl get_userPresence() { }

	[CompilerGenerated]
	private void set_batteryLevel(AxisControl value) { }

	[CompilerGenerated]
	private void set_grip(AxisControl value) { }

	[CompilerGenerated]
	private void set_gripButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_menuButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_primary2DAxis(Vector2Control value) { }

	[CompilerGenerated]
	private void set_primary2DAxisClick(ButtonControl value) { }

	[CompilerGenerated]
	private void set_primary2DAxisTouch(ButtonControl value) { }

	[CompilerGenerated]
	private void set_primaryButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_primaryTouch(ButtonControl value) { }

	[CompilerGenerated]
	private void set_secondary2DAxis(Vector2Control value) { }

	[CompilerGenerated]
	private void set_secondary2DAxisClick(ButtonControl value) { }

	[CompilerGenerated]
	private void set_secondary2DAxisTouch(ButtonControl value) { }

	[CompilerGenerated]
	private void set_secondaryButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_secondaryTouch(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	private void set_triggerButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_userPresence(ButtonControl value) { }

}

