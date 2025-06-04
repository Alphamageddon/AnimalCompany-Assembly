namespace Photon.Realtime;

public class GamePropertyKey
{
	public const byte MaxPlayers = 255; //Field offset: 0x0
	public const byte MaxPlayersInt = 243; //Field offset: 0x0
	public const byte IsVisible = 254; //Field offset: 0x0
	public const byte IsOpen = 253; //Field offset: 0x0
	public const byte PlayerCount = 252; //Field offset: 0x0
	public const byte Removed = 251; //Field offset: 0x0
	public const byte PropsListedInLobby = 250; //Field offset: 0x0
	public const byte CleanupCacheOnLeave = 249; //Field offset: 0x0
	public const byte MasterClientId = 248; //Field offset: 0x0
	public const byte ExpectedUsers = 247; //Field offset: 0x0
	public const byte PlayerTtl = 246; //Field offset: 0x0
	public const byte EmptyRoomTtl = 245; //Field offset: 0x0

	public GamePropertyKey() { }

}

