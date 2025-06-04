namespace Nakama;

internal class ApiValidatePurchaseResponse : IApiValidatePurchaseResponse
{
	[CompilerGenerated]
	private List<ApiValidatedPurchase> <_validatedPurchases>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "validated_purchases")]
	[Preserve]
	public List<ApiValidatedPurchase> _validatedPurchases
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiValidatedPurchase> ValidatedPurchases
	{
		 get { } //Length: 120
	}

	public ApiValidatePurchaseResponse() { }

	[CompilerGenerated]
	public List<ApiValidatedPurchase> get__validatedPurchases() { }

	public override IEnumerable<IApiValidatedPurchase> get_ValidatedPurchases() { }

	[CompilerGenerated]
	public void set__validatedPurchases(List<ApiValidatedPurchase> value) { }

	public virtual string ToString() { }

}

