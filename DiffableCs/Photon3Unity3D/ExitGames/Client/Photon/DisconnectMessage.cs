namespace ExitGames.Client.Photon;

public class DisconnectMessage
{
	public short Code; //Field offset: 0x10
	public string DebugMessage; //Field offset: 0x18
	public Dictionary<Byte, Object> Parameters; //Field offset: 0x20

	public DisconnectMessage() { }

}

