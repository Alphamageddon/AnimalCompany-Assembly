namespace Nakama;

internal class ApiValidateSubscriptionAppleRequest : IApiValidateSubscriptionAppleRequest
{
	[CompilerGenerated]
	private bool <Persist>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Receipt>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "persist")]
	[Preserve]
	public override bool Persist
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "receipt")]
	[Preserve]
	public override string Receipt
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiValidateSubscriptionAppleRequest() { }

	[CompilerGenerated]
	public override bool get_Persist() { }

	[CompilerGenerated]
	public override string get_Receipt() { }

	[CompilerGenerated]
	public void set_Persist(bool value) { }

	[CompilerGenerated]
	public void set_Receipt(string value) { }

	public virtual string ToString() { }

}

