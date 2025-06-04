namespace Nakama;

internal class ApiAccountEmail : IApiAccountEmail
{
	[CompilerGenerated]
	private string <Email>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Password>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary<String, String> <_vars>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "vars")]
	[Preserve]
	public Dictionary<String, String> _vars
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

	[DataMember(Name = "password")]
	[Preserve]
	public override string Password
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IDictionary<String, String> Vars
	{
		 get { } //Length: 116
	}

	public ApiAccountEmail() { }

	[CompilerGenerated]
	public Dictionary<String, String> get__vars() { }

	[CompilerGenerated]
	public override string get_Email() { }

	[CompilerGenerated]
	public override string get_Password() { }

	public override IDictionary<String, String> get_Vars() { }

	[CompilerGenerated]
	public void set__vars(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_Email(string value) { }

	[CompilerGenerated]
	public void set_Password(string value) { }

	public virtual string ToString() { }

}

