namespace Photon.Voice.Unity.UtilityScripts;

[RequireComponent(typeof(VoiceConnection))]
public class ConnectAndJoin : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks
{
	private VoiceConnection voiceConnection; //Field offset: 0x20
	public bool RandomRoom; //Field offset: 0x28
	[SerializeField]
	private bool autoConnect; //Field offset: 0x29
	[SerializeField]
	private bool publishUserId; //Field offset: 0x2A
	public string RoomName; //Field offset: 0x30
	private readonly EnterRoomParams enterRoomParams; //Field offset: 0x38

	public bool IsConnected
	{
		 get { } //Length: 144
	}

	public ConnectAndJoin() { }

	public void ConnectNow() { }

	public bool get_IsConnected() { }

	public override void OnConnected() { }

	public override void OnConnectedToMaster() { }

	public override void OnCreatedRoom() { }

	public override void OnCreateRoomFailed(short returnCode, string message) { }

	public override void OnCustomAuthenticationFailed(string debugMessage) { }

	public override void OnCustomAuthenticationResponse(Dictionary<String, Object> data) { }

	private void OnDestroy() { }

	public override void OnDisconnected(DisconnectCause cause) { }

	public override void OnFriendListUpdate(List<FriendInfo> friendList) { }

	public override void OnJoinedRoom() { }

	public override void OnJoinRandomFailed(short returnCode, string message) { }

	public override void OnJoinRoomFailed(short returnCode, string message) { }

	public override void OnLeftRoom() { }

	public override void OnRegionListReceived(RegionHandler regionHandler) { }

	private void Start() { }

}

