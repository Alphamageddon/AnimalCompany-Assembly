namespace Fusion.Photon.Realtime;

internal class WebRpcCallbacksContainer : List<IWebRpcCallback>, IWebRpcCallback
{
	private LoadBalancingClient client; //Field offset: 0x28

	public WebRpcCallbacksContainer(LoadBalancingClient client) { }

	public override void OnWebRpcResponse(OperationResponse response) { }

}

