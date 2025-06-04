namespace AnimalCompany;

public class RemoveUserAvatarCacheAction : BaseAction
{
	private String[] _userIDs; //Field offset: 0x18

	public RemoveUserAvatarCacheAction(String[] userIDs) { }

	public virtual void Execute(AppState state) { }

}

