namespace Fusion.Photon.Realtime;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
internal class SupportLogger : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, IInRoomCallbacks, ILobbyCallbacks, IErrorInfoCallback
{
	public bool LogTrafficStats; //Field offset: 0x20
	private LoadBalancingClient client; //Field offset: 0x28
	private Stopwatch startStopwatch; //Field offset: 0x30
	private bool initialOnApplicationPauseSkipped; //Field offset: 0x38
	private int pingMax; //Field offset: 0x3C
	private int pingMin; //Field offset: 0x40

	public LoadBalancingClient Client
	{
		 get { } //Length: 8
		 set { } //Length: 88
	}

	public SupportLogger() { }

	public LoadBalancingClient get_Client() { }

	private string GetFormattedTimestamp() { }

	private void LogBasics() { }

	public void LogStats() { }

	protected void OnApplicationPause(bool pause) { }

	protected void OnApplicationQuit() { }

	public override void OnConnected() { }

	public override void OnConnectedToMaster() { }

	public override void OnCreatedRoom() { }

	public override void OnCreateRoomFailed(short returnCode, string message) { }

	public override void OnCustomAuthenticationFailed(string debugMessage) { }

	public override void OnCustomAuthenticationResponse(Dictionary<String, Object> data) { }

	protected void OnDestroy() { }

	public override void OnDisconnected(DisconnectCause cause) { }

	public override void OnErrorInfo(ErrorInfo errorInfo) { }

	public override void OnFriendListUpdate(List<FriendInfo> friendList) { }

	public override void OnJoinedLobby() { }

	public override void OnJoinedRoom() { }

	public override void OnJoinRandomFailed(short returnCode, string message) { }

	public override void OnJoinRoomFailed(short returnCode, string message) { }

	public override void OnLeftLobby() { }

	public override void OnLeftRoom() { }

	public override void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) { }

	public override void OnMasterClientSwitched(Player newMasterClient) { }

	public override void OnPlayerEnteredRoom(Player newPlayer) { }

	public override void OnPlayerLeftRoom(Player otherPlayer) { }

	public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps) { }

	public override void OnRegionListReceived(RegionHandler regionHandler) { }

	public override void OnRoomListUpdate(List<RoomInfo> roomList) { }

	public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) { }

	public void set_Client(LoadBalancingClient value) { }

	protected void Start() { }

	public void StartLogStats() { }

	private void StartTrackValues() { }

	public void StopLogStats() { }

	private void StopTrackValues() { }

	private void TrackValues() { }

}

