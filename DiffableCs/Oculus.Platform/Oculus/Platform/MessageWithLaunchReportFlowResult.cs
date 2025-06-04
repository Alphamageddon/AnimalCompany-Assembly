namespace Oculus.Platform;

public class MessageWithLaunchReportFlowResult : Message<LaunchReportFlowResult>
{

	public MessageWithLaunchReportFlowResult(IntPtr c_message) { }

	protected virtual LaunchReportFlowResult GetDataFromMessage(IntPtr c_message) { }

	public virtual LaunchReportFlowResult GetLaunchReportFlowResult() { }

}

