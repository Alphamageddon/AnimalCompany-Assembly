namespace Nakama.Console;

internal class NakamaapiAccount : INakamaapiAccount
{
	[CompilerGenerated]
	private string <CustomId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ApiAccountDevice> <_devices>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Email>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ApiUser <_user>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <VerifyTime>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <Wallet>k__BackingField; //Field offset: 0x38

	[DataMember(Name = "devices")]
	public List<ApiAccountDevice> _devices
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "user")]
	public ApiUser _user
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "custom_id")]
	public override string CustomId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IApiAccountDevice> Devices
	{
		 get { } //Length: 120
	}

	[DataMember(Name = "email")]
	public override string Email
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IApiUser User
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "verify_time")]
	public override string VerifyTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "wallet")]
	public override string Wallet
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public NakamaapiAccount() { }

	[CompilerGenerated]
	public List<ApiAccountDevice> get__devices() { }

	[CompilerGenerated]
	public ApiUser get__user() { }

	[CompilerGenerated]
	public override string get_CustomId() { }

	public override IEnumerable<IApiAccountDevice> get_Devices() { }

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
	public void set_Email(string value) { }

	[CompilerGenerated]
	public void set_VerifyTime(string value) { }

	[CompilerGenerated]
	public void set_Wallet(string value) { }

	public virtual string ToString() { }

}

