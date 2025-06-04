namespace Oculus.Platform;

public class MessageWithLaunchBlockFlowResult : Message<LaunchBlockFlowResult>
{

	public MessageWithLaunchBlockFlowResult(IntPtr c_message) { }

	protected virtual LaunchBlockFlowResult GetDataFromMessage(IntPtr c_message) { }

	public virtual LaunchBlockFlowResult GetLaunchBlockFlowResult() { }

}

