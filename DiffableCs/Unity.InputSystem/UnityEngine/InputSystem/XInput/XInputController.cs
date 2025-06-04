namespace UnityEngine.InputSystem.XInput;

[InputControlLayout(displayName = "Xbox Controller")]
public class XInputController : Gamepad
{
	public struct Capabilities
	{
		public DeviceType type; //Field offset: 0x0
		public DeviceSubType subType; //Field offset: 0x4
		public DeviceFlags flags; //Field offset: 0x8

	}

	[Flags]
	internal enum DeviceFlags
	{
		ForceFeedbackSupported = 1,
		Wireless = 2,
		VoiceSupported = 4,
		PluginModulesSupported = 8,
		NoNavigation = 16,
	}

	internal enum DeviceSubType
	{
		Unknown = 0,
		Gamepad = 1,
		Wheel = 2,
		ArcadeStick = 3,
		FlightStick = 4,
		DancePad = 5,
		Guitar = 6,
		GuitarAlternate = 7,
		DrumKit = 8,
		GuitarBass = 11,
		ArcadePad = 19,
	}

	public enum DeviceType
	{
		Gamepad = 0,
	}

	[CompilerGenerated]
	private ButtonControl <menu>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private ButtonControl <view>k__BackingField; //Field offset: 0x1F8
	private bool m_HaveParsedCapabilities; //Field offset: 0x200
	private DeviceSubType m_SubType; //Field offset: 0x204
	private DeviceFlags m_Flags; //Field offset: 0x208

	public DeviceFlags flags
	{
		 get { } //Length: 36
	}

	[InputControl(name = "select", displayName = "View", alias = "view")]
	[InputControl(name = "rightTrigger", shortDisplayName = "RT")]
	[InputControl(name = "leftTrigger", shortDisplayName = "LT")]
	[InputControl(name = "rightShoulder", displayName = "Right Bumper", shortDisplayName = "RB")]
	[InputControl(name = "leftShoulder", displayName = "Left Bumper", shortDisplayName = "LB")]
	[InputControl(name = "buttonNorth", displayName = "Y")]
	[InputControl(name = "buttonWest", displayName = "X")]
	[InputControl(name = "start", displayName = "Menu", alias = "menu")]
	[InputControl(name = "buttonSouth", displayName = "A")]
	[InputControl(name = "buttonEast", displayName = "B")]
	public ButtonControl menu
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public DeviceSubType subType
	{
		 get { } //Length: 36
	}

	public ButtonControl view
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public XInputController() { }

	protected virtual void FinishSetup() { }

	public DeviceFlags get_flags() { }

	[CompilerGenerated]
	public ButtonControl get_menu() { }

	public DeviceSubType get_subType() { }

	[CompilerGenerated]
	public ButtonControl get_view() { }

	private void ParseCapabilities() { }

	[CompilerGenerated]
	protected void set_menu(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_view(ButtonControl value) { }

}

