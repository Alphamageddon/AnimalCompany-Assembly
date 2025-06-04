namespace System.Net.Http;

internal class MonoWebRequestHandler : IMonoHttpClientHandler, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__95_0; //Field offset: 0x8
		public static Func<String, Boolean> <>9__96_1; //Field offset: 0x10
		public static Action<Object> <>9__99_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <CreateWebRequest>b__96_1(string l) { }

		internal bool <GetConnectionKeepAlive>b__95_0(string l) { }

		internal void <SendAsync>b__99_0(object l) { }

	}

	[CompilerGenerated]
	private struct <SendAsync>d__99 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; //Field offset: 0x8
		public MonoWebRequestHandler <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public HttpRequestMessage request; //Field offset: 0x30
		private HttpWebRequest <wrequest>5__2; //Field offset: 0x38
		private HttpWebResponse <wresponse>5__3; //Field offset: 0x40
		private CancellationTokenRegistration <>7__wrap3; //Field offset: 0x48
		private HttpContent <content>5__5; //Field offset: 0x60
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x68
		private Stream <stream>5__6; //Field offset: 0x78
		private ConfiguredTaskAwaiter<Stream> <>u__2; //Field offset: 0x80
		private ConfiguredTaskAwaiter<WebResponse> <>u__3; //Field offset: 0x90
		private TaskAwaiter<HttpResponseMessage> <>u__4; //Field offset: 0xA0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static long groupCounter; //Field offset: 0x0
	private bool allowAutoRedirect; //Field offset: 0x10
	private DecompressionMethods automaticDecompression; //Field offset: 0x14
	private CookieContainer cookieContainer; //Field offset: 0x18
	private ICredentials credentials; //Field offset: 0x20
	private int maxAutomaticRedirections; //Field offset: 0x28
	private long maxRequestContentBufferSize; //Field offset: 0x30
	private bool preAuthenticate; //Field offset: 0x38
	private IWebProxy proxy; //Field offset: 0x40
	private bool useCookies; //Field offset: 0x48
	private bool useProxy; //Field offset: 0x49
	private SslClientAuthenticationOptions sslOptions; //Field offset: 0x50
	private bool allowPipelining; //Field offset: 0x58
	private RequestCachePolicy cachePolicy; //Field offset: 0x60
	private AuthenticationLevel authenticationLevel; //Field offset: 0x68
	private TimeSpan continueTimeout; //Field offset: 0x70
	private TokenImpersonationLevel impersonationLevel; //Field offset: 0x78
	private int maxResponseHeadersLength; //Field offset: 0x7C
	private int readWriteTimeout; //Field offset: 0x80
	private RemoteCertificateValidationCallback serverCertificateValidationCallback; //Field offset: 0x88
	private bool unsafeAuthenticatedConnectionSharing; //Field offset: 0x90
	private bool sentRequest; //Field offset: 0x91
	private string connectionGroupName; //Field offset: 0x98
	private Nullable<TimeSpan> timeout; //Field offset: 0xA0
	private bool disposed; //Field offset: 0xB0

	public override DecompressionMethods AutomaticDecompression
	{
		 set { } //Length: 36
	}

	public override CookieContainer CookieContainer
	{
		 get { } //Length: 100
	}

	public override long MaxRequestContentBufferSize
	{
		 get { } //Length: 8
	}

	public override SslClientAuthenticationOptions SslOptions
	{
		 get { } //Length: 100
		 set { } //Length: 36
	}

	public override bool SupportsAutomaticDecompression
	{
		 get { } //Length: 8
	}

	public MonoWebRequestHandler() { }

	[CompilerGenerated]
	private X509Certificate <CreateWebRequest>b__96_0(string t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	internal override HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	internal void EnsureModifiability() { }

	public override CookieContainer get_CookieContainer() { }

	public override long get_MaxRequestContentBufferSize() { }

	public override SslClientAuthenticationOptions get_SslOptions() { }

	public override bool get_SupportsAutomaticDecompression() { }

	private bool GetConnectionKeepAlive(HttpRequestHeaders headers) { }

	private static bool MethodHasBody(HttpMethod method) { }

	[AsyncStateMachine(typeof(<SendAsync>d__99))]
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	public override void set_AutomaticDecompression(DecompressionMethods value) { }

	public override void set_SslOptions(SslClientAuthenticationOptions value) { }

	private override void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(TimeSpan timeout) { }

}

