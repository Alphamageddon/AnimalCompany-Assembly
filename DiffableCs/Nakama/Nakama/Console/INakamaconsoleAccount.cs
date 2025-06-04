namespace Nakama.Console;

public interface INakamaconsoleAccount
{

	public INakamaapiAccount Account
	{
		 get { } //Length: 0
	}

	public string DisableTime
	{
		 get { } //Length: 0
	}

	public INakamaapiAccount get_Account() { }

	public string get_DisableTime() { }

}

