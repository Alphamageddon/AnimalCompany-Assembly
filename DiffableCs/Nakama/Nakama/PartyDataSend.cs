namespace Nakama;

internal class PartyDataSend
{
	[CompilerGenerated]
	private string <PartyId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <OpCode>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Data>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "data")]
	[Preserve]
	public string Data
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "op_code")]
	[Preserve]
	public string OpCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_id")]
	[Preserve]
	public string PartyId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public PartyDataSend() { }

	[CompilerGenerated]
	public string get_Data() { }

	[CompilerGenerated]
	public string get_OpCode() { }

	[CompilerGenerated]
	public string get_PartyId() { }

	[CompilerGenerated]
	public void set_Data(string value) { }

	[CompilerGenerated]
	public void set_OpCode(string value) { }

	[CompilerGenerated]
	public void set_PartyId(string value) { }

	public virtual string ToString() { }

}

