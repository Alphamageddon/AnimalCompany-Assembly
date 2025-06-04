namespace Nakama;

internal class ApiMatchList : IApiMatchList
{
	[CompilerGenerated]
	private List<ApiMatch> <_matches>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "matches")]
	[Preserve]
	public List<ApiMatch> _matches
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiMatch> Matches
	{
		 get { } //Length: 120
	}

	public ApiMatchList() { }

	[CompilerGenerated]
	public List<ApiMatch> get__matches() { }

	public override IEnumerable<IApiMatch> get_Matches() { }

	[CompilerGenerated]
	public void set__matches(List<ApiMatch> value) { }

	public virtual string ToString() { }

}

