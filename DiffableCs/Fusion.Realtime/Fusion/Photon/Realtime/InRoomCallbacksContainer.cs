namespace Fusion.Photon.Realtime;

internal class InRoomCallbacksContainer : List<IInRoomCallbacks>, IInRoomCallbacks
{
	private readonly LoadBalancingClient client; //Field offset: 0x28

	public InRoomCallbacksContainer(LoadBalancingClient client) { }

	public override void OnMasterClientSwitched(Player newMasterClient) { }

	public override void OnPlayerEnteredRoom(Player newPlayer) { }

	public override void OnPlayerLeftRoom(Player otherPlayer) { }

	public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProp) { }

	public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) { }

}

