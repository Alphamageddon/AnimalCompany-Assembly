namespace Oculus.Platform;

public class MessageWithUserProof : Message<UserProof>
{

	public MessageWithUserProof(IntPtr c_message) { }

	protected virtual UserProof GetDataFromMessage(IntPtr c_message) { }

	public virtual UserProof GetUserProof() { }

}

