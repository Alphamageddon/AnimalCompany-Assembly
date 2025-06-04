namespace Nakama;

public interface IApiUsers
{

	public IEnumerable<IApiUser> Users
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiUser> get_Users() { }

}

