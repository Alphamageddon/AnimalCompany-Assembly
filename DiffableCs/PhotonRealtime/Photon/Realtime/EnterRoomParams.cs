namespace Photon.Realtime;

public class EnterRoomParams
{
	public string RoomName; //Field offset: 0x10
	public RoomOptions RoomOptions; //Field offset: 0x18
	public TypedLobby Lobby; //Field offset: 0x20
	public Hashtable PlayerProperties; //Field offset: 0x28
	protected private bool OnGameServer; //Field offset: 0x30
	protected private JoinMode JoinMode; //Field offset: 0x31
	public String[] ExpectedUsers; //Field offset: 0x38

	public EnterRoomParams() { }

}

