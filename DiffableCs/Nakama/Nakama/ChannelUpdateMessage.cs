namespace Nakama;

internal class ChannelUpdateMessage
{
	[CompilerGenerated]
	private string <ChannelId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <MessageId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Content>k__BackingField; //Field offset: 0x20

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

	[DataMember(Name = "message_id")]
	[Preserve]
	public string MessageId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ChannelUpdateMessage() { }

	[CompilerGenerated]
	public string get_ChannelId() { }

	[CompilerGenerated]
	public string get_Content() { }

	[CompilerGenerated]
	public string get_MessageId() { }

	[CompilerGenerated]
	public void set_ChannelId(string value) { }

	[CompilerGenerated]
	public void set_Content(string value) { }

	[CompilerGenerated]
	public void set_MessageId(string value) { }

	public virtual string ToString() { }

}

