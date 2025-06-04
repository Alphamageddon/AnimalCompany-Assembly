namespace Nakama;

internal class ApiMatch : IApiMatch
{
	[CompilerGenerated]
	private bool <Authoritative>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <HandlerName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Label>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <MatchId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <Size>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <TickRate>k__BackingField; //Field offset: 0x34

	[DataMember(Name = "authoritative")]
	[Preserve]
	public override bool Authoritative
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "handler_name")]
	[Preserve]
	public override string HandlerName
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "label")]
	[Preserve]
	public override string Label
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

	[DataMember(Name = "size")]
	[Preserve]
	public override int Size
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "tick_rate")]
	[Preserve]
	public override int TickRate
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiMatch() { }

	[CompilerGenerated]
	public override bool get_Authoritative() { }

	[CompilerGenerated]
	public override string get_HandlerName() { }

	[CompilerGenerated]
	public override string get_Label() { }

	[CompilerGenerated]
	public override string get_MatchId() { }

	[CompilerGenerated]
	public override int get_Size() { }

	[CompilerGenerated]
	public override int get_TickRate() { }

	[CompilerGenerated]
	public void set_Authoritative(bool value) { }

	[CompilerGenerated]
	public void set_HandlerName(string value) { }

	[CompilerGenerated]
	public void set_Label(string value) { }

	[CompilerGenerated]
	public void set_MatchId(string value) { }

	[CompilerGenerated]
	public void set_Size(int value) { }

	[CompilerGenerated]
	public void set_TickRate(int value) { }

	public virtual string ToString() { }

}

