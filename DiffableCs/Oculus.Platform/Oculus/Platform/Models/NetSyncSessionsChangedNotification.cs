namespace Oculus.Platform.Models;

public class NetSyncSessionsChangedNotification
{
	public readonly long ConnectionId; //Field offset: 0x10
	public readonly NetSyncSessionList Sessions; //Field offset: 0x18

	public NetSyncSessionsChangedNotification(IntPtr o) { }

}

