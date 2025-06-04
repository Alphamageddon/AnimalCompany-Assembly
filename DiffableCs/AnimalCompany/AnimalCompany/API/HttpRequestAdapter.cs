namespace AnimalCompany.API;

public class HttpRequestAdapter : IHttpAdapter
{
	[CompilerGenerated]
	private struct <SendAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public Uri uri; //Field offset: 0x20
		public string method; //Field offset: 0x28
		public IDictionary<String, String> headers; //Field offset: 0x30
		public HttpRequestAdapter <>4__this; //Field offset: 0x38
		public Byte[] body; //Field offset: 0x40
		public int timeout; //Field offset: 0x48
		public Nullable<CancellationToken> userCancelToken; //Field offset: 0x50
		private HttpResponseMessage <response>5__2; //Field offset: 0x60
		private TaskAwaiter<HttpResponseMessage> <>u__1; //Field offset: 0x68
		private TaskAwaiter<String> <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly HttpClient _httpClient; //Field offset: 0x10
	[CompilerGenerated]
	private ILogger <Logger>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ClientAgentHeader>k__BackingField; //Field offset: 0x20

	public string ClientAgentHeader
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override ILogger Logger
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override TransientExceptionDelegate TransientExceptionDelegate
	{
		 get { } //Length: 124
	}

	public HttpRequestAdapter(HttpClient httpClient) { }

	[CompilerGenerated]
	public string get_ClientAgentHeader() { }

	[CompilerGenerated]
	public override ILogger get_Logger() { }

	public override TransientExceptionDelegate get_TransientExceptionDelegate() { }

	private bool IsTransientException(Exception e) { }

	[AsyncStateMachine(typeof(<SendAsync>d__12))]
	public override Task<String> SendAsync(string method, Uri uri, IDictionary<String, String> headers, Byte[] body, int timeout, Nullable<CancellationToken> userCancelToken) { }

	[CompilerGenerated]
	public void set_ClientAgentHeader(string value) { }

	[CompilerGenerated]
	public override void set_Logger(ILogger value) { }

	public static HttpRequestAdapter WithGzip(bool decompression = false, bool compression = false) { }

}

