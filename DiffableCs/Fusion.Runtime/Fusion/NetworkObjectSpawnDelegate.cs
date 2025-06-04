namespace Fusion;

public sealed class NetworkObjectSpawnDelegate : MulticastDelegate
{

	public NetworkObjectSpawnDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(NetworkSpawnOp result, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(NetworkSpawnOp result) { }

}

