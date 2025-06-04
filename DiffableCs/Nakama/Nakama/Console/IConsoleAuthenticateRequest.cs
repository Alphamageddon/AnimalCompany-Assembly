namespace Nakama.Console;

public interface IConsoleAuthenticateRequest
{

	public string Password
	{
		 get { } //Length: 0
	}

	public string Username
	{
		 get { } //Length: 0
	}

	public string get_Password() { }

	public string get_Username() { }

}

