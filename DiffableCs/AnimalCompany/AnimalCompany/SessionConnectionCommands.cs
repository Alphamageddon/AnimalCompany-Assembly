namespace AnimalCompany;

public class SessionConnectionCommands : MonoBehaviour
{
	internal class ConnectToSessionCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__8 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public ConnectToSessionCommand <>4__this; //Field offset: 0x20

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
			public <ExecuteAsync>d__8(int <>1__state) { }

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

		private NetworkRunner _runner; //Field offset: 0x58
		private INetworkSceneManager _sceneManager; //Field offset: 0x60
		private Byte[] _connectionToken; //Field offset: 0x68
		private int _netSceneIndex; //Field offset: 0x70
		private string _sessionCode; //Field offset: 0x78
		private bool _privateIfCreator; //Field offset: 0x80
		private SessionProperties _properties; //Field offset: 0x88

		public ConnectToSessionCommand(NetworkRunner runner, INetworkSceneManager sceneManager, Byte[] connectionToken, int netSceneIndex, string sessionCode = null, SessionProperties properties = null) { }

		[CompilerGenerated]
		private Task<StartGameResult> <ExecuteAsync>b__8_0(CancellationToken cancellationToken) { }

		public virtual void Cancel() { }

		private string CreateNewSessionCode() { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__8))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

		private Task<StartGameResult> StartGame(GameMode mode, string sessionCode, CancellationToken cancellationToken) { }

	}


	public SessionConnectionCommands() { }

}

