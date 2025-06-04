namespace AnimalCompany;

public static class NotificationCommands
{
	internal class DeleteNotificationsCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__2 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public DeleteNotificationsCommand <>4__this; //Field offset: 0x20

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
			public <ExecuteAsync>d__2(int <>1__state) { }

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

		private String[] _userIDs; //Field offset: 0x58

		public DeleteNotificationsCommand(String[] userIDs) { }

		[CompilerGenerated]
		private Task <ExecuteAsync>b__2_0(CancellationToken t) { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__2))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

	}


	public static Command DeleteNotifications(String[] userIDs) { }

}

