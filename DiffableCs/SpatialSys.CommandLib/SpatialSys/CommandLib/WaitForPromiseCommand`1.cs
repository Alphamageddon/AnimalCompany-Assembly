namespace SpatialSys.CommandLib;

public class WaitForPromiseCommand : Command
{
	private IPromise<T> _promise; //Field offset: 0x0
	private bool _promiseCompleted; //Field offset: 0x0
	private Exception _exc; //Field offset: 0x0
	private bool _abortOnReject; //Field offset: 0x0

	public WaitForPromiseCommand`1(IPromise<T> promise, bool abortOnReject = false) { }

	public WaitForPromiseCommand`1(string identifier, IPromise<T> promise, bool abortOnReject = false) { }

	[CompilerGenerated]
	private void <.ctor>b__5_0() { }

	[CompilerGenerated]
	private void <.ctor>b__5_1(Exception exc) { }

	public virtual string ToString() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

