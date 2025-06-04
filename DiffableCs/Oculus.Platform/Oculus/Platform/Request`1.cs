namespace Oculus.Platform;

public sealed class Request : Request
{
	private Callback<T> callback_; //Field offset: 0x0

	public Request`1(ulong requestID) { }

	public virtual void HandleMessage(Message msg) { }

	public Request<T> OnComplete(Callback<T> callback) { }

}

