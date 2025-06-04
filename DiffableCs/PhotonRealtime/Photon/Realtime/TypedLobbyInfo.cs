namespace Photon.Realtime;

public class TypedLobbyInfo : TypedLobby
{
	public int PlayerCount; //Field offset: 0x1C
	public int RoomCount; //Field offset: 0x20

	public TypedLobbyInfo() { }

	public virtual string ToString() { }

}

