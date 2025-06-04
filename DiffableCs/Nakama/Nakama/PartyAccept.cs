namespace Nakama;

internal class PartyAccept
{
	[CompilerGenerated]
	private string <PartyId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private UserPresence <Presence>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "party_id")]
	[Preserve]
	public string PartyId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "presence")]
	[Preserve]
	public UserPresence Presence
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public PartyAccept() { }

	[CompilerGenerated]
	public string get_PartyId() { }

	[CompilerGenerated]
	public UserPresence get_Presence() { }

	[CompilerGenerated]
	public void set_PartyId(string value) { }

	[CompilerGenerated]
	public void set_Presence(UserPresence value) { }

	public virtual string ToString() { }

}

