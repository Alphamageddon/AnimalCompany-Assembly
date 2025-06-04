namespace AnimalCompany;

public class NetworkManager : MonoBehaviour, INetworkRunnerCallbacks
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public NetworkRunner runner; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal int <OnConnectedToServer>b__0(PlayerRef p) { }

		internal string <OnConnectedToServer>b__1(PlayerRef p) { }

	}

	[CompilerGenerated]
	private sealed class <CreateSessionCommand>d__25 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public NetworkManager <>4__this; //Field offset: 0x20

		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <CreateSessionCommand>d__25(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static Byte[] _connectionToken; //Field offset: 0x0
	private static int _cachedTokenHash; //Field offset: 0x8
	public static Action<NetworkRunner> onConnected; //Field offset: 0x10
	public static Action<NetworkInput> onInput; //Field offset: 0x18
	public static Action<PlayerRef> onPlayerJoined; //Field offset: 0x20
	public static Action<PlayerRef> onPlayerLeft; //Field offset: 0x28
	public static Action<PlayerRef> onMasterClientSwitched; //Field offset: 0x30
	private static NetworkManager _instance; //Field offset: 0x38
	public bool singlePlayer; //Field offset: 0x20
	public string customSessionCode; //Field offset: 0x28
	public bool pvpEnabled; //Field offset: 0x30
	[SerializeField]
	private GameObject _sessionManagerPrefab; //Field offset: 0x38
	private NetworkSessionManager _currSessionManager; //Field offset: 0x40
	private CommandHandle _autoJoinCommandHandle; //Field offset: 0x48
	private float _nextAutoJoinDelay; //Field offset: 0x50

	public NetworkRunner currentRunner
	{
		 get { } //Length: 128
	}

	public static NetworkManager instance
	{
		 get { } //Length: 72
	}

	public NetworkManager() { }

	private void AutoJoin() { }

	private void Awake() { }

	private string CreateNewSessionCode() { }

	[IteratorStateMachine(typeof(<CreateSessionCommand>d__25))]
	private IEnumerator<Command> CreateSessionCommand() { }

	public bool CustomCodeEntered(string code, SessionProperties properties) { }

	public NetworkRunner get_currentRunner() { }

	public static NetworkManager get_instance() { }

	public static int GetPlayerToken(NetworkRunner runner, PlayerRef player) { }

	private void HandleAppStartupComplete(StateChangedEventArgs args) { }

	private void HandleShutdown(NetworkRunner runner, bool restart) { }

	private void HandleTargetRoomChanged(StateChangedEventArgs args) { }

	public static int HashToken(Byte[] token) { }

	public static Byte[] NewToken() { }

	public override void OnConnectedToServer(NetworkRunner runner) { }

	public override void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason) { }

	public override void OnConnectRequest(NetworkRunner runner, ConnectRequest request, Byte[] token) { }

	public override void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<String, Object> data) { }

	private void OnDestroy() { }

	public override void OnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason) { }

	public override void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken) { }

	private void OnHostMigrationResumed(NetworkRunner runner) { }

	public override void OnInput(NetworkRunner runner, NetworkInput input) { }

	public override void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input) { }

	public override void OnObjectEnterAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player) { }

	public override void OnObjectExitAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player) { }

	public override void OnPlayerJoined(NetworkRunner runner, PlayerRef player) { }

	public override void OnPlayerLeft(NetworkRunner runner, PlayerRef player) { }

	public override void OnReliableDataProgress(NetworkRunner runner, PlayerRef player, ReliableKey key, float progress) { }

	public override void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ReliableKey key, ArraySegment<Byte> data) { }

	public override void OnSceneLoadDone(NetworkRunner runner) { }

	public override void OnSceneLoadStart(NetworkRunner runner) { }

	public override void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList) { }

	public override void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason) { }

	public override void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message) { }

	public static string TokenToString(Byte[] token) { }

}

