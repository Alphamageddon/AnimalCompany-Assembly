namespace Nakama;

internal class MatchLeaveMessage
{
	[CompilerGenerated]
	private string <MatchId>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "match_id")]
	[Preserve]
	public string MatchId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public MatchLeaveMessage() { }

	[CompilerGenerated]
	public string get_MatchId() { }

	[CompilerGenerated]
	public void set_MatchId(string value) { }

	public virtual string ToString() { }

}

