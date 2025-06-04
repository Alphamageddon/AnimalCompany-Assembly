namespace Oculus.Platform;

public class MessageWithRejoinDialogResult : Message<RejoinDialogResult>
{

	public MessageWithRejoinDialogResult(IntPtr c_message) { }

	protected virtual RejoinDialogResult GetDataFromMessage(IntPtr c_message) { }

	public virtual RejoinDialogResult GetRejoinDialogResult() { }

}

