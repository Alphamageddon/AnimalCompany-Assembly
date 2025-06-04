namespace Nakama;

internal class WriteLeaderboardRecordRequestLeaderboardRecordWrite : IWriteLeaderboardRecordRequestLeaderboardRecordWrite
{
	[CompilerGenerated]
	private string <Metadata>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ApiOperator <_operator>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Score>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Subscore>k__BackingField; //Field offset: 0x28

	[DataMember(Name = "operator")]
	[Preserve]
	public ApiOperator _operator
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

	[IgnoreDataMember]
	public override ApiOperator Operator
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "score")]
	[Preserve]
	public override string Score
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "subscore")]
	[Preserve]
	public override string Subscore
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public WriteLeaderboardRecordRequestLeaderboardRecordWrite() { }

	[CompilerGenerated]
	public ApiOperator get__operator() { }

	[CompilerGenerated]
	public override string get_Metadata() { }

	public override ApiOperator get_Operator() { }

	[CompilerGenerated]
	public override string get_Score() { }

	[CompilerGenerated]
	public override string get_Subscore() { }

	[CompilerGenerated]
	public void set__operator(ApiOperator value) { }

	[CompilerGenerated]
	public void set_Metadata(string value) { }

	[CompilerGenerated]
	public void set_Score(string value) { }

	[CompilerGenerated]
	public void set_Subscore(string value) { }

	public virtual string ToString() { }

}

