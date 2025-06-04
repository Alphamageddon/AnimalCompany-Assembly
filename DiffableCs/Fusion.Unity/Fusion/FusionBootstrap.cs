namespace Fusion;

[AddComponentMenu("Fusion/Fusion Bootstrap")]
[DisallowMultipleComponent]
[ScriptHelp(BackColor = ScriptHeaderBackColor::Steel (7))]
public class FusionBootstrap : Behaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<NetworkRunner> <>9__58_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <StartWithClients>b__58_0(NetworkRunner runner) { }

	}

	[CompilerGenerated]
	private sealed class <StartClients>d__63 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FusionBootstrap <>4__this; //Field offset: 0x20
		public GameMode serverMode; //Field offset: 0x28
		public SceneRef sceneRef; //Field offset: 0x2C
		public int clientCount; //Field offset: 0x30
		private List<Task> <clientTasks>5__2; //Field offset: 0x38
		private Task <clientsStartTask>5__3; //Field offset: 0x40
		private int <i>5__4; //Field offset: 0x48

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
		public <StartClients>d__63(int <>1__state) { }

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
	private sealed class <StartWithClients>d__58 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FusionBootstrap <>4__this; //Field offset: 0x20
		public GameMode serverMode; //Field offset: 0x28
		public int clientCount; //Field offset: 0x2C
		public SceneRef sceneRef; //Field offset: 0x30
		private Task <serverTask>5__2; //Field offset: 0x38

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
		public <StartWithClients>d__58(int <>1__state) { }

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
	private sealed class <StartWithMppmVirtualInstance>d__59 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FusionBootstrap <>4__this; //Field offset: 0x20

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
		public <StartWithMppmVirtualInstance>d__59(int <>1__state) { }

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

	internal enum Stage
	{
		Disconnected = 0,
		StartingUp = 1,
		UnloadOriginalScene = 2,
		ConnectingServer = 3,
		ConnectingClients = 4,
		AllConnected = 5,
	}

	private class StartCommand : FusionMppmCommand
	{
		public static StartCommand Instance; //Field offset: 0x0
		public string RoomName; //Field offset: 0x10
		public SceneRef InitialScene; //Field offset: 0x18
		public int ClientCount; //Field offset: 0x1C
		public bool IsShared; //Field offset: 0x20

		public StartCommand() { }

		public virtual void Execute() { }

	}

	internal enum StartModes
	{
		UserInterface = 0,
		Automatic = 1,
		Manual = 2,
	}

	private static string _initialScenePath; //Field offset: 0x0
	[InlineHelp]
	[WarnIf("RunnerPrefab", False, "No RunnerPrefab supplied. Will search for a NetworkRunner in the scene at startup.", CompareOperator::Equal (0))]
	public NetworkRunner RunnerPrefab; //Field offset: 0x20
	[InlineHelp]
	[WarnIf("StartMode", 2, "Start network by calling the methods StartHost(), StartServer(), StartClient(), StartHostPlusClients(), or StartServerPlusClients()", CompareOperator::Equal (0))]
	public StartModes StartMode; //Field offset: 0x28
	[DrawIf("StartMode", 1, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0), Hide = True)]
	[FormerlySerializedAs("Server")]
	[InlineHelp]
	public GameMode AutoStartAs; //Field offset: 0x2C
	[DrawIf("StartMode", 0, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0), Hide = True)]
	[InlineHelp]
	public bool AutoHideGUI; //Field offset: 0x30
	[DrawIf("ShowAutoClients", Hide = True)]
	[InlineHelp]
	public int AutoClients; //Field offset: 0x34
	[InlineHelp]
	public float ClientStartDelay; //Field offset: 0x38
	[InlineHelp]
	public ushort ServerPort; //Field offset: 0x3C
	[InlineHelp]
	public string DefaultRoomName; //Field offset: 0x40
	private NetworkRunner _server; //Field offset: 0x48
	[InlineHelp]
	[ScenePath]
	public string InitialScenePath; //Field offset: 0x50
	[InlineHelp]
	[ReadOnly]
	[SerializeField]
	protected Stage _currentStage; //Field offset: 0x58
	[DrawIf("IsMPPMEnabled", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[Header("Multiplayer Play Mode")]
	public bool AutoConnectVirtualInstances; //Field offset: 0x5C
	[DrawIf("IsMPPMEnabled", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	public float VirtualInstanceConnectDelay; //Field offset: 0x60
	[CompilerGenerated]
	private int <LastCreatedClientIndex>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private GameMode <CurrentServerMode>k__BackingField; //Field offset: 0x68

	protected bool CanAddClients
	{
		 get { } //Length: 36
	}

	protected bool CanAddSharedClients
	{
		 get { } //Length: 36
	}

	public internal GameMode CurrentServerMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal Stage CurrentStage
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	private static bool IsMPPMEnabled
	{
		private get { } //Length: 80
	}

	protected bool IsShutdown
	{
		 get { } //Length: 16
	}

	protected bool IsShutdownAndMultiPeer
	{
		 get { } //Length: 56
	}

	public internal int LastCreatedClientIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public bool ShouldShowGUI
	{
		 get { } //Length: 116
	}

	protected bool ShowAutoClients
	{
		 get { } //Length: 88
	}

	protected bool UsingMultiPeerMode
	{
		 get { } //Length: 40
	}

	public FusionBootstrap() { }

	public Task AddClient(GameMode serverMode, SceneRef sceneRef) { }

	[DrawIf("CanAddClients", Hide = True)]
	[EditorButton("Add Additional Client", EditorButtonVisibility::PlayMode (0), 0, False)]
	public void AddClient() { }

	[DrawIf("CanAddSharedClients", Hide = True)]
	[EditorButton("Add Additional Shared Client", EditorButtonVisibility::PlayMode (0), 0, False)]
	public void AddSharedClient() { }

	protected bool get_CanAddClients() { }

	protected bool get_CanAddSharedClients() { }

	[CompilerGenerated]
	public GameMode get_CurrentServerMode() { }

	public Stage get_CurrentStage() { }

	private static bool get_IsMPPMEnabled() { }

	protected bool get_IsShutdown() { }

	protected bool get_IsShutdownAndMultiPeer() { }

	[CompilerGenerated]
	public int get_LastCreatedClientIndex() { }

	public bool get_ShouldShowGUI() { }

	protected bool get_ShowAutoClients() { }

	protected bool get_UsingMultiPeerMode() { }

	protected override Task InitializeNetworkRunner(NetworkRunner runner, GameMode gameMode, NetAddress address, SceneRef scene, Action<NetworkRunner> onGameStarted, INetworkRunnerUpdater updater = null) { }

	[CompilerGenerated]
	internal void set_CurrentServerMode(GameMode value) { }

	internal void set_CurrentStage(Stage value) { }

	[CompilerGenerated]
	internal void set_LastCreatedClientIndex(int value) { }

	protected void ShowUserInterface() { }

	[DrawIf("CurrentStage", Hide = True)]
	[EditorButton(EditorButtonVisibility::PlayMode (0), 0, False)]
	public void Shutdown() { }

	public void ShutdownAll() { }

	protected override void Start() { }

	[DrawIf("IsShutdown", Hide = True)]
	[EditorButton("Start Auto Host Or Client", EditorButtonVisibility::PlayMode (0), 0, False)]
	public override void StartAutoClient() { }

	[DrawIf("IsShutdown", Hide = True)]
	[EditorButton(EditorButtonVisibility::PlayMode (0), 0, False)]
	public override void StartClient() { }

	[IteratorStateMachine(typeof(<StartClients>d__63))]
	protected IEnumerator StartClients(int clientCount, GameMode serverMode, SceneRef sceneRef = null) { }

	[DrawIf("IsShutdown", Hide = True)]
	[EditorButton(EditorButtonVisibility::PlayMode (0), 0, False)]
	public override void StartHost() { }

	[DrawIf("IsShutdown", Hide = True)]
	[EditorButton(EditorButtonVisibility::PlayMode (0), 0, False)]
	public void StartHostPlusClients() { }

	public void StartHostPlusClients(int clientCount) { }

	public void StartMultipleAutoClients(int clientCount) { }

	public void StartMultipleClients(int clientCount) { }

	public void StartMultipleSharedClients(int clientCount) { }

	[DrawIf("IsShutdown", Hide = True)]
	[EditorButton(EditorButtonVisibility::PlayMode (0), 0, False)]
	public override void StartServer() { }

	[DrawIf("IsShutdown", Hide = True)]
	[EditorButton(EditorButtonVisibility::PlayMode (0), 0, False)]
	public override void StartServerPlusClients() { }

	public override void StartServerPlusClients(int clientCount) { }

	[DrawIf("IsShutdown", Hide = True)]
	[EditorButton(EditorButtonVisibility::PlayMode (0), 0, False)]
	public override void StartSharedClient() { }

	[DrawIf("IsShutdown", Hide = True)]
	[EditorButton(EditorButtonVisibility::PlayMode (0), 0, False)]
	public override void StartSinglePlayer() { }

	[IteratorStateMachine(typeof(<StartWithClients>d__58))]
	protected IEnumerator StartWithClients(GameMode serverMode, SceneRef sceneRef, int clientCount) { }

	[IteratorStateMachine(typeof(<StartWithMppmVirtualInstance>d__59))]
	protected IEnumerator StartWithMppmVirtualInstance() { }

	private bool TryGetSceneRef(out SceneRef sceneRef) { }

}

