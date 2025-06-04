namespace Photon.Realtime;

public class OpJoinRandomRoomParams
{
	public Hashtable ExpectedCustomRoomProperties; //Field offset: 0x10
	public int ExpectedMaxPlayers; //Field offset: 0x18
	public MatchmakingMode MatchingType; //Field offset: 0x1C
	public TypedLobby TypedLobby; //Field offset: 0x20
	public string SqlLobbyFilter; //Field offset: 0x28
	public String[] ExpectedUsers; //Field offset: 0x30
	public object Ticket; //Field offset: 0x38

	public OpJoinRandomRoomParams() { }

}

