namespace UnityEngine.InputSystem.Android.LowLevel;

public struct AndroidGameControllerState : IInputStateTypeInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <axis>e__FixedBuffer
	{
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <buttons>e__FixedBuffer
	{
		public uint FixedElementField; //Field offset: 0x0

	}

	internal class Variants
	{
		public const string Gamepad = "Gamepad"; //Field offset: 0x0
		public const string Joystick = "Joystick"; //Field offset: 0x0
		public const string DPadAxes = "DpadAxes"; //Field offset: 0x0
		public const string DPadButtons = "DpadButtons"; //Field offset: 0x0

		public Variants() { }

	}

	public const int MaxAxes = 48; //Field offset: 0x0
	public const int MaxButtons = 220; //Field offset: 0x0
	internal const uint kAxisOffset = 28; //Field offset: 0x0
	public static FourCC kFormat; //Field offset: 0x0
	[FixedBuffer(typeof(uint, 7)]
	[InputControl(name = "dpad/right", bit = 22, variants = "DpadButtons")]
	[InputControl(name = "dpad/left", bit = 21, variants = "DpadButtons")]
	[InputControl(name = "buttonWest", bit = 99, variants = "Gamepad")]
	[InputControl(name = "select", bit = 109, variants = "Gamepad")]
	[InputControl(name = "start", bit = 108, variants = "Gamepad")]
	[InputControl(name = "rightShoulder", bit = 103, variants = "Gamepad")]
	[InputControl(name = "leftShoulder", bit = 102, variants = "Gamepad")]
	[InputControl(name = "rightStickPress", bit = 107, variants = "Gamepad")]
	[InputControl(name = "leftStickPress", bit = 106, variants = "Gamepad")]
	[InputControl(name = "buttonSouth", bit = 96, variants = "Gamepad")]
	[InputControl(name = "buttonEast", bit = 97, variants = "Gamepad")]
	[InputControl(name = "dpad/down", bit = 20, variants = "DpadButtons")]
	[InputControl(name = "dpad", layout = "Dpad", bit = 19, sizeInBits = 4, variants = "DpadButtons")]
	[InputControl(name = "dpad/up", bit = 19, variants = "DpadButtons")]
	[InputControl(name = "buttonNorth", bit = 100, variants = "Gamepad")]
	public <buttons>e__FixedBuffer buttons; //Field offset: 0x0
	[FixedBuffer(typeof(float, 48)]
	[InputControl(name = "dpad/right", offset = 0, bit = 0, sizeInBits = 32, format = "FLT", parameters = "clamp=3,clampConstant=0,clampMin=0,clampMax=1", variants = "DpadAxes")]
	[InputControl(name = "rightTrigger", offset = 116, parameters = "clamp=1,clampMin=0,clampMax=1.0", variants = "Gamepad")]
	[InputControl(name = "leftTrigger", offset = 120, parameters = "clamp=1,clampMin=0,clampMax=1.0", variants = "Gamepad")]
	[InputControl(name = "leftStick/up", variants = "Gamepad", parameters = "invert,clamp=1,clampMin=-1.0,clampMax=0.0")]
	[InputControl(name = "dpad/up", offset = 4, bit = 0, sizeInBits = 32, format = "FLT", parameters = "clamp=3,clampConstant=0,clampMin=-1,clampMax=0,invert", variants = "DpadAxes")]
	[InputControl(name = "dpad/left", offset = 0, bit = 0, sizeInBits = 32, format = "FLT", parameters = "clamp=3,clampConstant=0,clampMin=-1,clampMax=0,invert", variants = "DpadAxes")]
	[InputControl(name = "leftStick/down", variants = "Gamepad", parameters = "invert=false,clamp=1,clampMin=0,clampMax=1.0")]
	[InputControl(name = "rightStick", offset = 72, sizeInBits = 128, variants = "Gamepad")]
	[InputControl(name = "rightStick/x", variants = "Gamepad")]
	[InputControl(name = "rightStick/y", offset = 12, variants = "Gamepad", parameters = "invert")]
	[InputControl(name = "rightStick/up", offset = 12, variants = "Gamepad", parameters = "invert,clamp=1,clampMin=-1.0,clampMax=0.0")]
	[InputControl(name = "rightStick/down", offset = 12, variants = "Gamepad", parameters = "invert=false,clamp=1,clampMin=0,clampMax=1.0")]
	[InputControl(name = "dpad/down", offset = 4, bit = 0, sizeInBits = 32, format = "FLT", parameters = "clamp=3,clampConstant=0,clampMin=0,clampMax=1", variants = "DpadAxes")]
	[InputControl(name = "dpad", layout = "Dpad", offset = 88, format = "VEC2", sizeInBits = 64, variants = "DpadAxes")]
	[InputControl(name = "leftStick/y", variants = "Gamepad", parameters = "invert")]
	[InputControl(name = "leftStick", variants = "Gamepad")]
	public <axis>e__FixedBuffer axis; //Field offset: 0x1C

	public override FourCC format
	{
		 get { } //Length: 88
	}

	private static AndroidGameControllerState() { }

	public override FourCC get_format() { }

	public AndroidGameControllerState WithAxis(AndroidAxis axis, float value) { }

	public AndroidGameControllerState WithButton(AndroidKeyCode code, bool value = true) { }

}

