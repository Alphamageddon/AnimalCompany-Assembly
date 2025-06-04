namespace Oculus.Platform;

public class MessageWithAvatarEditorResult : Message<AvatarEditorResult>
{

	public MessageWithAvatarEditorResult(IntPtr c_message) { }

	public virtual AvatarEditorResult GetAvatarEditorResult() { }

	protected virtual AvatarEditorResult GetDataFromMessage(IntPtr c_message) { }

}

