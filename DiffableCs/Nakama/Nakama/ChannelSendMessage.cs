namespace Nakama;

internal class ChannelSendMessage
{
	[CompilerGenerated]
	private string <ChannelId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Content>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "channel_id")]
	[Preserve]
	public string ChannelId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "content")]
	[Preserve]
	public string Content
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ChannelSendMessage() { }

	[CompilerGenerated]
	public string get_ChannelId() { }

	[CompilerGenerated]
	public string get_Content() { }

	[CompilerGenerated]
	public void set_ChannelId(string value) { }

	[CompilerGenerated]
	public void set_Content(string value) { }

	public virtual string ToString() { }

}

