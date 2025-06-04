namespace Oculus.Platform;

public class MessageWithInvitePanelResultInfo : Message<InvitePanelResultInfo>
{

	public MessageWithInvitePanelResultInfo(IntPtr c_message) { }

	protected virtual InvitePanelResultInfo GetDataFromMessage(IntPtr c_message) { }

	public virtual InvitePanelResultInfo GetInvitePanelResultInfo() { }

}

