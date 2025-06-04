namespace Oculus.Platform;

public class MessageWithLaunchInvitePanelFlowResult : Message<LaunchInvitePanelFlowResult>
{

	public MessageWithLaunchInvitePanelFlowResult(IntPtr c_message) { }

	protected virtual LaunchInvitePanelFlowResult GetDataFromMessage(IntPtr c_message) { }

	public virtual LaunchInvitePanelFlowResult GetLaunchInvitePanelFlowResult() { }

}

