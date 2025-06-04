namespace Nakama.Ninja.WebSockets;

public class WebSocketClientFactory : IWebSocketClientFactory
{
	[CompilerGenerated]
	private struct <ConnectAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocket> <>t__builder; //Field offset: 0x8
		public WebSocketClientFactory <>4__this; //Field offset: 0x20
		public Uri uri; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private TaskAwaiter<WebSocket> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ConnectAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocket> <>t__builder; //Field offset: 0x8
		public Uri uri; //Field offset: 0x20
		public WebSocketClientFactory <>4__this; //Field offset: 0x28
		public WebSocketClientOptions options; //Field offset: 0x30
		public CancellationToken token; //Field offset: 0x38
		private Guid <guid>5__2; //Field offset: 0x40
		private TaskAwaiter<Stream> <>u__1; //Field offset: 0x50
		private TaskAwaiter<WebSocket> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ConnectAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocket> <>t__builder; //Field offset: 0x8
		public WebSocketClientFactory <>4__this; //Field offset: 0x20
		public Stream responseStream; //Field offset: 0x28
		public string secWebSocketKey; //Field offset: 0x30
		public WebSocketClientOptions options; //Field offset: 0x38
		public CancellationToken token; //Field offset: 0x40
		private TaskAwaiter<WebSocket> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ConnectAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocket> <>t__builder; //Field offset: 0x8
		public Stream responseStream; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public WebSocketClientFactory <>4__this; //Field offset: 0x30
		public Guid guid; //Field offset: 0x38
		public string secWebSocketKey; //Field offset: 0x48
		public TimeSpan keepAliveInterval; //Field offset: 0x50
		public string secWebSocketExtensions; //Field offset: 0x58
		public bool includeExceptionInCloseResponse; //Field offset: 0x60
		private TaskAwaiter<String> <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetStream>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Stream> <>t__builder; //Field offset: 0x8
		public bool noDelay; //Field offset: 0x20
		public string host; //Field offset: 0x28
		public int port; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		public bool isSecure; //Field offset: 0x40
		public WebSocketClientFactory <>4__this; //Field offset: 0x48
		private TcpClient <tcpClient>5__2; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PerformHandshake>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocket> <>t__builder; //Field offset: 0x8
		public WebSocketClientOptions options; //Field offset: 0x20
		public Uri uri; //Field offset: 0x28
		public Stream stream; //Field offset: 0x30
		public WebSocketClientFactory <>4__this; //Field offset: 0x38
		public CancellationToken token; //Field offset: 0x40
		private TaskAwaiter<WebSocket> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Func<MemoryStream> _bufferFactory; //Field offset: 0x10
	private readonly IBufferPool _bufferPool; //Field offset: 0x18

	public WebSocketClientFactory() { }

	public WebSocketClientFactory(Func<MemoryStream> bufferFactory) { }

	[AsyncStateMachine(typeof(<ConnectAsync>d__4))]
	public override Task<WebSocket> ConnectAsync(Uri uri, CancellationToken token = null) { }

	[AsyncStateMachine(typeof(<ConnectAsync>d__5))]
	public override Task<WebSocket> ConnectAsync(Uri uri, WebSocketClientOptions options, CancellationToken token = null) { }

	[AsyncStateMachine(typeof(<ConnectAsync>d__6))]
	public override Task<WebSocket> ConnectAsync(Stream responseStream, string secWebSocketKey, WebSocketClientOptions options, CancellationToken token = null) { }

	[AsyncStateMachine(typeof(<ConnectAsync>d__7))]
	private Task<WebSocket> ConnectAsync(Guid guid, Stream responseStream, string secWebSocketKey, TimeSpan keepAliveInterval, string secWebSocketExtensions, bool includeExceptionInCloseResponse, CancellationToken token) { }

	private static string GetAdditionalHeaders(Dictionary<String, String> additionalHeaders) { }

	[AsyncStateMachine(typeof(<GetStream>d__12))]
	protected override Task<Stream> GetStream(Guid loggingGuid, bool isSecure, bool noDelay, string host, int port, CancellationToken cancellationToken) { }

	private string GetSubProtocolFromHeader(string response) { }

	[AsyncStateMachine(typeof(<PerformHandshake>d__15))]
	private Task<WebSocket> PerformHandshake(Guid guid, Uri uri, Stream stream, WebSocketClientOptions options, CancellationToken token) { }

	private void ThrowIfInvalidAcceptString(Guid guid, string response, string secWebSocketKey) { }

	private void ThrowIfInvalidResponseCode(string responseHeader) { }

	protected override void TlsAuthenticateAsClient(SslStream sslStream, string host) { }

	private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

