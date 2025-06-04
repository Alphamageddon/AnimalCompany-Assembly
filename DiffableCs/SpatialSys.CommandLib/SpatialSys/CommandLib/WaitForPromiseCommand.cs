namespace SpatialSys.CommandLib;

public class WaitForPromiseCommand : Command
{
	private IPromise _promise; //Field offset: 0x38
	private bool _promiseCompleted; //Field offset: 0x40
	private Exception _exc; //Field offset: 0x48
	private bool _abortOnReject; //Field offset: 0x50

	public WaitForPromiseCommand(IPromise promise, bool abortOnReject = false) { }

	public WaitForPromiseCommand(string identifier, IPromise promise, bool abortOnReject = false) { }

	[CompilerGenerated]
	private void <.ctor>b__5_0() { }

	[CompilerGenerated]
	private void <.ctor>b__5_1(Exception exc) { }

	public virtual string ToString() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

