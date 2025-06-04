namespace AnimalCompany;

public class PlayerJoinedRoomAction : BaseAction
{
	private int _playerID; //Field offset: 0x14
	private string _userID; //Field offset: 0x18

	public PlayerJoinedRoomAction(int playerID, string userID) { }

	public virtual void Execute(AppState state) { }

}

