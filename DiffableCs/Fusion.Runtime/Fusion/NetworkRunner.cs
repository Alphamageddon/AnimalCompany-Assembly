namespace Fusion;

[AddComponentMenu("Fusion/Network Runner")]
[DisallowMultipleComponent]
[HelpURL("https://doc.photonengine.com/fusion/current/manual/prebuilt-components#networkrunner")]
[ScriptHelp(BackColor = ScriptHeaderBackColor::Red (3))]
public sealed class NetworkRunner : Behaviour, ICallbacks
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<NetworkObject, Boolean> <>9__226_0; //Field offset: 0x8
		public static Func<NetworkRunner, Boolean> <>9__273_0; //Field offset: 0x10
		public static Func<Byte[], Int32> <>9__361_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <Fusion.Simulation.ICallbacks.OnReliableData>b__361_0(Byte[] x) { }

		internal bool <RegisterSceneObjects>b__226_0(NetworkObject o) { }

		internal bool <RestoreMultiPeerDefaultPhysics>b__273_0(NetworkRunner r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass140_0
	{
		public bool destroyGameObject; //Field offset: 0x10
		public NetworkRunner <>4__this; //Field offset: 0x18
		public ShutdownReason shutdownReason; //Field offset: 0x20

		public <>c__DisplayClass140_0() { }

		internal Task <Shutdown>b__2(CancellationToken token) { }

		internal Task <Shutdown>g__ContinueTasksWithDestroy|0(Task[] precedingTasks) { }

		internal void <Shutdown>g__InvokeOnShutdownCallbacks|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass301_0
	{
		public NetworkRunner <>4__this; //Field offset: 0x10
		public NetworkLoadSceneParameters sceneParameters; //Field offset: 0x18

		public <>c__DisplayClass301_0() { }

		internal NetworkSceneAsyncOp <LoadScene>b__0(SceneRef x) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass370_0
	{
		public NetworkRunner <>4__this; //Field offset: 0x0
		public NetworkObjectSpawnDelegate spawnedCallback; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass370_1
	{
		public AsyncOpData asyncOp; //Field offset: 0x10

		public <>c__DisplayClass370_1() { }

		internal void <SpawnInternal>b__4(NetworkSpawnOp op) { }

	}

	[CompilerGenerated]
	private struct <DisconnectFromCloud>d__425 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NetworkRunner <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <GetResumeSnapshotNetworkObjects>d__3 : IEnumerable<NetworkObject>, IEnumerable, IEnumerator<NetworkObject>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private NetworkObject <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public NetworkRunner <>4__this; //Field offset: 0x28
		private Dictionary<NetworkId, NetworkObjectHeaderPtr> <headerMapping>5__2; //Field offset: 0x30
		private Dictionary<NetworkId, List`1<NetworkId>> <nestedMapping>5__3; //Field offset: 0x38
		private Enumerator<NetworkId, NetworkObjectHeaderPtr> <>7__wrap3; //Field offset: 0x40
		private NetworkObject <resumeObj>5__5; //Field offset: 0x58

		private override NetworkObject System.Collections.Generic.IEnumerator<Fusion.NetworkObject>.Current
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
		public <GetResumeSnapshotNetworkObjects>d__3(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<NetworkObject> System.Collections.Generic.IEnumerable<Fusion.NetworkObject>.GetEnumerator() { }

		[DebuggerHidden]
		private override NetworkObject System.Collections.Generic.IEnumerator<Fusion.NetworkObject>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetResumeSnapshotNetworkSceneObjects>d__4 : IEnumerable<ValueTuple`2<NetworkObject, NetworkObjectHeaderPtr>>, IEnumerable, IEnumerator<ValueTuple`2<NetworkObject, NetworkObjectHeaderPtr>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ValueTuple<NetworkObject, NetworkObjectHeaderPtr> <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		public NetworkRunner <>4__this; //Field offset: 0x30
		private Enumerator<NetworkId, NetworkObjectHeaderPtr> <>7__wrap1; //Field offset: 0x38

		private override ValueTuple<NetworkObject, NetworkObjectHeaderPtr> System.Collections.Generic.IEnumerator<System.ValueTuple<Fusion.NetworkObject,Fusion.NetworkObjectHeaderPtr>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 12
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 92
		}

		[DebuggerHidden]
		public <GetResumeSnapshotNetworkSceneObjects>d__4(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ValueTuple`2<NetworkObject, NetworkObjectHeaderPtr>> System.Collections.Generic.IEnumerable<System.ValueTuple<Fusion.NetworkObject,Fusion.NetworkObjectHeaderPtr>>.GetEnumerator() { }

		[DebuggerHidden]
		private override ValueTuple<NetworkObject, NetworkObjectHeaderPtr> System.Collections.Generic.IEnumerator<System.ValueTuple<Fusion.NetworkObject,Fusion.NetworkObjectHeaderPtr>>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <JoinSessionLobby>d__422 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StartGameResult> <>t__builder; //Field offset: 0x8
		public NetworkRunner <>4__this; //Field offset: 0x20
		public AuthenticationValues authentication; //Field offset: 0x28
		public FusionAppSettings customAppSettings; //Field offset: 0x30
		public Nullable<Boolean> useDefaultCloudPorts; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		public bool useCachedRegions; //Field offset: 0x48
		public SessionLobby sessionLobby; //Field offset: 0x4C
		public string lobbyID; //Field offset: 0x50
		private object <>7__wrap1; //Field offset: 0x58
		private int <>7__wrap2; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68
		private TaskAwaiter<Int16> <>u__2; //Field offset: 0x70
		private TaskAwaiter<StartGameResult> <>u__3; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PushHostMigrationSnapshot>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public NetworkRunner <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <RunHostMigrationResume>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NetworkRunner <>4__this; //Field offset: 0x20
		public NetworkRunnerInitializeArgs args; //Field offset: 0x28

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
		public <RunHostMigrationResume>d__11(int <>1__state) { }

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
	private struct <ShutdownAndBuildResult>d__428 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StartGameResult> <>t__builder; //Field offset: 0x8
		public Exception e; //Field offset: 0x20
		public NetworkRunner <>4__this; //Field offset: 0x28
		private StartGameResult <result>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartGameModeCloud>d__427 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StartGameResult> <>t__builder; //Field offset: 0x8
		public NetworkRunner <>4__this; //Field offset: 0x20
		public StartGameArgs args; //Field offset: 0x28
		private Nullable<SimulationModes> <simulationMode>5__2; //Field offset: 0x160
		private object <>7__wrap2; //Field offset: 0x168
		private int <>7__wrap3; //Field offset: 0x170
		private TaskAwaiter <>u__1; //Field offset: 0x178
		private TaskAwaiter<Int16> <>u__2; //Field offset: 0x180
		private TaskAwaiter<ShutdownReason> <>u__3; //Field offset: 0x188
		private TaskAwaiter<StartGameResult> <>u__4; //Field offset: 0x190

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartGameModeSinglePlayer>d__426 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StartGameResult> <>t__builder; //Field offset: 0x8
		public NetworkRunner <>4__this; //Field offset: 0x20
		public StartGameArgs args; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x160
		private TaskAwaiter<ShutdownReason> <>u__2; //Field offset: 0x168
		private TaskAwaiter<StartGameResult> <>u__3; //Field offset: 0x170

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Flags]
	private enum AttachOptions
	{
		LocalSpawn = 1,
	}

	internal enum BuildTypes
	{
		Debug = 0,
		Release = 1,
	}

	internal sealed class CloudConnectionLostHandler : MulticastDelegate
	{

		public CloudConnectionLostHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetworkRunner networkRunner, ShutdownReason shutdownReason, bool reconnecting, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NetworkRunner networkRunner, ShutdownReason shutdownReason, bool reconnecting) { }

	}

	private enum CreateInstanceResult
	{
		Success = 0,
		Failed = 1,
		InProgress = 2,
		Ignore = 3,
	}

	private struct DeferredShutdownParams
	{
		public bool ShutdownRequested; //Field offset: 0x0
		public ShutdownReason ShutdownReason; //Field offset: 0x4
		public bool DestroyGO; //Field offset: 0x8

	}

	internal sealed class ObjectDelegate : MulticastDelegate
	{

		public ObjectDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetworkRunner runner, NetworkObject obj, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NetworkRunner runner, NetworkObject obj) { }

	}

	internal sealed class OnBeforeSpawned : MulticastDelegate
	{

		public OnBeforeSpawned(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetworkRunner runner, NetworkObject obj, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NetworkRunner runner, NetworkObject obj) { }

	}

	[Flags]
	private enum ShutdownFlags
	{
		Regular = 1,
	}

	private enum SimulationPhase
	{
		None = 0,
		Update = 1,
		Render = 2,
	}

	[IsReadOnly]
	private struct SpawnArgs
	{
		public readonly NetworkObjectTypeId TypeId; //Field offset: 0x0
		public readonly Nullable<Vector3> Position; //Field offset: 0x8
		public readonly Nullable<Quaternion> Rotation; //Field offset: 0x18
		public readonly Nullable<PlayerRef> InputAuthority; //Field offset: 0x2C
		public readonly object OnBeforeSpawned; //Field offset: 0x38
		public readonly NetworkObjectSpawnDelegate Spawned; //Field offset: 0x40
		public readonly SpawnFlagsInternal SpawnFlags; //Field offset: 0x48
		public readonly NetworkObject ResumeNO; //Field offset: 0x50

		public bool DontDestroyOnLoad
		{
			 get { } //Length: 12
		}

		public Nullable<Boolean> MasterClientOverride
		{
			 get { } //Length: 108
		}

		public bool Synchronous
		{
			 get { } //Length: 12
		}

		public SpawnArgs(in SpawnArgs other, NetworkObjectSpawnDelegate del) { }

		public SpawnArgs(NetworkObjectTypeId typeId, Nullable<Vector3> position, Nullable<Quaternion> rotation, Nullable<PlayerRef> inputAuthority, object onBeforeSpawned, NetworkSpawnFlags flags, NetworkObjectSpawnDelegate spawned, bool synchronous, NetworkObject resumeNO) { }

		public bool get_DontDestroyOnLoad() { }

		public Nullable<Boolean> get_MasterClientOverride() { }

		public bool get_Synchronous() { }

		public virtual string ToString() { }

	}

	[Flags]
	private enum SpawnFlagsInternal
	{
		DontDestroyOnLoad = 1,
		SharedModeStateAuthMasterClient = 2,
		SharedModeStateAuthLocalPlayer = 4,
		Synchronous = 65536,
	}

	internal enum States
	{
		Starting = 1,
		Running = 2,
		Shutdown = 3,
	}

	private const int HostSnapshotTransferDataSize = 4096; //Field offset: 0x0
	private const bool DefaultSetActiveOnLoad = False; //Field offset: 0x0
	private static List<NetworkRunner> _instances; //Field offset: 0x0
	private static SimulationMode2D _defaultPhysicsSimMode2D; //Field offset: 0x8
	private static bool _defaultPhysicsAutoSimulation3D; //Field offset: 0xC
	private static bool _defaultPhysicsInitialized; //Field offset: 0xD
	public static CloudConnectionLostHandler CloudConnectionLost; //Field offset: 0x10
	private static string _cachedRegionSummary; //Field offset: 0x18
	private HostMigration _lastHostMigrationInfo; //Field offset: 0x20
	private Byte[] _hostSnapshotTempData; //Field offset: 0x28
	internal int LastSnapshotTick; //Field offset: 0x30
	internal int LastConfirmedSnapshotTick; //Field offset: 0x34
	[CompilerGenerated]
	private ObjectDelegate ObjectAcquired; //Field offset: 0x38
	private DeferredShutdownParams _deferredShutdownParams; //Field offset: 0x40
	internal Simulation _simulation; //Field offset: 0x50
	private SimulationPhase _simulationPhase; //Field offset: 0x58
	private ShutdownFlags _simulationShutdown; //Field offset: 0x5C
	private SimulationBehaviourUpdater _behaviourUpdater; //Field offset: 0x60
	private List<INetworkRunnerCallbacks> _callbacks; //Field offset: 0x68
	private List<NetworkId> _destroyIdsBuffer; //Field offset: 0x70
	private Queue<SpawnArgs> _spawnQueue; //Field offset: 0x78
	internal TaskCompletionSource<Boolean> _initializeOperation; //Field offset: 0x80
	internal bool OnGameStartedInvoked; //Field offset: 0x88
	private Queue<ISpawned> _spawnedSimBehaviourQueue; //Field offset: 0x90
	private NetworkProjectConfig _config; //Field offset: 0x98
	private int _ticksExecuted; //Field offset: 0xA0
	private INetworkRunnerUpdater _updater; //Field offset: 0xA8
	private INetworkObjectInitializer _objectInitializer; //Field offset: 0xB0
	private INetworkObjectProvider _objectProvider; //Field offset: 0xB8
	internal Byte[] _connectionToken; //Field offset: 0xC0
	private Dictionary<NetworkObjectTypeId, NetworkObject> _attachableInstances; //Field offset: 0xC8
	private Nullable<Boolean> _provideInput; //Field offset: 0xD0
	private CancellationTokenSource OperationsCancellationTokenSource; //Field offset: 0xD8
	private List<NetworkObject> _remotePrefabsWaitingForSpawnedCallback; //Field offset: 0xE0
	private Action<NetworkRunner> _onGameStartAction; //Field offset: 0xE8
	internal Stack<NetworkObjectInactivityGuard> _inactivityGuardPool; //Field offset: 0xF0
	private bool _simulateMultiPeerPhysicsScenes; //Field offset: 0xF8
	private INetworkSceneManager _sceneManager; //Field offset: 0x100
	private NetworkSceneInfo _sceneInfoInitial; //Field offset: 0x108
	private NetworkSceneInfoChangeSource _sceneInfoChangeSource; //Field offset: 0x13C
	private NetworkSceneInfo _sceneInfoSnapshot; //Field offset: 0x140
	private TaskCompletionSource<Int32> _sceneLoadInitialTCS; //Field offset: 0x178
	private Dictionary<Int64, List`1<Byte[]>> _reliableTransfers; //Field offset: 0x180
	[CompilerGenerated]
	private GameMode <GameMode>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private SessionInfo <SessionInfo>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private LobbyInfo <LobbyInfo>k__BackingField; //Field offset: 0x198
	private bool _alreadyInitialized; //Field offset: 0x1A0
	internal AsyncOperationHandler<ShutdownReason> _startGameOperation; //Field offset: 0x1A8
	internal CloudServices _cloudServices; //Field offset: 0x1B0

	public event ObjectDelegate ObjectAcquired
	{
		[CompilerGenerated]
		 add { } //Length: 156
		[CompilerGenerated]
		 remove { } //Length: 156
	}

	public IEnumerable<PlayerRef> ActivePlayers
	{
		 get { } //Length: 172
	}

	public AuthenticationValues AuthenticationValues
	{
		 get { } //Length: 52
	}

	public static BuildTypes BuildType
	{
		 get { } //Length: 8
	}

	public bool CanSpawn
	{
		 get { } //Length: 84
	}

	public NetworkProjectConfig Config
	{
		 get { } //Length: 8
	}

	public ConnectionType CurrentConnectionType
	{
		 get { } //Length: 280
	}

	public float DeltaTime
	{
		 get { } //Length: 24
	}

	private override bool Fusion.Simulation.ICallbacks.CanReceivePlayerJoinLeaveCallbacks
	{
		private get { } //Length: 48
	}

	private override bool Fusion.Simulation.ICallbacks.IsSharedModeMasterClient
	{
		private get { } //Length: 4
	}

	private override PlayerRef Fusion.Simulation.ICallbacks.LocalPlayerRef
	{
		private get { } //Length: 136
	}

	public private GameMode GameMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public static IReadOnlyList<NetworkRunner> Instances
	{
		 get { } //Length: 88
	}

	public bool IsClient
	{
		 get { } //Length: 20
	}

	public bool IsCloudReady
	{
		 get { } //Length: 124
	}

	public bool IsConnectedToServer
	{
		 get { } //Length: 164
	}

	public bool IsFirstTick
	{
		 get { } //Length: 32
	}

	public bool IsForward
	{
		 get { } //Length: 20
	}

	internal bool IsInitialized
	{
		internal get { } //Length: 144
	}

	public bool IsInSession
	{
		 get { } //Length: 124
	}

	public bool IsLastTick
	{
		 get { } //Length: 32
	}

	public bool IsPlayer
	{
		 get { } //Length: 20
	}

	private bool IsRegularShutdown
	{
		private get { } //Length: 12
	}

	public bool IsResimulation
	{
		 get { } //Length: 32
	}

	public bool IsResume
	{
		 get { } //Length: 108
	}

	public bool IsRunning
	{
		 get { } //Length: 20
	}

	public bool IsSceneAuthority
	{
		 get { } //Length: 52
	}

	public bool IsSceneManagerBusy
	{
		 get { } //Length: 188
	}

	public bool IsServer
	{
		 get { } //Length: 20
	}

	public bool IsSharedModeMasterClient
	{
		 get { } //Length: 72
	}

	public bool IsShutdown
	{
		 get { } //Length: 16
	}

	internal bool IsShutdownDeferred
	{
		internal get { } //Length: 8
	}

	internal bool IsSimulationUpdating
	{
		internal get { } //Length: 16
	}

	public bool IsSinglePlayer
	{
		 get { } //Length: 20
	}

	public bool IsStarting
	{
		 get { } //Length: 56
	}

	public HitboxManager LagCompensation
	{
		 get { } //Length: 116
	}

	public Tick LatestServerTick
	{
		 get { } //Length: 40
	}

	public private LobbyInfo LobbyInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public float LocalAlpha
	{
		 get { } //Length: 24
	}

	public PlayerRef LocalPlayer
	{
		 get { } //Length: 40
	}

	public float LocalRenderTime
	{
		 get { } //Length: 384
	}

	public SimulationModes Mode
	{
		 get { } //Length: 24
	}

	public NATType NATType
	{
		 get { } //Length: 20
	}

	public INetworkObjectProvider ObjectProvider
	{
		 get { } //Length: 8
	}

	internal CancellationToken OperationsCancellationToken
	{
		internal get { } //Length: 132
	}

	public NetworkPrefabTable Prefabs
	{
		 get { } //Length: 24
	}

	public bool ProvideInput
	{
		 get { } //Length: 60
		 set { } //Length: 104
	}

	public int ReliableDataSendRate
	{
		 get { } //Length: 20
		 set { } //Length: 20
	}

	public float RemoteRenderTime
	{
		 get { } //Length: 188
	}

	public INetworkSceneManager SceneManager
	{
		 get { } //Length: 8
	}

	public private SessionInfo SessionInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal Simulation Simulation
	{
		internal get { } //Length: 8
	}

	public float SimulationTime
	{
		 get { } //Length: 40
	}

	public Scene SimulationUnityScene
	{
		 get { } //Length: 176
	}

	public SimulationStages Stage
	{
		 get { } //Length: 24
	}

	public States State
	{
		 get { } //Length: 60
	}

	public Tick Tick
	{
		 get { } //Length: 24
	}

	public int TickRate
	{
		 get { } //Length: 20
	}

	public int TicksExecuted
	{
		 get { } //Length: 8
	}

	public Topologies Topology
	{
		 get { } //Length: 44
	}

	public string UserId
	{
		 get { } //Length: 52
	}

	private static NetworkRunner() { }

	public NetworkRunner() { }

	[CompilerGenerated]
	private bool <RunHostMigrationResume>b__11_0() { }

	[CompilerGenerated]
	private void <SceneInfoSyncSceneManager>b__321_0(NetworkSceneAsyncOp op) { }

	[CompilerGenerated]
	private void <SceneInfoSyncSceneManager>b__321_1(NetworkSceneAsyncOp op) { }

	[CompilerGenerated]
	private bool <SendHostMigrationSnapshot>b__17_0() { }

	[CompilerGenerated]
	private NetworkId <SpawnInternal>g__CheckIdOrGetNewId|370_0(NetworkObject obj, ref <>c__DisplayClass370_0 unnamed_param_1) { }

	[CompilerGenerated]
	private NetworkSpawnOp <SpawnInternal>g__Complete|370_2(NetworkObject instance, ref <>c__DisplayClass370_0 unnamed_param_1) { }

	[CompilerGenerated]
	private NetworkSpawnOp <SpawnInternal>g__Failed|370_1(NetworkSpawnStatus status, ref <>c__DisplayClass370_0 unnamed_param_1) { }

	[CompilerGenerated]
	private NetworkSpawnOp <SpawnInternal>g__Incomplete|370_3(in SpawnArgs spawnArgs, ref <>c__DisplayClass370_0 unnamed_param_1) { }

	[CompilerGenerated]
	private NetworkSceneAsyncOp <UnloadScene>b__302_0(SceneRef x) { }

	[CompilerGenerated]
	public void add_ObjectAcquired(ObjectDelegate value) { }

	public void AddCallbacks(INetworkRunnerCallbacks[] callbacks) { }

	public void AddGlobal(SimulationBehaviour instance) { }

	private void AddInactiveObjectGuard(NetworkObject obj) { }

	private static bool AddInstance(NetworkRunner runner) { }

	public void AddPlayerAreaOfInterest(PlayerRef player, Vector3 center, float radius) { }

	internal void AddSimulationBehaviour(SimulationBehaviour behaviour) { }

	private static void ApplySpawnArgs(NetworkObject obj, in SpawnArgs spawnArgs) { }

	public void Attach(NetworkObject[] networkObjects, Nullable<PlayerRef> inputAuthority = null, bool allocate = true, Nullable<Boolean> masterClientObjectOverride = null) { }

	public void Attach(NetworkObject networkObject, Nullable<PlayerRef> inputAuthority = null, bool allocate = true, Nullable<Boolean> masterClientObjectOverride = null) { }

	internal void AttachActivatedByUser(NetworkObject networkObject) { }

	private static NetworkObjectRuntimeFlags AttachOptionsToNetworkObjectFlags(AttachOptions options) { }

	private void Awake() { }

	public void ClearPlayerAreaOfInterest(PlayerRef player) { }

	internal void Connect(NetAddress address, Byte[] token, Byte[] uniqueId) { }

	internal Task ConnectToCloud(AuthenticationValues authentication = null, FusionAppSettings customAppSettings = null, CloudCommunicator externalCommunicator = null, CancellationToken externalCancellationToken = null, Nullable<Boolean> useDefaultCloudPorts = null, bool useCachedRegions = false) { }

	private void ConsumeInitialSceneInfo(bool isSceneAuthority) { }

	private INetSocket CreateCloudSocket() { }

	public void Despawn(NetworkObject networkObject) { }

	internal void Destroy(NetworkObject networkObject, NetworkObjectDestroyFlags flags) { }

	public void DestroySingleton() { }

	internal void DetachInstance(NetworkObject obj, bool destroyedByEngine, bool hasState) { }

	public void Disconnect(PlayerRef player, Byte[] token = null) { }

	internal void Disconnect(NetAddress address) { }

	[AsyncStateMachine(typeof(<DisconnectFromCloud>d__425))]
	private Task DisconnectFromCloud() { }

	public bool EnsureRunnerSceneIsActive(out Scene previousActiveScene) { }

	public bool Exists(NetworkObject obj) { }

	public bool Exists(NetworkId id) { }

	public NetworkObject FindObject(NetworkId networkId) { }

	private void FixedUpdate() { }

	private void FreeObject(NetworkObject obj) { }

	private override bool Fusion.Simulation.ICallbacks.CreateRemotePrefab(NetworkObjectMeta meta) { }

	private override bool Fusion.Simulation.ICallbacks.DestroyRemotePrefab(NetworkId id, bool exists) { }

	private override void Fusion.Simulation.ICallbacks.EndUpdateRemotePrefabs() { }

	private override bool Fusion.Simulation.ICallbacks.get_CanReceivePlayerJoinLeaveCallbacks() { }

	private override bool Fusion.Simulation.ICallbacks.get_IsSharedModeMasterClient() { }

	private override PlayerRef Fusion.Simulation.ICallbacks.get_LocalPlayerRef() { }

	private override void Fusion.Simulation.ICallbacks.ObjectChanged(NetworkId id, bool created) { }

	private override void Fusion.Simulation.ICallbacks.ObjectEnterAOI(PlayerRef player, NetworkId id) { }

	private override void Fusion.Simulation.ICallbacks.ObjectExitAOI(PlayerRef player, NetworkId id) { }

	private override void Fusion.Simulation.ICallbacks.ObjectInputAuthorityChanged(NetworkId id, bool gained) { }

	private override void Fusion.Simulation.ICallbacks.ObjectIsSimulatedChanged(NetworkId id, bool simulated) { }

	private override void Fusion.Simulation.ICallbacks.ObjectStateAuthorityChanged(NetworkId id, bool gained) { }

	private override void Fusion.Simulation.ICallbacks.OnAfterAllTicks(bool resimulation, int tickCount) { }

	private override void Fusion.Simulation.ICallbacks.OnAfterClientSidePredictionReset() { }

	private override void Fusion.Simulation.ICallbacks.OnAfterSimulation() { }

	private override void Fusion.Simulation.ICallbacks.OnAfterTick() { }

	private override void Fusion.Simulation.ICallbacks.OnBeforeAllTicks(bool resimulation, int tickCount) { }

	private override void Fusion.Simulation.ICallbacks.OnBeforeClientSidePredictionReset() { }

	private override void Fusion.Simulation.ICallbacks.OnBeforeCopyPreviousState() { }

	private override void Fusion.Simulation.ICallbacks.OnBeforeSimulation(int forwardTickCount) { }

	private override void Fusion.Simulation.ICallbacks.OnBeforeTick() { }

	private override void Fusion.Simulation.ICallbacks.OnClientStart() { }

	private override void Fusion.Simulation.ICallbacks.OnConnectedToServer() { }

	private override void Fusion.Simulation.ICallbacks.OnConnectionFailed(NetAddress remoteAddress, NetConnectFailedReason reason) { }

	private override OnConnectionRequestReply Fusion.Simulation.ICallbacks.OnConnectionRequest(NetAddress remoteAddress, Byte[] token) { }

	private override void Fusion.Simulation.ICallbacks.OnDisconnectedFromServer(NetDisconnectReason reason) { }

	private override void Fusion.Simulation.ICallbacks.OnInput(SimulationInput input) { }

	private override void Fusion.Simulation.ICallbacks.OnInputMissing(SimulationInput input) { }

	private override void Fusion.Simulation.ICallbacks.OnInternalConnectionAttempt(int attempt, int totalConnectionAttempts, out bool shouldChange, out NetAddress newAddress) { }

	private override SimulationMessageResult Fusion.Simulation.ICallbacks.OnMessage(SimulationMessage* message) { }

	private override void Fusion.Simulation.ICallbacks.OnReliableData(PlayerRef player, ReliableId id, bool local, Byte[] dataArray) { }

	private override void Fusion.Simulation.ICallbacks.OnServerStart() { }

	private override void Fusion.Simulation.ICallbacks.OnTick() { }

	private override void Fusion.Simulation.ICallbacks.PlayerJoined(PlayerRef player) { }

	private override void Fusion.Simulation.ICallbacks.PlayerLeft(PlayerRef player) { }

	private override bool Fusion.Simulation.ICallbacks.TryBeginUpdateRemotePrefabs() { }

	public IEnumerable<PlayerRef> get_ActivePlayers() { }

	public AuthenticationValues get_AuthenticationValues() { }

	public static BuildTypes get_BuildType() { }

	public bool get_CanSpawn() { }

	public NetworkProjectConfig get_Config() { }

	public ConnectionType get_CurrentConnectionType() { }

	public float get_DeltaTime() { }

	[CompilerGenerated]
	public GameMode get_GameMode() { }

	public static IReadOnlyList<NetworkRunner> get_Instances() { }

	public bool get_IsClient() { }

	public bool get_IsCloudReady() { }

	public bool get_IsConnectedToServer() { }

	public bool get_IsFirstTick() { }

	public bool get_IsForward() { }

	internal bool get_IsInitialized() { }

	public bool get_IsInSession() { }

	public bool get_IsLastTick() { }

	public bool get_IsPlayer() { }

	private bool get_IsRegularShutdown() { }

	public bool get_IsResimulation() { }

	public bool get_IsResume() { }

	public bool get_IsRunning() { }

	public bool get_IsSceneAuthority() { }

	public bool get_IsSceneManagerBusy() { }

	public bool get_IsServer() { }

	public bool get_IsSharedModeMasterClient() { }

	public bool get_IsShutdown() { }

	internal bool get_IsShutdownDeferred() { }

	internal bool get_IsSimulationUpdating() { }

	public bool get_IsSinglePlayer() { }

	public bool get_IsStarting() { }

	public HitboxManager get_LagCompensation() { }

	public Tick get_LatestServerTick() { }

	[CompilerGenerated]
	public LobbyInfo get_LobbyInfo() { }

	public float get_LocalAlpha() { }

	public PlayerRef get_LocalPlayer() { }

	public float get_LocalRenderTime() { }

	public SimulationModes get_Mode() { }

	public NATType get_NATType() { }

	public INetworkObjectProvider get_ObjectProvider() { }

	internal CancellationToken get_OperationsCancellationToken() { }

	public NetworkPrefabTable get_Prefabs() { }

	public bool get_ProvideInput() { }

	public int get_ReliableDataSendRate() { }

	public float get_RemoteRenderTime() { }

	public INetworkSceneManager get_SceneManager() { }

	[CompilerGenerated]
	public SessionInfo get_SessionInfo() { }

	internal Simulation get_Simulation() { }

	public float get_SimulationTime() { }

	public Scene get_SimulationUnityScene() { }

	public SimulationStages get_Stage() { }

	public States get_State() { }

	public Tick get_Tick() { }

	public int get_TickRate() { }

	public int get_TicksExecuted() { }

	public Topologies get_Topology() { }

	public string get_UserId() { }

	public List<T> GetAllBehaviours() { }

	public void GetAllBehaviours(List<T> result) { }

	public SimulationBehaviour[] GetAllBehaviours(Type type) { }

	public List<NetworkObject> GetAllNetworkObjects() { }

	public void GetAreaOfInterestGizmoData(List<ValueTuple`4<Vector3, Vector3, Int32, Int32>> result) { }

	public static Task<List`1<RegionInfo>> GetAvailableRegions(string appId = null, CancellationToken cancellationToken = null) { }

	public Nullable<T> GetInputForPlayer(PlayerRef player) { }

	public static Enumerator<NetworkRunner> GetInstancesEnumerator() { }

	public SimulationBehaviourListScope GetInterfaceListHead(Type type, int index, out SimulationBehaviour head) { }

	public SimulationBehaviour GetInterfaceListNext(SimulationBehaviour behaviour) { }

	public SimulationBehaviour GetInterfaceListPrev(SimulationBehaviour behaviour) { }

	public int GetInterfaceListsCount(Type type) { }

	public void GetMemorySnapshot(TargetAllocator targetAllocator, ref MemoryStatisticsSnapshot snapshot) { }

	private NetworkObject GetNetworkObjectFromResumeSnapshot(NetworkObjectHeaderPtr networkObjectPtr, Dictionary<NetworkId, NetworkObjectHeaderPtr> headerList, Dictionary<NetworkId, List`1<NetworkId>> nestedMapping) { }

	public List<NetworkId> GetObjectsInAreaOfInterestForPlayer(PlayerRef player) { }

	public PhysicsScene GetPhysicsScene() { }

	public PhysicsScene2D GetPhysicsScene2D() { }

	public Nullable<Int32> GetPlayerActorId(PlayerRef player) { }

	public Byte[] GetPlayerConnectionToken(PlayerRef player = null) { }

	public ConnectionType GetPlayerConnectionType(PlayerRef player) { }

	public NetworkObject GetPlayerObject(PlayerRef player) { }

	public double GetPlayerRtt(PlayerRef playerRef) { }

	public string GetPlayerUserId(PlayerRef player = null) { }

	public Nullable<NetworkInput> GetRawInputForPlayer(PlayerRef player) { }

	[IteratorStateMachine(typeof(<GetResumeSnapshotNetworkObjects>d__3))]
	public IEnumerable<NetworkObject> GetResumeSnapshotNetworkObjects() { }

	[IteratorStateMachine(typeof(<GetResumeSnapshotNetworkSceneObjects>d__4))]
	public IEnumerable<ValueTuple`2<NetworkObject, NetworkObjectHeaderPtr>> GetResumeSnapshotNetworkSceneObjects() { }

	public RpcTargetStatus GetRpcTargetStatus(PlayerRef target) { }

	public static NetworkRunner GetRunnerForGameObject(GameObject gameObject) { }

	public static NetworkRunner GetRunnerForScene(Scene scene) { }

	private NetworkSceneInfo GetSceneInfoRef(bool allowFallback = true) { }

	public SceneRef GetSceneRef(string sceneNameOrPath) { }

	public SceneRef GetSceneRef(GameObject gameObj) { }

	private bool GetServerSnapshot(ref Byte[] data, out Tick tick, out uint idCounter, out int length) { }

	public T GetSingleton() { }

	public bool HasAnyActiveConnections() { }

	public bool HasSingleton() { }

	internal void InitFusionLogSystem() { }

	internal Task<Boolean> Initialize(NetworkRunnerInitializeArgs args) { }

	private void InitializeNetworkObjectAssignRunner(NetworkObject instance, Nullable<NetworkObjectTypeId> typeId = null, bool isNestedObject = false) { }

	private void InitializeNetworkObjectInstance(NetworkObjectMeta meta, NetworkObject instance, Nullable<PlayerRef> inputAuthority, AttachOptions options, Nullable<Boolean> masterClientObjectOverride) { }

	private void InitializeNetworkObjectState(NetworkObject instance, AttachOptions options) { }

	private void InitializeTempNetworkObjectInstance(NetworkObjectHeader* header, NetworkObject instance) { }

	public GameObject InstantiateInRunnerScene(GameObject original, Vector3 position, Quaternion rotation) { }

	public GameObject InstantiateInRunnerScene(GameObject original) { }

	public T InstantiateInRunnerScene(T original) { }

	public T InstantiateInRunnerScene(T original, Vector3 position, Quaternion rotation) { }

	private void InvokeAfterSpawnedCallback(NetworkObject instance) { }

	private void InvokeAfterUpdate() { }

	private void InvokeBeforeSpawnedCallbacks(NetworkObject instance, AttachOptions options, OnBeforeSpawned onBeforeSpawned) { }

	private void InvokeBeforeUpdate() { }

	internal void InvokeCustomAuthenticationResponse(Dictionary<String, Object> data) { }

	internal void InvokeDespawnedCallback(NetworkObject instance, bool hasState) { }

	private void InvokeHostMigration(HostMigrationToken migrationToken) { }

	private void InvokeObjectAcquired(NetworkObject instance) { }

	internal void InvokeOnBeforeHitboxRegistration() { }

	internal void InvokeOnGameStartedCallback() { }

	public void InvokeSceneLoadDone(in SceneLoadDoneArgs info) { }

	public void InvokeSceneLoadStart(SceneRef sceneRef) { }

	internal void InvokeSessionListUpdated(List<SessionInfo> sessionList) { }

	private void InvokeSpawnedCallback(NetworkObject instance) { }

	private static bool IsAwakeAtInitialization(NetworkObject obj) { }

	public Nullable<Boolean> IsInterestedIn(NetworkObject obj, PlayerRef player) { }

	public bool IsPlayerValid(PlayerRef player) { }

	private static bool IsPreexistingAtInitialization(NetworkObject obj) { }

	[AsyncStateMachine(typeof(<JoinSessionLobby>d__422))]
	public Task<StartGameResult> JoinSessionLobby(SessionLobby sessionLobby, string lobbyID = null, AuthenticationValues authentication = null, FusionAppSettings customAppSettings = null, Nullable<Boolean> useDefaultCloudPorts = null, CancellationToken cancellationToken = null, bool useCachedRegions = true) { }

	public NetworkSceneAsyncOp LoadScene(string sceneName, LoadSceneParameters parameters, bool setActiveOnLoad = false) { }

	public NetworkSceneAsyncOp LoadScene(string sceneName, LoadSceneMode loadSceneMode = 0, LocalPhysicsMode localPhysicsMode = 0, bool setActiveOnLoad = false) { }

	public NetworkSceneAsyncOp LoadScene(SceneRef sceneRef, LoadSceneMode loadSceneMode = 0, LocalPhysicsMode localPhysicsMode = 0, bool setActiveOnLoad = false) { }

	public NetworkSceneAsyncOp LoadScene(SceneRef sceneRef, LoadSceneParameters parameters, bool setActiveOnLoad = false) { }

	public void MakeDontDestroyOnLoad(GameObject obj) { }

	public bool MoveGameObjectToSameScene(GameObject gameObj, GameObject other) { }

	public bool MoveGameObjectToScene(GameObject gameObj, SceneRef sceneRef) { }

	public void MoveToRunnerScene(GameObject instance, Nullable<SceneRef> targetSceneRef = null) { }

	public void MoveToRunnerScene(T component) { }

	private static AttachOptions NetworkObjectFlagsToAttachOptions(NetworkObjectRuntimeFlags flags) { }

	internal void OnApplicationQuit() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnMessageUser(SimulationMessage* message) { }

	private void OnRemoteSceneLoadCompleted(NetworkSceneAsyncOp asyncOp) { }

	private void OnRemoteSceneUnloadCompleted(NetworkSceneAsyncOp asyncOp) { }

	internal void OnRuntimeConfigReady() { }

	private void OnValidate() { }

	private void ProcessSpawnQueue() { }

	[AsyncStateMachine(typeof(<PushHostMigrationSnapshot>d__2))]
	public Task<Boolean> PushHostMigrationSnapshot() { }

	private void RegisterNetworkCallbacks() { }

	public int RegisterSceneObjects(SceneRef scene, NetworkObject[] objects, NetworkSceneLoadId loadId = null) { }

	[CompilerGenerated]
	public void remove_ObjectAcquired(ObjectDelegate value) { }

	public void RemoveCallbacks(INetworkRunnerCallbacks[] callbacks) { }

	public void RemoveGlobal(SimulationBehaviour instance) { }

	private static bool RemoveInstance(NetworkRunner runner) { }

	internal void RemoveSimulationBehavior(SimulationBehaviour behaviour) { }

	public void RenderInternal() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void ResetAllSimulationStatics() { }

	internal static void ResetStatics() { }

	private void RestoreMultiPeerDefaultPhysics() { }

	[IteratorStateMachine(typeof(<RunHostMigrationResume>d__11))]
	private IEnumerator RunHostMigrationResume(NetworkRunnerInitializeArgs args) { }

	private void SceneInfoSyncSceneManager(NetworkSceneInfoChangeSource changeSource, ref NetworkSceneInfo sceneInfo, ref NetworkSceneInfo prevInfo) { }

	private void SceneInfoUpdate() { }

	internal Task<Boolean> SendHostMigrationSnapshot() { }

	public void SendReliableDataToPlayer(PlayerRef player, ReliableKey key, Byte[] data) { }

	public void SendReliableDataToServer(ReliableKey key, Byte[] data) { }

	public void SendRpc(SimulationMessage* message, out RpcSendResult info) { }

	public void SendRpc(SimulationMessage* message) { }

	[CompilerGenerated]
	private void set_GameMode(GameMode value) { }

	[CompilerGenerated]
	private void set_LobbyInfo(LobbyInfo value) { }

	public void set_ProvideInput(bool value) { }

	public void set_ReliableDataSendRate(int value) { }

	[CompilerGenerated]
	private void set_SessionInfo(SessionInfo value) { }

	public void SetAreaOfInterestCellSize(int size) { }

	public void SetAreaOfInterestGrid(int x, int y, int z) { }

	public void SetBehaviourReplicateTo(NetworkBehaviour behaviour, PlayerRef player, bool replicate) { }

	private void SetBehaviourReplicateTo(NetworkBehaviour behaviour, SimulationConnection sc, bool replicate, bool forceCreate) { }

	public void SetBehaviourReplicateToAll(NetworkBehaviour behaviour, bool replicate) { }

	private void SetHostMigrationBandwidth(int bytePerSecond) { }

	private void SetInitializationDone(NetworkRunnerInitializeArgs args) { }

	public bool SetIsSimulated(NetworkObject obj, bool simulate) { }

	public void SetMasterClient(PlayerRef player) { }

	public void SetPlayerAlwaysInterested(PlayerRef player, NetworkObject networkObject, bool alwaysInterested) { }

	public void SetPlayerObject(PlayerRef player, NetworkObject networkObject) { }

	public void SetSimulateMultiPeerPhysics(bool value) { }

	internal void SetupEncryption(EncryptionToken token) { }

	internal void SetupHostMigration(HostMigration hostMigration) { }

	private void SetupMultiPeerPhysics() { }

	internal static NetworkProjectConfig SetupNetworkProjectConfig(NetworkRunnerInitializeArgs args) { }

	public Task Shutdown(bool destroyGameObject = true, ShutdownReason shutdownReason = 0, bool forceShutdownProcedure = false) { }

	[EditorButton("Shutdown", EditorButtonVisibility::PlayMode (0), 0, False)]
	internal void ShutdownAction() { }

	[AsyncStateMachine(typeof(<ShutdownAndBuildResult>d__428))]
	private Task<StartGameResult> ShutdownAndBuildResult(Exception e) { }

	private void SimulatePhysicsScenes(float fixedDeltaTime) { }

	public void SinglePlayerContinue() { }

	public void SinglePlayerPause(bool paused) { }

	public void SinglePlayerPause() { }

	public NetworkObject Spawn(NetworkPrefabId typeId, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public NetworkObject Spawn(NetworkPrefabRef prefabRef, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public NetworkObject Spawn(NetworkObjectGuid prefabGuid, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public NetworkObject Spawn(GameObject prefab, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public T Spawn(T prefab, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public NetworkObject Spawn(NetworkObject prefab, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public NetworkSpawnOp SpawnAsync(NetworkPrefabId typeId, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0, NetworkObjectSpawnDelegate onCompleted = null) { }

	public NetworkSpawnOp SpawnAsync(NetworkObjectGuid prefabGuid, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0, NetworkObjectSpawnDelegate onCompleted = null) { }

	public NetworkSpawnOp SpawnAsync(NetworkPrefabRef prefabRef, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0, NetworkObjectSpawnDelegate onCompleted = null) { }

	public NetworkSpawnOp SpawnAsync(NetworkObject prefab, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0, NetworkObjectSpawnDelegate onCompleted = null) { }

	public NetworkSpawnOp SpawnAsync(T prefab, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0, NetworkObjectSpawnDelegate onCompleted = null) { }

	public NetworkSpawnOp SpawnAsync(GameObject prefab, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0, NetworkObjectSpawnDelegate onCompleted = null) { }

	private NetworkSpawnOp SpawnInternal(in SpawnArgs args) { }

	public Task<StartGameResult> StartGame(StartGameArgs args) { }

	[AsyncStateMachine(typeof(<StartGameModeCloud>d__427))]
	private Task<StartGameResult> StartGameModeCloud(StartGameArgs args) { }

	[AsyncStateMachine(typeof(<StartGameModeSinglePlayer>d__426))]
	private Task<StartGameResult> StartGameModeSinglePlayer(StartGameArgs args) { }

	internal void StartHostMigration(Snapshot snapshot = null) { }

	private CreateInstanceResult TryAcquireInstance(NetworkObjectTypeId typeId, NetworkObjectMeta meta, out NetworkObject result, bool synchronous = true, bool dontDestroyOnLoad = false) { }

	public bool TryFindBehaviour(NetworkBehaviourId id, out T behaviour) { }

	public bool TryFindBehaviour(NetworkBehaviourId behaviourId, out NetworkBehaviour behaviour) { }

	public bool TryFindObject(NetworkId objectId, out NetworkObject networkObject) { }

	private bool TryFindSceneObject(NetworkObjectTypeId networkObjectTypeId, out NetworkObject networkObject) { }

	public bool TryGetBehaviourStatistics(Type behaviourType, out BehaviourStatisticsSnapshot behaviourStatisticsSnapshot) { }

	public bool TryGetFusionStatistics(out FusionStatisticsManager statisticsManager) { }

	public bool TryGetInputForPlayer(PlayerRef player, out T input) { }

	private bool TryGetInterfaceWithDefaultType(string defaultTypeName, out T result) { }

	public T TryGetNetworkedBehaviourFromNetworkedObjectRef(NetworkId networkId) { }

	public NetworkBehaviourId TryGetNetworkedBehaviourId(NetworkBehaviour behaviour) { }

	public NetworkId TryGetObjectRefFromNetworkedBehaviour(NetworkBehaviour behaviour) { }

	public bool TryGetPhysicsInfo(out NetworkPhysicsInfo info) { }

	public bool TryGetPlayerObject(PlayerRef player, out NetworkObject networkObject) { }

	internal static bool TryGetPrettyRunnerName(StringBuilder output, NetworkRunner runner) { }

	public bool TryGetSceneInfo(out NetworkSceneInfo sceneInfo) { }

	private bool TryGetSceneInfo(out NetworkSceneInfo sceneInfo, bool allowFallback) { }

	private bool TryResolveRemotePrefabInstance(NetworkObjectMeta header, out NetworkObject result) { }

	public bool TrySetPhysicsInfo(NetworkPhysicsInfo info) { }

	public NetworkSpawnStatus TrySpawn(T prefab, out T obj, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public NetworkSpawnStatus TrySpawn(GameObject prefab, out NetworkObject obj, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public NetworkSpawnStatus TrySpawn(NetworkPrefabRef prefabRef, out NetworkObject obj, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public NetworkSpawnStatus TrySpawn(NetworkObjectGuid prefabGuid, out NetworkObject obj, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public NetworkSpawnStatus TrySpawn(NetworkPrefabId typeId, out NetworkObject obj, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	public NetworkSpawnStatus TrySpawn(NetworkObject prefab, out NetworkObject obj, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null, Nullable<PlayerRef> inputAuthority = null, OnBeforeSpawned onBeforeSpawned = null, NetworkSpawnFlags flags = 0) { }

	private void UnityPreInitialize(NetworkObjectMeta meta, AttachOptions options) { }

	public NetworkSceneAsyncOp UnloadScene(SceneRef sceneRef) { }

	public NetworkSceneAsyncOp UnloadScene(string sceneName) { }

	private void Update() { }

	public void UpdateInternal(double dt) { }

	private SceneRef ValidateSceneName(string sceneName) { }

	private NetworkSceneAsyncOp ValidateSceneOp(NetworkSceneAsyncOp op) { }

	private SceneRef ValidateSceneRef(SceneRef sceneRef) { }

}

