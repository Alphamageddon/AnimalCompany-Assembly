namespace UnityEngine.XR.Interaction.Toolkit;

[Extension]
[MovedFrom(null)]
public static class InputHelpers
{
	internal enum Axis2D
	{
		None = 0,
		PrimaryAxis2D = 1,
		SecondaryAxis2D = 2,
	}

	internal enum Button
	{
		None = 0,
		MenuButton = 1,
		Trigger = 2,
		Grip = 3,
		TriggerButton = 4,
		GripButton = 5,
		PrimaryButton = 6,
		PrimaryTouch = 7,
		SecondaryButton = 8,
		SecondaryTouch = 9,
		Primary2DAxisTouch = 10,
		Primary2DAxisClick = 11,
		Secondary2DAxisTouch = 12,
		Secondary2DAxisClick = 13,
		PrimaryAxis2DUp = 14,
		PrimaryAxis2DDown = 15,
		PrimaryAxis2DLeft = 16,
		PrimaryAxis2DRight = 17,
		SecondaryAxis2DUp = 18,
		SecondaryAxis2DDown = 19,
		SecondaryAxis2DLeft = 20,
		SecondaryAxis2DRight = 21,
		TriggerPressed = 4,
		GripPressed = 5,
	}

	private struct ButtonInfo
	{
		public string name; //Field offset: 0x0
		public ButtonReadType type; //Field offset: 0x8

		public ButtonInfo(string name, ButtonReadType type) { }

	}

	private enum ButtonReadType
	{
		None = 0,
		Binary = 1,
		Axis1D = 2,
		Axis2DUp = 3,
		Axis2DDown = 4,
		Axis2DLeft = 5,
		Axis2DRight = 6,
	}

	private static readonly ButtonInfo[] s_ButtonData; //Field offset: 0x0
	private const float k_DefaultPressThreshold = 0.1; //Field offset: 0x0
	private static readonly String[] s_Axis2DNames; //Field offset: 0x8

	private static InputHelpers() { }

	[Extension]
	public static bool IsPressed(InputDevice device, Button button, out bool isPressed, float pressThreshold = -1) { }

	[Extension]
	public static bool TryReadAxis2DValue(InputDevice device, Axis2D axis2D, out Vector2 value) { }

	[Extension]
	public static bool TryReadSingleValue(InputDevice device, Button button, out float singleValue) { }

}

