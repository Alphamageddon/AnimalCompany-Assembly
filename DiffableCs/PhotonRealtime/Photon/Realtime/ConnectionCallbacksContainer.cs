namespace Photon.Realtime;

public class ConnectionCallbacksContainer : List<IConnectionCallbacks>, IConnectionCallbacks
{
	private readonly LoadBalancingClient client; //Field offset: 0x28

	public ConnectionCallbacksContainer(LoadBalancingClient client) { }

	public override void OnConnected() { }

	public override void OnConnectedToMaster() { }

	public override void OnCustomAuthenticationFailed(string debugMessage) { }

	public override void OnCustomAuthenticationResponse(Dictionary<String, Object> data) { }

	public override void OnDisconnected(DisconnectCause cause) { }

	public override void OnRegionListReceived(RegionHandler regionHandler) { }

}

