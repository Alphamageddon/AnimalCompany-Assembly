namespace Nakama.Console;

internal class NakamaconsoleAccount : INakamaconsoleAccount
{
	[CompilerGenerated]
	private NakamaapiAccount <_account>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <DisableTime>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "account")]
	public NakamaapiAccount _account
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override INakamaapiAccount Account
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "disable_time")]
	public override string DisableTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public NakamaconsoleAccount() { }

	[CompilerGenerated]
	public NakamaapiAccount get__account() { }

	public override INakamaapiAccount get_Account() { }

	[CompilerGenerated]
	public override string get_DisableTime() { }

	[CompilerGenerated]
	public void set__account(NakamaapiAccount value) { }

	[CompilerGenerated]
	public void set_DisableTime(string value) { }

	public virtual string ToString() { }

}

