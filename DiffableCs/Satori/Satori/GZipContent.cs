namespace Satori;

internal class GZipContent : HttpContent
{
	[CompilerGenerated]
	private struct <SerializeToStreamAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Stream stream; //Field offset: 0x20
		public GZipContent <>4__this; //Field offset: 0x28
		private GZipStream <gzip>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly HttpContent _content; //Field offset: 0x28

	public GZipContent(HttpContent content) { }

	[AsyncStateMachine(typeof(<SerializeToStreamAsync>d__2))]
	protected virtual Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	protected virtual bool TryComputeLength(out long length) { }

}

