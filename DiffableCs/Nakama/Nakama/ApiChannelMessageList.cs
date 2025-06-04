namespace Nakama;

internal class ApiChannelMessageList : IApiChannelMessageList
{
	[CompilerGenerated]
	private string <CacheableCursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiChannelMessage> <_messages>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <NextCursor>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <PrevCursor>k__BackingField; //Field offset: 0x28

	[DataMember(Name = "messages")]
	[Preserve]
	public List<ApiChannelMessage> _messages
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "cacheable_cursor")]
	[Preserve]
	public override string CacheableCursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiChannelMessage> Messages
	{
		 get { } //Length: 120
	}

	[DataMember(Name = "next_cursor")]
	[Preserve]
	public override string NextCursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "prev_cursor")]
	[Preserve]
	public override string PrevCursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiChannelMessageList() { }

	[CompilerGenerated]
	public List<ApiChannelMessage> get__messages() { }

	[CompilerGenerated]
	public override string get_CacheableCursor() { }

	public override IEnumerable<IApiChannelMessage> get_Messages() { }

	[CompilerGenerated]
	public override string get_NextCursor() { }

	[CompilerGenerated]
	public override string get_PrevCursor() { }

	[CompilerGenerated]
	public void set__messages(List<ApiChannelMessage> value) { }

	[CompilerGenerated]
	public void set_CacheableCursor(string value) { }

	[CompilerGenerated]
	public void set_NextCursor(string value) { }

	[CompilerGenerated]
	public void set_PrevCursor(string value) { }

	public virtual string ToString() { }

}

