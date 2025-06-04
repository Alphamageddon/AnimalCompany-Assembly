namespace Nakama;

public interface IApiFriend
{

	public int State
	{
		 get { } //Length: 0
	}

	public string UpdateTime
	{
		 get { } //Length: 0
	}

	public IApiUser User
	{
		 get { } //Length: 0
	}

	public int get_State() { }

	public string get_UpdateTime() { }

	public IApiUser get_User() { }

}

