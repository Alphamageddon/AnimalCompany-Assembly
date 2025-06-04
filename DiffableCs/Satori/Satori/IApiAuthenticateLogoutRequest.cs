namespace Satori;

public interface IApiAuthenticateLogoutRequest
{

	public string RefreshToken
	{
		 get { } //Length: 0
	}

	public string Token
	{
		 get { } //Length: 0
	}

	public string get_RefreshToken() { }

	public string get_Token() { }

}

