namespace Nakama.Console;

public interface IApiUserGroupList
{

	public string Cursor
	{
		 get { } //Length: 0
	}

	public IEnumerable<IUserGroupListUserGroup> UserGroups
	{
		 get { } //Length: 0
	}

	public string get_Cursor() { }

	public IEnumerable<IUserGroupListUserGroup> get_UserGroups() { }

}

