namespace Fusion.Protocol;

[Flags]
internal enum StartRequests
{
	None = 0,
	ConnectToShared = 2,
	WaitForReflexiveInfo = 4,
}

