namespace Photon.Voice;

public struct DeviceInfo
{
	public static readonly DeviceInfo Default; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsDefault>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <IDInt>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private string <IDString>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10
	private DeviceFeatures features; //Field offset: 0x18
	private bool useStringID; //Field offset: 0x20

	public DeviceFeatures Features
	{
		 get { } //Length: 100
	}

	public private int IDInt
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string IDString
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private bool IsDefault
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private string Name
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static DeviceInfo() { }

	public DeviceInfo(string name, DeviceFeatures features = null) { }

	private DeviceInfo(bool isDefault, int idInt, string idString, string name, DeviceFeatures features = null) { }

	public DeviceInfo(int id, string name, DeviceFeatures features = null) { }

	public DeviceInfo(string id, string name, DeviceFeatures features = null) { }

	public virtual bool Equals(object obj) { }

	public DeviceFeatures get_Features() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_IDInt() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_IDString() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_IsDefault() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_Name() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(DeviceInfo d1, DeviceInfo d2) { }

	public static bool op_Inequality(DeviceInfo d1, DeviceInfo d2) { }

	[CompilerGenerated]
	private void set_IDInt(int value) { }

	[CompilerGenerated]
	private void set_IDString(string value) { }

	[CompilerGenerated]
	private void set_IsDefault(bool value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	public virtual string ToString() { }

}

