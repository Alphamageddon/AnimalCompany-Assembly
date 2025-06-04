namespace SpatialSys.CommandLib;

public class CoroutineCommand : Command
{
	[CompilerGenerated]
	private sealed class <get__childCommands>d__5 : IEnumerable<Command>, IEnumerable, IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CoroutineCommand <>4__this; //Field offset: 0x28

		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <get__childCommands>d__5(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Command> System.Collections.Generic.IEnumerable<SpatialSys.CommandLib.Command>.GetEnumerator() { }

		[DebuggerHidden]
		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	protected CoroutineGenerator _coroutineGenerator; //Field offset: 0x38
	private IEnumerator<Command> _execCoroutine; //Field offset: 0x40
	private Command _currInnerCommand; //Field offset: 0x48
	private bool _startedThisFrame; //Field offset: 0x50

	internal virtual IEnumerable<Command> _childCommands
	{
		[IteratorStateMachine(typeof(<get__childCommands>d__5))]
		internal get { } //Length: 112
	}

	public CoroutineCommand(string identifier) { }

	public CoroutineCommand(CoroutineGenerator coroutineGenerator) { }

	public CoroutineCommand(string identifier, CoroutineGenerator coroutineGenerator) { }

	public virtual void Cancel() { }

	protected override void CheckShouldContinue() { }

	[IteratorStateMachine(typeof(<get__childCommands>d__5))]
	internal virtual IEnumerable<Command> get__childCommands() { }

	protected virtual void Start() { }

	public virtual string ToString() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

