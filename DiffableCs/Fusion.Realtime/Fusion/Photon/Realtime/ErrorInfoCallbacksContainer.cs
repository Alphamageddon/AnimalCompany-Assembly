namespace Fusion.Photon.Realtime;

internal class ErrorInfoCallbacksContainer : List<IErrorInfoCallback>, IErrorInfoCallback
{
	private LoadBalancingClient client; //Field offset: 0x28

	public ErrorInfoCallbacksContainer(LoadBalancingClient client) { }

	public override void OnErrorInfo(ErrorInfo errorInfo) { }

}

