namespace AnimalCompany;

public class JoinedRoomAction : BaseAction
{
	private string _roomCode; //Field offset: 0x18
	private Dictionary<Int32, String> _players; //Field offset: 0x20

	public JoinedRoomAction(string roomCode, Dictionary<Int32, String> players) { }

	public virtual void Execute(AppState state) { }

}

