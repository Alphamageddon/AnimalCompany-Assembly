namespace Fusion.Sockets;

public enum NetDisconnectReason
{
	Unknown = 1,
	Timeout = 2,
	Requested = 3,
	SequenceOutOfBounds = 4,
	SendWindowFull = 5,
	ByRemote = 6,
}

