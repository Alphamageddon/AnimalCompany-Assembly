namespace Satori;

public sealed class TransientExceptionDelegate : MulticastDelegate
{

	public TransientExceptionDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(Exception e, AsyncCallback callback, object object) { }

	public override bool EndInvoke(IAsyncResult result) { }

	public override bool Invoke(Exception e) { }

}

