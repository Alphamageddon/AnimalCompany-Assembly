namespace Nakama;

internal class MatchmakerMatched : IMatchmakerMatched
{
	[CompilerGenerated]
	private string <MatchId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Ticket>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Token>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private List<MatchmakerUser> <_users>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private MatchmakerUser <_self>k__BackingField; //Field offset: 0x30

	[DataMember(Name = "self")]
	[Preserve]
	public MatchmakerUser _self
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "users")]
	[Preserve]
	public List<MatchmakerUser> _users
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
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

	public override IMatchmakerUser Self
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "ticket")]
	[Preserve]
	public override string Ticket
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "token")]
	[Preserve]
	public override string Token
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IMatchmakerUser> Users
	{
		 get { } //Length: 120
	}

	public MatchmakerMatched() { }

	[CompilerGenerated]
	public MatchmakerUser get__self() { }

	[CompilerGenerated]
	public List<MatchmakerUser> get__users() { }

	[CompilerGenerated]
	public override string get_MatchId() { }

	public override IMatchmakerUser get_Self() { }

	[CompilerGenerated]
	public override string get_Ticket() { }

	[CompilerGenerated]
	public override string get_Token() { }

	public override IEnumerable<IMatchmakerUser> get_Users() { }

	[CompilerGenerated]
	public void set__self(MatchmakerUser value) { }

	[CompilerGenerated]
	public void set__users(List<MatchmakerUser> value) { }

	[CompilerGenerated]
	public void set_MatchId(string value) { }

	[CompilerGenerated]
	public void set_Ticket(string value) { }

	[CompilerGenerated]
	public void set_Token(string value) { }

	public virtual string ToString() { }

}

