namespace Oculus.Platform;

public enum PlatformInitializeResult
{
	Success = 0,
	Uninitialized = -1,
	PreLoaded = -2,
	FileInvalid = -3,
	SignatureInvalid = -4,
	UnableToVerify = -5,
	VersionMismatch = -6,
	Unknown = -7,
	InvalidCredentials = -8,
	NotEntitled = -9,
}

