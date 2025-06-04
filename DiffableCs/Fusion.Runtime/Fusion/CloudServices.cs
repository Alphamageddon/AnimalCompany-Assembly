namespace Fusion;

internal class CloudServices : IConnectionCallbacks, IMatchmakingCallbacks, ILobbyCallbacks, IDisposable
{
	[CompilerGenerated]
	private struct <<HandleReflexiveInfoMessage>b__94_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken token; //Field offset: 0x20
		public CloudServices <>4__this; //Field offset: 0x28
		private int <timeout>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<String> <>9__111_0; //Field offset: 0x8
		public static Action<String> <>9__111_1; //Field offset: 0x10
		public static Action<String> <>9__111_2; //Field offset: 0x18
		public static Action<Exception> <>9__111_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal void <InitRelayLogs>b__111_0(string info) { }

		internal void <InitRelayLogs>b__111_1(string warn) { }

		internal void <InitRelayLogs>b__111_2(string error) { }

		internal void <InitRelayLogs>b__111_3(Exception exn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass103_0
	{
		private struct <<Run_ReversePing>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public CancellationToken token; //Field offset: 0x20
			public <>c__DisplayClass103_0 <>4__this; //Field offset: 0x28
			private int <i>5__2; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public NetAddress remoteAddr; //Field offset: 0x10
		public CloudServices <>4__this; //Field offset: 0x28

		public <>c__DisplayClass103_0() { }

		[AsyncStateMachine(typeof(<<Run_ReversePing>b__0>d))]
		internal Task <Run_ReversePing>b__0(CancellationToken token) { }

		internal bool <Run_ReversePing>g__SendPing|1(NetAddress netAddress) { }

	}

	[CompilerGenerated]
	private struct <ConfirmJoin>d__98 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public CloudServices <>4__this; //Field offset: 0x20
		private Stopwatch <timer>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ConnectToCloud>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AppSettings appSettings; //Field offset: 0x20
		public CloudServices <>4__this; //Field offset: 0x28
		public AuthenticationValues authentication; //Field offset: 0x30
		public Nullable<Boolean> useDefaultCloudPorts; //Field offset: 0x38
		public CancellationToken externalCancellationToken; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DisconnectFromCloud>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CloudServices <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleReflexiveInfoMessage>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CloudServices <>4__this; //Field offset: 0x28
		public ReflexiveInfo reflexiveInfo; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleStartMessage>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CloudServices <>4__this; //Field offset: 0x28
		public Start start; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private CloudServicesMetadata <>7__wrap1; //Field offset: 0x40
		private ConfiguredTaskAwaiter<StunResult> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Join>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CloudServices <>4__this; //Field offset: 0x20
		public CancellationToken externalCancellationToken; //Field offset: 0x28
		private TaskAwaiter<Join> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <QueryReflexiveInfo>d__108 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StunResult> <>t__builder; //Field offset: 0x8
		public CloudServices <>4__this; //Field offset: 0x20
		private TaskAwaiter<StunResult> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Service_HostMigrationSnapshot>d__102 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public CloudServices <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static class ErrorMessages
	{
		public const string StartBeforeJoin = "Received Start Message, but never a Join Confirmation. Shutdown."; //Field offset: 0x0
		public const string RunnerFailInit = "Runner failed to Initialize. Shutdown."; //Field offset: 0x0
		public const string JoinTimeout = "Join Confirmation timeout. Shutdown."; //Field offset: 0x0

	}

	[CompilerGenerated]
	private bool <CloudServerDisconnected>k__BackingField; //Field offset: 0x10
	private bool _tryingToReconnect; //Field offset: 0x11
	[CompilerGenerated]
	private bool <IsNATPunchthroughEnabled>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	private string <CustomSTUNServer>k__BackingField; //Field offset: 0x18
	private readonly CloudServicesMetadata _metadata; //Field offset: 0x20
	private readonly NetworkRunner _runner; //Field offset: 0x28
	private CloudCommunicator _communicator; //Field offset: 0x30
	private readonly Dictionary<String, SessionInfo> _cachedSessionList; //Field offset: 0x38
	private AsyncOperationHandler<Join> _joinAsyncHandler; //Field offset: 0x40
	private Byte[] _dummyData; //Field offset: 0x48
	private CancellationTokenSource _dummyTrafficCts; //Field offset: 0x50
	private CancellationTokenSource _dummyTrafficLinkCts; //Field offset: 0x58

	public AuthenticationValues AuthenticationValues
	{
		 get { } //Length: 84
	}

	public string CachedRegionSummary
	{
		 get { } //Length: 36
	}

	public private bool CloudServerDisconnected
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public ICommunicator Communicator
	{
		 get { } //Length: 8
	}

	public JoinProcessStage CurrentJoinStage
	{
		 get { } //Length: 28
	}

	public ProtocolMessageVersion CurrentProtocolMessageVersion
	{
		 get { } //Length: 28
	}

	public internal string CustomSTUNServer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public bool IsCloudReady
	{
		 get { } //Length: 32
	}

	public bool IsEncryptionEnabled
	{
		 get { } //Length: 80
	}

	public bool IsInLobby
	{
		 get { } //Length: 80
	}

	public bool IsInRoom
	{
		 get { } //Length: 80
	}

	public bool IsMasterClient
	{
		 get { } //Length: 68
	}

	public internal bool IsNATPunchthroughEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	private bool IsServerOrMasterClient
	{
		private get { } //Length: 164
	}

	public PlayerRef LocalPlayerRef
	{
		 get { } //Length: 168
	}

	public NATType NATType
	{
		 get { } //Length: 32
	}

	public int SessionSlots
	{
		 get { } //Length: 68
	}

	public string UserId
	{
		 get { } //Length: 80
	}

	public CloudServices(NetworkRunner runner, FusionAppSettings customAppSettings, CloudCommunicator communicator = null) { }

	[AsyncStateMachine(typeof(<<HandleReflexiveInfoMessage>b__94_0>d))]
	[CompilerGenerated]
	private Task <HandleReflexiveInfoMessage>b__94_0(CancellationToken token) { }

	[CompilerGenerated]
	private bool <QueryReflexiveInfo>g__KeepRunning|108_0() { }

	[CompilerGenerated]
	private bool <QueryReflexiveInfo>g__SendAnyData|108_1(Byte[] requestBytes, NetAddress target) { }

	[CompilerGenerated]
	private Task<Boolean> <SetupDummyTraffic>b__107_0() { }

	[CompilerGenerated]
	private void <SetupDummyTraffic>g__SendDummyTraffic|107_1(Byte[] buffer) { }

	private bool CheckSubnet(NetAddress remotePrivateEndPoint) { }

	[AsyncStateMachine(typeof(<ConfirmJoin>d__98))]
	private Task<Boolean> ConfirmJoin() { }

	private void Connect(NATPunchStage punchStage, NetAddress endPoint) { }

	[AsyncStateMachine(typeof(<ConnectToCloud>d__69))]
	public Task ConnectToCloud(AppSettings appSettings, AuthenticationValues authentication = null, CancellationToken externalCancellationToken = null, Nullable<Boolean> useDefaultCloudPorts = null) { }

	[AsyncStateMachine(typeof(<DisconnectFromCloud>d__72))]
	public Task DisconnectFromCloud() { }

	public override void Dispose() { }

	public Task<Int16> EnterRoom(StartGameArgs args, CancellationToken externalCancellationToken = null) { }

	public CloudCommunicator ExtractCommunicator() { }

	public AuthenticationValues get_AuthenticationValues() { }

	public string get_CachedRegionSummary() { }

	[CompilerGenerated]
	public bool get_CloudServerDisconnected() { }

	public ICommunicator get_Communicator() { }

	public JoinProcessStage get_CurrentJoinStage() { }

	public ProtocolMessageVersion get_CurrentProtocolMessageVersion() { }

	[CompilerGenerated]
	public string get_CustomSTUNServer() { }

	public bool get_IsCloudReady() { }

	public bool get_IsEncryptionEnabled() { }

	public bool get_IsInLobby() { }

	public bool get_IsInRoom() { }

	public bool get_IsMasterClient() { }

	[CompilerGenerated]
	public bool get_IsNATPunchthroughEnabled() { }

	private bool get_IsServerOrMasterClient() { }

	public PlayerRef get_LocalPlayerRef() { }

	public NATType get_NATType() { }

	public int get_SessionSlots() { }

	public string get_UserId() { }

	public string GetActorUserID(int actorID) { }

	private void HandleDisconnectMessage(int sender, Disconnect disconnect) { }

	private void HandleDummyTrafficSync(int sender, DummyTrafficSync dummyTrafficSync) { }

	private void HandleHostMigrationMessage(int sender, HostMigration hostMigration) { }

	private void HandleJoinMessage(int sender, Join join) { }

	private void HandleNetworkConfigMessage(int sender, NetworkConfigSync configSync) { }

	private bool HandlePhotonCloudDisconnect(ShutdownReason shutdownReason) { }

	private void HandlePlayerRefMapping(int sender, PlayerRefMapping msg) { }

	[AsyncStateMachine(typeof(<HandleReflexiveInfoMessage>d__94))]
	private void HandleReflexiveInfoMessage(int sender, ReflexiveInfo reflexiveInfo) { }

	private void HandleSnapshotMessage(int sender, Snapshot snapshot) { }

	[AsyncStateMachine(typeof(<HandleStartMessage>d__91))]
	private void HandleStartMessage(int sender, Start start) { }

	private void InitRelayLogs() { }

	[AsyncStateMachine(typeof(<Join>d__85))]
	internal Task Join(CancellationToken externalCancellationToken = null) { }

	public Task<Int16> JoinSessionLobby(SessionLobby sessionLobby, string lobbyID = null, LobbyType lobbyType = 0) { }

	public override void OnConnected() { }

	public override void OnConnectedToMaster() { }

	public override void OnCreatedRoom() { }

	public override void OnCreateRoomFailed(short returnCode, string message) { }

	public override void OnCustomAuthenticationFailed(string debugMessage) { }

	public override void OnCustomAuthenticationResponse(Dictionary<String, Object> data) { }

	public override void OnDisconnected(DisconnectCause cause) { }

	public override void OnFriendListUpdate(List<FriendInfo> friendList) { }

	internal void OnInternalConnectionAttempt(int attempt, int totalConnectionAttempts, out bool shouldChange, out NetAddress newAddress) { }

	public override void OnJoinedLobby() { }

	public override void OnJoinedRoom() { }

	public override void OnJoinRandomFailed(short returnCode, string message) { }

	public override void OnJoinRoomFailed(short returnCode, string message) { }

	public override void OnLeftLobby() { }

	public override void OnLeftRoom() { }

	public override void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) { }

	public override void OnRegionListReceived(RegionHandler regionHandler) { }

	internal void OnRoomChanged() { }

	private void OnRoomListChanged(List<RoomInfo> roomList) { }

	public override void OnRoomListUpdate(List<RoomInfo> roomList) { }

	private void OperationFailHandler(short returnCode, string message) { }

	[AsyncStateMachine(typeof(<QueryReflexiveInfo>d__108))]
	private Task<StunResult> QueryReflexiveInfo() { }

	private void Run_ReversePing(NetAddress remoteAddr) { }

	public void SendChangeMasterClient(int newCandidate) { }

	private void SendNetworkSyncMessage(NetworkProjectConfig projectConfig) { }

	private void SendReflexiveInfo(StunResult stunResult) { }

	public void SendStateSnapshot(Byte[] data, int snapshotSize, int tick, uint lastId) { }

	[AsyncStateMachine(typeof(<Service_HostMigrationSnapshot>d__102))]
	private Task<Boolean> Service_HostMigrationSnapshot() { }

	private Task<Boolean> Service_KeepAlive() { }

	[CompilerGenerated]
	private void set_CloudServerDisconnected(bool value) { }

	[CompilerGenerated]
	internal void set_CustomSTUNServer(string value) { }

	[CompilerGenerated]
	internal void set_IsNATPunchthroughEnabled(bool value) { }

	private void SetupDummyTraffic(DummyTrafficSync dummyTrafficSyncMessage) { }

	internal void StartBackgroundCloudServices() { }

	public bool TryGetActorIdByUniqueId(long uniqueId, out int actorId) { }

	public void Update() { }

	public void UpdateInitializeArgs(NetworkRunnerInitializeArgs newArgs) { }

	internal bool UpdateRoomIsOpen(bool status) { }

	internal bool UpdateRoomIsVisible(bool status) { }

	internal bool UpdateRoomProperties(Dictionary<String, SessionProperty> customProperties) { }

	private void UpdateSessionInfo(SessionInfo sessionInfo, RoomInfo roomInfo, string region) { }

}

