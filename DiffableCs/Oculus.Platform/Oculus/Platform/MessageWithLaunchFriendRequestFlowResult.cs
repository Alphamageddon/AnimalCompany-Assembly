namespace Oculus.Platform;

public class MessageWithLaunchFriendRequestFlowResult : Message<LaunchFriendRequestFlowResult>
{

	public MessageWithLaunchFriendRequestFlowResult(IntPtr c_message) { }

	protected virtual LaunchFriendRequestFlowResult GetDataFromMessage(IntPtr c_message) { }

	public virtual LaunchFriendRequestFlowResult GetLaunchFriendRequestFlowResult() { }

}

