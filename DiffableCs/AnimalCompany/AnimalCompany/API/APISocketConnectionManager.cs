namespace AnimalCompany.API;

public class APISocketConnectionManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public float delay; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <Reconnect>b__1(float elapsed) { }

	}

	[CompilerGenerated]
	private sealed class <Reconnect>d__11 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public APISocketConnectionManager <>4__this; //Field offset: 0x20
		private int <retryCount>5__2; //Field offset: 0x28

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
		public <Reconnect>d__11(int <>1__state) { }

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

	private static APISocketConnectionManager _instance; //Field offset: 0x0
	private CommandHandle _retryCmdHandle; //Field offset: 0x20

	private ISocket socket
	{
		private get { } //Length: 136
	}

	public APISocketConnectionManager() { }

	[CompilerGenerated]
	private bool <Reconnect>b__11_0(float _) { }

	private void Awake() { }

	private ISocket get_socket() { }

	private void HandleAPISocketClosed() { }

	private void HandleAPISocketConnected() { }

	private void HandleAPISocketError(Exception error) { }

	private void HandleUserLoggedInChanged(StateChangedEventArgs args) { }

	private void OnDestroy() { }

	[IteratorStateMachine(typeof(<Reconnect>d__11))]
	private IEnumerator<Command> Reconnect() { }

	private void ReconnectIfNeeded() { }

}

