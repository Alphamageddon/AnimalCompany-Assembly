namespace Fusion;

public sealed class RpcInvokeDelegate : MulticastDelegate
{

	public RpcInvokeDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(NetworkBehaviour behaviour, SimulationMessage* message, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(NetworkBehaviour behaviour, SimulationMessage* message) { }

}

