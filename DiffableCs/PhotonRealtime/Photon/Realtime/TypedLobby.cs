namespace Photon.Realtime;

public class TypedLobby
{
	public static readonly TypedLobby Default; //Field offset: 0x0
	public string Name; //Field offset: 0x10
	public LobbyType Type; //Field offset: 0x18

	public bool IsDefault
	{
		 get { } //Length: 12
	}

	private static TypedLobby() { }

	internal TypedLobby() { }

	public TypedLobby(string name, LobbyType type) { }

	public bool get_IsDefault() { }

	public virtual string ToString() { }

}

