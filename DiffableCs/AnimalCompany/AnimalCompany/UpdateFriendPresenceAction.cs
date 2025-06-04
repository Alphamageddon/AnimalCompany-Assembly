namespace AnimalCompany;

public class UpdateFriendPresenceAction : BaseAction
{
	private IEnumerable<IUserPresence> _userPresences; //Field offset: 0x18
	private bool _isOnline; //Field offset: 0x20

	public UpdateFriendPresenceAction(IEnumerable<IUserPresence> userPresences, bool isOnline = true) { }

	public virtual void Execute(AppState state) { }

}

