namespace AnimalCompany;

public class PlayerUnmutedAction : BaseAction
{
	private string _userID; //Field offset: 0x18

	public PlayerUnmutedAction(string userID) { }

	public virtual void Execute(AppState state) { }

}

