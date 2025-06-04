namespace SpatialSys.CommandLib;

public sealed class TaskGenerator : MulticastDelegate
{

	public TaskGenerator(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(CancellationToken token, AsyncCallback callback, object object) { }

	public override Task EndInvoke(IAsyncResult result) { }

	public override Task Invoke(CancellationToken token) { }

}

