namespace AnimalCompany;

public class PollBootstrapCommand : CustomCoroutineCommand
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public ApiBootstrapRequest req; //Field offset: 0x10
		public TaskGenerator<ClientBootstrapResponse> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass1_0() { }

		internal Task<ClientBootstrapResponse> <ExecuteAsync>b__0(CancellationToken token) { }

	}

	[CompilerGenerated]
	private sealed class <ExecuteAsync>d__1 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		private <>c__DisplayClass1_0 <>8__1; //Field offset: 0x20
		private TaskCommand<ClientBootstrapResponse> <bootstrapRequestCmd>5__2; //Field offset: 0x28

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
		public <ExecuteAsync>d__1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const int POLL_INTERVAL_SECONDS = 300; //Field offset: 0x0

	public PollBootstrapCommand() { }

	[IteratorStateMachine(typeof(<ExecuteAsync>d__1))]
	public virtual IEnumerator<Command> ExecuteAsync() { }

}

