namespace System.Threading.Tasks;

public class TaskFactory
{
	private sealed class CompleteOnCountdownPromise : Task<Task[]>, ITaskCompletionAction
	{
		private readonly Task[] _tasks; //Field offset: 0x58
		private int _count; //Field offset: 0x60

		public override bool InvokeMayRunArbitraryCode
		{
			 get { } //Length: 8
		}

		internal virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			internal get { } //Length: 116
		}

		internal CompleteOnCountdownPromise(Task[] tasksCopy) { }

		public override bool get_InvokeMayRunArbitraryCode() { }

		internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

		public override void Invoke(Task completingTask) { }

	}

	public sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
	{
		private IList<Task> _tasks; //Field offset: 0x58

		public override bool InvokeMayRunArbitraryCode
		{
			 get { } //Length: 8
		}

		public CompleteOnInvokePromise(IList<Task> tasks) { }

		public override bool get_InvokeMayRunArbitraryCode() { }

		public override void Invoke(Task completingTask) { }

	}

	private readonly CancellationToken m_defaultCancellationToken; //Field offset: 0x10
	private readonly TaskScheduler m_defaultScheduler; //Field offset: 0x18
	private readonly TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x20
	private readonly TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x24

	public TaskContinuationOptions ContinuationOptions
	{
		 get { } //Length: 8
	}

	public TaskCreationOptions CreationOptions
	{
		 get { } //Length: 8
	}

	public TaskScheduler Scheduler
	{
		 get { } //Length: 8
	}

	public TaskFactory() { }

	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	internal static Task[] CheckMultiContinuationTasksAndCopy(Task[] tasks) { }

	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }

	internal static Task<Task[]> CommonCWAllLogic(Task[] tasksCopy) { }

	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	public Task FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state) { }

	public Task FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }

	public Task FromAsync(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }

	public Task FromAsync(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }

	public TaskContinuationOptions get_ContinuationOptions() { }

	public TaskCreationOptions get_CreationOptions() { }

	public TaskScheduler get_Scheduler() { }

	private TaskScheduler GetDefaultScheduler(Task currTask) { }

	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	public Task StartNew(Action<Object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	public Task<TResult> StartNew(Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	public Task<TResult> StartNew(Func<Object, TResult> function, object state, CancellationToken cancellationToken) { }

}

