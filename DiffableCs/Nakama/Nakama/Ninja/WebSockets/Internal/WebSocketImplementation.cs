namespace Nakama.Ninja.WebSockets.Internal;

internal class WebSocketImplementation : WebSocket
{
	[CompilerGenerated]
	private struct <CloseAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebSocketImplementation <>4__this; //Field offset: 0x20
		public WebSocketCloseStatus closeStatus; //Field offset: 0x28
		public string statusDescription; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private MemoryStream <stream>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseOutputAsync>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebSocketImplementation <>4__this; //Field offset: 0x20
		public WebSocketCloseStatus closeStatus; //Field offset: 0x28
		public string statusDescription; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private MemoryStream <stream>5__2; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseOutputAutoTimeoutAsync>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebSocketImplementation <>4__this; //Field offset: 0x20
		public string statusDescription; //Field offset: 0x28
		public Exception ex; //Field offset: 0x30
		public WebSocketCloseStatus closeStatus; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReceiveAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocketReceiveResult> <>t__builder; //Field offset: 0x8
		public WebSocketImplementation <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public ArraySegment<Byte> buffer; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x40
		private CancellationTokenSource <linkedCts>5__3; //Field offset: 0x48
		private WebSocketFrame <frame>5__4; //Field offset: 0x50
		private object <>7__wrap4; //Field offset: 0x58
		private int <>7__wrap5; //Field offset: 0x60
		private TaskAwaiter<WebSocketReadCursor> <>u__1; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70
		private Exception <ex>5__7; //Field offset: 0x78
		private TaskAwaiter<WebSocketReceiveResult> <>u__3; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RespondToCloseFrame>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocketReceiveResult> <>t__builder; //Field offset: 0x8
		public WebSocketImplementation <>4__this; //Field offset: 0x20
		public WebSocketFrame frame; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private MemoryStream <stream>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebSocketImplementation <>4__this; //Field offset: 0x20
		public WebSocketMessageType messageType; //Field offset: 0x28
		public ArraySegment<Byte> buffer; //Field offset: 0x30
		public bool endOfMessage; //Field offset: 0x40
		public CancellationToken cancellationToken; //Field offset: 0x48
		private MemoryStream <stream>5__2; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendPingAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArraySegment<Byte> payload; //Field offset: 0x20
		public WebSocketImplementation <>4__this; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private MemoryStream <stream>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendPongAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArraySegment<Byte> payload; //Field offset: 0x20
		public WebSocketImplementation <>4__this; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private Exception <ex>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private object <>7__wrap2; //Field offset: 0x50
		private int <>7__wrap3; //Field offset: 0x58
		private MemoryStream <stream>5__5; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteStreamToNetwork>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebSocketImplementation <>4__this; //Field offset: 0x20
		public MemoryStream stream; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ArraySegment<Byte> <buffer>5__2; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int MAX_PING_PONG_PAYLOAD_LEN = 125; //Field offset: 0x0
	private readonly Guid _guid; //Field offset: 0x10
	private readonly Func<MemoryStream> _recycledStreamFactory; //Field offset: 0x20
	private readonly Stream _stream; //Field offset: 0x28
	private readonly bool _includeExceptionInCloseResponse; //Field offset: 0x30
	private readonly bool _isClient; //Field offset: 0x31
	private readonly string _subProtocol; //Field offset: 0x38
	private CancellationTokenSource _internalReadCts; //Field offset: 0x40
	private WebSocketState _state; //Field offset: 0x48
	private readonly IPingPongManager _pingPongManager; //Field offset: 0x50
	private bool _isContinuationFrame; //Field offset: 0x58
	private WebSocketMessageType _continuationFrameMessageType; //Field offset: 0x5C
	private WebSocketReadCursor _readCursor; //Field offset: 0x60
	private readonly bool _usePerMessageDeflate; //Field offset: 0x68
	private bool _tryGetBufferFailureLogged; //Field offset: 0x69
	private Nullable<WebSocketCloseStatus> _closeStatus; //Field offset: 0x6C
	private string _closeStatusDescription; //Field offset: 0x78
	private readonly SemaphoreSlim _semaphore; //Field offset: 0x80
	[CompilerGenerated]
	private EventHandler<PongEventArgs> Pong; //Field offset: 0x88
	[CompilerGenerated]
	private TimeSpan <KeepAliveInterval>k__BackingField; //Field offset: 0x90

	public event EventHandler<PongEventArgs> Pong
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public virtual Nullable<WebSocketCloseStatus> CloseStatus
	{
		 get { } //Length: 8
	}

	public virtual string CloseStatusDescription
	{
		 get { } //Length: 8
	}

	public private TimeSpan KeepAliveInterval
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public virtual WebSocketState State
	{
		 get { } //Length: 8
	}

	public virtual string SubProtocol
	{
		 get { } //Length: 8
	}

	internal WebSocketImplementation(Guid guid, Func<MemoryStream> recycledStreamFactory, Stream stream, TimeSpan keepAliveInterval, string secWebSocketExtensions, bool includeExceptionInCloseResponse, bool isClient, string subProtocol) { }

	public virtual void Abort() { }

	[CompilerGenerated]
	public void add_Pong(EventHandler<PongEventArgs> value) { }

	private ArraySegment<Byte> BuildClosePayload(WebSocketCloseStatus closeStatus, string statusDescription) { }

	[AsyncStateMachine(typeof(<CloseAsync>d__38))]
	public virtual Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<CloseOutputAsync>d__39))]
	public virtual Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<CloseOutputAutoTimeoutAsync>d__48))]
	private Task CloseOutputAutoTimeoutAsync(WebSocketCloseStatus closeStatus, string statusDescription, Exception ex) { }

	public virtual void Dispose() { }

	public virtual Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	public virtual string get_CloseStatusDescription() { }

	[CompilerGenerated]
	public TimeSpan get_KeepAliveInterval() { }

	public virtual WebSocketState get_State() { }

	public virtual string get_SubProtocol() { }

	private ArraySegment<Byte> GetBuffer(MemoryStream stream) { }

	private WebSocketOpCode GetOppCode(WebSocketMessageType messageType) { }

	protected override void OnPong(PongEventArgs e) { }

	[AsyncStateMachine(typeof(<ReceiveAsync>d__34))]
	public virtual Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<Byte> buffer, CancellationToken cancellationToken) { }

	[CompilerGenerated]
	public void remove_Pong(EventHandler<PongEventArgs> value) { }

	[AsyncStateMachine(typeof(<RespondToCloseFrame>d__44))]
	private Task<WebSocketReceiveResult> RespondToCloseFrame(WebSocketFrame frame, ArraySegment<Byte> buffer, CancellationToken token) { }

	[AsyncStateMachine(typeof(<SendAsync>d__35))]
	public virtual Task SendAsync(ArraySegment<Byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<SendPingAsync>d__36))]
	public Task SendPingAsync(ArraySegment<Byte> payload, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<SendPongAsync>d__43))]
	private Task SendPongAsync(ArraySegment<Byte> payload, CancellationToken cancellationToken) { }

	[CompilerGenerated]
	private void set_KeepAliveInterval(TimeSpan value) { }

	[AsyncStateMachine(typeof(<WriteStreamToNetwork>d__46))]
	private Task WriteStreamToNetwork(MemoryStream stream, CancellationToken cancellationToken) { }

}

