namespace AnimalCompany;

public class SetTargetRoomAction : BaseAction
{
	private string _roomCode; //Field offset: 0x18
	private SessionProperties _properties; //Field offset: 0x20

	public SetTargetRoomAction(string roomCode, SessionProperties properties) { }

	public virtual void Execute(AppState state) { }

}

