namespace Nakama;

internal class MatchState : IMatchState
{
	private static readonly Byte[] NoBytes; //Field offset: 0x0
	[CompilerGenerated]
	private string <MatchId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <OpCodeField>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <StateField>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private UserPresence <UserPresenceField>k__BackingField; //Field offset: 0x28

	[DataMember(Name = "match_id")]
	[Preserve]
	public override string MatchId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override long OpCode
	{
		 get { } //Length: 92
	}

	[DataMember(Name = "op_code")]
	[Preserve]
	public string OpCodeField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override Byte[] State
	{
		 get { } //Length: 156
	}

	[DataMember(Name = "data")]
	[Preserve]
	public string StateField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IUserPresence UserPresence
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "presence")]
	[Preserve]
	public UserPresence UserPresenceField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private static MatchState() { }

	public MatchState() { }

	[CompilerGenerated]
	public override string get_MatchId() { }

	public override long get_OpCode() { }

	[CompilerGenerated]
	public string get_OpCodeField() { }

	public override Byte[] get_State() { }

	[CompilerGenerated]
	public string get_StateField() { }

	public override IUserPresence get_UserPresence() { }

	[CompilerGenerated]
	public UserPresence get_UserPresenceField() { }

	[CompilerGenerated]
	public void set_MatchId(string value) { }

	[CompilerGenerated]
	public void set_OpCodeField(string value) { }

	[CompilerGenerated]
	public void set_StateField(string value) { }

	[CompilerGenerated]
	public void set_UserPresenceField(UserPresence value) { }

	public virtual string ToString() { }

}

