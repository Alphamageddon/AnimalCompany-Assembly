namespace Oculus.Platform.Models;

public class LaunchReportFlowResult
{
	public readonly bool DidCancel; //Field offset: 0x10
	public readonly ulong UserReportId; //Field offset: 0x18

	public LaunchReportFlowResult(IntPtr o) { }

}

