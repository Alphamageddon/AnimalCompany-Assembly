namespace Nakama;

internal class ApiListSubscriptionsRequest : IApiListSubscriptionsRequest
{
	[CompilerGenerated]
	private string <Cursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Limit>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "cursor")]
	[Preserve]
	public override string Cursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "limit")]
	[Preserve]
	public override int Limit
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiListSubscriptionsRequest() { }

	[CompilerGenerated]
	public override string get_Cursor() { }

	[CompilerGenerated]
	public override int get_Limit() { }

	[CompilerGenerated]
	public void set_Cursor(string value) { }

	[CompilerGenerated]
	public void set_Limit(int value) { }

	public virtual string ToString() { }

}

