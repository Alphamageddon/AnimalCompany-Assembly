namespace Nakama.Console;

internal class ConsoleUnlinkDeviceRequest : IConsoleUnlinkDeviceRequest
{
	[CompilerGenerated]
	private string <DeviceId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "device_id")]
	public override string DeviceId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "id")]
	public override string Id
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ConsoleUnlinkDeviceRequest() { }

	[CompilerGenerated]
	public override string get_DeviceId() { }

	[CompilerGenerated]
	public override string get_Id() { }

	[CompilerGenerated]
	public void set_DeviceId(string value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	public virtual string ToString() { }

}

