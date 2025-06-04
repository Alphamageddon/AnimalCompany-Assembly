namespace Satori;

internal class ApiMessage : IApiMessage
{
	[CompilerGenerated]
	private string <ConsumeTime>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <CreateTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <ImageUrl>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Dictionary<String, String> <_metadata>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <ReadTime>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <ScheduleId>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private string <SendTime>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private string <Text>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private string <UpdateTime>k__BackingField; //Field offset: 0x60

	[DataMember(Name = "metadata")]
	[Preserve]
	public Dictionary<String, String> _metadata
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "consume_time")]
	[Preserve]
	public override string ConsumeTime
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

	[DataMember(Name = "image_url")]
	[Preserve]
	public override string ImageUrl
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IDictionary<String, String> Metadata
	{
		 get { } //Length: 116
	}

	[DataMember(Name = "read_time")]
	[Preserve]
	public override string ReadTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "schedule_id")]
	[Preserve]
	public override string ScheduleId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "send_time")]
	[Preserve]
	public override string SendTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "text")]
	[Preserve]
	public override string Text
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "title")]
	[Preserve]
	public override string Title
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "update_time")]
	[Preserve]
	public override string UpdateTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiMessage() { }

	[CompilerGenerated]
	public Dictionary<String, String> get__metadata() { }

	[CompilerGenerated]
	public override string get_ConsumeTime() { }

	[CompilerGenerated]
	public override string get_CreateTime() { }

	[CompilerGenerated]
	public override string get_Id() { }

	[CompilerGenerated]
	public override string get_ImageUrl() { }

	public override IDictionary<String, String> get_Metadata() { }

	[CompilerGenerated]
	public override string get_ReadTime() { }

	[CompilerGenerated]
	public override string get_ScheduleId() { }

	[CompilerGenerated]
	public override string get_SendTime() { }

	[CompilerGenerated]
	public override string get_Text() { }

	[CompilerGenerated]
	public override string get_Title() { }

	[CompilerGenerated]
	public override string get_UpdateTime() { }

	[CompilerGenerated]
	public void set__metadata(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_ConsumeTime(string value) { }

	[CompilerGenerated]
	public void set_CreateTime(string value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_ImageUrl(string value) { }

	[CompilerGenerated]
	public void set_ReadTime(string value) { }

	[CompilerGenerated]
	public void set_ScheduleId(string value) { }

	[CompilerGenerated]
	public void set_SendTime(string value) { }

	[CompilerGenerated]
	public void set_Text(string value) { }

	[CompilerGenerated]
	public void set_Title(string value) { }

	[CompilerGenerated]
	public void set_UpdateTime(string value) { }

	public virtual string ToString() { }

}

