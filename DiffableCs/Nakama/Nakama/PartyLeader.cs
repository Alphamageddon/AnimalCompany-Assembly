namespace Nakama;

internal class PartyLeader : IPartyLeader
{
	[CompilerGenerated]
	private string <PartyId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private UserPresence <PresenceField>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "party_id")]
	[Preserve]
	public override string PartyId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IUserPresence Presence
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "presence")]
	[Preserve]
	public UserPresence PresenceField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public PartyLeader() { }

	[CompilerGenerated]
	public override string get_PartyId() { }

	public override IUserPresence get_Presence() { }

	[CompilerGenerated]
	public UserPresence get_PresenceField() { }

	[CompilerGenerated]
	public void set_PartyId(string value) { }

	[CompilerGenerated]
	public void set_PresenceField(UserPresence value) { }

	public virtual string ToString() { }

}

