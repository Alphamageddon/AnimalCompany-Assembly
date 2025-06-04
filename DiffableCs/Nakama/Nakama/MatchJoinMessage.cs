namespace Nakama;

internal class MatchJoinMessage
{
	[CompilerGenerated]
	private string <MatchId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Token>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private IDictionary<String, String> <Metadata>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "match_id")]
	[Preserve]
	public string MatchId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "metadata")]
	[Preserve]
	public IDictionary<String, String> Metadata
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "token")]
	[Preserve]
	public string Token
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public MatchJoinMessage() { }

	[CompilerGenerated]
	public string get_MatchId() { }

	[CompilerGenerated]
	public IDictionary<String, String> get_Metadata() { }

	[CompilerGenerated]
	public string get_Token() { }

	[CompilerGenerated]
	public void set_MatchId(string value) { }

	[CompilerGenerated]
	public void set_Metadata(IDictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_Token(string value) { }

	public virtual string ToString() { }

}

