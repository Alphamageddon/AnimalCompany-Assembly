namespace Fusion;

public class NetworkSceneManagerDefault : Behaviour, INetworkSceneManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<Scene, NetworkSceneManagerDefault>, Scene> <>9__25_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__23_0(Scene s) { }

		internal Scene <Shutdown>b__25_1(KeyValuePair<Scene, NetworkSceneManagerDefault> x) { }

	}

	[CompilerGenerated]
	private sealed class <LoadSceneCoroutine>d__40 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NetworkSceneManagerDefault <>4__this; //Field offset: 0x20
		public SceneRef sceneRef; //Field offset: 0x28
		public NetworkLoadSceneParameters sceneParams; //Field offset: 0x2C
		private Scene <scene>5__2; //Field offset: 0x30
		private LoadingScope <>7__wrap2; //Field offset: 0x38
		private LocalPhysicsMode <localPhysicsMode>5__4; //Field offset: 0x40
		private LoadSceneMode <loadSceneMode>5__5; //Field offset: 0x44
		private Enumerator<MultiPeerSceneRoot> <>7__wrap5; //Field offset: 0x48
		private MultiPeerSceneRoot <root>5__7; //Field offset: 0x60
		private Scene <candidate>5__8; //Field offset: 0x68
		private int <i>5__9; //Field offset: 0x6C
		private AsyncOperation <op>5__10; //Field offset: 0x70

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
		public <LoadSceneCoroutine>d__40(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

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
	private sealed class <OnSceneLoaded>d__42 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Scene scene; //Field offset: 0x20
		public NetworkSceneManagerDefault <>4__this; //Field offset: 0x28
		public SceneRef sceneRef; //Field offset: 0x30
		public NetworkLoadSceneParameters sceneParams; //Field offset: 0x34

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
		public <OnSceneLoaded>d__42(int <>1__state) { }

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
	private sealed class <UnloadSceneCoroutine>d__41 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NetworkSceneManagerDefault <>4__this; //Field offset: 0x20
		public SceneRef sceneRef; //Field offset: 0x28
		private LoadingScope <>7__wrap1; //Field offset: 0x30
		private MultiPeerSceneRoot <root>5__3; //Field offset: 0x38

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
		public <UnloadSceneCoroutine>d__41(int <>1__state) { }

		private void <>m__Finally1() { }

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

	internal struct LoadingScope : IDisposable
	{
		private readonly NetworkSceneManagerDefault _manager; //Field offset: 0x0

		public LoadingScope(NetworkSceneManagerDefault manager) { }

		public override void Dispose() { }

	}

	internal sealed class MultiPeerSceneRoot : MonoBehaviour
	{
		public SceneRef SceneRef; //Field offset: 0x20
		public string ScenePath; //Field offset: 0x28
		public int SceneHandle; //Field offset: 0x30
		public Scene Scene; //Field offset: 0x34

		public MultiPeerSceneRoot() { }

	}

	private static Dictionary<Scene, NetworkSceneManagerDefault> _allOwnedScenes; //Field offset: 0x0
	[InlineHelp]
	[ToggleLeft]
	public bool IsSceneTakeOverEnabled; //Field offset: 0x20
	[InlineHelp]
	[ToggleLeft]
	public bool LogSceneLoadErrors; //Field offset: 0x21
	private List<MultiPeerSceneRoot> _multiPeerSceneRoots; //Field offset: 0x28
	private MultiPeerSceneRoot _multiPeerActiveRoot; //Field offset: 0x30
	private List<ICoroutine> _runningCoroutines; //Field offset: 0x38
	private Scene _tempUnloadScene; //Field offset: 0x40
	[CompilerGenerated]
	private Scene <MultiPeerScene>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private Transform <MultiPeerDontDestroyOnLoadRoot>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private NetworkRunner <Runner>k__BackingField; //Field offset: 0x50
	private bool _isLoading; //Field offset: 0x58

	public override bool IsBusy
	{
		 get { } //Length: 108
	}

	private bool IsMultiplePeer
	{
		private get { } //Length: 44
	}

	public override Scene MainRunnerScene
	{
		 get { } //Length: 112
	}

	public private Transform MultiPeerDontDestroyOnLoadRoot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Scene MultiPeerScene
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private NetworkRunner Runner
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static NetworkSceneManagerDefault() { }

	public NetworkSceneManagerDefault() { }

	[CompilerGenerated]
	private bool <Shutdown>b__25_0(KeyValuePair<Scene, NetworkSceneManagerDefault> x) { }

	[CompilerGenerated]
	private void <StartTracedCoroutine>b__45_0(IAsyncOperation x) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void ClearStatics() { }

	private NetworkSceneAsyncOp FailOp(SceneRef sceneRef, Exception exception) { }

	private Scene FindSceneToTakeOver(SceneRef sceneRef) { }

	public override bool get_IsBusy() { }

	private bool get_IsMultiplePeer() { }

	public override Scene get_MainRunnerScene() { }

	[CompilerGenerated]
	public Transform get_MultiPeerDontDestroyOnLoadRoot() { }

	[CompilerGenerated]
	public Scene get_MultiPeerScene() { }

	[CompilerGenerated]
	public NetworkRunner get_Runner() { }

	public override SceneRef GetSceneRef(GameObject gameObject) { }

	public override SceneRef GetSceneRef(string sceneNameOrPath) { }

	public override void Initialize(NetworkRunner runner) { }

	public override bool IsRunnerScene(Scene scene) { }

	public override NetworkSceneAsyncOp LoadScene(SceneRef sceneRef, NetworkLoadSceneParameters parameters) { }

	[IteratorStateMachine(typeof(<LoadSceneCoroutine>d__40))]
	protected override IEnumerator LoadSceneCoroutine(SceneRef sceneRef, NetworkLoadSceneParameters sceneParams) { }

	public override void MakeDontDestroyOnLoad(GameObject obj) { }

	protected LoadingScope MakeLoadingScope() { }

	protected void MarkSceneAsOwned(SceneRef sceneRef, Scene scene) { }

	public override bool MoveGameObjectToScene(GameObject gameObject, SceneRef sceneRef) { }

	protected override void OnLoadSceneProgress(SceneRef sceneRef, float progress) { }

	public override bool OnSceneInfoChanged(NetworkSceneInfo sceneInfo, NetworkSceneInfoChangeSource changeSource) { }

	[IteratorStateMachine(typeof(<OnSceneLoaded>d__42))]
	protected override IEnumerator OnSceneLoaded(SceneRef sceneRef, Scene scene, NetworkLoadSceneParameters sceneParams) { }

	[CompilerGenerated]
	private void set_MultiPeerDontDestroyOnLoadRoot(Transform value) { }

	[CompilerGenerated]
	private void set_MultiPeerScene(Scene value) { }

	[CompilerGenerated]
	private void set_Runner(NetworkRunner value) { }

	public override void Shutdown() { }

	private ICoroutine StartTracedCoroutine(IEnumerator inner) { }

	public override bool TryGetPhysicsScene2D(out PhysicsScene2D scene2D) { }

	public override bool TryGetPhysicsScene3D(out PhysicsScene scene3D) { }

	public override NetworkSceneAsyncOp UnloadScene(SceneRef sceneRef) { }

	[IteratorStateMachine(typeof(<UnloadSceneCoroutine>d__41))]
	protected override IEnumerator UnloadSceneCoroutine(SceneRef sceneRef) { }

}

