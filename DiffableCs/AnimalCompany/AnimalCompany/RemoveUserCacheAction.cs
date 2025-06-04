namespace AnimalCompany;

public class RemoveUserCacheAction : BaseAction
{
	private String[] _userIDs; //Field offset: 0x18

	public RemoveUserCacheAction(String[] userIDs) { }

	public virtual void Execute(AppState state) { }

}

