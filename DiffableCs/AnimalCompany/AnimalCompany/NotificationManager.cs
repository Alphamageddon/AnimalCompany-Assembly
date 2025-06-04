namespace AnimalCompany;

public class NotificationManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TaskGenerator<IApiNotificationList> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Task<IApiNotificationList> <FetchNotifications>b__5_0(CancellationToken t) { }

	}

	[CompilerGenerated]
	private sealed class <FetchNotifications>d__5 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		private TaskCommand<IApiNotificationList> <fetchCommand>5__2; //Field offset: 0x20

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
		public <FetchNotifications>d__5(int <>1__state) { }

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


	private ISocket socket
	{
		private get { } //Length: 136
	}

	public NotificationManager() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<FetchNotifications>d__5))]
	private IEnumerator<Command> FetchNotifications() { }

	private ISocket get_socket() { }

	private void HandleReceivedNotification(IApiNotification notification) { }

	private void HandleSocketConnected(StateChangedEventArgs args) { }

	private void OnDestroy() { }

}

