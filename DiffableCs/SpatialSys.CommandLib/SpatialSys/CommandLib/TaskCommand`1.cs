namespace SpatialSys.CommandLib;

public class TaskCommand : Command
{
	[CompilerGenerated]
	private struct <AwaitTask>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x0
		public TaskCommand<T> <>4__this; //Field offset: 0x0
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected TaskGenerator<T> _taskGenerator; //Field offset: 0x0
	private bool _isAsyncComplete; //Field offset: 0x0
	private bool _isAsyncError; //Field offset: 0x0
	private Exception _exc; //Field offset: 0x0
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x0
	private T _result; //Field offset: 0x0

	public T result
	{
		 get { } //Length: 8
	}

	public TaskCommand`1(string identifier, TaskGenerator<T> taskGenerator, Command parentCommand = null) { }

	public TaskCommand`1(TaskGenerator<T> taskGenerator, Command parentCommand = null) { }

	public TaskCommand`1(string identifier = null) { }

	[AsyncStateMachine(typeof(<AwaitTask>d__14))]
	private void AwaitTask() { }

	public virtual void Cancel() { }

	public T get_result() { }

	protected virtual void Start() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

