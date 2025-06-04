namespace SpatialSys.CommandLib;

public sealed class CommandConditionEval : MulticastDelegate
{

	public CommandConditionEval(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(float elapsedTime, AsyncCallback callback, object object) { }

	public override bool EndInvoke(IAsyncResult result) { }

	public override bool Invoke(float elapsedTime) { }

}

