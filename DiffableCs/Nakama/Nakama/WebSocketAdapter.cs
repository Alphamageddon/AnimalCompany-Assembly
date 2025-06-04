namespace Nakama;

public class WebSocketAdapter : ISocketAdapter
{
	[CompilerGenerated]
	private struct <CloseAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebSocketAdapter <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ConnectAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebSocketAdapter <>4__this; //Field offset: 0x20
		public Uri uri; //Field offset: 0x28
		public int timeout; //Field offset: 0x30
		private ConfiguredTaskAwaiter<WebSocket> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReceiveLoop>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken canceller; //Field offset: 0x20
		public WebSocketAdapter <>4__this; //Field offset: 0x28
		public WebSocket webSocket; //Field offset: 0x30
		private Byte[] <buffer>5__2; //Field offset: 0x38
		private int <bufferReadCount>5__3; //Field offset: 0x40
		private ConfiguredTaskAwaiter<WebSocketReceiveResult> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int KeepAliveIntervalSec = 15; //Field offset: 0x0
	private const int MaxMessageReadSize = 262144; //Field offset: 0x0
	private const int SendTimeoutSec = 10; //Field offset: 0x0
	[CompilerGenerated]
	private Action Connected; //Field offset: 0x10
	[CompilerGenerated]
	private Action Closed; //Field offset: 0x18
	[CompilerGenerated]
	private Action<Exception> ReceivedError; //Field offset: 0x20
	[CompilerGenerated]
	private Action<ArraySegment`1<Byte>> Received; //Field offset: 0x28
	private readonly int _maxMessageReadSize; //Field offset: 0x30
	private readonly WebSocketClientOptions _options; //Field offset: 0x38
	private readonly TimeSpan _sendTimeoutSec; //Field offset: 0x40
	private CancellationTokenSource _cancellationSource; //Field offset: 0x48
	private WebSocket _webSocket; //Field offset: 0x50
	private Uri _uri; //Field offset: 0x58
	private readonly ILogger _logger; //Field offset: 0x60

	public override event Action Closed
	{
		[CompilerGenerated]
		 add { } //Length: 156
		[CompilerGenerated]
		 remove { } //Length: 156
	}

	public override event Action Connected
	{
		[CompilerGenerated]
		 add { } //Length: 156
		[CompilerGenerated]
		 remove { } //Length: 156
	}

	public override event Action<ArraySegment`1<Byte>> Received
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<Exception> ReceivedError
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override bool IsConnected
	{
		 get { } //Length: 40
	}

	public override bool IsConnecting
	{
		 get { } //Length: 40
	}

	public WebSocketAdapter(WebSocketClientOptions options, int sendTimeoutSec, int maxMessageReadSize, ILogger logger) { }

	public WebSocketAdapter(int keepAliveIntervalSec = 15, int sendTimeoutSec = 10, int maxMessageReadSize = 262144, ILogger logger = null) { }

	[CompilerGenerated]
	private Task <ConnectAsync>b__29_0(object _) { }

	[CompilerGenerated]
	public override void add_Closed(Action value) { }

	[CompilerGenerated]
	public override void add_Connected(Action value) { }

	[CompilerGenerated]
	public override void add_Received(Action<ArraySegment`1<Byte>> value) { }

	[CompilerGenerated]
	public override void add_ReceivedError(Action<Exception> value) { }

	[AsyncStateMachine(typeof(<CloseAsync>d__28))]
	public override Task CloseAsync() { }

	[AsyncStateMachine(typeof(<ConnectAsync>d__29))]
	public override Task ConnectAsync(Uri uri, int timeout) { }

	public override bool get_IsConnected() { }

	public override bool get_IsConnecting() { }

	[AsyncStateMachine(typeof(<ReceiveLoop>d__32))]
	private Task ReceiveLoop(WebSocket webSocket, CancellationToken canceller) { }

	[CompilerGenerated]
	public override void remove_Closed(Action value) { }

	[CompilerGenerated]
	public override void remove_Connected(Action value) { }

	[CompilerGenerated]
	public override void remove_Received(Action<ArraySegment`1<Byte>> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedError(Action<Exception> value) { }

	public override Task SendAsync(ArraySegment<Byte> buffer, bool reliable = true, CancellationToken canceller = null) { }

	public virtual string ToString() { }

}

