namespace Nakama;

internal class PartyData : IPartyData
{
	private static readonly Byte[] NoBytes; //Field offset: 0x0
	[CompilerGenerated]
	private string <PartyId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private UserPresence <PresenceField>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <OpCodeField>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <DataField>k__BackingField; //Field offset: 0x28

	public override Byte[] Data
	{
		 get { } //Length: 156
	}

	[DataMember(Name = "data")]
	[Preserve]
	public string DataField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override long OpCode
	{
		 get { } //Length: 92
	}

	[DataMember(Name = "op_code")]
	[Preserve]
	public string OpCodeField
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

	private static PartyData() { }

	public PartyData() { }

	public override Byte[] get_Data() { }

	[CompilerGenerated]
	public string get_DataField() { }

	public override long get_OpCode() { }

	[CompilerGenerated]
	public string get_OpCodeField() { }

	[CompilerGenerated]
	public override string get_PartyId() { }

	public override IUserPresence get_Presence() { }

	[CompilerGenerated]
	public UserPresence get_PresenceField() { }

	[CompilerGenerated]
	public void set_DataField(string value) { }

	[CompilerGenerated]
	public void set_OpCodeField(string value) { }

	[CompilerGenerated]
	public void set_PartyId(string value) { }

	[CompilerGenerated]
	public void set_PresenceField(UserPresence value) { }

	public virtual string ToString() { }

}

