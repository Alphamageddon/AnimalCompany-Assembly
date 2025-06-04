namespace Satori;

internal class ApiClient
{
	[CompilerGenerated]
	private struct <SatoriAuthenticateAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAuthenticateRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string basicAuthUsername; //Field offset: 0x30
		public string basicAuthPassword; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriAuthenticateLogoutAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAuthenticateLogoutRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriAuthenticateRefreshAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAuthenticateRefreshRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string basicAuthUsername; //Field offset: 0x30
		public string basicAuthPassword; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriDeleteIdentityAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiClient <>4__this; //Field offset: 0x20
		public string bearerToken; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriDeleteMessageAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriEventAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiEventRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriGetExperimentsAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiExperimentList> <>t__builder; //Field offset: 0x8
		public IEnumerable<String> names; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriGetFlagsAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiFlagList> <>t__builder; //Field offset: 0x8
		public IEnumerable<String> names; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public string basicAuthUsername; //Field offset: 0x38
		public string basicAuthPassword; //Field offset: 0x40
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x48
		private TaskAwaiter<String> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriGetLiveEventsAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLiveEventList> <>t__builder; //Field offset: 0x8
		public IEnumerable<String> names; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriGetMessageListAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiGetMessageListResponse> <>t__builder; //Field offset: 0x8
		public Nullable<Int32> limit; //Field offset: 0x20
		public Nullable<Boolean> forward; //Field offset: 0x28
		public string cursor; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string bearerToken; //Field offset: 0x40
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x48
		private TaskAwaiter<String> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriHealthcheckAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiClient <>4__this; //Field offset: 0x20
		public string bearerToken; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriIdentifyAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiIdentifyRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriListPropertiesAsync>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiProperties> <>t__builder; //Field offset: 0x8
		public ApiClient <>4__this; //Field offset: 0x20
		public string bearerToken; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriReadycheckAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiClient <>4__this; //Field offset: 0x20
		public string bearerToken; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriUpdateMessageAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiUpdateMessageRequest body; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SatoriUpdatePropertiesAsync>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiUpdatePropertiesRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public readonly IHttpAdapter HttpAdapter; //Field offset: 0x10
	[CompilerGenerated]
	private int <Timeout>k__BackingField; //Field offset: 0x18
	private readonly Uri _baseUri; //Field offset: 0x20

	public int Timeout
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ApiClient(Uri baseUri, IHttpAdapter httpAdapter, int timeout = 10) { }

	[CompilerGenerated]
	public int get_Timeout() { }

	[AsyncStateMachine(typeof(<SatoriAuthenticateAsync>d__9))]
	public Task<IApiSession> SatoriAuthenticateAsync(string basicAuthUsername, string basicAuthPassword, ApiAuthenticateRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriAuthenticateLogoutAsync>d__10))]
	public Task SatoriAuthenticateLogoutAsync(string bearerToken, ApiAuthenticateLogoutRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriAuthenticateRefreshAsync>d__11))]
	public Task<IApiSession> SatoriAuthenticateRefreshAsync(string basicAuthUsername, string basicAuthPassword, ApiAuthenticateRefreshRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriDeleteIdentityAsync>d__16))]
	public Task SatoriDeleteIdentityAsync(string bearerToken, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriDeleteMessageAsync>d__19))]
	public Task SatoriDeleteMessageAsync(string bearerToken, string id, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriEventAsync>d__12))]
	public Task SatoriEventAsync(string bearerToken, ApiEventRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriGetExperimentsAsync>d__13))]
	public Task<IApiExperimentList> SatoriGetExperimentsAsync(string bearerToken, IEnumerable<String> names, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriGetFlagsAsync>d__14))]
	public Task<IApiFlagList> SatoriGetFlagsAsync(string bearerToken, string basicAuthUsername, string basicAuthPassword, IEnumerable<String> names, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriGetLiveEventsAsync>d__17))]
	public Task<IApiLiveEventList> SatoriGetLiveEventsAsync(string bearerToken, IEnumerable<String> names, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriGetMessageListAsync>d__18))]
	public Task<IApiGetMessageListResponse> SatoriGetMessageListAsync(string bearerToken, Nullable<Int32> limit, Nullable<Boolean> forward, string cursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriHealthcheckAsync>d__7))]
	public Task SatoriHealthcheckAsync(string bearerToken, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriIdentifyAsync>d__15))]
	public Task<IApiSession> SatoriIdentifyAsync(string bearerToken, ApiIdentifyRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriListPropertiesAsync>d__21))]
	public Task<IApiProperties> SatoriListPropertiesAsync(string bearerToken, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriReadycheckAsync>d__8))]
	public Task SatoriReadycheckAsync(string bearerToken, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriUpdateMessageAsync>d__20))]
	public Task SatoriUpdateMessageAsync(string bearerToken, string id, ApiUpdateMessageRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SatoriUpdatePropertiesAsync>d__22))]
	public Task SatoriUpdatePropertiesAsync(string bearerToken, ApiUpdatePropertiesRequest body, Nullable<CancellationToken> cancellationToken) { }

	[CompilerGenerated]
	public void set_Timeout(int value) { }

}

