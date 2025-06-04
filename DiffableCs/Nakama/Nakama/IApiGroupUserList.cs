namespace Nakama;

public interface IApiGroupUserList
{

	public string Cursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IGroupUserListGroupUser> GroupUsers
	{
		 get { } //Length: 0
	}

	public string get_Cursor() { }

	public IEnumerable<IGroupUserListGroupUser> get_GroupUsers() { }

}

