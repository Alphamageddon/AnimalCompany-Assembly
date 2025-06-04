namespace UnityEngine.InputSystem.LowLevel;

public struct QueryPairedUserAccountCommand : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <idBuffer>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <nameBuffer>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[Flags]
	internal enum Result
	{
		DevicePairedToUserAccount = 2,
		UserAccountSelectionInProgress = 4,
		UserAccountSelectionComplete = 8,
		UserAccountSelectionCanceled = 16,
	}

	internal const int kMaxNameLength = 256; //Field offset: 0x0
	internal const int kMaxIdLength = 256; //Field offset: 0x0
	internal const int kSize = 1040; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	public ulong handle; //Field offset: 0x8
	[FixedBuffer(typeof(byte, 512)]
	internal <nameBuffer>e__FixedBuffer nameBuffer; //Field offset: 0x10
	[FixedBuffer(typeof(byte, 512)]
	internal <idBuffer>e__FixedBuffer idBuffer; //Field offset: 0x210

	public string id
	{
		 get { } //Length: 16
		 set { } //Length: 272
	}

	public string name
	{
		 get { } //Length: 16
		 set { } //Length: 272
	}

	public static FourCC Type
	{
		 get { } //Length: 48
	}

	public override FourCC typeStatic
	{
		 get { } //Length: 48
	}

	public static QueryPairedUserAccountCommand Create() { }

	public string get_id() { }

	public string get_name() { }

	public static FourCC get_Type() { }

	public override FourCC get_typeStatic() { }

	public void set_id(string value) { }

	public void set_name(string value) { }

}

