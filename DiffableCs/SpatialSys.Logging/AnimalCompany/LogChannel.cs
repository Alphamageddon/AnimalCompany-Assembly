namespace AnimalCompany;

[Flags]
public enum LogChannel
{
	None = 0,
	Default = 1,
	UncaughtExceptions = 2,
	WebRequests = 4,
	Fusion = 8,
	Analytics = 16,
	LevelGenerator = 32,
	Player = 32,
	API = 64,
	AppStateObservationContext = 128,
	AppActionScheduler = 256,
	AppCommandScheduler = 512,
	CommandLib = 1024,
	Auth = 2048,
	Network = 4096,
	AvatarSystem = 8192,
	IAP = 16384,
	Friends = 32768,
}

