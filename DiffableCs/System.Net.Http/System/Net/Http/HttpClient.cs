namespace System.Net.Http;

public class HttpClient : HttpMessageInvoker
{
	[CompilerGenerated]
	private struct <SendAsyncWorker>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; //Field offset: 0x8
		public HttpClient <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public HttpRequestMessage request; //Field offset: 0x30
		public HttpCompletionOption completionOption; //Field offset: 0x38
		private CancellationTokenSource <lcts>5__2; //Field offset: 0x40
		private HttpResponseMessage <response>5__3; //Field offset: 0x48
		private ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; //Field offset: 0x50
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly TimeSpan TimeoutDefault; //Field offset: 0x0
	private Uri base_address; //Field offset: 0x20
	private CancellationTokenSource cts; //Field offset: 0x28
	private bool disposed; //Field offset: 0x30
	private HttpRequestHeaders headers; //Field offset: 0x38
	private long buffer_size; //Field offset: 0x40
	private TimeSpan timeout; //Field offset: 0x48

	public long MaxResponseContentBufferSize
	{
		 get { } //Length: 8
	}

	public TimeSpan Timeout
	{
		 set { } //Length: 316
	}

	private static HttpClient() { }

	public HttpClient(HttpMessageHandler handler) { }

	public HttpClient(HttpMessageHandler handler, bool disposeHandler) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task<HttpResponseMessage> <>n__0(HttpRequestMessage request, CancellationToken cancellationToken) { }

	protected virtual void Dispose(bool disposing) { }

	public long get_MaxResponseContentBufferSize() { }

	public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<SendAsyncWorker>d__47))]
	private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	public void set_Timeout(TimeSpan value) { }

}

