namespace Nakama;

internal class PartyPresenceEvent : IPartyPresenceEvent
{
	[CompilerGenerated]
	private string <PartyId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<UserPresence> <LeavesField>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<UserPresence> <JoinsField>k__BackingField; //Field offset: 0x20

	public override IEnumerable<IUserPresence> Joins
	{
		 get { } //Length: 100
	}

	[DataMember(Name = "joins")]
	[Preserve]
	public List<UserPresence> JoinsField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IUserPresence> Leaves
	{
		 get { } //Length: 100
	}

	[DataMember(Name = "leaves")]
	[Preserve]
	public List<UserPresence> LeavesField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_id")]
	[Preserve]
	public override string PartyId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public PartyPresenceEvent() { }

	public override IEnumerable<IUserPresence> get_Joins() { }

	[CompilerGenerated]
	public List<UserPresence> get_JoinsField() { }

	public override IEnumerable<IUserPresence> get_Leaves() { }

	[CompilerGenerated]
	public List<UserPresence> get_LeavesField() { }

	[CompilerGenerated]
	public override string get_PartyId() { }

	[CompilerGenerated]
	public void set_JoinsField(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set_LeavesField(List<UserPresence> value) { }

	[CompilerGenerated]
	public void set_PartyId(string value) { }

	public virtual string ToString() { }

}

