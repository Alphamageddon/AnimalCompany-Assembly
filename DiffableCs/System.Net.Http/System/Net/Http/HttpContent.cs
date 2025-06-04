namespace System.Net.Http;

public abstract class HttpContent : IDisposable
{
	[CompilerGenerated]
	private struct <LoadIntoBufferAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HttpContent <>4__this; //Field offset: 0x20
		public long maxBufferSize; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAsStringAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpContent <>4__this; //Field offset: 0x20
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class FixedMemoryStream : MemoryStream
	{
		private readonly long maxSize; //Field offset: 0x50

		public FixedMemoryStream(long maxSize) { }

		private void CheckOverflow(int count) { }

		public virtual void Write(Byte[] buffer, int offset, int count) { }

		public virtual void WriteByte(byte value) { }

	}

	private FixedMemoryStream buffer; //Field offset: 0x10
	private bool disposed; //Field offset: 0x18
	private HttpContentHeaders headers; //Field offset: 0x20

	public HttpContentHeaders Headers
	{
		 get { } //Length: 100
	}

	internal Nullable<Int64> LoadedBufferLength
	{
		internal get { } //Length: 124
	}

	protected HttpContent() { }

	public Task CopyToAsync(Stream stream) { }

	public Task CopyToAsync(Stream stream, TransportContext context) { }

	private static FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public HttpContentHeaders get_Headers() { }

	internal Nullable<Int64> get_LoadedBufferLength() { }

	private static Encoding GetEncodingFromBuffer(Byte[] buffer, int length, ref int preambleLength) { }

	public Task LoadIntoBufferAsync() { }

	[AsyncStateMachine(typeof(<LoadIntoBufferAsync>d__17))]
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[AsyncStateMachine(typeof(<ReadAsStringAsync>d__20))]
	public Task<String> ReadAsStringAsync() { }

	protected abstract Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	private static int StartsWith(Byte[] array, int length, Byte[] value) { }

	protected private abstract bool TryComputeLength(out long length) { }

}

