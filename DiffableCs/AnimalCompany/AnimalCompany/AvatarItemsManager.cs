namespace AnimalCompany;

public class AvatarItemsManager : MonoBehaviour
{
	private class FetchItemsCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static TaskGenerator<ApiAvatarItem[]> <>9__0_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal Task<ApiAvatarItem[]> <ExecuteAsync>b__0_0(CancellationToken token) { }

		}

		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__0 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public FetchItemsCommand <>4__this; //Field offset: 0x20
			private int <delay>5__2; //Field offset: 0x28
			private TaskCommand<ApiAvatarItem[]> <getItemsCmd>5__3; //Field offset: 0x30

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
			public <ExecuteAsync>d__0(int <>1__state) { }

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


		public FetchItemsCommand() { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__0))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

	}

	private CommandHandle _fetchCommandHandle; //Field offset: 0x20

	public AvatarItemsManager() { }

	private void Awake() { }

	private void OnDestroy() { }

}

