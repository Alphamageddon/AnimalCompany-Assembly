namespace Fusion.Photon.Realtime.Async;

internal class PhotonMatchmakingCallbacks
{
	public Action<List`1<FriendInfo>> FriendListUpdate; //Field offset: 0x10
	public Action JoinedRoom; //Field offset: 0x18
	public Action CreatedRoom; //Field offset: 0x20
	public Action<Int16, String> JoinRoomFailed; //Field offset: 0x28
	public Action<Int16, String> JoinRoomRandomFailed; //Field offset: 0x30
	public Action<Int16, String> CreateRoomFailed; //Field offset: 0x38
	public Action LeftRoom; //Field offset: 0x40

	public PhotonMatchmakingCallbacks() { }

}

