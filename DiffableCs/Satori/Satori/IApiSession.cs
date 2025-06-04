namespace Satori;

public interface IApiSession
{

	public IApiProperties Properties
	{
		 get { } //Length: 0
	}

	public string RefreshToken
	{
		 get { } //Length: 0
	}

	public string Token
	{
		 get { } //Length: 0
	}

	public IApiProperties get_Properties() { }

	public string get_RefreshToken() { }

	public string get_Token() { }

}

