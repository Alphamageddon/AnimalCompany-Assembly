namespace Nakama;

internal class ApiNotification : IApiNotification
{
	[CompilerGenerated]
	private int <Code>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Content>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <CreateTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <Persistent>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <SenderId>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <Subject>k__BackingField; //Field offset: 0x40

	[DataMember(Name = "code")]
	[Preserve]
	public override int Code
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "content")]
	[Preserve]
	public override string Content
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "create_time")]
	[Preserve]
	public override string CreateTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "id")]
	[Preserve]
	public override string Id
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "persistent")]
	[Preserve]
	public override bool Persistent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "sender_id")]
	[Preserve]
	public override string SenderId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "subject")]
	[Preserve]
	public override string Subject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiNotification() { }

	[CompilerGenerated]
	public override int get_Code() { }

	[CompilerGenerated]
	public override string get_Content() { }

	[CompilerGenerated]
	public override string get_CreateTime() { }

	[CompilerGenerated]
	public override string get_Id() { }

	[CompilerGenerated]
	public override bool get_Persistent() { }

	[CompilerGenerated]
	public override string get_SenderId() { }

	[CompilerGenerated]
	public override string get_Subject() { }

	[CompilerGenerated]
	public void set_Code(int value) { }

	[CompilerGenerated]
	public void set_Content(string value) { }

	[CompilerGenerated]
	public void set_CreateTime(string value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_Persistent(bool value) { }

	[CompilerGenerated]
	public void set_SenderId(string value) { }

	[CompilerGenerated]
	public void set_Subject(string value) { }

	public virtual string ToString() { }

}

