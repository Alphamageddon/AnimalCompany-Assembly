namespace AnimalCompany;

public class PlayerMutedAction : BaseAction
{
	private string _userID; //Field offset: 0x18

	public PlayerMutedAction(string userID) { }

	public virtual void Execute(AppState state) { }

}

