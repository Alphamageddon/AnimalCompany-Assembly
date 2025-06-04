namespace AnimalCompany;

public class UpdateFriendsAction : BaseAction
{
	private IEnumerable<IApiFriend> _friends; //Field offset: 0x18

	public UpdateFriendsAction(IEnumerable<IApiFriend> friends) { }

	public virtual void Execute(AppState state) { }

}

