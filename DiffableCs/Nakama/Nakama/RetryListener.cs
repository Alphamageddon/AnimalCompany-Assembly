namespace Nakama;

public sealed class RetryListener : MulticastDelegate
{

	public RetryListener(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(int numRetry, Retry retry, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(int numRetry, Retry retry) { }

}

