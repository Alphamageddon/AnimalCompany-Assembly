namespace Nakama;

internal class ApiLeaderboardRecordList : IApiLeaderboardRecordList
{
	[CompilerGenerated]
	private string <NextCursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiLeaderboardRecord> <_ownerRecords>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <PrevCursor>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <RankCount>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private List<ApiLeaderboardRecord> <_records>k__BackingField; //Field offset: 0x30

	[DataMember(Name = "owner_records")]
	[Preserve]
	public List<ApiLeaderboardRecord> _ownerRecords
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "records")]
	[Preserve]
	public List<ApiLeaderboardRecord> _records
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
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

	[IgnoreDataMember]
	public override IEnumerable<IApiLeaderboardRecord> OwnerRecords
	{
		 get { } //Length: 120
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

	[DataMember(Name = "rank_count")]
	[Preserve]
	public override string RankCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiLeaderboardRecord> Records
	{
		 get { } //Length: 120
	}

	public ApiLeaderboardRecordList() { }

	[CompilerGenerated]
	public List<ApiLeaderboardRecord> get__ownerRecords() { }

	[CompilerGenerated]
	public List<ApiLeaderboardRecord> get__records() { }

	[CompilerGenerated]
	public override string get_NextCursor() { }

	public override IEnumerable<IApiLeaderboardRecord> get_OwnerRecords() { }

	[CompilerGenerated]
	public override string get_PrevCursor() { }

	[CompilerGenerated]
	public override string get_RankCount() { }

	public override IEnumerable<IApiLeaderboardRecord> get_Records() { }

	[CompilerGenerated]
	public void set__ownerRecords(List<ApiLeaderboardRecord> value) { }

	[CompilerGenerated]
	public void set__records(List<ApiLeaderboardRecord> value) { }

	[CompilerGenerated]
	public void set_NextCursor(string value) { }

	[CompilerGenerated]
	public void set_PrevCursor(string value) { }

	[CompilerGenerated]
	public void set_RankCount(string value) { }

	public virtual string ToString() { }

}

