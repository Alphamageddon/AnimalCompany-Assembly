namespace UnityEngine.InputSystem.LowLevel;

public struct InitiateUserAccountPairingCommand : IInputDeviceCommandInfo
{
	internal enum Result
	{
		SuccessfullyInitiated = 1,
		ErrorNotSupported = -1,
		ErrorAlreadyInProgress = -2,
	}

	internal const int kSize = 8; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0

	public static FourCC Type
	{
		 get { } //Length: 48
	}

	public override FourCC typeStatic
	{
		 get { } //Length: 48
	}

	public static InitiateUserAccountPairingCommand Create() { }

	public static FourCC get_Type() { }

	public override FourCC get_typeStatic() { }

}

