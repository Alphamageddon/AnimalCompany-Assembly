namespace AnimalCompany;

public class AddFriendAction : BaseAction
{
	private IApiUser _user; //Field offset: 0x18
	private UserCacheState _userCacheState; //Field offset: 0x20
	private FriendshipState _friendshipState; //Field offset: 0x28

	public AddFriendAction(IApiUser user, FriendshipState friendshipState) { }

	public AddFriendAction(UserCacheState userCacheState, FriendshipState friendshipState) { }

	public virtual void Execute(AppState state) { }

}

