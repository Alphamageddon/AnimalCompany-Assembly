namespace Fusion.Photon.Realtime;

internal enum ClientState
{
	PeerCreated = 0,
	Authenticating = 1,
	Authenticated = 2,
	JoiningLobby = 3,
	JoinedLobby = 4,
	DisconnectingFromMasterServer = 5,
	DisconnectingFromMasterserver = 5,
	ConnectingToGameServer = 6,
	ConnectingToGameserver = 6,
	ConnectedToGameServer = 7,
	ConnectedToGameserver = 7,
	Joining = 8,
	Joined = 9,
	Leaving = 10,
	DisconnectingFromGameServer = 11,
	DisconnectingFromGameserver = 11,
	ConnectingToMasterServer = 12,
	ConnectingToMasterserver = 12,
	Disconnecting = 13,
	Disconnected = 14,
	ConnectedToMasterServer = 15,
	ConnectedToMasterserver = 15,
	ConnectedToMaster = 15,
	ConnectingToNameServer = 16,
	ConnectedToNameServer = 17,
	DisconnectingFromNameServer = 18,
	ConnectWithFallbackProtocol = 19,
	ConnectWithoutAuthOnceWss = 20,
}

