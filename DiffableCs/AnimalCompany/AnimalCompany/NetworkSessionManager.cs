namespace AnimalCompany;

public class NetworkSessionManager : SimulationBehaviour, INetworkRunnerCallbacks
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		private struct <<ShutdownCommand>g__Shutdown|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass15_0 <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public NetworkSessionManager <>4__this; //Field offset: 0x10
		public bool isFinishedShuttingDown; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal bool <ShutdownCommand>b__1(float elapsed) { }

		[AsyncStateMachine(typeof(<<ShutdownCommand>g__Shutdown|0>d))]
		internal void <ShutdownCommand>g__Shutdown|0() { }

	}

	[CompilerGenerated]
	private sealed class <ShutdownCommand>d__15 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public NetworkSessionManager <>4__this; //Field offset: 0x20
		private <>c__DisplayClass15_0 <>8__1; //Field offset: 0x28

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
		public <ShutdownCommand>d__15(int <>1__state) { }

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

	private const int NET_SCENE_INDEX = 4; //Field offset: 0x0
	private const int MAX_TOTAL_PLAYERS_PUBLIC_SESSION = 200; //Field offset: 0x0
	[SerializeField]
	private NetworkPrefabRef _playerPrefab; //Field offset: 0x48
	private NetworkRunner _netRunner; //Field offset: 0x58
	private FusionVoiceClient _voiceClient; //Field offset: 0x60
	private NetworkSceneManagerDefault _sceneManager; //Field offset: 0x68
	private Byte[] _localPlayerConnectionToken; //Field offset: 0x70
	private CommandHandle _connectCommandHandle; //Field offset: 0x78
	private ConnectToSessionCommand _connectCommand; //Field offset: 0x80

	public NetworkRunner NetRunner
	{
		 get { } //Length: 8
	}

	public NetworkSessionManager() { }

	private void Awake() { }

	public Command Connect(string sessionCode, SessionProperties properties) { }

	public virtual void FixedUpdateNetwork() { }

	public NetworkRunner get_NetRunner() { }

	public override void OnConnectedToServer(NetworkRunner runner) { }

	public override void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason) { }

	public override void OnConnectRequest(NetworkRunner runner, ConnectRequest request, Byte[] token) { }

	public override void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<String, Object> data) { }

	public override void OnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason) { }

	public override void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken) { }

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

	public void Setup(Byte[] connectionToken) { }

	public Command Shutdown() { }

	[IteratorStateMachine(typeof(<ShutdownCommand>d__15))]
	private IEnumerator<Command> ShutdownCommand() { }

}

