namespace Nakama;

internal class ApiTournament : IApiTournament
{
	[CompilerGenerated]
	private bool <Authoritative>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <CanEnter>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private int <Category>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private string <CreateTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Description>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <Duration>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <EndActive>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private string <EndTime>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <MaxNumScore>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <MaxSize>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private string <Metadata>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <NextReset>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private ApiOperator <_operator>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private int <PrevReset>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private int <Size>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private int <SortOrder>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private int <StartActive>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private string <StartTime>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x70

	[DataMember(Name = "operator")]
	[Preserve]
	public ApiOperator _operator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "authoritative")]
	[Preserve]
	public override bool Authoritative
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "can_enter")]
	[Preserve]
	public override bool CanEnter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "category")]
	[Preserve]
	public override int Category
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

	[DataMember(Name = "description")]
	[Preserve]
	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "duration")]
	[Preserve]
	public override int Duration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "end_active")]
	[Preserve]
	public override int EndActive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "end_time")]
	[Preserve]
	public override string EndTime
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

	[DataMember(Name = "max_num_score")]
	[Preserve]
	public override int MaxNumScore
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "max_size")]
	[Preserve]
	public override int MaxSize
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "metadata")]
	[Preserve]
	public override string Metadata
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "next_reset")]
	[Preserve]
	public override int NextReset
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override ApiOperator Operator
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "prev_reset")]
	[Preserve]
	public override int PrevReset
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "size")]
	[Preserve]
	public override int Size
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "sort_order")]
	[Preserve]
	public override int SortOrder
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "start_active")]
	[Preserve]
	public override int StartActive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "start_time")]
	[Preserve]
	public override string StartTime
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

	public ApiTournament() { }

	[CompilerGenerated]
	public ApiOperator get__operator() { }

	[CompilerGenerated]
	public override bool get_Authoritative() { }

	[CompilerGenerated]
	public override bool get_CanEnter() { }

	[CompilerGenerated]
	public override int get_Category() { }

	[CompilerGenerated]
	public override string get_CreateTime() { }

	[CompilerGenerated]
	public override string get_Description() { }

	[CompilerGenerated]
	public override int get_Duration() { }

	[CompilerGenerated]
	public override int get_EndActive() { }

	[CompilerGenerated]
	public override string get_EndTime() { }

	[CompilerGenerated]
	public override string get_Id() { }

	[CompilerGenerated]
	public override int get_MaxNumScore() { }

	[CompilerGenerated]
	public override int get_MaxSize() { }

	[CompilerGenerated]
	public override string get_Metadata() { }

	[CompilerGenerated]
	public override int get_NextReset() { }

	public override ApiOperator get_Operator() { }

	[CompilerGenerated]
	public override int get_PrevReset() { }

	[CompilerGenerated]
	public override int get_Size() { }

	[CompilerGenerated]
	public override int get_SortOrder() { }

	[CompilerGenerated]
	public override int get_StartActive() { }

	[CompilerGenerated]
	public override string get_StartTime() { }

	[CompilerGenerated]
	public override string get_Title() { }

	[CompilerGenerated]
	public void set__operator(ApiOperator value) { }

	[CompilerGenerated]
	public void set_Authoritative(bool value) { }

	[CompilerGenerated]
	public void set_CanEnter(bool value) { }

	[CompilerGenerated]
	public void set_Category(int value) { }

	[CompilerGenerated]
	public void set_CreateTime(string value) { }

	[CompilerGenerated]
	public void set_Description(string value) { }

	[CompilerGenerated]
	public void set_Duration(int value) { }

	[CompilerGenerated]
	public void set_EndActive(int value) { }

	[CompilerGenerated]
	public void set_EndTime(string value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_MaxNumScore(int value) { }

	[CompilerGenerated]
	public void set_MaxSize(int value) { }

	[CompilerGenerated]
	public void set_Metadata(string value) { }

	[CompilerGenerated]
	public void set_NextReset(int value) { }

	[CompilerGenerated]
	public void set_PrevReset(int value) { }

	[CompilerGenerated]
	public void set_Size(int value) { }

	[CompilerGenerated]
	public void set_SortOrder(int value) { }

	[CompilerGenerated]
	public void set_StartActive(int value) { }

	[CompilerGenerated]
	public void set_StartTime(string value) { }

	[CompilerGenerated]
	public void set_Title(string value) { }

	public virtual string ToString() { }

}

