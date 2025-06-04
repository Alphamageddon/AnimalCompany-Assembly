namespace Oculus.Platform;

public class MessageWithShareMediaResult : Message<ShareMediaResult>
{

	public MessageWithShareMediaResult(IntPtr c_message) { }

	protected virtual ShareMediaResult GetDataFromMessage(IntPtr c_message) { }

	public virtual ShareMediaResult GetShareMediaResult() { }

}

