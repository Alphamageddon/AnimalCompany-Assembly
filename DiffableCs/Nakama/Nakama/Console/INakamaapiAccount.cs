namespace Nakama.Console;

public interface INakamaapiAccount
{

	public string CustomId
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiAccountDevice> Devices
	{
		 get { } //Length: 0
	}

	public string Email
	{
		 get { } //Length: 0
	}

	public IApiUser User
	{
		 get { } //Length: 0
	}

	public string VerifyTime
	{
		 get { } //Length: 0
	}

	public string Wallet
	{
		 get { } //Length: 0
	}

	public string get_CustomId() { }

	public IEnumerable<IApiAccountDevice> get_Devices() { }

	public string get_Email() { }

	public IApiUser get_User() { }

	public string get_VerifyTime() { }

	public string get_Wallet() { }

}

