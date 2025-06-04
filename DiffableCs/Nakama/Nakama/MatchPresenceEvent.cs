namespace Nakama;

internal class MatchPresenceEvent : IMatchPresenceEvent
{
	[CompilerGenerated]
	private List<UserPresence> <_joins>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<UserPresence> <_leaves>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <MatchId>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "joins")]
	[Preserve]
	public List<UserPresence> _joins
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "leaves")]
	[Preserve]
	public List<UserPresence> _leaves
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IUserPresence> Joins
	{
		 get { } //Length: 100
	}

	public override IEnumerable<IUserPresence> Leaves
	{
		 get { } //Length: 100
	}

	[DataMember(Name = "match_id")]
	[Preserve]
	public override string MatchId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public MatchPresenceEvent() { }

	[CompilerGenerated]
	public List<UserPresence> get__joins() { }

	[CompilerGenerated]
	public List<UserPresence> get__leaves() { }

	public override IEnumerable<IUserPresence> get_Joins() { }

	public override IEnumerable<IUserPresence> get_Leaves() { }

	[CompilerGenerated]
	public override string get_MatchId() { }

	[CompilerGenerated]
	public void set__joins(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set__leaves(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set_MatchId(string value) { }

	public virtual string ToString() { }

}

