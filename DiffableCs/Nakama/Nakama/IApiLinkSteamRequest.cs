namespace Nakama;

public interface IApiLinkSteamRequest
{

	public IApiAccountSteam Account
	{
		 get { } //Length: 0
	}

	public bool Sync
	{
		 get { } //Length: 0
	}

	public IApiAccountSteam get_Account() { }

	public bool get_Sync() { }

}

