namespace UnityEngine.InputSystem.XR.Haptics;

public struct GetHapticCapabilitiesCommand : IInputDeviceCommandInfo
{
	private const int kSize = 20; //Field offset: 0x0
	private InputDeviceCommand baseCommand; //Field offset: 0x0
	public uint numChannels; //Field offset: 0x8
	public uint frequencyHz; //Field offset: 0xC
	public uint maxBufferSize; //Field offset: 0x10

	public HapticCapabilities capabilities
	{
		 get { } //Length: 12
	}

	private static FourCC Type
	{
		private get { } //Length: 48
	}

	public override FourCC typeStatic
	{
		 get { } //Length: 48
	}

	public static GetHapticCapabilitiesCommand Create() { }

	public HapticCapabilities get_capabilities() { }

	private static FourCC get_Type() { }

	public override FourCC get_typeStatic() { }

}

