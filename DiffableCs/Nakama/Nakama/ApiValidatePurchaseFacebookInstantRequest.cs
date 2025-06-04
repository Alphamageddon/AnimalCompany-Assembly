namespace Nakama;

internal class ApiValidatePurchaseFacebookInstantRequest : IApiValidatePurchaseFacebookInstantRequest
{
	[CompilerGenerated]
	private bool <Persist>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <SignedRequest>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "persist")]
	[Preserve]
	public override bool Persist
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "signed_request")]
	[Preserve]
	public override string SignedRequest
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiValidatePurchaseFacebookInstantRequest() { }

	[CompilerGenerated]
	public override bool get_Persist() { }

	[CompilerGenerated]
	public override string get_SignedRequest() { }

	[CompilerGenerated]
	public void set_Persist(bool value) { }

	[CompilerGenerated]
	public void set_SignedRequest(string value) { }

	public virtual string ToString() { }

}

