namespace AnimalCompany;

public class PlayerLeftRoomAction : BaseAction
{
	private int _playerID; //Field offset: 0x14

	public PlayerLeftRoomAction(int playerID) { }

	public virtual void Execute(AppState state) { }

}

