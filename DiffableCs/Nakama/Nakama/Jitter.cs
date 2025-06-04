namespace Nakama;

public sealed class Jitter : MulticastDelegate
{

	public Jitter(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(IList<Retry> retryHistory, int retryDelay, Random random, AsyncCallback callback, object object) { }

	public override int EndInvoke(IAsyncResult result) { }

	public override int Invoke(IList<Retry> retryHistory, int retryDelay, Random random) { }

}

