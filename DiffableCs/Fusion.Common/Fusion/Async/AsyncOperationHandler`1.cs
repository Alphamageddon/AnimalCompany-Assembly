namespace Fusion.Async;

internal class AsyncOperationHandler
{
	private const float OperationTimeoutSec = 30; //Field offset: 0x0
	private readonly TaskCompletionSource<T> _result; //Field offset: 0x0
	private readonly CancellationTokenSource _cancellation; //Field offset: 0x0
	private readonly string _customTimeoutMsg; //Field offset: 0x0

	public Task<T> Task
	{
		 get { } //Length: 28
	}

	public AsyncOperationHandler`1(CancellationToken externalCancellationToken = null, float operationTimeout = 30, string customTimeoutMsg = null) { }

	private void Cancel() { }

	private void Expire() { }

	public Task<T> get_Task() { }

	public void SetException(Exception e) { }

	public void SetResult(T result) { }

}

