namespace Oculus.Platform.Models;

public class LaunchBlockFlowResult
{
	public readonly bool DidBlock; //Field offset: 0x10
	public readonly bool DidCancel; //Field offset: 0x11

	public LaunchBlockFlowResult(IntPtr o) { }

}

