namespace Fusion;

public sealed class RpcStaticInvokeDelegate : MulticastDelegate
{

	public RpcStaticInvokeDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(NetworkRunner runner, SimulationMessage* message, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(NetworkRunner runner, SimulationMessage* message) { }

}

