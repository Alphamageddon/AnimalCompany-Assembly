namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

public struct XRSimulatedControllerState : IInputStateTypeInfo
{
	[InputControl(usage = "Primary2DAxis", aliases = new IL2CPP_TYPE_STRING[] {"thumbstick", "joystick"}], offset = 0)]
	public Vector2 primary2DAxis; //Field offset: 0x0
	[InputControl(usage = "Trigger", layout = "Axis", offset = 8)]
	public float trigger; //Field offset: 0x8
	[InputControl(usage = "Grip", layout = "Axis", offset = 12)]
	public float grip; //Field offset: 0xC
	[InputControl(usage = "Secondary2DAxis", offset = 16)]
	public Vector2 secondary2DAxis; //Field offset: 0x10
	[InputControl(name = "primary2DAxisClick", usage = "Primary2DAxisClick", layout = "Button", bit = 7, offset = 24)]
	[InputControl(name = "secondary2DAxisClick", usage = "Secondary2DAxisClick", layout = "Button", bit = 9, offset = 24)]
	[InputControl(name = "primaryTouch", usage = "PrimaryTouch", layout = "Button", bit = 1, offset = 24)]
	[InputControl(name = "secondaryButton", usage = "SecondaryButton", layout = "Button", bit = 2, offset = 24)]
	[InputControl(name = "secondaryTouch", usage = "SecondaryTouch", layout = "Button", bit = 3, offset = 24)]
	[InputControl(name = "gripButton", usage = "GripButton", layout = "Button", bit = 4, offset = 24, alias = "gripPressed")]
	[InputControl(name = "triggerButton", usage = "TriggerButton", layout = "Button", bit = 5, offset = 24, alias = "triggerPressed")]
	[InputControl(name = "menuButton", usage = "MenuButton", layout = "Button", bit = 6, offset = 24)]
	[InputControl(name = "primary2DAxisTouch", usage = "Primary2DAxisTouch", layout = "Button", bit = 8, offset = 24)]
	[InputControl(name = "primaryButton", usage = "PrimaryButton", layout = "Button", bit = 0, offset = 24)]
	[InputControl(name = "secondary2DAxisTouch", usage = "Secondary2DAxisTouch", layout = "Button", bit = 10, offset = 24)]
	[InputControl(name = "userPresence", usage = "UserPresence", layout = "Button", bit = 11, offset = 24)]
	public ushort buttons; //Field offset: 0x18
	[InputControl(usage = "BatteryLevel", layout = "Axis", offset = 26)]
	public float batteryLevel; //Field offset: 0x1A
	[InputControl(usage = "TrackingState", layout = "Integer", offset = 30)]
	public int trackingState; //Field offset: 0x1E
	[InputControl(usage = "IsTracked", layout = "Button", offset = 34)]
	public bool isTracked; //Field offset: 0x22
	[InputControl(usage = "DevicePosition", offset = 35)]
	public Vector3 devicePosition; //Field offset: 0x23
	[InputControl(usage = "DeviceRotation", offset = 47)]
	public Quaternion deviceRotation; //Field offset: 0x2F

	public override FourCC format
	{
		 get { } //Length: 48
	}

	public static FourCC formatId
	{
		 get { } //Length: 48
	}

	public override FourCC get_format() { }

	public static FourCC get_formatId() { }

	public bool HasButton(ControllerButton button) { }

	public void Reset() { }

	public XRSimulatedControllerState WithButton(ControllerButton button, bool state = true) { }

}

