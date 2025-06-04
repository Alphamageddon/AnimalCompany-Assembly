namespace Satori;

public class Client : IClient
{
	[CompilerGenerated]
	private struct <AuthenticateAsync>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public string id; //Field offset: 0x28
		public Dictionary<String, String> defaultProperties; //Field offset: 0x30
		public Dictionary<String, String> customProperties; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteIdentityAsync>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteMessageAsync>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		public string id; //Field offset: 0x40
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EventAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		public Event event; //Field offset: 0x40
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EventsAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		public IEnumerable<Event> events; //Field offset: 0x40
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAllExperimentsAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiExperimentList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		private TaskAwaiter<IApiExperimentList> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetExperimentsAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiExperimentList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		public IEnumerable<String> names; //Field offset: 0x40
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x48
		private TaskAwaiter<IApiExperimentList> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFlagAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiFlag> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string name; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<IApiFlagList> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFlagDefaultAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiFlag> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public string name; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		private TaskAwaiter<IApiFlagList> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFlagsAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiFlagList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		public IEnumerable<String> names; //Field offset: 0x40
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x48
		private TaskAwaiter<IApiFlagList> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLiveEventsAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLiveEventList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		public IEnumerable<String> names; //Field offset: 0x40
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x48
		private TaskAwaiter<IApiLiveEventList> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetMessageListAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiGetMessageListResponse> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		public int limit; //Field offset: 0x40
		public bool forward; //Field offset: 0x44
		public string cursor; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter<IApiGetMessageListResponse> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <IdentifyAsync>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		public string id; //Field offset: 0x40
		public Dictionary<String, String> defaultProperties; //Field offset: 0x48
		public Dictionary<String, String> customProperties; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IApiSession> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListPropertiesAsync>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiProperties> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x40
		private TaskAwaiter<IApiProperties> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SessionRefreshAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateMessageAsync>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		public string id; //Field offset: 0x40
		public string consumeTime; //Field offset: 0x48
		public string readTime; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdatePropertiesAsync>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		public Dictionary<String, String> defaultProperties; //Field offset: 0x40
		public Dictionary<String, String> customProperties; //Field offset: 0x48
		public bool recompute; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static TimeSpan DefaultExpiredTimeSpan; //Field offset: 0x0
	public const int DefaultTimeout = 15; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <AutoRefreshSession>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Host>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <Port>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <Scheme>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <ApiKey>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <Timeout>k__BackingField; //Field offset: 0x38
	private readonly ApiClient _apiClient; //Field offset: 0x40
	private readonly TransientExceptionDelegate _transientExceptionDelegate; //Field offset: 0x48

	public string ApiKey
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override bool AutoRefreshSession
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public string Host
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int Port
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public string Scheme
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int Timeout
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private static Client() { }

	public Client(string scheme, string host, int port, string apiKey) { }

	public Client(string scheme, string host, int port, string apiKey, IHttpAdapter adapter, bool autoRefreshSession = true) { }

	[AsyncStateMachine(typeof(<AuthenticateAsync>d__25))]
	public override Task<ISession> AuthenticateAsync(string id, Dictionary<String, String> defaultProperties = null, Dictionary<String, String> customProperties = null, Nullable<CancellationToken> cancellationToken = null) { }

	public override Task AuthenticateLogoutAsync(ISession session, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<DeleteIdentityAsync>d__42))]
	public override Task DeleteIdentityAsync(ISession session, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<DeleteMessageAsync>d__45))]
	public override Task DeleteMessageAsync(ISession session, string id, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<EventAsync>d__27))]
	public override Task EventAsync(ISession session, Event event, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<EventsAsync>d__28))]
	public override Task EventsAsync(ISession session, IEnumerable<Event> events, Nullable<CancellationToken> cancellationToken = null) { }

	[CompilerGenerated]
	public string get_ApiKey() { }

	[CompilerGenerated]
	public override bool get_AutoRefreshSession() { }

	[CompilerGenerated]
	public string get_Host() { }

	[CompilerGenerated]
	public int get_Port() { }

	[CompilerGenerated]
	public string get_Scheme() { }

	[CompilerGenerated]
	public int get_Timeout() { }

	[AsyncStateMachine(typeof(<GetAllExperimentsAsync>d__29))]
	public override Task<IApiExperimentList> GetAllExperimentsAsync(ISession session, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<GetExperimentsAsync>d__30))]
	public override Task<IApiExperimentList> GetExperimentsAsync(ISession session, IEnumerable<String> names, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<GetFlagAsync>d__31))]
	public override Task<IApiFlag> GetFlagAsync(ISession session, string name, Nullable<CancellationToken> cancellationToken = null) { }

	public override Task<IApiFlag> GetFlagAsync(ISession session, string name, string defaultValue, Nullable<CancellationToken> cancellationToken = null) { }

	public override Task<IApiFlag> GetFlagDefaultAsync(string name, string defaultValue, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<GetFlagDefaultAsync>d__33))]
	public override Task<IApiFlag> GetFlagDefaultAsync(string name, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<GetFlagsAsync>d__35))]
	public override Task<IApiFlagList> GetFlagsAsync(ISession session, IEnumerable<String> names, Nullable<CancellationToken> cancellationToken = null) { }

	public override Task<IApiFlagList> GetFlagsDefaultAsync(IEnumerable<String> names, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<GetLiveEventsAsync>d__38))]
	public override Task<IApiLiveEventList> GetLiveEventsAsync(ISession session, IEnumerable<String> names = null, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<GetMessageListAsync>d__43))]
	public override Task<IApiGetMessageListResponse> GetMessageListAsync(ISession session, int limit = 1, bool forward = true, string cursor = null, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<IdentifyAsync>d__37))]
	public override Task<ISession> IdentifyAsync(ISession session, string id, Dictionary<String, String> defaultProperties, Dictionary<String, String> customProperties, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<ListPropertiesAsync>d__39))]
	public override Task<IApiProperties> ListPropertiesAsync(ISession session, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<SessionRefreshAsync>d__40))]
	public override Task<ISession> SessionRefreshAsync(ISession session, Nullable<CancellationToken> cancellationToken = null) { }

	[CompilerGenerated]
	public void set_Timeout(int value) { }

	[AsyncStateMachine(typeof(<UpdateMessageAsync>d__44))]
	public override Task UpdateMessageAsync(ISession session, string id, string consumeTime, string readTime, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<UpdatePropertiesAsync>d__41))]
	public override Task UpdatePropertiesAsync(ISession session, Dictionary<String, String> defaultProperties, Dictionary<String, String> customProperties, bool recompute = false, Nullable<CancellationToken> cancellationToken = null) { }

}

