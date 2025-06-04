namespace System.Net.WebSockets;

internal sealed class ManagedWebSocket : WebSocket
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Object> <>9__36_0; //Field offset: 0x8
		public static TimerCallback <>9__36_1; //Field offset: 0x10
		public static Action<Object> <>9__56_0; //Field offset: 0x18
		public static Action<Task> <>9__58_0; //Field offset: 0x20
		public static Action<Object> <>9__63_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__36_0(object s) { }

		internal void <.ctor>b__36_1(object s) { }

		internal void <SendFrameFallbackAsync>b__56_0(object s) { }

		internal void <SendKeepAliveFrameAsync>b__58_0(Task p) { }

		internal void <WaitForServerToCloseConnectionAsync>b__63_0(object s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__61
	{
		public static readonly <>c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult> <>9; //Field offset: 0x0
		public static Action<Object> <>9__61_0; //Field offset: 0x0

		private static <>c__61`2() { }

		public <>c__61`2() { }

		internal void <ReceiveAsyncPrivate>b__61_0(object s) { }

	}

	[CompilerGenerated]
	private struct <CloseAsyncPrivate>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManagedWebSocket <>4__this; //Field offset: 0x20
		public WebSocketCloseStatus closeStatus; //Field offset: 0x28
		public string statusDescription; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private Byte[] <closeBuffer>5__2; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseWithReceiveErrorAndThrowAsync>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManagedWebSocket <>4__this; //Field offset: 0x20
		public WebSocketCloseStatus closeStatus; //Field offset: 0x28
		public WebSocketError error; //Field offset: 0x2C
		public Exception innerException; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureBufferContainsAsync>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManagedWebSocket <>4__this; //Field offset: 0x20
		public int minimumRequiredBytes; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public bool throwOnPrematureClosure; //Field offset: 0x38
		private ConfiguredValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleReceivedCloseAsync>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManagedWebSocket <>4__this; //Field offset: 0x20
		public MessageHeader header; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x40
		private WebSocketCloseStatus <closeStatus>5__2; //Field offset: 0x48
		private string <closeStatusDescription>5__3; //Field offset: 0x50
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleReceivedPingPongAsync>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MessageHeader header; //Field offset: 0x20
		public ManagedWebSocket <>4__this; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReceiveAsyncPrivate>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder<TWebSocketReceiveResult> <>t__builder; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x0
		public ManagedWebSocket <>4__this; //Field offset: 0x0
		public TWebSocketReceiveResultGetter resultGetter; //Field offset: 0x0
		public Memory<Byte> payloadBuffer; //Field offset: 0x0
		private CancellationTokenRegistration <registration>5__2; //Field offset: 0x0
		private MessageHeader <header>5__3; //Field offset: 0x0
		private int <totalBytesReceived>5__4; //Field offset: 0x0
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x0
		private ConfiguredValueTaskAwaiter<Int32> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendCloseFrameAsync>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string closeStatusDescription; //Field offset: 0x20
		public WebSocketCloseStatus closeStatus; //Field offset: 0x28
		public ManagedWebSocket <>4__this; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private Byte[] <buffer>5__2; //Field offset: 0x40
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendFrameFallbackAsync>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManagedWebSocket <>4__this; //Field offset: 0x20
		public MessageOpcode opcode; //Field offset: 0x28
		public bool endOfMessage; //Field offset: 0x29
		public ReadOnlyMemory<Byte> payloadBuffer; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		private CancellationTokenRegistration <>7__wrap1; //Field offset: 0x58
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForServerToCloseConnectionAsync>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManagedWebSocket <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private CancellationTokenSource <finalCts>5__2; //Field offset: 0x30
		private CancellationTokenRegistration <>7__wrap2; //Field offset: 0x38
		private ConfiguredValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForWriteTaskAsync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ValueTask writeTask; //Field offset: 0x20
		public ManagedWebSocket <>4__this; //Field offset: 0x30
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private interface IWebSocketReceiveResultGetter
	{

		public TResult GetResult(int count, WebSocketMessageType messageType, bool endOfMessage, Nullable<WebSocketCloseStatus> closeStatus, string closeDescription) { }

	}

	private struct MessageHeader
	{
		internal MessageOpcode Opcode; //Field offset: 0x0
		internal bool Fin; //Field offset: 0x1
		internal long PayloadLength; //Field offset: 0x8
		internal int Mask; //Field offset: 0x10

	}

	private enum MessageOpcode
	{
		Continuation = 0,
		Text = 1,
		Binary = 2,
		Close = 8,
		Ping = 9,
		Pong = 10,
	}

	private sealed class Utf8MessageState
	{
		internal bool SequenceInProgress; //Field offset: 0x10
		internal int AdditionalBytesExpected; //Field offset: 0x14
		internal int ExpectedValueMin; //Field offset: 0x18
		internal int CurrentDecodeBits; //Field offset: 0x1C

		public Utf8MessageState() { }

	}

	[IsReadOnly]
	private struct WebSocketReceiveResultGetter : IWebSocketReceiveResultGetter<WebSocketReceiveResult>
	{

		public override WebSocketReceiveResult GetResult(int count, WebSocketMessageType messageType, bool endOfMessage, Nullable<WebSocketCloseStatus> closeStatus, string closeDescription) { }

	}

	private static readonly RandomNumberGenerator s_random; //Field offset: 0x0
	private static readonly UTF8Encoding s_textEncoding; //Field offset: 0x8
	private static readonly WebSocketState[] s_validSendStates; //Field offset: 0x10
	private static readonly WebSocketState[] s_validReceiveStates; //Field offset: 0x18
	private static readonly WebSocketState[] s_validCloseOutputStates; //Field offset: 0x20
	private static readonly WebSocketState[] s_validCloseStates; //Field offset: 0x28
	private static readonly Task<WebSocketReceiveResult> s_cachedCloseTask; //Field offset: 0x30
	private readonly Stream _stream; //Field offset: 0x10
	private readonly bool _isServer; //Field offset: 0x18
	private readonly string _subprotocol; //Field offset: 0x20
	private readonly Timer _keepAliveTimer; //Field offset: 0x28
	private readonly CancellationTokenSource _abortSource; //Field offset: 0x30
	private Memory<Byte> _receiveBuffer; //Field offset: 0x38
	private readonly Utf8MessageState _utf8TextState; //Field offset: 0x48
	private readonly SemaphoreSlim _sendFrameAsyncLock; //Field offset: 0x50
	private WebSocketState _state; //Field offset: 0x58
	private bool _disposed; //Field offset: 0x5C
	private bool _sentCloseFrame; //Field offset: 0x5D
	private bool _receivedCloseFrame; //Field offset: 0x5E
	private Nullable<WebSocketCloseStatus> _closeStatus; //Field offset: 0x60
	private string _closeStatusDescription; //Field offset: 0x68
	private MessageHeader _lastReceiveHeader; //Field offset: 0x70
	private int _receiveBufferOffset; //Field offset: 0x88
	private int _receiveBufferCount; //Field offset: 0x8C
	private int _receivedMaskOffsetOffset; //Field offset: 0x90
	private Byte[] _sendBuffer; //Field offset: 0x98
	private bool _lastSendWasFragment; //Field offset: 0xA0
	private Task _lastReceiveAsync; //Field offset: 0xA8

	public virtual Nullable<WebSocketCloseStatus> CloseStatus
	{
		 get { } //Length: 8
	}

	public virtual string CloseStatusDescription
	{
		 get { } //Length: 8
	}

	private object ReceiveAsyncLock
	{
		private get { } //Length: 8
	}

	public virtual WebSocketState State
	{
		 get { } //Length: 8
	}

	private object StateUpdateLock
	{
		private get { } //Length: 8
	}

	public virtual string SubProtocol
	{
		 get { } //Length: 8
	}

	private static ManagedWebSocket() { }

	private ManagedWebSocket(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval) { }

	public virtual void Abort() { }

	private void AllocateSendBuffer(int minLength) { }

	private static int ApplyMask(Span<Byte> toMask, int mask, int maskIndex) { }

	private static int ApplyMask(Span<Byte> toMask, Byte[] mask, int maskOffset, int maskOffsetIndex) { }

	public virtual Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<CloseAsyncPrivate>d__68))]
	private Task CloseAsyncPrivate(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	public virtual Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<CloseWithReceiveErrorAndThrowAsync>d__66))]
	private Task CloseWithReceiveErrorAndThrowAsync(WebSocketCloseStatus closeStatus, WebSocketError error, Exception innerException = null) { }

	private static int CombineMaskBytes(Span<Byte> buffer, int maskOffset) { }

	private void ConsumeFromBuffer(int count) { }

	public static ManagedWebSocket CreateFromConnectedStream(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval) { }

	private static Exception CreateOperationCanceledException(Exception innerException, CancellationToken cancellationToken = null) { }

	public virtual void Dispose() { }

	private void DisposeCore() { }

	[AsyncStateMachine(typeof(<EnsureBufferContainsAsync>d__71))]
	private Task EnsureBufferContainsAsync(int minimumRequiredBytes, CancellationToken cancellationToken, bool throwOnPrematureClosure = true) { }

	public virtual Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	public virtual string get_CloseStatusDescription() { }

	private object get_ReceiveAsyncLock() { }

	public virtual WebSocketState get_State() { }

	private object get_StateUpdateLock() { }

	public virtual string get_SubProtocol() { }

	[AsyncStateMachine(typeof(<HandleReceivedCloseAsync>d__62))]
	private Task HandleReceivedCloseAsync(MessageHeader header, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<HandleReceivedPingPongAsync>d__64))]
	private Task HandleReceivedPingPongAsync(MessageHeader header, CancellationToken cancellationToken) { }

	private static bool IsValidCloseStatus(WebSocketCloseStatus closeStatus) { }

	public virtual Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<Byte> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReceiveAsyncPrivate>d__61`2))]
	private ValueTask<TWebSocketReceiveResult> ReceiveAsyncPrivate(Memory<Byte> payloadBuffer, CancellationToken cancellationToken, TWebSocketReceiveResultGetter resultGetter = null) { }

	private void ReleaseSendBuffer() { }

	public virtual Task SendAsync(ArraySegment<Byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<SendCloseFrameAsync>d__69))]
	private Task SendCloseFrameAsync(WebSocketCloseStatus closeStatus, string closeStatusDescription, CancellationToken cancellationToken) { }

	private ValueTask SendFrameAsync(MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<Byte> payloadBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<SendFrameFallbackAsync>d__56))]
	private Task SendFrameFallbackAsync(MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<Byte> payloadBuffer, CancellationToken cancellationToken) { }

	private ValueTask SendFrameLockAcquiredNonCancelableAsync(MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<Byte> payloadBuffer) { }

	private void SendKeepAliveFrameAsync() { }

	private ValueTask SendPrivateAsync(ReadOnlyMemory<Byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	private void ThrowIfEOFUnexpected(bool throwOnPrematureClosure) { }

	private void ThrowIfOperationInProgress(bool operationCompleted, string methodName = null) { }

	private void ThrowOperationInProgress(string methodName) { }

	private bool TryParseMessageHeaderFromReceiveBuffer(out MessageHeader resultHeader) { }

	private static bool TryValidateUtf8(Span<Byte> span, bool endOfMessage, Utf8MessageState state) { }

	private Task ValidateAndReceiveAsync(Task receiveTask, Byte[] buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WaitForServerToCloseConnectionAsync>d__63))]
	private Task WaitForServerToCloseConnectionAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WaitForWriteTaskAsync>d__55))]
	private Task WaitForWriteTaskAsync(ValueTask writeTask) { }

	private int WriteFrameToSendBuffer(MessageOpcode opcode, bool endOfMessage, ReadOnlySpan<Byte> payloadBuffer) { }

	private static int WriteHeader(MessageOpcode opcode, Byte[] sendBuffer, ReadOnlySpan<Byte> payload, bool endOfMessage, bool useMask) { }

	private static void WriteRandomMask(Byte[] buffer, int offset) { }

}

