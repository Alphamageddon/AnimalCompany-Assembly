namespace Oculus.Platform.Models;

public class NetSyncConnection
{
	public readonly long ConnectionId; //Field offset: 0x10
	public readonly NetSyncDisconnectReason DisconnectReason; //Field offset: 0x18
	public readonly ulong SessionId; //Field offset: 0x20
	public readonly NetSyncConnectionStatus Status; //Field offset: 0x28
	public readonly string ZoneId; //Field offset: 0x30

	public NetSyncConnection(IntPtr o) { }

}

