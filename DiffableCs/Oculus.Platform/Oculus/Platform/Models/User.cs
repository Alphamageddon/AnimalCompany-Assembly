namespace Oculus.Platform.Models;

public class User
{
	public readonly string DisplayName; //Field offset: 0x10
	public readonly ulong ID; //Field offset: 0x18
	public readonly string ImageURL; //Field offset: 0x20
	public readonly string OculusID; //Field offset: 0x28
	public readonly string Presence; //Field offset: 0x30
	public readonly string PresenceDeeplinkMessage; //Field offset: 0x38
	public readonly string PresenceDestinationApiName; //Field offset: 0x40
	public readonly string PresenceLobbySessionId; //Field offset: 0x48
	public readonly string PresenceMatchSessionId; //Field offset: 0x50
	public readonly UserPresenceStatus PresenceStatus; //Field offset: 0x58
	public readonly string SmallImageUrl; //Field offset: 0x60

	public User(IntPtr o) { }

}

