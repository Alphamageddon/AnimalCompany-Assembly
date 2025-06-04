namespace Photon.Voice.Fusion;

[AddComponentMenu("Photon Voice/Fusion/Fusion Voice Client")]
[RequireComponent(typeof(NetworkRunner))]
public class FusionVoiceClient : VoiceFollowClient, INetworkRunnerCallbacks
{
	private const byte FusionNetworkIdTypeCode = 0; //Field offset: 0x0
	private static Byte[] memCompressedUInt64; //Field offset: 0x0
	private NetworkRunner networkRunner; //Field offset: 0xC8
	private EnterRoomParams voiceRoomParams; //Field offset: 0xD0
	private bool voiceFollowClientStarted; //Field offset: 0xD8
	[SerializeField]
	public bool UseFusionAppSettings; //Field offset: 0xD9
	[SerializeField]
	public bool UseFusionAuthValues; //Field offset: 0xDA
	private string fusionOfflineVoiceRoomName; //Field offset: 0xE0

	private string FusionOfflineVoiceRoomName
	{
		private get { } //Length: 148
	}

	protected virtual bool LeaderInRoom
	{
		 get { } //Length: 36
	}

	protected virtual bool LeaderOfflineMode
	{
		 get { } //Length: 36
	}

	private static FusionVoiceClient() { }

	public FusionVoiceClient() { }

	protected virtual void Awake() { }

	protected virtual bool ConnectVoice() { }

	private static object DeserializeFusionNetworkId(StreamBuffer instream, short length) { }

	private override void Fusion.INetworkRunnerCallbacks.OnConnectedToServer(NetworkRunner runner) { }

	private override void Fusion.INetworkRunnerCallbacks.OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason) { }

	private override void Fusion.INetworkRunnerCallbacks.OnConnectRequest(NetworkRunner runner, ConnectRequest request, Byte[] token) { }

	private override void Fusion.INetworkRunnerCallbacks.OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<String, Object> data) { }

	private override void Fusion.INetworkRunnerCallbacks.OnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason) { }

	private override void Fusion.INetworkRunnerCallbacks.OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken) { }

	private override void Fusion.INetworkRunnerCallbacks.OnInput(NetworkRunner runner, NetworkInput input) { }

	private override void Fusion.INetworkRunnerCallbacks.OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input) { }

	private override void Fusion.INetworkRunnerCallbacks.OnPlayerJoined(NetworkRunner runner, PlayerRef player) { }

	private override void Fusion.INetworkRunnerCallbacks.OnPlayerLeft(NetworkRunner runner, PlayerRef player) { }

	private override void Fusion.INetworkRunnerCallbacks.OnReliableDataProgress(NetworkRunner runner, PlayerRef player, ReliableKey reliableKey, float progress) { }

	private override void Fusion.INetworkRunnerCallbacks.OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ReliableKey reliableKey, ArraySegment<Byte> data) { }

	private override void Fusion.INetworkRunnerCallbacks.OnSceneLoadDone(NetworkRunner runner) { }

	private override void Fusion.INetworkRunnerCallbacks.OnSceneLoadStart(NetworkRunner runner) { }

	private override void Fusion.INetworkRunnerCallbacks.OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList) { }

	private override void Fusion.INetworkRunnerCallbacks.OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason) { }

	private override void Fusion.INetworkRunnerCallbacks.OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message) { }

	private string get_FusionOfflineVoiceRoomName() { }

	protected virtual bool get_LeaderInRoom() { }

	protected virtual bool get_LeaderOfflineMode() { }

	protected virtual string GetVoiceRoomName() { }

	protected virtual Speaker InstantiateSpeakerForRemoteVoice(int playerId, byte voiceId, object userData) { }

	protected virtual void OnDestroy() { }

	public override void OnObjectEnterAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player) { }

	public override void OnObjectExitAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player) { }

	private static ulong ReadCompressedUInt64(StreamBuffer stream) { }

	private static short SerializeFusionNetworkId(StreamBuffer outstream, object customobject) { }

	protected virtual void Start() { }

	private void VoiceFollowClientStart() { }

	private static void VoiceRegisterCustomTypes() { }

	private static int WriteCompressedUInt64(StreamBuffer stream, ulong value) { }

}

