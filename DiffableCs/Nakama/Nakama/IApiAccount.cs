namespace Nakama;

public interface IApiAccount
{

	public string CustomId
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiAccountDevice> Devices
	{
		 get { } //Length: 0
	}

	public string DisableTime
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

	public string get_DisableTime() { }

	public string get_Email() { }

	public IApiUser get_User() { }

	public string get_VerifyTime() { }

	public string get_Wallet() { }

}

