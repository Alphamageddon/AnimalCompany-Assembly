namespace Nakama.Ninja.WebSockets;

public class WebSocketServerFactory : IWebSocketServerFactory
{
	[CompilerGenerated]
	private struct <AcceptWebSocketAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocket> <>t__builder; //Field offset: 0x8
		public WebSocketServerFactory <>4__this; //Field offset: 0x20
		public WebSocketHttpContext context; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private TaskAwaiter<WebSocket> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AcceptWebSocketAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocket> <>t__builder; //Field offset: 0x8
		public WebSocketHttpContext context; //Field offset: 0x20
		public WebSocketServerOptions options; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		public WebSocketServerFactory <>4__this; //Field offset: 0x38
		private Guid <guid>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PerformHandshakeAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string httpHeader; //Field offset: 0x20
		public string subProtocol; //Field offset: 0x28
		public Stream stream; //Field offset: 0x30
		public CancellationToken token; //Field offset: 0x38
		private object <>7__wrap1; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadHttpHeaderFromStreamAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocketHttpContext> <>t__builder; //Field offset: 0x8
		public Stream stream; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Func<MemoryStream> _bufferFactory; //Field offset: 0x10
	private readonly IBufferPool _bufferPool; //Field offset: 0x18

	public WebSocketServerFactory() { }

	public WebSocketServerFactory(Func<MemoryStream> bufferFactory) { }

	[AsyncStateMachine(typeof(<AcceptWebSocketAsync>d__5))]
	public override Task<WebSocket> AcceptWebSocketAsync(WebSocketHttpContext context, CancellationToken token = null) { }

	[AsyncStateMachine(typeof(<AcceptWebSocketAsync>d__6))]
	public override Task<WebSocket> AcceptWebSocketAsync(WebSocketHttpContext context, WebSocketServerOptions options, CancellationToken token = null) { }

	private static void CheckWebSocketVersion(string httpHeader) { }

	[AsyncStateMachine(typeof(<PerformHandshakeAsync>d__8))]
	private static Task PerformHandshakeAsync(Guid guid, string httpHeader, string subProtocol, Stream stream, CancellationToken token) { }

	[AsyncStateMachine(typeof(<ReadHttpHeaderFromStreamAsync>d__4))]
	public override Task<WebSocketHttpContext> ReadHttpHeaderFromStreamAsync(Stream stream, CancellationToken token = null) { }

}

