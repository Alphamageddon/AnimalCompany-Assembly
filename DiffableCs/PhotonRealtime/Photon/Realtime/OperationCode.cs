namespace Photon.Realtime;

public class OperationCode
{
	[Obsolete("Exchanging encrpytion keys is done internally in the lib now. Don't expect this operation-result.")]
	public const byte ExchangeKeysForEncryption = 250; //Field offset: 0x0
	public const byte WebRpc = 219; //Field offset: 0x0
	public const byte GetRegions = 220; //Field offset: 0x0
	public const byte GetLobbyStats = 221; //Field offset: 0x0
	public const byte FindFriends = 222; //Field offset: 0x0
	public const byte ChangeGroups = 248; //Field offset: 0x0
	public const byte GetProperties = 251; //Field offset: 0x0
	public const byte SetProperties = 252; //Field offset: 0x0
	public const byte RaiseEvent = 253; //Field offset: 0x0
	public const byte Leave = 254; //Field offset: 0x0
	public const byte JoinRandomGame = 225; //Field offset: 0x0
	public const byte JoinGame = 226; //Field offset: 0x0
	public const byte CreateGame = 227; //Field offset: 0x0
	public const byte LeaveLobby = 228; //Field offset: 0x0
	public const byte JoinLobby = 229; //Field offset: 0x0
	public const byte Authenticate = 230; //Field offset: 0x0
	public const byte AuthenticateOnce = 231; //Field offset: 0x0
	[Obsolete]
	public const byte Join = 255; //Field offset: 0x0
	public const byte ServerSettings = 218; //Field offset: 0x0
	public const byte GetGameList = 217; //Field offset: 0x0

	public OperationCode() { }

}

