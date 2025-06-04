namespace Nakama;

public interface IApiAccountFacebookInstantGame
{

	public string SignedPlayerInfo
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Vars
	{
		 get { } //Length: 0
	}

	public string get_SignedPlayerInfo() { }

	public IDictionary<String, String> get_Vars() { }

}

