namespace Oculus.Platform;

public class MessageWithNetSyncSessionsChangedNotification : Message<NetSyncSessionsChangedNotification>
{

	public MessageWithNetSyncSessionsChangedNotification(IntPtr c_message) { }

	protected virtual NetSyncSessionsChangedNotification GetDataFromMessage(IntPtr c_message) { }

	public virtual NetSyncSessionsChangedNotification GetNetSyncSessionsChangedNotification() { }

}

