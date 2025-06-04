namespace UnityEngine.InputSystem.LowLevel;

public struct QueryCanRunInBackground : IInputDeviceCommandInfo
{
	internal const int kSize = 9; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	public bool canRunInBackground; //Field offset: 0x8

	public static FourCC Type
	{
		 get { } //Length: 48
	}

	public override FourCC typeStatic
	{
		 get { } //Length: 48
	}

	public static QueryCanRunInBackground Create() { }

	public static FourCC get_Type() { }

	public override FourCC get_typeStatic() { }

}

