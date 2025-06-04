namespace Oculus.Platform.Models;

public class GroupPresenceLeaveIntent
{
	public readonly string DestinationApiName; //Field offset: 0x10
	public readonly string LobbySessionId; //Field offset: 0x18
	public readonly string MatchSessionId; //Field offset: 0x20

	public GroupPresenceLeaveIntent(IntPtr o) { }

}

