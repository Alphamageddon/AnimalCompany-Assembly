namespace Oculus.Platform.Models;

public class LaunchDetails
{
	public readonly string DeeplinkMessage; //Field offset: 0x10
	public readonly string DestinationApiName; //Field offset: 0x18
	public readonly string LaunchSource; //Field offset: 0x20
	public readonly LaunchType LaunchType; //Field offset: 0x28
	public readonly string LobbySessionID; //Field offset: 0x30
	public readonly string MatchSessionID; //Field offset: 0x38
	public readonly string TrackingID; //Field offset: 0x40
	public readonly UserList UsersOptional; //Field offset: 0x48
	[Obsolete("Deprecated in favor of UsersOptional")]
	public readonly UserList Users; //Field offset: 0x50

	public LaunchDetails(IntPtr o) { }

}

