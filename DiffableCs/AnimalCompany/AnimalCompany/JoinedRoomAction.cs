namespace AnimalCompany;

public class JoinedRoomAction : BaseAction
{
	private string _roomCode; //Field offset: 0x18

	public JoinedRoomAction(string roomCode) { }

	public virtual void Execute(AppState state) { }

}

