namespace AnimalCompany;

public class AppStartup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TaskGenerator<LoginResult> <>9__17_0; //Field offset: 0x8
		public static TaskGenerator<ClientBootstrapResponse> <>9__18_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Task<ClientBootstrapResponse> <BootstrapCommand>b__18_0(CancellationToken token) { }

		internal Task<LoginResult> <InitialLogInCommand>b__17_0(CancellationToken token) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public AsyncOperation loadingSceneOp; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <InitializeAppCommand>b__0(float elapsed) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public bool waitingForPermissionDialog; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal void <RequestMicrophonePermissionCommand>b__0(bool isFocused) { }

		internal bool <RequestMicrophonePermissionCommand>b__1(float timePassed) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public LoginResult loginResult; //Field offset: 0x10
		public CommandConditionEval <>9__1; //Field offset: 0x28

		public <>c__DisplayClass17_0() { }

		internal bool <InitialLogInCommand>b__1(float elapsed) { }

	}

	[CompilerGenerated]
	private sealed class <BootstrapCommand>d__18 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public AppStartup <>4__this; //Field offset: 0x20
		private int <tryCount>5__2; //Field offset: 0x28
		private float <timeout>5__3; //Field offset: 0x2C
		private TaskCommand<ClientBootstrapResponse> <bootstrapRequestCmd>5__4; //Field offset: 0x30

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
		public <BootstrapCommand>d__18(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <InitializeAppCommand>d__12 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public AppStartup <>4__this; //Field offset: 0x20
		private string <clientVersion>5__2; //Field offset: 0x28
		private string <commitSHA>5__3; //Field offset: 0x30
		private AsyncOperation <openWorldSceneOp>5__4; //Field offset: 0x38
		private AsyncOperation <appViewSceneOp>5__5; //Field offset: 0x40

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
		public <InitializeAppCommand>d__12(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <InitialLogInCommand>d__17 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		private <>c__DisplayClass17_0 <>8__1; //Field offset: 0x20
		public AppStartup <>4__this; //Field offset: 0x28
		private TaskCommand<LoginResult> <loginCommand>5__2; //Field offset: 0x30

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
		public <InitialLogInCommand>d__17(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <InternetConnectivityCheckCommand>d__16 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		private int <tryCount>5__2; //Field offset: 0x20
		private float <timeout>5__3; //Field offset: 0x24
		private UnityWebRequest <request>5__4; //Field offset: 0x28

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
		public <InternetConnectivityCheckCommand>d__16(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <RequestMicrophonePermissionCommand>d__15 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		private <>c__DisplayClass15_0 <>8__1; //Field offset: 0x20
		private Action<Boolean> <onFocusChanged>5__2; //Field offset: 0x28

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
		public <RequestMicrophonePermissionCommand>d__15(int <>1__state) { }

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

	private const int APPCORE_SCENE_BUILD_INDEX = 0; //Field offset: 0x0
	private const int LOADING_SCENE_BUILD_INDEX = 1; //Field offset: 0x0
	private const int APPVIEW_SCENE_BUILD_INDEX = 2; //Field offset: 0x0
	private const int OPENWORLD_SCENE_BUILD_INDEX = 3; //Field offset: 0x0
	[Header("Logging")]
	[SerializeField]
	private LogLevel _logLevel; //Field offset: 0x20
	[MaskField]
	[SerializeField]
	private LogChannel _logChannels; //Field offset: 0x24
	[SerializeField]
	private LogLevel _remoteLogLevel; //Field offset: 0x28
	[MaskField]
	[SerializeField]
	private LogChannel _remoteLogChannels; //Field offset: 0x2C
	[HideInInspector]
	[SerializeField]
	private string _apiOrigin; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private string _apiToken; //Field offset: 0x38
	private CommandHandle _startupCommandHandle; //Field offset: 0x40

	public AppStartup() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<BootstrapCommand>d__18))]
	private IEnumerator<Command> BootstrapCommand() { }

	private GameObject CreateSystemGameObject(string name) { }

	private GameObject CreateSystemGameObject() { }

	private int GetAppSignatureHash(string commitSHA) { }

	private void GetAppStartupConfig(out string clientVersion, out string commitSHA, out string apiOrigin, out string apiToken, out LogLevel logLevel, out LogLevel remoteLogLevel) { }

	[IteratorStateMachine(typeof(<InitializeAppCommand>d__12))]
	private IEnumerator<Command> InitializeAppCommand() { }

	[IteratorStateMachine(typeof(<InitialLogInCommand>d__17))]
	private IEnumerator<Command> InitialLogInCommand() { }

	[IteratorStateMachine(typeof(<InternetConnectivityCheckCommand>d__16))]
	private IEnumerator<Command> InternetConnectivityCheckCommand() { }

	[IteratorStateMachine(typeof(<RequestMicrophonePermissionCommand>d__15))]
	private IEnumerator<Command> RequestMicrophonePermissionCommand() { }

}

