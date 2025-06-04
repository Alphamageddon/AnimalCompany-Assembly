namespace Nakama;

internal class Party : IParty
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Open>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <MaxSize>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private UserPresence <SelfField>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private UserPresence <LeaderField>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private List<UserPresence> <PresencesField>k__BackingField; //Field offset: 0x30

	[DataMember(Name = "party_id")]
	[Preserve]
	public override string Id
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IUserPresence Leader
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "leader")]
	[Preserve]
	public UserPresence LeaderField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "max_size")]
	[Preserve]
	public override int MaxSize
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "open")]
	[Preserve]
	public override bool Open
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public override IEnumerable<IUserPresence> Presences
	{
		 get { } //Length: 100
	}

	[DataMember(Name = "presences")]
	[Preserve]
	public List<UserPresence> PresencesField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IUserPresence Self
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "self")]
	[Preserve]
	public UserPresence SelfField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Party() { }

	[CompilerGenerated]
	public override string get_Id() { }

	public override IUserPresence get_Leader() { }

	[CompilerGenerated]
	public UserPresence get_LeaderField() { }

	[CompilerGenerated]
	public override int get_MaxSize() { }

	[CompilerGenerated]
	public override bool get_Open() { }

	public override IEnumerable<IUserPresence> get_Presences() { }

	[CompilerGenerated]
	public List<UserPresence> get_PresencesField() { }

	public override IUserPresence get_Self() { }

	[CompilerGenerated]
	public UserPresence get_SelfField() { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_LeaderField(UserPresence value) { }

	[CompilerGenerated]
	public void set_MaxSize(int value) { }

	[CompilerGenerated]
	public void set_Open(bool value) { }

	[CompilerGenerated]
	public void set_PresencesField(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set_SelfField(UserPresence value) { }

	public override void UpdatePresences(IPartyPresenceEvent presenceEvent) { }

}

