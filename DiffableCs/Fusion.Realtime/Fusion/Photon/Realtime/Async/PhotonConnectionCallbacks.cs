namespace Fusion.Photon.Realtime.Async;

internal class PhotonConnectionCallbacks
{
	public Action ConnectedToMaster; //Field offset: 0x10
	public Action ConnectedToNameServer; //Field offset: 0x18
	public Action<RegionHandler> RegionListReceived; //Field offset: 0x20
	public Action<DisconnectCause> Disconnected; //Field offset: 0x28
	public Action<String> CustomAuthenticationFailed; //Field offset: 0x30
	public Action<Dictionary`2<String, Object>> CustomAuthenticationResponse; //Field offset: 0x38

	public PhotonConnectionCallbacks() { }

}

