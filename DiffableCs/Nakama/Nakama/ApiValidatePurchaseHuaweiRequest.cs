namespace Nakama;

internal class ApiValidatePurchaseHuaweiRequest : IApiValidatePurchaseHuaweiRequest
{
	[CompilerGenerated]
	private bool <Persist>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Purchase>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Signature>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "persist")]
	[Preserve]
	public override bool Persist
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "purchase")]
	[Preserve]
	public override string Purchase
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "signature")]
	[Preserve]
	public override string Signature
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiValidatePurchaseHuaweiRequest() { }

	[CompilerGenerated]
	public override bool get_Persist() { }

	[CompilerGenerated]
	public override string get_Purchase() { }

	[CompilerGenerated]
	public override string get_Signature() { }

	[CompilerGenerated]
	public void set_Persist(bool value) { }

	[CompilerGenerated]
	public void set_Purchase(string value) { }

	[CompilerGenerated]
	public void set_Signature(string value) { }

	public virtual string ToString() { }

}

