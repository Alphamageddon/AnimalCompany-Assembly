namespace Nakama;

internal class ApiLinkSteamRequest : IApiLinkSteamRequest
{
	[CompilerGenerated]
	private ApiAccountSteam <_account>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Sync>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "account")]
	[Preserve]
	public ApiAccountSteam _account
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IApiAccountSteam Account
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "sync")]
	[Preserve]
	public override bool Sync
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public ApiLinkSteamRequest() { }

	[CompilerGenerated]
	public ApiAccountSteam get__account() { }

	public override IApiAccountSteam get_Account() { }

	[CompilerGenerated]
	public override bool get_Sync() { }

	[CompilerGenerated]
	public void set__account(ApiAccountSteam value) { }

	[CompilerGenerated]
	public void set_Sync(bool value) { }

	public virtual string ToString() { }

}

