namespace AnimalCompany;

public class RemoveFriendsAction : BaseAction
{
	private String[] _userIDs; //Field offset: 0x18

	public RemoveFriendsAction(String[] userIDs) { }

	public virtual void Execute(AppState state) { }

}

