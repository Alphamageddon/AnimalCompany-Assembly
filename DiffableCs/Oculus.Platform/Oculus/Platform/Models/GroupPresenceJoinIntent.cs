namespace Oculus.Platform.Models;

public class GroupPresenceJoinIntent
{
	public readonly string DeeplinkMessage; //Field offset: 0x10
	public readonly string DestinationApiName; //Field offset: 0x18
	public readonly string LobbySessionId; //Field offset: 0x20
	public readonly string MatchSessionId; //Field offset: 0x28

	public GroupPresenceJoinIntent(IntPtr o) { }

}

