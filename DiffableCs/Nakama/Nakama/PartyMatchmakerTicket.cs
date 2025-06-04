namespace Nakama;

internal class PartyMatchmakerTicket : IPartyMatchmakerTicket
{
	[CompilerGenerated]
	private string <PartyId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Ticket>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "party_id")]
	[Preserve]
	public override string PartyId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "ticket")]
	[Preserve]
	public override string Ticket
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public PartyMatchmakerTicket() { }

	[CompilerGenerated]
	public override string get_PartyId() { }

	[CompilerGenerated]
	public override string get_Ticket() { }

	[CompilerGenerated]
	public void set_PartyId(string value) { }

	[CompilerGenerated]
	public void set_Ticket(string value) { }

	public virtual string ToString() { }

}

