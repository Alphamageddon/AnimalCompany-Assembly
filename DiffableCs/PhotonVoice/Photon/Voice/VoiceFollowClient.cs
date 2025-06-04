namespace Photon.Voice;

public abstract class VoiceFollowClient : VoiceConnection
{
	public bool AutoConnectAndJoin; //Field offset: 0xC4
	private bool manualDisconnect; //Field offset: 0xC5
	private bool errAuthOrJoin; //Field offset: 0xC6

	protected abstract bool LeaderInRoom
	{
		 get { } //Length: 0
	}

	protected abstract bool LeaderOfflineMode
	{
		 get { } //Length: 0
	}

	protected VoiceFollowClient() { }

	public bool ConnectAndJoinRoom() { }

	private void ConnectOrJoinVoice() { }

	protected abstract bool ConnectVoice() { }

	public void Disconnect() { }

	private void FollowLeader(ClientState toState) { }

	private void FollowLeader() { }

	protected abstract bool get_LeaderInRoom() { }

	protected abstract bool get_LeaderOfflineMode() { }

	protected abstract string GetVoiceRoomName() { }

	protected override bool JoinVoiceRoom(string voiceRoomName) { }

	protected void LeaderStateChanged(ClientState toState) { }

	protected virtual void OnDestroy() { }

	protected virtual void OnOperationResponseReceived(OperationResponse operationResponse) { }

	protected virtual void OnVoiceStateChanged(ClientState fromState, ClientState toState) { }

	protected override void Start() { }

}

