namespace Nakama;

internal class PartyJoinRequest : IPartyJoinRequest
{
	[CompilerGenerated]
	private string <PartyId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<UserPresence> <PresencesField>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "party_id")]
	[Preserve]
	public override string PartyId
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

	[DataMember(Name = "presences")]
	[Preserve]
	public List<UserPresence> PresencesField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public PartyJoinRequest() { }

	[CompilerGenerated]
	public override string get_PartyId() { }

	public override IEnumerable<IUserPresence> get_Presences() { }

	[CompilerGenerated]
	public List<UserPresence> get_PresencesField() { }

	[CompilerGenerated]
	public void set_PartyId(string value) { }

	[CompilerGenerated]
	public void set_PresencesField(List<UserPresence> value) { }

	public virtual string ToString() { }

}

