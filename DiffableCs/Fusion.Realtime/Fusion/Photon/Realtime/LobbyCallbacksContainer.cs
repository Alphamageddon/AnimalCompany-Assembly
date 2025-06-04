namespace Fusion.Photon.Realtime;

internal class LobbyCallbacksContainer : List<ILobbyCallbacks>, ILobbyCallbacks
{
	private readonly LoadBalancingClient client; //Field offset: 0x28

	public LobbyCallbacksContainer(LoadBalancingClient client) { }

	public override void OnJoinedLobby() { }

	public override void OnLeftLobby() { }

	public override void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) { }

	public override void OnRoomListUpdate(List<RoomInfo> roomList) { }

}

