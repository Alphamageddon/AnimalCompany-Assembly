namespace Nakama.Console;

internal class ApiClient
{
	[CompilerGenerated]
	private struct <AuthenticateAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IConsoleConsoleSession> <>t__builder; //Field offset: 0x8
		public ConsoleAuthenticateRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BanUserAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteAccountAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public Nullable<Boolean> recordDeletion; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteFriendAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public string friendId; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteGroupUserAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public string groupId; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteStorageAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiClient <>4__this; //Field offset: 0x20
		public string bearerToken; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteStorageObject2Async>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string collection; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public string userId; //Field offset: 0x30
		public string version; //Field offset: 0x38
		public ApiClient <>4__this; //Field offset: 0x40
		public string bearerToken; //Field offset: 0x48
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteStorageObjectAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string collection; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public string userId; //Field offset: 0x30
		public string version; //Field offset: 0x38
		public ApiClient <>4__this; //Field offset: 0x40
		public string bearerToken; //Field offset: 0x48
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteUsersAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiClient <>4__this; //Field offset: 0x20
		public string bearerToken; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteWalletLedgerAsync>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public string walletId; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExportAccountAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IConsoleAccountExport> <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAccountAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<INakamaconsoleAccount> <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetConfigAsync>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IConsoleConfig> <>t__builder; //Field offset: 0x8
		public ApiClient <>4__this; //Field offset: 0x20
		public string bearerToken; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFriendsAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiFriendList> <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetGroupsAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiUserGroupList> <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetStatusAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IConsoleStatusList> <>t__builder; //Field offset: 0x8
		public ApiClient <>4__this; //Field offset: 0x20
		public string bearerToken; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetStorageAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiStorageObject> <>t__builder; //Field offset: 0x8
		public string collection; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public string userId; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string bearerToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetWalletLedgerAsync>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IConsoleWalletLedgerList> <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListStorageAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IConsoleStorageList> <>t__builder; //Field offset: 0x8
		public string userId; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListUsersAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IConsoleUserList> <>t__builder; //Field offset: 0x8
		public string filter; //Field offset: 0x20
		public Nullable<Boolean> banned; //Field offset: 0x28
		public Nullable<Boolean> tombstones; //Field offset: 0x2A
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnbanUserAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkCustomAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkDeviceAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ConsoleUnlinkDeviceRequest body; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkEmailAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkFacebookAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkFacebookInstantGameAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkGameCenterAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkGoogleAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkSteamAsync>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateAccountAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public NakamaconsoleUpdateAccountRequest body; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteStorageObjectAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiStorageObjectAck> <>t__builder; //Field offset: 0x8
		public string collection; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public string userId; //Field offset: 0x30
		public ConsoleWriteStorageObjectRequest body; //Field offset: 0x38
		public ApiClient <>4__this; //Field offset: 0x40
		public string bearerToken; //Field offset: 0x48
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Uri _baseUri; //Field offset: 0x10
	private readonly int _timeout; //Field offset: 0x18
	public readonly IHttpAdapter HttpAdapter; //Field offset: 0x20

	public ApiClient(Uri baseUri, IHttpAdapter httpAdapter, int timeout = 10) { }

	[AsyncStateMachine(typeof(<AuthenticateAsync>d__24))]
	public Task<IConsoleConsoleSession> AuthenticateAsync(ConsoleAuthenticateRequest body) { }

	[AsyncStateMachine(typeof(<BanUserAsync>d__7))]
	public Task BanUserAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<DeleteAccountAsync>d__4))]
	public Task DeleteAccountAsync(string bearerToken, string id, Nullable<Boolean> recordDeletion) { }

	[AsyncStateMachine(typeof(<DeleteFriendAsync>d__10))]
	public Task DeleteFriendAsync(string bearerToken, string id, string friendId) { }

	[AsyncStateMachine(typeof(<DeleteGroupUserAsync>d__12))]
	public Task DeleteGroupUserAsync(string bearerToken, string id, string groupId) { }

	[AsyncStateMachine(typeof(<DeleteStorageAsync>d__27))]
	public Task DeleteStorageAsync(string bearerToken) { }

	[AsyncStateMachine(typeof(<DeleteStorageObject2Async>d__32))]
	public Task DeleteStorageObject2Async(string bearerToken, string collection, string key, string userId, string version) { }

	[AsyncStateMachine(typeof(<DeleteStorageObjectAsync>d__29))]
	public Task DeleteStorageObjectAsync(string bearerToken, string collection, string key, string userId, string version) { }

	[AsyncStateMachine(typeof(<DeleteUsersAsync>d__33))]
	public Task DeleteUsersAsync(string bearerToken) { }

	[AsyncStateMachine(typeof(<DeleteWalletLedgerAsync>d__23))]
	public Task DeleteWalletLedgerAsync(string bearerToken, string id, string walletId) { }

	[AsyncStateMachine(typeof(<ExportAccountAsync>d__8))]
	public Task<IConsoleAccountExport> ExportAccountAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<GetAccountAsync>d__5))]
	public Task<INakamaconsoleAccount> GetAccountAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<GetConfigAsync>d__25))]
	public Task<IConsoleConfig> GetConfigAsync(string bearerToken) { }

	[AsyncStateMachine(typeof(<GetFriendsAsync>d__9))]
	public Task<IApiFriendList> GetFriendsAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<GetGroupsAsync>d__11))]
	public Task<IApiUserGroupList> GetGroupsAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<GetStatusAsync>d__26))]
	public Task<IConsoleStatusList> GetStatusAsync(string bearerToken) { }

	[AsyncStateMachine(typeof(<GetStorageAsync>d__30))]
	public Task<IApiStorageObject> GetStorageAsync(string bearerToken, string collection, string key, string userId) { }

	[AsyncStateMachine(typeof(<GetWalletLedgerAsync>d__22))]
	public Task<IConsoleWalletLedgerList> GetWalletLedgerAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<ListStorageAsync>d__28))]
	public Task<IConsoleStorageList> ListStorageAsync(string bearerToken, string userId) { }

	[AsyncStateMachine(typeof(<ListUsersAsync>d__34))]
	public Task<IConsoleUserList> ListUsersAsync(string bearerToken, string filter, Nullable<Boolean> banned, Nullable<Boolean> tombstones) { }

	[AsyncStateMachine(typeof(<UnbanUserAsync>d__13))]
	public Task UnbanUserAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<UnlinkCustomAsync>d__14))]
	public Task UnlinkCustomAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<UnlinkDeviceAsync>d__15))]
	public Task UnlinkDeviceAsync(string bearerToken, string id, ConsoleUnlinkDeviceRequest body) { }

	[AsyncStateMachine(typeof(<UnlinkEmailAsync>d__16))]
	public Task UnlinkEmailAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<UnlinkFacebookAsync>d__17))]
	public Task UnlinkFacebookAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<UnlinkFacebookInstantGameAsync>d__18))]
	public Task UnlinkFacebookInstantGameAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<UnlinkGameCenterAsync>d__19))]
	public Task UnlinkGameCenterAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<UnlinkGoogleAsync>d__20))]
	public Task UnlinkGoogleAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<UnlinkSteamAsync>d__21))]
	public Task UnlinkSteamAsync(string bearerToken, string id) { }

	[AsyncStateMachine(typeof(<UpdateAccountAsync>d__6))]
	public Task UpdateAccountAsync(string bearerToken, string id, NakamaconsoleUpdateAccountRequest body) { }

	[AsyncStateMachine(typeof(<WriteStorageObjectAsync>d__31))]
	public Task<IApiStorageObjectAck> WriteStorageObjectAsync(string bearerToken, string collection, string key, string userId, ConsoleWriteStorageObjectRequest body) { }

}

