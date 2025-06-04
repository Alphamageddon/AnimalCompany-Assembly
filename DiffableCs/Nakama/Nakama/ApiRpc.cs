namespace Nakama;

internal class ApiRpc : IApiRpc
{
	[CompilerGenerated]
	private string <HttpKey>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Payload>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "http_key")]
	[Preserve]
	public override string HttpKey
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "id")]
	[Preserve]
	public override string Id
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "payload")]
	[Preserve]
	public override string Payload
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiRpc() { }

	[CompilerGenerated]
	public override string get_HttpKey() { }

	[CompilerGenerated]
	public override string get_Id() { }

	[CompilerGenerated]
	public override string get_Payload() { }

	[CompilerGenerated]
	public void set_HttpKey(string value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_Payload(string value) { }

	public virtual string ToString() { }

}

