namespace Nakama.Console;

public interface IConsoleUserList
{

	public int TotalCount
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiUser> Users
	{
		 get { } //Length: 0
	}

	public int get_TotalCount() { }

	public IEnumerable<IApiUser> get_Users() { }

}

