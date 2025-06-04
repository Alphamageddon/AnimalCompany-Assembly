namespace Nakama;

internal class StatusUpdateMessage
{
	[CompilerGenerated]
	private string <Status>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "status")]
	[Preserve]
	public string Status
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public StatusUpdateMessage() { }

	[CompilerGenerated]
	public string get_Status() { }

	[CompilerGenerated]
	public void set_Status(string value) { }

	public virtual string ToString() { }

}

