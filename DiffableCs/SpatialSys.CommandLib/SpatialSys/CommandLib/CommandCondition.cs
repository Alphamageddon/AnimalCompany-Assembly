namespace SpatialSys.CommandLib;

public sealed class CommandCondition : MulticastDelegate
{

	public CommandCondition(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public override bool EndInvoke(IAsyncResult result) { }

	public override bool Invoke() { }

}

