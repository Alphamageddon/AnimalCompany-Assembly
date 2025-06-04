namespace Oculus.Platform;

public enum LivestreamingStartStatus
{
	Success = 1,
	Unknown = 0,
	NoPackageSet = -1,
	NoFbConnect = -2,
	NoSessionId = -3,
	MissingParameters = -4,
}

