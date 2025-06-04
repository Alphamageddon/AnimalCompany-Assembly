namespace Fusion.Async;

public static class TaskManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Action recurringAction; //Field offset: 0x10
		public Task<Boolean> result; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal Task<Boolean> <Service>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		private struct <<Service>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass6_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28
			private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public CancellationToken cancellationToken; //Field offset: 0x10
		public int interval; //Field offset: 0x18
		public Func<Task`1<Boolean>> recurringAction; //Field offset: 0x20

		public <>c__DisplayClass6_0() { }

		[AsyncStateMachine(typeof(<<Service>b__0>d))]
		internal Task <Service>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass7_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public CancellationToken cancellationToken; //Field offset: 0x10
		public Func<CancellationToken, Task> action; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task <Run>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		private struct <<ContinueWhenAll>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass8_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public CancellationToken cancellationToken; //Field offset: 0x10
		public Func<CancellationToken, Task> action; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		[AsyncStateMachine(typeof(<<ContinueWhenAll>b__0>d))]
		internal Task <ContinueWhenAll>b__0(Task[] tasks) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		private struct <<Delay>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass9_0 <>4__this; //Field offset: 0x20
			public CancellationToken cancelToken; //Field offset: 0x28
			private float <endTime>5__2; //Field offset: 0x30
			private YieldAwaiter <>u__1; //Field offset: 0x34

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public int delay; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		[AsyncStateMachine(typeof(<<Delay>b__0>d))]
		internal Task <Delay>b__0(CancellationToken cancelToken) { }

	}

	[CompilerGenerated]
	private static TaskFactory <TaskFactory>k__BackingField; //Field offset: 0x0

	private static TaskFactory TaskFactory
	{
		[CompilerGenerated]
		private get { } //Length: 88
		[CompilerGenerated]
		private set { } //Length: 92
	}

	private static TaskManager() { }

	public static Task ContinueWhenAll(Task[] precedingTasks, Func<CancellationToken, Task> action, CancellationToken cancellationToken) { }

	internal static Task Delay(int delay, CancellationToken token = null) { }

	[CompilerGenerated]
	private static TaskFactory get_TaskFactory() { }

	public static Task Run(Func<CancellationToken, Task> action, CancellationToken cancellationToken, TaskCreationOptions options = 0) { }

	public static Task Service(Action recurringAction, CancellationToken cancellationToken, int interval, string serviceName = null) { }

	public static Task Service(Func<Task`1<Boolean>> recurringAction, CancellationToken cancellationToken, int interval, string serviceName = null) { }

	[CompilerGenerated]
	private static void set_TaskFactory(TaskFactory value) { }

	[Conditional("FUSION_UNITY")]
	public static void Setup() { }

}

