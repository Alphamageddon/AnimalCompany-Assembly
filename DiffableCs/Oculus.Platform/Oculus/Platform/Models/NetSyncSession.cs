namespace Oculus.Platform.Models;

public class NetSyncSession
{
	public readonly long ConnectionId; //Field offset: 0x10
	public readonly bool Muted; //Field offset: 0x18
	public readonly ulong SessionId; //Field offset: 0x20
	public readonly ulong UserId; //Field offset: 0x28
	public readonly string VoipGroup; //Field offset: 0x30

	public NetSyncSession(IntPtr o) { }

}

