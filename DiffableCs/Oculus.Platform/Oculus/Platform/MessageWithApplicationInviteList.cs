namespace Oculus.Platform;

public class MessageWithApplicationInviteList : Message<ApplicationInviteList>
{

	public MessageWithApplicationInviteList(IntPtr c_message) { }

	public virtual ApplicationInviteList GetApplicationInviteList() { }

	protected virtual ApplicationInviteList GetDataFromMessage(IntPtr c_message) { }

}

