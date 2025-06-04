namespace Nakama.Ninja.WebSockets.Internal;

internal static class WebSocketFrameReader
{
	[CompilerGenerated]
	private struct <ReadAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocketReadCursor> <>t__builder; //Field offset: 0x8
		public Stream fromStream; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public ArraySegment<Byte> intoBuffer; //Field offset: 0x30
		private ArraySegment<Byte> <smallBuffer>5__2; //Field offset: 0x40
		private bool <isFinBitSet>5__3; //Field offset: 0x50
		private WebSocketOpCode <opCode>5__4; //Field offset: 0x54
		private bool <isMaskBitSet>5__5; //Field offset: 0x58
		private int <count>5__6; //Field offset: 0x5C
		private int <minCount>5__7; //Field offset: 0x60
		private ArraySegment<Byte> <maskKey>5__8; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x78
		private TaskAwaiter<UInt32> <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadFromCursorAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocketReadCursor> <>t__builder; //Field offset: 0x8
		public WebSocketReadCursor readCursor; //Field offset: 0x20
		public ArraySegment<Byte> intoBuffer; //Field offset: 0x28
		public Stream fromStream; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		private WebSocketFrame <remainingFrame>5__2; //Field offset: 0x48
		private int <minCount>5__3; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadLength>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<UInt32> <>t__builder; //Field offset: 0x8
		public byte byte2; //Field offset: 0x20
		public Stream fromStream; //Field offset: 0x28
		public ArraySegment<Byte> smallBuffer; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x40
		private TaskAwaiter<UInt16> <>u__1; //Field offset: 0x48
		private TaskAwaiter<UInt64> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	private static int CalculateNumBytesToRead(int numBytesLetfToRead, int bufferSize) { }

	private static WebSocketFrame DecodeCloseFrame(bool isFinBitSet, WebSocketOpCode opCode, int count, ArraySegment<Byte> buffer, ArraySegment<Byte> maskKey) { }

	[AsyncStateMachine(typeof(<ReadAsync>d__2))]
	public static Task<WebSocketReadCursor> ReadAsync(Stream fromStream, ArraySegment<Byte> intoBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadFromCursorAsync>d__1))]
	public static Task<WebSocketReadCursor> ReadFromCursorAsync(Stream fromStream, ArraySegment<Byte> intoBuffer, WebSocketReadCursor readCursor, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadLength>d__4))]
	private static Task<UInt32> ReadLength(byte byte2, ArraySegment<Byte> smallBuffer, Stream fromStream, CancellationToken cancellationToken) { }

}

