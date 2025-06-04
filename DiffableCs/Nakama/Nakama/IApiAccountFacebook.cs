namespace Nakama;

public interface IApiAccountFacebook
{

	public string Token
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Vars
	{
		 get { } //Length: 0
	}

	public string get_Token() { }

	public IDictionary<String, String> get_Vars() { }

}

