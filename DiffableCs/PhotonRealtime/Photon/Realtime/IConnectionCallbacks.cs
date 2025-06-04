namespace Photon.Realtime;

public interface IConnectionCallbacks
{

	public void OnConnected() { }

	public void OnConnectedToMaster() { }

	public void OnCustomAuthenticationFailed(string debugMessage) { }

	public void OnCustomAuthenticationResponse(Dictionary<String, Object> data) { }

	public void OnDisconnected(DisconnectCause cause) { }

	public void OnRegionListReceived(RegionHandler regionHandler) { }

}

