namespace Oculus.Platform;

public class MessageWithSendInvitesResult : Message<SendInvitesResult>
{

	public MessageWithSendInvitesResult(IntPtr c_message) { }

	protected virtual SendInvitesResult GetDataFromMessage(IntPtr c_message) { }

	public virtual SendInvitesResult GetSendInvitesResult() { }

}

