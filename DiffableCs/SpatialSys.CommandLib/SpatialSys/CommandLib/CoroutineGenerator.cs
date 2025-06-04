namespace SpatialSys.CommandLib;

public sealed class CoroutineGenerator : MulticastDelegate
{

	public CoroutineGenerator(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public override IEnumerator<Command> EndInvoke(IAsyncResult result) { }

	public override IEnumerator<Command> Invoke() { }

}

