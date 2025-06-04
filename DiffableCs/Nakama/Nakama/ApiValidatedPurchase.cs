namespace Nakama;

internal class ApiValidatedPurchase : IApiValidatedPurchase
{
	[CompilerGenerated]
	private string <CreateTime>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ApiStoreEnvironment <_environment>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ProductId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <ProviderResponse>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <PurchaseTime>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <RefundTime>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <SeenBefore>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private ApiStoreProvider <_store>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private string <TransactionId>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private string <UpdateTime>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private string <UserId>k__BackingField; //Field offset: 0x58

	[DataMember(Name = "environment")]
	[Preserve]
	public ApiStoreEnvironment _environment
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "store")]
	[Preserve]
	public ApiStoreProvider _store
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "create_time")]
	[Preserve]
	public override string CreateTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override ApiStoreEnvironment Environment
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "product_id")]
	[Preserve]
	public override string ProductId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "provider_response")]
	[Preserve]
	public override string ProviderResponse
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "purchase_time")]
	[Preserve]
	public override string PurchaseTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "refund_time")]
	[Preserve]
	public override string RefundTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "seen_before")]
	[Preserve]
	public override bool SeenBefore
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[IgnoreDataMember]
	public override ApiStoreProvider Store
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "transaction_id")]
	[Preserve]
	public override string TransactionId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "update_time")]
	[Preserve]
	public override string UpdateTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "user_id")]
	[Preserve]
	public override string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiValidatedPurchase() { }

	[CompilerGenerated]
	public ApiStoreEnvironment get__environment() { }

	[CompilerGenerated]
	public ApiStoreProvider get__store() { }

	[CompilerGenerated]
	public override string get_CreateTime() { }

	public override ApiStoreEnvironment get_Environment() { }

	[CompilerGenerated]
	public override string get_ProductId() { }

	[CompilerGenerated]
	public override string get_ProviderResponse() { }

	[CompilerGenerated]
	public override string get_PurchaseTime() { }

	[CompilerGenerated]
	public override string get_RefundTime() { }

	[CompilerGenerated]
	public override bool get_SeenBefore() { }

	public override ApiStoreProvider get_Store() { }

	[CompilerGenerated]
	public override string get_TransactionId() { }

	[CompilerGenerated]
	public override string get_UpdateTime() { }

	[CompilerGenerated]
	public override string get_UserId() { }

	[CompilerGenerated]
	public void set__environment(ApiStoreEnvironment value) { }

	[CompilerGenerated]
	public void set__store(ApiStoreProvider value) { }

	[CompilerGenerated]
	public void set_CreateTime(string value) { }

	[CompilerGenerated]
	public void set_ProductId(string value) { }

	[CompilerGenerated]
	public void set_ProviderResponse(string value) { }

	[CompilerGenerated]
	public void set_PurchaseTime(string value) { }

	[CompilerGenerated]
	public void set_RefundTime(string value) { }

	[CompilerGenerated]
	public void set_SeenBefore(bool value) { }

	[CompilerGenerated]
	public void set_TransactionId(string value) { }

	[CompilerGenerated]
	public void set_UpdateTime(string value) { }

	[CompilerGenerated]
	public void set_UserId(string value) { }

	public virtual string ToString() { }

}

