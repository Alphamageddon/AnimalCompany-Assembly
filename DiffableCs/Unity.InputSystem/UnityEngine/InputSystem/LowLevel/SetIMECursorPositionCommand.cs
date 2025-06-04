namespace UnityEngine.InputSystem.LowLevel;

public struct SetIMECursorPositionCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 16; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	private Vector2 m_Position; //Field offset: 0x8

	public Vector2 position
	{
		 get { } //Length: 8
	}

	public static FourCC Type
	{
		 get { } //Length: 48
	}

	public override FourCC typeStatic
	{
		 get { } //Length: 48
	}

	public static SetIMECursorPositionCommand Create(Vector2 cursorPosition) { }

	public Vector2 get_position() { }

	public static FourCC get_Type() { }

	public override FourCC get_typeStatic() { }

}

