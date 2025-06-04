namespace AnimalCompany;

public class FriendsManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TaskGenerator<IApiFriendList> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Task<IApiFriendList> <FetchFriendsData>b__6_0(CancellationToken t) { }

	}

	[CompilerGenerated]
	private sealed class <FetchFriendsData>d__6 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		private TaskCommand<IApiFriendList> <fetchCommand>5__2; //Field offset: 0x20

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
		public <FetchFriendsData>d__6(int <>1__state) { }

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

	public FriendsManager() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<FetchFriendsData>d__6))]
	private IEnumerator<Command> FetchFriendsData() { }

	private ISocket get_socket() { }

	private void HandleFriendsChanged(StateChangedEventArgs args) { }

	private void HandleNotificationsChanged(StateChangedEventArgs args) { }

	private void HandleReceivedStatusPresence(IStatusPresenceEvent e) { }

	private void HandleRoomCodeChanged(StateChangedEventArgs args) { }

	private void HandleSocketConnected(StateChangedEventArgs args) { }

	private void OnDestroy() { }

}

