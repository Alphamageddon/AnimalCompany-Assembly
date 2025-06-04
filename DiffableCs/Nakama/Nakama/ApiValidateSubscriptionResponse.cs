namespace Nakama;

internal class ApiValidateSubscriptionResponse : IApiValidateSubscriptionResponse
{
	[CompilerGenerated]
	private ApiValidatedSubscription <_validatedSubscription>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "validated_subscription")]
	[Preserve]
	public ApiValidatedSubscription _validatedSubscription
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IApiValidatedSubscription ValidatedSubscription
	{
		 get { } //Length: 8
	}

	public ApiValidateSubscriptionResponse() { }

	[CompilerGenerated]
	public ApiValidatedSubscription get__validatedSubscription() { }

	public override IApiValidatedSubscription get_ValidatedSubscription() { }

	[CompilerGenerated]
	public void set__validatedSubscription(ApiValidatedSubscription value) { }

	public virtual string ToString() { }

}

