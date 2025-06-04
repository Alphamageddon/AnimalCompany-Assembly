namespace Oculus.Platform;

public enum AppInstallResult
{
	Unknown = 0,
	LowStorage = 1,
	NetworkError = 2,
	DuplicateRequest = 3,
	InstallerError = 4,
	UserCancelled = 5,
	AuthorizationError = 6,
	Success = 7,
}

