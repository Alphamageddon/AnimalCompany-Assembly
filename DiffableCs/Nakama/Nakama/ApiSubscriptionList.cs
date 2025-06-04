namespace Nakama;

internal class ApiSubscriptionList : IApiSubscriptionList
{
	[CompilerGenerated]
	private string <Cursor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <PrevCursor>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<ApiValidatedSubscription> <_validatedSubscriptions>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "validated_subscriptions")]
	[Preserve]
	public List<ApiValidatedSubscription> _validatedSubscriptions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "cursor")]
	[Preserve]
	public override string Cursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "prev_cursor")]
	[Preserve]
	public override string PrevCursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiValidatedSubscription> ValidatedSubscriptions
	{
		 get { } //Length: 120
	}

	public ApiSubscriptionList() { }

	[CompilerGenerated]
	public List<ApiValidatedSubscription> get__validatedSubscriptions() { }

	[CompilerGenerated]
	public override string get_Cursor() { }

	[CompilerGenerated]
	public override string get_PrevCursor() { }

	public override IEnumerable<IApiValidatedSubscription> get_ValidatedSubscriptions() { }

	[CompilerGenerated]
	public void set__validatedSubscriptions(List<ApiValidatedSubscription> value) { }

	[CompilerGenerated]
	public void set_Cursor(string value) { }

	[CompilerGenerated]
	public void set_PrevCursor(string value) { }

	public virtual string ToString() { }

}

