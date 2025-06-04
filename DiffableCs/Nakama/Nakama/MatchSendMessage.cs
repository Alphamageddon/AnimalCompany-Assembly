namespace Nakama;

internal class MatchSendMessage
{
	[CompilerGenerated]
	private string <MatchId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <OpCode>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<UserPresence> <Presences>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <State>k__BackingField; //Field offset: 0x28

	[DataMember(Name = "match_id")]
	[Preserve]
	public string MatchId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "op_code")]
	[Preserve]
	public string OpCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "presences")]
	[Preserve]
	public List<UserPresence> Presences
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "data")]
	[Preserve]
	public string State
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public MatchSendMessage() { }

	[CompilerGenerated]
	public string get_MatchId() { }

	[CompilerGenerated]
	public string get_OpCode() { }

	[CompilerGenerated]
	public List<UserPresence> get_Presences() { }

	[CompilerGenerated]
	public string get_State() { }

	[CompilerGenerated]
	public void set_MatchId(string value) { }

	[CompilerGenerated]
	public void set_OpCode(string value) { }

	[CompilerGenerated]
	public void set_Presences(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set_State(string value) { }

	public virtual string ToString() { }

}

