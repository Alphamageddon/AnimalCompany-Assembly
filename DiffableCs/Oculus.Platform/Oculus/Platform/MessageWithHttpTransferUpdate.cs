namespace Oculus.Platform;

public class MessageWithHttpTransferUpdate : Message<HttpTransferUpdate>
{

	public MessageWithHttpTransferUpdate(IntPtr c_message) { }

	protected virtual HttpTransferUpdate GetDataFromMessage(IntPtr c_message) { }

	public virtual HttpTransferUpdate GetHttpTransferUpdate() { }

}

