namespace Photon.Realtime;

public interface IInRoomCallbacks
{

	public void OnMasterClientSwitched(Player newMasterClient) { }

	public void OnPlayerEnteredRoom(Player newPlayer) { }

	public void OnPlayerLeftRoom(Player otherPlayer) { }

	public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps) { }

	public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) { }

}

