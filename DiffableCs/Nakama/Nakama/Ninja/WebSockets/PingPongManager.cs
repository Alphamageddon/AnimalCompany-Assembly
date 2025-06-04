namespace Nakama.Ninja.WebSockets;

public class PingPongManager : IPingPongManager
{
	[CompilerGenerated]
	private struct <PingForever>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PingPongManager <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendPing>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PingPongManager <>4__this; //Field offset: 0x20
		public ArraySegment<Byte> payload; //Field offset: 0x28
		public CancellationToken cancellation; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly WebSocketImplementation _webSocket; //Field offset: 0x10
	private readonly Guid _guid; //Field offset: 0x18
	private readonly TimeSpan _keepAliveInterval; //Field offset: 0x28
	private readonly Task _pingTask; //Field offset: 0x30
	private readonly CancellationToken _cancellationToken; //Field offset: 0x38
	private Stopwatch _stopwatch; //Field offset: 0x40
	private long _pingSentTicks; //Field offset: 0x48
	[CompilerGenerated]
	private EventHandler<PongEventArgs> Pong; //Field offset: 0x50

	public override event EventHandler<PongEventArgs> Pong
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public PingPongManager(Guid guid, WebSocket webSocket, TimeSpan keepAliveInterval, CancellationToken cancellationToken) { }

	[CompilerGenerated]
	public override void add_Pong(EventHandler<PongEventArgs> value) { }

	protected override void OnPong(PongEventArgs e) { }

	[AsyncStateMachine(typeof(<PingForever>d__13))]
	private Task PingForever() { }

	[CompilerGenerated]
	public override void remove_Pong(EventHandler<PongEventArgs> value) { }

	[AsyncStateMachine(typeof(<SendPing>d__11))]
	public override Task SendPing(ArraySegment<Byte> payload, CancellationToken cancellation) { }

	private void WebSocketImpl_Pong(object sender, PongEventArgs e) { }

}

