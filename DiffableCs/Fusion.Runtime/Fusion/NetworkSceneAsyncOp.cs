namespace Fusion;

[IsReadOnly]
public struct NetworkSceneAsyncOp : IEnumerator
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public Action<NetworkSceneAsyncOp> action; //Field offset: 0x10
		public NetworkSceneAsyncOp captured; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <AddOnCompleted>b__0(AsyncOperation _) { }

		internal void <AddOnCompleted>b__1(IAsyncOperation _) { }

		internal void <AddOnCompleted>b__2(Task _) { }

	}

	[CompilerGenerated]
	private struct <CreateDeferredOpTask>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task blockingTask; //Field offset: 0x20
		public Func<SceneRef, NetworkSceneAsyncOp> op; //Field offset: 0x28
		public SceneRef sceneRef; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private Awaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct Awaiter : INotifyCompletion
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public Action continuation; //Field offset: 0x10
			public SendOrPostCallback <>9__1; //Field offset: 0x18

			public <>c__DisplayClass5_0() { }

			internal void <OnCompleted>b__1(object __) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_1
		{
			public SynchronizationContext capturedContext; //Field offset: 0x10
			public <>c__DisplayClass5_0 CS$<>8__locals1; //Field offset: 0x18

			public <>c__DisplayClass5_1() { }

			internal void <OnCompleted>b__0(NetworkSceneAsyncOp _) { }

		}

		private NetworkSceneAsyncOp _op; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 4
		}

		public Awaiter(in NetworkSceneAsyncOp op) { }

		public bool get_IsCompleted() { }

		public void GetResult() { }

		public override void OnCompleted(Action continuation) { }

	}

	public readonly SceneRef SceneRef; //Field offset: 0x0
	private readonly object _data; //Field offset: 0x8

	public Exception Error
	{
		 get { } //Length: 360
	}

	public bool IsDone
	{
		 get { } //Length: 444
	}

	public bool IsValid
	{
		 get { } //Length: 16
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 8
	}

	private NetworkSceneAsyncOp(SceneRef sceneRef, object data) { }

	private NetworkSceneAsyncOp(SceneRef sceneRef) { }

	public void AddOnCompleted(Action<NetworkSceneAsyncOp> action) { }

	[AsyncStateMachine(typeof(<CreateDeferredOpTask>d__17))]
	private static Task CreateDeferredOpTask(SceneRef sceneRef, Task blockingTask, Func<SceneRef, NetworkSceneAsyncOp> op) { }

	public static NetworkSceneAsyncOp FromAsyncOperation(SceneRef sceneRef, AsyncOperation asyncOp) { }

	public static NetworkSceneAsyncOp FromCompleted(SceneRef sceneRef) { }

	public static NetworkSceneAsyncOp FromCoroutine(SceneRef sceneRef, ICoroutine coroutine) { }

	internal static NetworkSceneAsyncOp FromDeferred(SceneRef sceneRef, Task blockingTask, Func<SceneRef, NetworkSceneAsyncOp> op) { }

	public static NetworkSceneAsyncOp FromError(SceneRef sceneRef, Exception error) { }

	public static NetworkSceneAsyncOp FromTask(SceneRef sceneRef, Task task) { }

	public Exception get_Error() { }

	public bool get_IsDone() { }

	public bool get_IsValid() { }

	public Awaiter GetAwaiter() { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

	internal void ThrowIfError() { }

}

