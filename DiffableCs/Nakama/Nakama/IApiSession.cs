namespace Nakama;

public interface IApiSession
{

	public bool Created
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

	public bool get_Created() { }

	public string get_RefreshToken() { }

	public string get_Token() { }

}

