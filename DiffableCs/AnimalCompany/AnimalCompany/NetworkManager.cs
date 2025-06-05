namespace AnimalCompany;

public class NetworkManager : SimulationBehaviour, INetworkRunnerCallbacks
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public NetworkObject resumeNO; //Field offset: 0x10

		public <>c__DisplayClass49_0() { }

		internal void <OnHostMigrationResumed>b__0(NetworkRunner runner, NetworkObject newNO) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public int playerToken; //Field offset: 0x10

		public <>c__DisplayClass63_0() { }

		internal void <OnPlayerJoined>b__0(NetworkRunner runner, NetworkObject obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_1
	{
		public int playerToken; //Field offset: 0x10

		public <>c__DisplayClass63_1() { }

		internal void <OnPlayerJoined>b__1(NetworkRunner runner, NetworkObject obj) { }

	}

	[CompilerGenerated]
	private sealed class <JoinLobby>d__47 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NetworkManager <>4__this; //Field offset: 0x20
		public GameMode mode; //Field offset: 0x28
		public HostMigrationToken hostMigrationToken; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <JoinLobby>d__47(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <OnHostMigration>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public NetworkRunner runner; //Field offset: 0x28
		public NetworkManager <>4__this; //Field offset: 0x30
		public HostMigrationToken hostMigrationToken; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartGame>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string sessionCode; //Field offset: 0x28
		public NetworkManager <>4__this; //Field offset: 0x30
		public GameMode mode; //Field offset: 0x38
		public HostMigrationToken hostMigrationToken; //Field offset: 0x40
		private SceneRef <scene>5__2; //Field offset: 0x48
		private TaskAwaiter<StartGameResult> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static Byte[] _connectionToken; //Field offset: 0x0
	private const int NET_COMPATIBILITY_VERSION = 4; //Field offset: 0x0
	private const int MAX_TOTAL_PLAYERS_PUBLIC_SESSION = 200; //Field offset: 0x0
	private const int NET_SCENE_INDEX = 4; //Field offset: 0x0
	private const float CLEANUP_TIMEOUT = 10000; //Field offset: 0x0
	private static int _cachedTokenHash; //Field offset: 0x8
	public static Action<NetworkRunner> onConnected; //Field offset: 0x10
	public static Action<NetworkRunner> onSetupRunner; //Field offset: 0x18
	public static Action<NetworkInput> onInput; //Field offset: 0x20
	public static Action<PlayerRef> onPlayerJoined; //Field offset: 0x28
	public static Action<PlayerRef> onPlayerLeft; //Field offset: 0x30
	public static Action<PlayerRef> onMasterClientSwitched; //Field offset: 0x38
	private static NetworkManager _instance; //Field offset: 0x40
	[CompilerGenerated]
	private static bool <isVerified>k__BackingField; //Field offset: 0x48
	public bool singlePlayer; //Field offset: 0x48
	public bool createPrivateSession; //Field offset: 0x49
	public string customSessionCode; //Field offset: 0x50
	[SerializeField]
	private NetworkPrefabRef _playerPrefab; //Field offset: 0x58
	[SerializeField]
	private GameObject _runnerPrefab; //Field offset: 0x68
	[SerializeField]
	private Transform _spawnLocation; //Field offset: 0x70
	private Dictionary<PlayerRef, NetworkObject> _spawnedPlayers; //Field offset: 0x78
	private Dictionary<Int32, NetworkObject> _playersByToken; //Field offset: 0x80
	private List<Int32> _pendingPlayerTokenJoin; //Field offset: 0x88
	private GameObject _currRunnerGO; //Field offset: 0x90
	private NetworkRunner _currRunner; //Field offset: 0x98
	private FusionVoiceClient _voiceClient; //Field offset: 0xA0
	private Stopwatch _watch; //Field offset: 0xA8
	private NetworkSceneManagerDefault _sceneManager; //Field offset: 0xB0
	private SceneRef _loadedScene; //Field offset: 0xB8
	private PlayerRef _localPlayerRef; //Field offset: 0xBC
	private float _nextAutoJoinDelay; //Field offset: 0xC0

	public NetworkRunner currentRunner
	{
		 get { } //Length: 8
	}

	public static NetworkManager instance
	{
		 get { } //Length: 72
	}

	public static bool isVerified
	{
		[CompilerGenerated]
		 get { } //Length: 72
		[CompilerGenerated]
		 set { } //Length: 80
	}

	public static int LocalToken
	{
		 get { } //Length: 72
	}

	public NetworkManager() { }

	private void AutoJoin() { }

	private void Awake() { }

	private string CreateNewSessionCode() { }

	private void DespawnPlayerNetObject(NetworkRunner runner, NetworkObject playerNetObj) { }

	public virtual void FixedUpdateNetwork() { }

	public NetworkRunner get_currentRunner() { }

	public static NetworkManager get_instance() { }

	[CompilerGenerated]
	public static bool get_isVerified() { }

	public static int get_LocalToken() { }

	private int GetPlayerToken(NetworkRunner runner, PlayerRef player) { }

	private void HandleAppStartupComplete(StateChangedEventArgs args) { }

	private void HandleShutdown(bool restart) { }

	public static int HashToken(Byte[] token) { }

	[IteratorStateMachine(typeof(<JoinLobby>d__47))]
	private IEnumerator JoinLobby(GameMode mode, HostMigrationToken hostMigrationToken = null) { }

	public bool JoinWithSessionCode(string code) { }

	public static Byte[] NewToken() { }

	public override void OnConnectedToServer(NetworkRunner runner) { }

	public override void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason) { }

	public override void OnConnectRequest(NetworkRunner runner, ConnectRequest request, Byte[] token) { }

	public override void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<String, Object> data) { }

	private void OnDestroy() { }

	public override void OnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason) { }

	[AsyncStateMachine(typeof(<OnHostMigration>d__58))]
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

	[CompilerGenerated]
	public static void set_isVerified(bool value) { }

	private void SetupRunner() { }

	[AsyncStateMachine(typeof(<StartGame>d__48))]
	private void StartGame(GameMode mode, HostMigrationToken hostMigrationToken = null, string sessionCode = null) { }

	[ContextMenu("Join With Custom Session Code")]
	public void TestJoinWithSessionCode() { }

	public static string TokenToString(Byte[] token) { }

}

