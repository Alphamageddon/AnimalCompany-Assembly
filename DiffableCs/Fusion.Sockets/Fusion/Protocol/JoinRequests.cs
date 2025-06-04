namespace Fusion.Protocol;

[Flags]
internal enum JoinRequests
{
	None = 0,
	NetworkConfig = 2,
	ReflexiveInfo = 4,
	DisableNATPunch = 8,
}

