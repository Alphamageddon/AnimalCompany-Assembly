namespace UnityEngine.InputSystem.Controls;

public class ButtonControl : AxisControl
{
	internal static float s_GlobalDefaultButtonPressPoint; //Field offset: 0x0
	internal const float kMinButtonPressPoint = 0.0001; //Field offset: 0x0
	internal static float s_GlobalDefaultButtonReleaseThreshold; //Field offset: 0x4
	public float pressPoint; //Field offset: 0x12C

	public bool isPressed
	{
		 get { } //Length: 160
	}

	public float pressPointOrDefault
	{
		 get { } //Length: 88
	}

	public bool wasPressedThisFrame
	{
		 get { } //Length: 296
	}

	public bool wasReleasedThisFrame
	{
		 get { } //Length: 296
	}

	public ButtonControl() { }

	public bool get_isPressed() { }

	public float get_pressPointOrDefault() { }

	public bool get_wasPressedThisFrame() { }

	public bool get_wasReleasedThisFrame() { }

	public bool IsValueConsideredPressed(float value) { }

}

