namespace Oculus.Platform;

public class MessageWithNetSyncSetSessionPropertyResult : Message<NetSyncSetSessionPropertyResult>
{

	public MessageWithNetSyncSetSessionPropertyResult(IntPtr c_message) { }

	protected virtual NetSyncSetSessionPropertyResult GetDataFromMessage(IntPtr c_message) { }

	public virtual NetSyncSetSessionPropertyResult GetNetSyncSetSessionPropertyResult() { }

}

