namespace Fusion.Photon.Realtime;

internal class MatchMakingCallbacksContainer : List<IMatchmakingCallbacks>, IMatchmakingCallbacks
{
	private readonly LoadBalancingClient client; //Field offset: 0x28

	public MatchMakingCallbacksContainer(LoadBalancingClient client) { }

	public override void OnCreatedRoom() { }

	public override void OnCreateRoomFailed(short returnCode, string message) { }

	public override void OnFriendListUpdate(List<FriendInfo> friendList) { }

	public override void OnJoinedRoom() { }

	public override void OnJoinRandomFailed(short returnCode, string message) { }

	public override void OnJoinRoomFailed(short returnCode, string message) { }

	public override void OnLeftRoom() { }

}

