namespace Nakama;

internal class ApiAccount : IApiAccount
{
	[CompilerGenerated]
	private string <CustomId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiAccountDevice> <_devices>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <DisableTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Email>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ApiUser <_user>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <VerifyTime>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <Wallet>k__BackingField; //Field offset: 0x40

	[DataMember(Name = "devices")]
	[Preserve]
	public List<ApiAccountDevice> _devices
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "user")]
	[Preserve]
	public ApiUser _user
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "custom_id")]
	[Preserve]
	public override string CustomId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiAccountDevice> Devices
	{
		 get { } //Length: 120
	}

	[DataMember(Name = "disable_time")]
	[Preserve]
	public override string DisableTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "email")]
	[Preserve]
	public override string Email
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IApiUser User
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "verify_time")]
	[Preserve]
	public override string VerifyTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "wallet")]
	[Preserve]
	public override string Wallet
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiAccount() { }

	[CompilerGenerated]
	public List<ApiAccountDevice> get__devices() { }

	[CompilerGenerated]
	public ApiUser get__user() { }

	[CompilerGenerated]
	public override string get_CustomId() { }

	public override IEnumerable<IApiAccountDevice> get_Devices() { }

	[CompilerGenerated]
	public override string get_DisableTime() { }

	[CompilerGenerated]
	public override string get_Email() { }

	public override IApiUser get_User() { }

	[CompilerGenerated]
	public override string get_VerifyTime() { }

	[CompilerGenerated]
	public override string get_Wallet() { }

	[CompilerGenerated]
	public void set__devices(List<ApiAccountDevice> value) { }

	[CompilerGenerated]
	public void set__user(ApiUser value) { }

	[CompilerGenerated]
	public void set_CustomId(string value) { }

	[CompilerGenerated]
	public void set_DisableTime(string value) { }

	[CompilerGenerated]
	public void set_Email(string value) { }

	[CompilerGenerated]
	public void set_VerifyTime(string value) { }

	[CompilerGenerated]
	public void set_Wallet(string value) { }

	public virtual string ToString() { }

}

