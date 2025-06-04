namespace Oculus.Platform;

public class MessageWithNetSyncSessionList : Message<NetSyncSessionList>
{

	public MessageWithNetSyncSessionList(IntPtr c_message) { }

	protected virtual NetSyncSessionList GetDataFromMessage(IntPtr c_message) { }

	public virtual NetSyncSessionList GetNetSyncSessionList() { }

}

