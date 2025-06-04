namespace SpatialSys.CommandLib;

public class TaskCommand : Command
{
	[CompilerGenerated]
	private struct <AwaitTask>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TaskCommand <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected TaskGenerator _taskGenerator; //Field offset: 0x38
	private bool _isAsyncComplete; //Field offset: 0x40
	private bool _isAsyncError; //Field offset: 0x41
	private Exception _exc; //Field offset: 0x48
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x50

	public TaskCommand(string identifier, TaskGenerator taskGenerator, Command parentCommand = null) { }

	public TaskCommand(TaskGenerator taskGenerator, Command parentCommand = null) { }

	public TaskCommand(string identifier = null) { }

	[AsyncStateMachine(typeof(<AwaitTask>d__11))]
	private void AwaitTask() { }

	public virtual void Cancel() { }

	protected virtual void Start() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

