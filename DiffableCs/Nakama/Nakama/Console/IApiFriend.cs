namespace Nakama.Console;

public interface IApiFriend
{

	public int State
	{
		 get { } //Length: 0
	}

	public IApiUser User
	{
		 get { } //Length: 0
	}

	public int get_State() { }

	public IApiUser get_User() { }

}

