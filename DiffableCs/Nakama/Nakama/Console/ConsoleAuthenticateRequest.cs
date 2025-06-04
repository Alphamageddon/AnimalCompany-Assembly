namespace Nakama.Console;

internal class ConsoleAuthenticateRequest : IConsoleAuthenticateRequest
{
	[CompilerGenerated]
	private string <Password>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Username>k__BackingField; //Field offset: 0x18

	[DataMember(Name = "password")]
	public override string Password
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "username")]
	public override string Username
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ConsoleAuthenticateRequest() { }

	[CompilerGenerated]
	public override string get_Password() { }

	[CompilerGenerated]
	public override string get_Username() { }

	[CompilerGenerated]
	public void set_Password(string value) { }

	[CompilerGenerated]
	public void set_Username(string value) { }

	public virtual string ToString() { }

}

