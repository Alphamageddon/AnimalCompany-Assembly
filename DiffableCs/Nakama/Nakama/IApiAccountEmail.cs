namespace Nakama;

public interface IApiAccountEmail
{

	public string Email
	{
		 get { } //Length: 0
	}

	public string Password
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Vars
	{
		 get { } //Length: 0
	}

	public string get_Email() { }

	public string get_Password() { }

	public IDictionary<String, String> get_Vars() { }

}

