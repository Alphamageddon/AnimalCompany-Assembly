namespace Nakama;

internal class ApiTournamentList : IApiTournamentList
{
	[CompilerGenerated]
	private string <Cursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiTournament> <_tournaments>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "tournaments")]
	[Preserve]
	public List<ApiTournament> _tournaments
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "cursor")]
	[Preserve]
	public override string Cursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiTournament> Tournaments
	{
		 get { } //Length: 120
	}

	public ApiTournamentList() { }

	[CompilerGenerated]
	public List<ApiTournament> get__tournaments() { }

	[CompilerGenerated]
	public override string get_Cursor() { }

	public override IEnumerable<IApiTournament> get_Tournaments() { }

	[CompilerGenerated]
	public void set__tournaments(List<ApiTournament> value) { }

	[CompilerGenerated]
	public void set_Cursor(string value) { }

	public virtual string ToString() { }

}

