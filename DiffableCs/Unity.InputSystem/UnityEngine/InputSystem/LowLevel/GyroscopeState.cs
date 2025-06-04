namespace UnityEngine.InputSystem.LowLevel;

internal struct GyroscopeState : IInputStateTypeInfo
{
	[InputControl(displayName = "Angular Velocity", processors = "CompensateDirection", noisy = True)]
	public Vector3 angularVelocity; //Field offset: 0x0

	public override FourCC format
	{
		 get { } //Length: 48
	}

	public static FourCC kFormat
	{
		 get { } //Length: 48
	}

	public override FourCC get_format() { }

	public static FourCC get_kFormat() { }

}

