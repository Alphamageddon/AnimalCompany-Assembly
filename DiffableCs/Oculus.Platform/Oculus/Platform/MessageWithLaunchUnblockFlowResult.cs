namespace Oculus.Platform;

public class MessageWithLaunchUnblockFlowResult : Message<LaunchUnblockFlowResult>
{

	public MessageWithLaunchUnblockFlowResult(IntPtr c_message) { }

	protected virtual LaunchUnblockFlowResult GetDataFromMessage(IntPtr c_message) { }

	public virtual LaunchUnblockFlowResult GetLaunchUnblockFlowResult() { }

}

