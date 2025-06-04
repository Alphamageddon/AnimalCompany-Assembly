namespace Fusion.Protocol;

public enum DisconnectReason
{
	None = 0,
	ServerLogic = 1,
	InvalidEventCode = 2,
	InvalidJoinMsgType = 3,
	InvalidJoinGameMode = 4,
	IncompatibleConfiguration = 5,
	ServerAlreadyInRoom = 6,
	Error = 7,
}

