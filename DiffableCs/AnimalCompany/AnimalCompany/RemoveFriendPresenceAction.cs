namespace AnimalCompany;

public class RemoveFriendPresenceAction : BaseAction
{
	private IEnumerable<String> _userIDs; //Field offset: 0x18

	public RemoveFriendPresenceAction(IEnumerable<String> userIDs) { }

	public virtual void Execute(AppState state) { }

}

