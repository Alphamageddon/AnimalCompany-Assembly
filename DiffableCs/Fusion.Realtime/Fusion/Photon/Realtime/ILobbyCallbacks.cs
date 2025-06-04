namespace Fusion.Photon.Realtime;

internal interface ILobbyCallbacks
{

	public void OnJoinedLobby() { }

	public void OnLeftLobby() { }

	public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) { }

	public void OnRoomListUpdate(List<RoomInfo> roomList) { }

}

