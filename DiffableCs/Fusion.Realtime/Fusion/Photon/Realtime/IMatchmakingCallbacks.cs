namespace Fusion.Photon.Realtime;

internal interface IMatchmakingCallbacks
{

	public void OnCreatedRoom() { }

	public void OnCreateRoomFailed(short returnCode, string message) { }

	public void OnFriendListUpdate(List<FriendInfo> friendList) { }

	public void OnJoinedRoom() { }

	public void OnJoinRandomFailed(short returnCode, string message) { }

	public void OnJoinRoomFailed(short returnCode, string message) { }

	public void OnLeftRoom() { }

}

