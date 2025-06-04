namespace UnityEngine.InputSystem.LowLevel;

internal struct UseWindowsGamingInputCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 9; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	public byte enable; //Field offset: 0x8

	public static FourCC Type
	{
		 get { } //Length: 48
	}

	public override FourCC typeStatic
	{
		 get { } //Length: 48
	}

	public static UseWindowsGamingInputCommand Create(bool enable) { }

	public static FourCC get_Type() { }

	public override FourCC get_typeStatic() { }

}

