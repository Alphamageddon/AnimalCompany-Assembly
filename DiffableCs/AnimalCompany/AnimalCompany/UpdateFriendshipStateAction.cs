namespace AnimalCompany;

public class UpdateFriendshipStateAction : BaseAction
{
	private string _userID; //Field offset: 0x18
	private FriendshipState _friendshipState; //Field offset: 0x20

	public UpdateFriendshipStateAction(string userID, FriendshipState friendshipState) { }

	public virtual void Execute(AppState state) { }

}

