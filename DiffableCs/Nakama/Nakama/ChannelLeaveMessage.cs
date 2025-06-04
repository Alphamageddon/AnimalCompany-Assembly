namespace Nakama;

internal class ChannelLeaveMessage
{
	[CompilerGenerated]
	private string <ChannelId>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "channel_id")]
	[Preserve]
	public string ChannelId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ChannelLeaveMessage() { }

	[CompilerGenerated]
	public string get_ChannelId() { }

	[CompilerGenerated]
	public void set_ChannelId(string value) { }

	public virtual string ToString() { }

}

