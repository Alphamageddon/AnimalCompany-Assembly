namespace Nakama.Ninja.WebSockets.Internal;

internal class BinaryReaderWriter
{
	[CompilerGenerated]
	private struct <ReadExactly>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int length; //Field offset: 0x20
		public ArraySegment<Byte> buffer; //Field offset: 0x28
		public Stream stream; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		private int <offset>5__2; //Field offset: 0x48
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadLongExactly>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x8
		public Stream stream; //Field offset: 0x20
		public ArraySegment<Byte> buffer; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x38
		public bool isLittleEndian; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadULongExactly>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<UInt64> <>t__builder; //Field offset: 0x8
		public Stream stream; //Field offset: 0x20
		public ArraySegment<Byte> buffer; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x38
		public bool isLittleEndian; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadUShortExactly>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<UInt16> <>t__builder; //Field offset: 0x8
		public Stream stream; //Field offset: 0x20
		public ArraySegment<Byte> buffer; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x38
		public bool isLittleEndian; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public BinaryReaderWriter() { }

	[AsyncStateMachine(typeof(<ReadExactly>d__0))]
	public static Task ReadExactly(int length, Stream stream, ArraySegment<Byte> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadLongExactly>d__3))]
	public static Task<Int64> ReadLongExactly(Stream stream, bool isLittleEndian, ArraySegment<Byte> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadULongExactly>d__2))]
	public static Task<UInt64> ReadULongExactly(Stream stream, bool isLittleEndian, ArraySegment<Byte> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadUShortExactly>d__1))]
	public static Task<UInt16> ReadUShortExactly(Stream stream, bool isLittleEndian, ArraySegment<Byte> buffer, CancellationToken cancellationToken) { }

	public static void WriteInt(int value, Stream stream, bool isLittleEndian) { }

	public static void WriteLong(long value, Stream stream, bool isLittleEndian) { }

	public static void WriteULong(ulong value, Stream stream, bool isLittleEndian) { }

	public static void WriteUShort(ushort value, Stream stream, bool isLittleEndian) { }

}

