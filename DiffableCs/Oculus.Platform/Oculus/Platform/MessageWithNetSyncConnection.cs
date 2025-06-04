namespace Oculus.Platform;

public class MessageWithNetSyncConnection : Message<NetSyncConnection>
{

	public MessageWithNetSyncConnection(IntPtr c_message) { }

	protected virtual NetSyncConnection GetDataFromMessage(IntPtr c_message) { }

	public virtual NetSyncConnection GetNetSyncConnection() { }

}

