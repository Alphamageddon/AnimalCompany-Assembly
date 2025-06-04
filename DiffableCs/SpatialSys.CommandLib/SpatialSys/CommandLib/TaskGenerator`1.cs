namespace SpatialSys.CommandLib;

public sealed class TaskGenerator : MulticastDelegate
{

	public TaskGenerator`1(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(CancellationToken token, AsyncCallback callback, object object) { }

	public override Task<T> EndInvoke(IAsyncResult result) { }

	public override Task<T> Invoke(CancellationToken token) { }

}

