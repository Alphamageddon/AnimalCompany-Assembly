namespace Nakama;

internal class Match : IMatch
{
	[CompilerGenerated]
	private bool <Authoritative>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Label>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private List<UserPresence> <_presences>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <Size>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private UserPresence <_self>k__BackingField; //Field offset: 0x38

	[DataMember(Name = "presences")]
	[Preserve]
	public List<UserPresence> _presences
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "self")]
	[Preserve]
	public UserPresence _self
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "authoritative")]
	[Preserve]
	public override bool Authoritative
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "match_id")]
	[Preserve]
	public override string Id
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

	public override IEnumerable<IUserPresence> Presences
	{
		 get { } //Length: 100
	}

	public override IUserPresence Self
	{
		 get { } //Length: 8
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

	public Match() { }

	[CompilerGenerated]
	public List<UserPresence> get__presences() { }

	[CompilerGenerated]
	public UserPresence get__self() { }

	[CompilerGenerated]
	public override bool get_Authoritative() { }

	[CompilerGenerated]
	public override string get_Id() { }

	[CompilerGenerated]
	public override string get_Label() { }

	public override IEnumerable<IUserPresence> get_Presences() { }

	public override IUserPresence get_Self() { }

	[CompilerGenerated]
	public override int get_Size() { }

	[CompilerGenerated]
	public void set__presences(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set__self(UserPresence value) { }

	[CompilerGenerated]
	public void set_Authoritative(bool value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_Label(string value) { }

	[CompilerGenerated]
	public void set_Size(int value) { }

	public virtual string ToString() { }

	public override void UpdatePresences(IMatchPresenceEvent presenceEvent) { }

}

