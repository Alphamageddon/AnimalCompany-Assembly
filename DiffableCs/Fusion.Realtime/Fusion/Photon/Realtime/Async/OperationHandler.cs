namespace Fusion.Photon.Realtime.Async;

internal class OperationHandler : IConnectionCallbacks, IMatchmakingCallbacks, ILobbyCallbacks
{
	private const float OPERATION_TIMEOUT_SEC = 30; //Field offset: 0x0
	public PhotonConnectionCallbacks ConnectionCallbacks; //Field offset: 0x10
	public PhotonMatchmakingCallbacks MatchmakingCallbacks; //Field offset: 0x18
	public PhotonLobbyCallbacks LobbyCallbacks; //Field offset: 0x20
	private bool _throwOnErrors; //Field offset: 0x28
	private TaskCompletionSource<Int16> _result; //Field offset: 0x30
	private CancellationTokenSource _cancellation; //Field offset: 0x38

	public TaskCompletionSource<Int16> CompletionSource
	{
		 get { } //Length: 8
	}

	public bool IsCancellationRequested
	{
		 get { } //Length: 28
	}

	public Task<Int16> Task
	{
		 get { } //Length: 72
	}

	public CancellationToken Token
	{
		 get { } //Length: 28
	}

	public OperationHandler(bool throwOnErrors = true, CancellationToken externalCancellationToken = null) { }

	private void Cancel() { }

	private void Expire() { }

	public TaskCompletionSource<Int16> get_CompletionSource() { }

	public bool get_IsCancellationRequested() { }

	public Task<Int16> get_Task() { }

	public CancellationToken get_Token() { }

	public override void OnConnected() { }

	public override void OnConnectedToMaster() { }

	public override void OnCreatedRoom() { }

	public override void OnCreateRoomFailed(short returnCode, string message) { }

	public override void OnCustomAuthenticationFailed(string debugMessage) { }

	public override void OnCustomAuthenticationResponse(Dictionary<String, Object> data) { }

	public override void OnDisconnected(DisconnectCause cause) { }

	public override void OnFriendListUpdate(List<FriendInfo> friendList) { }

	public override void OnJoinedLobby() { }

	public override void OnJoinedRoom() { }

	public override void OnJoinRandomFailed(short returnCode, string message) { }

	public override void OnJoinRoomFailed(short returnCode, string message) { }

	public override void OnLeftLobby() { }

	public override void OnLeftRoom() { }

	public override void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) { }

	public override void OnRegionListReceived(RegionHandler regionHandler) { }

	public override void OnRoomListUpdate(List<RoomInfo> roomList) { }

	public void SetException(Exception e) { }

	public void SetResult(short result) { }

}

