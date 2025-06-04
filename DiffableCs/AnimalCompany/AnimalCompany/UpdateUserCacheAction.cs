namespace AnimalCompany;

public class UpdateUserCacheAction : BaseAction
{
	private IApiUsers _users; //Field offset: 0x18

	public UpdateUserCacheAction(IApiUsers users) { }

	public virtual void Execute(AppState state) { }

}

