namespace Nakama;

internal class RetryInvoker
{
	[CompilerGenerated]
	private struct <InvokeWithRetry>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public Func<Task`1<T>> request; //Field offset: 0x0
		public RetryHistory history; //Field offset: 0x0
		public RetryInvoker <>4__this; //Field offset: 0x0
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InvokeWithRetry>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Func<Task> request; //Field offset: 0x20
		public RetryHistory history; //Field offset: 0x28
		public RetryInvoker <>4__this; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly TransientExceptionDelegate _del; //Field offset: 0x10

	public RetryInvoker(TransientExceptionDelegate del) { }

	private Task Backoff(RetryHistory history, Exception e) { }

	private Retry CreateNewRetry(RetryHistory history) { }

	[AsyncStateMachine(typeof(<InvokeWithRetry>d__2`1))]
	public Task<T> InvokeWithRetry(Func<Task`1<T>> request, RetryHistory history) { }

	[AsyncStateMachine(typeof(<InvokeWithRetry>d__3))]
	public Task InvokeWithRetry(Func<Task> request, RetryHistory history) { }

}

