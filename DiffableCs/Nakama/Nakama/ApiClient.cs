namespace Nakama;

internal class ApiClient
{
	[CompilerGenerated]
	private struct <AddFriendsAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<String> ids; //Field offset: 0x20
		public IEnumerable<String> usernames; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AddGroupUsersAsync>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string groupId; //Field offset: 0x20
		public IEnumerable<String> userIds; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateAppleAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAccountApple account; //Field offset: 0x20
		public Nullable<Boolean> create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string basicAuthUsername; //Field offset: 0x40
		public string basicAuthPassword; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateCustomAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAccountCustom account; //Field offset: 0x20
		public Nullable<Boolean> create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string basicAuthUsername; //Field offset: 0x40
		public string basicAuthPassword; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateDeviceAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAccountDevice account; //Field offset: 0x20
		public Nullable<Boolean> create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string basicAuthUsername; //Field offset: 0x40
		public string basicAuthPassword; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateEmailAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAccountEmail account; //Field offset: 0x20
		public Nullable<Boolean> create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string basicAuthUsername; //Field offset: 0x40
		public string basicAuthPassword; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateFacebookAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAccountFacebook account; //Field offset: 0x20
		public Nullable<Boolean> create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public Nullable<Boolean> sync; //Field offset: 0x38
		public ApiClient <>4__this; //Field offset: 0x40
		public string basicAuthUsername; //Field offset: 0x48
		public string basicAuthPassword; //Field offset: 0x50
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x58
		private TaskAwaiter<String> <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateFacebookInstantGameAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAccountFacebookInstantGame account; //Field offset: 0x20
		public Nullable<Boolean> create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string basicAuthUsername; //Field offset: 0x40
		public string basicAuthPassword; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateGameCenterAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAccountGameCenter account; //Field offset: 0x20
		public Nullable<Boolean> create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string basicAuthUsername; //Field offset: 0x40
		public string basicAuthPassword; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateGoogleAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAccountGoogle account; //Field offset: 0x20
		public Nullable<Boolean> create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string basicAuthUsername; //Field offset: 0x40
		public string basicAuthPassword; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateSteamAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiAccountSteam account; //Field offset: 0x20
		public Nullable<Boolean> create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public Nullable<Boolean> sync; //Field offset: 0x38
		public ApiClient <>4__this; //Field offset: 0x40
		public string basicAuthUsername; //Field offset: 0x48
		public string basicAuthPassword; //Field offset: 0x50
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x58
		private TaskAwaiter<String> <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BanGroupUsersAsync>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string groupId; //Field offset: 0x20
		public IEnumerable<String> userIds; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BlockFriendsAsync>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<String> ids; //Field offset: 0x20
		public IEnumerable<String> usernames; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateGroupAsync>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiGroup> <>t__builder; //Field offset: 0x8
		public ApiCreateGroupRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteAccountAsync>d__8 : IAsyncStateMachine
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
	private struct <DeleteFriendsAsync>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<String> ids; //Field offset: 0x20
		public IEnumerable<String> usernames; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteGroupAsync>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string groupId; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteLeaderboardRecordAsync>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string leaderboardId; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteNotificationsAsync>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<String> ids; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteStorageObjectsAsync>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiDeleteStorageObjectsRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteTournamentRecordAsync>d__83 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string tournamentId; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DemoteGroupUsersAsync>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string groupId; //Field offset: 0x20
		public IEnumerable<String> userIds; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EventAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiEvent body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAccountAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiAccount> <>t__builder; //Field offset: 0x8
		public ApiClient <>4__this; //Field offset: 0x20
		public string bearerToken; //Field offset: 0x28
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetSubscriptionAsync>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidatedSubscription> <>t__builder; //Field offset: 0x8
		public string productId; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetUsersAsync>d__89 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiUsers> <>t__builder; //Field offset: 0x8
		public IEnumerable<String> ids; //Field offset: 0x20
		public IEnumerable<String> usernames; //Field offset: 0x28
		public IEnumerable<String> facebookIds; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string bearerToken; //Field offset: 0x40
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x48
		private TaskAwaiter<String> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HealthcheckAsync>d__7 : IAsyncStateMachine
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
	private struct <ImportFacebookFriendsAsync>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountFacebook account; //Field offset: 0x20
		public Nullable<Boolean> reset; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ImportSteamFriendsAsync>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountSteam account; //Field offset: 0x20
		public Nullable<Boolean> reset; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <JoinGroupAsync>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string groupId; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <JoinTournamentAsync>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string tournamentId; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <KickGroupUsersAsync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string groupId; //Field offset: 0x20
		public IEnumerable<String> userIds; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LeaveGroupAsync>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string groupId; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkAppleAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountApple body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkCustomAsync>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountCustom body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkDeviceAsync>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountDevice body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkEmailAsync>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountEmail body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkFacebookAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountFacebook account; //Field offset: 0x20
		public Nullable<Boolean> sync; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkFacebookInstantGameAsync>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountFacebookInstantGame body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkGameCenterAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountGameCenter body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkGoogleAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountGoogle body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkSteamAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiLinkSteamRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListChannelMessagesAsync>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiChannelMessageList> <>t__builder; //Field offset: 0x8
		public string channelId; //Field offset: 0x20
		public Nullable<Int32> limit; //Field offset: 0x28
		public Nullable<Boolean> forward; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public ApiClient <>4__this; //Field offset: 0x40
		public string bearerToken; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListFriendsAsync>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiFriendList> <>t__builder; //Field offset: 0x8
		public Nullable<Int32> limit; //Field offset: 0x20
		public Nullable<Int32> state; //Field offset: 0x28
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
	private struct <ListGroupsAsync>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiGroupList> <>t__builder; //Field offset: 0x8
		public string name; //Field offset: 0x20
		public string cursor; //Field offset: 0x28
		public Nullable<Int32> limit; //Field offset: 0x30
		public string langTag; //Field offset: 0x38
		public Nullable<Int32> members; //Field offset: 0x40
		public Nullable<Boolean> open; //Field offset: 0x48
		public ApiClient <>4__this; //Field offset: 0x50
		public string bearerToken; //Field offset: 0x58
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x60
		private TaskAwaiter<String> <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListGroupUsersAsync>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiGroupUserList> <>t__builder; //Field offset: 0x8
		public string groupId; //Field offset: 0x20
		public Nullable<Int32> limit; //Field offset: 0x28
		public Nullable<Int32> state; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public ApiClient <>4__this; //Field offset: 0x40
		public string bearerToken; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListLeaderboardRecordsAroundOwnerAsync>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLeaderboardRecordList> <>t__builder; //Field offset: 0x8
		public string leaderboardId; //Field offset: 0x20
		public string ownerId; //Field offset: 0x28
		public Nullable<Int32> limit; //Field offset: 0x30
		public string expiry; //Field offset: 0x38
		public string cursor; //Field offset: 0x40
		public ApiClient <>4__this; //Field offset: 0x48
		public string bearerToken; //Field offset: 0x50
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x58
		private TaskAwaiter<String> <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListLeaderboardRecordsAsync>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLeaderboardRecordList> <>t__builder; //Field offset: 0x8
		public string leaderboardId; //Field offset: 0x20
		public IEnumerable<String> ownerIds; //Field offset: 0x28
		public Nullable<Int32> limit; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public string expiry; //Field offset: 0x40
		public ApiClient <>4__this; //Field offset: 0x48
		public string bearerToken; //Field offset: 0x50
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x58
		private TaskAwaiter<String> <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListMatchesAsync>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiMatchList> <>t__builder; //Field offset: 0x8
		public Nullable<Int32> limit; //Field offset: 0x20
		public Nullable<Boolean> authoritative; //Field offset: 0x28
		public string label; //Field offset: 0x30
		public Nullable<Int32> minSize; //Field offset: 0x38
		public Nullable<Int32> maxSize; //Field offset: 0x40
		public string query; //Field offset: 0x48
		public ApiClient <>4__this; //Field offset: 0x50
		public string bearerToken; //Field offset: 0x58
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x60
		private TaskAwaiter<String> <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListNotificationsAsync>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiNotificationList> <>t__builder; //Field offset: 0x8
		public Nullable<Int32> limit; //Field offset: 0x20
		public string cacheableCursor; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListStorageObjects2Async>d__81 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiStorageObjectList> <>t__builder; //Field offset: 0x8
		public string collection; //Field offset: 0x20
		public string userId; //Field offset: 0x28
		public Nullable<Int32> limit; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public ApiClient <>4__this; //Field offset: 0x40
		public string bearerToken; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListStorageObjectsAsync>d__80 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiStorageObjectList> <>t__builder; //Field offset: 0x8
		public string collection; //Field offset: 0x20
		public string userId; //Field offset: 0x28
		public Nullable<Int32> limit; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public ApiClient <>4__this; //Field offset: 0x40
		public string bearerToken; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListSubscriptionsAsync>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSubscriptionList> <>t__builder; //Field offset: 0x8
		public ApiListSubscriptionsRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListTournamentRecordsAroundOwnerAsync>d__88 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiTournamentRecordList> <>t__builder; //Field offset: 0x8
		public string tournamentId; //Field offset: 0x20
		public string ownerId; //Field offset: 0x28
		public Nullable<Int32> limit; //Field offset: 0x30
		public string expiry; //Field offset: 0x38
		public string cursor; //Field offset: 0x40
		public ApiClient <>4__this; //Field offset: 0x48
		public string bearerToken; //Field offset: 0x50
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x58
		private TaskAwaiter<String> <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListTournamentRecordsAsync>d__84 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiTournamentRecordList> <>t__builder; //Field offset: 0x8
		public string tournamentId; //Field offset: 0x20
		public IEnumerable<String> ownerIds; //Field offset: 0x28
		public Nullable<Int32> limit; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public string expiry; //Field offset: 0x40
		public ApiClient <>4__this; //Field offset: 0x48
		public string bearerToken; //Field offset: 0x50
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x58
		private TaskAwaiter<String> <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListTournamentsAsync>d__82 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiTournamentList> <>t__builder; //Field offset: 0x8
		public Nullable<Int32> categoryStart; //Field offset: 0x20
		public Nullable<Int32> categoryEnd; //Field offset: 0x28
		public Nullable<Int32> startTime; //Field offset: 0x30
		public Nullable<Int32> endTime; //Field offset: 0x38
		public Nullable<Int32> limit; //Field offset: 0x40
		public string cursor; //Field offset: 0x48
		public ApiClient <>4__this; //Field offset: 0x50
		public string bearerToken; //Field offset: 0x58
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x60
		private TaskAwaiter<String> <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListUserGroupsAsync>d__90 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiUserGroupList> <>t__builder; //Field offset: 0x8
		public string userId; //Field offset: 0x20
		public Nullable<Int32> limit; //Field offset: 0x28
		public Nullable<Int32> state; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public ApiClient <>4__this; //Field offset: 0x40
		public string bearerToken; //Field offset: 0x48
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x50
		private TaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PromoteGroupUsersAsync>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string groupId; //Field offset: 0x20
		public IEnumerable<String> userIds; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadStorageObjectsAsync>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiStorageObjects> <>t__builder; //Field offset: 0x8
		public ApiReadStorageObjectsRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RpcFunc2Async>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiRpc> <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public string payload; //Field offset: 0x28
		public string httpKey; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string bearerToken; //Field offset: 0x40
		public string basicAuthUsername; //Field offset: 0x48
		public string basicAuthPassword; //Field offset: 0x50
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x58
		private TaskAwaiter<String> <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RpcFuncAsync>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiRpc> <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public string payload; //Field offset: 0x28
		public string httpKey; //Field offset: 0x30
		public ApiClient <>4__this; //Field offset: 0x38
		public string bearerToken; //Field offset: 0x40
		public string basicAuthUsername; //Field offset: 0x48
		public string basicAuthPassword; //Field offset: 0x50
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x58
		private TaskAwaiter<String> <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SessionLogoutAsync>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiSessionLogoutRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SessionRefreshAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSession> <>t__builder; //Field offset: 0x8
		public ApiSessionRefreshRequest body; //Field offset: 0x20
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
	private struct <UnlinkAppleAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountApple body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkCustomAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountCustom body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkDeviceAsync>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountDevice body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkEmailAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountEmail body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkFacebookAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountFacebook body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkFacebookInstantGameAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountFacebookInstantGame body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkGameCenterAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountGameCenter body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkGoogleAsync>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountGoogle body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkSteamAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiAccountSteam body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateAccountAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApiUpdateAccountRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateGroupAsync>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string groupId; //Field offset: 0x20
		public ApiUpdateGroupRequest body; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidatePurchaseAppleAsync>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidatePurchaseResponse> <>t__builder; //Field offset: 0x8
		public ApiValidatePurchaseAppleRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidatePurchaseFacebookInstantAsync>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidatePurchaseResponse> <>t__builder; //Field offset: 0x8
		public ApiValidatePurchaseFacebookInstantRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidatePurchaseGoogleAsync>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidatePurchaseResponse> <>t__builder; //Field offset: 0x8
		public ApiValidatePurchaseGoogleRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidatePurchaseHuaweiAsync>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidatePurchaseResponse> <>t__builder; //Field offset: 0x8
		public ApiValidatePurchaseHuaweiRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateSubscriptionAppleAsync>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidateSubscriptionResponse> <>t__builder; //Field offset: 0x8
		public ApiValidateSubscriptionAppleRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateSubscriptionGoogleAsync>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidateSubscriptionResponse> <>t__builder; //Field offset: 0x8
		public ApiValidateSubscriptionGoogleRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteLeaderboardRecordAsync>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLeaderboardRecord> <>t__builder; //Field offset: 0x8
		public string leaderboardId; //Field offset: 0x20
		public WriteLeaderboardRecordRequestLeaderboardRecordWrite record; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteStorageObjectsAsync>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiStorageObjectAcks> <>t__builder; //Field offset: 0x8
		public ApiWriteStorageObjectsRequest body; //Field offset: 0x20
		public ApiClient <>4__this; //Field offset: 0x28
		public string bearerToken; //Field offset: 0x30
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteTournamentRecord2Async>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLeaderboardRecord> <>t__builder; //Field offset: 0x8
		public string tournamentId; //Field offset: 0x20
		public WriteTournamentRecordRequestTournamentRecordWrite record; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteTournamentRecordAsync>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLeaderboardRecord> <>t__builder; //Field offset: 0x8
		public string tournamentId; //Field offset: 0x20
		public WriteTournamentRecordRequestTournamentRecordWrite record; //Field offset: 0x28
		public ApiClient <>4__this; //Field offset: 0x30
		public string bearerToken; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

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

	[AsyncStateMachine(typeof(<AddFriendsAsync>d__43))]
	public Task AddFriendsAsync(string bearerToken, IEnumerable<String> ids, IEnumerable<String> usernames, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<AddGroupUsersAsync>d__51))]
	public Task AddGroupUsersAsync(string bearerToken, string groupId, IEnumerable<String> userIds, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<AuthenticateAppleAsync>d__11))]
	public Task<IApiSession> AuthenticateAppleAsync(string basicAuthUsername, string basicAuthPassword, ApiAccountApple account, Nullable<Boolean> create, string username, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<AuthenticateCustomAsync>d__12))]
	public Task<IApiSession> AuthenticateCustomAsync(string basicAuthUsername, string basicAuthPassword, ApiAccountCustom account, Nullable<Boolean> create, string username, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<AuthenticateDeviceAsync>d__13))]
	public Task<IApiSession> AuthenticateDeviceAsync(string basicAuthUsername, string basicAuthPassword, ApiAccountDevice account, Nullable<Boolean> create, string username, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<AuthenticateEmailAsync>d__14))]
	public Task<IApiSession> AuthenticateEmailAsync(string basicAuthUsername, string basicAuthPassword, ApiAccountEmail account, Nullable<Boolean> create, string username, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<AuthenticateFacebookAsync>d__15))]
	public Task<IApiSession> AuthenticateFacebookAsync(string basicAuthUsername, string basicAuthPassword, ApiAccountFacebook account, Nullable<Boolean> create, string username, Nullable<Boolean> sync, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<AuthenticateFacebookInstantGameAsync>d__16))]
	public Task<IApiSession> AuthenticateFacebookInstantGameAsync(string basicAuthUsername, string basicAuthPassword, ApiAccountFacebookInstantGame account, Nullable<Boolean> create, string username, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<AuthenticateGameCenterAsync>d__17))]
	public Task<IApiSession> AuthenticateGameCenterAsync(string basicAuthUsername, string basicAuthPassword, ApiAccountGameCenter account, Nullable<Boolean> create, string username, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<AuthenticateGoogleAsync>d__18))]
	public Task<IApiSession> AuthenticateGoogleAsync(string basicAuthUsername, string basicAuthPassword, ApiAccountGoogle account, Nullable<Boolean> create, string username, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<AuthenticateSteamAsync>d__19))]
	public Task<IApiSession> AuthenticateSteamAsync(string basicAuthUsername, string basicAuthPassword, ApiAccountSteam account, Nullable<Boolean> create, string username, Nullable<Boolean> sync, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<BanGroupUsersAsync>d__52))]
	public Task BanGroupUsersAsync(string bearerToken, string groupId, IEnumerable<String> userIds, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<BlockFriendsAsync>d__44))]
	public Task BlockFriendsAsync(string bearerToken, IEnumerable<String> ids, IEnumerable<String> usernames, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<CreateGroupAsync>d__48))]
	public Task<IApiGroup> CreateGroupAsync(string bearerToken, ApiCreateGroupRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<DeleteAccountAsync>d__8))]
	public Task DeleteAccountAsync(string bearerToken, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<DeleteFriendsAsync>d__41))]
	public Task DeleteFriendsAsync(string bearerToken, IEnumerable<String> ids, IEnumerable<String> usernames, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<DeleteGroupAsync>d__49))]
	public Task DeleteGroupAsync(string bearerToken, string groupId, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<DeleteLeaderboardRecordAsync>d__67))]
	public Task DeleteLeaderboardRecordAsync(string bearerToken, string leaderboardId, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<DeleteNotificationsAsync>d__72))]
	public Task DeleteNotificationsAsync(string bearerToken, IEnumerable<String> ids, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<DeleteStorageObjectsAsync>d__79))]
	public Task DeleteStorageObjectsAsync(string bearerToken, ApiDeleteStorageObjectsRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<DeleteTournamentRecordAsync>d__83))]
	public Task DeleteTournamentRecordAsync(string bearerToken, string tournamentId, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<DemoteGroupUsersAsync>d__53))]
	public Task DemoteGroupUsersAsync(string bearerToken, string groupId, IEnumerable<String> userIds, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<EventAsync>d__40))]
	public Task EventAsync(string bearerToken, ApiEvent body, Nullable<CancellationToken> cancellationToken) { }

	[CompilerGenerated]
	public int get_Timeout() { }

	[AsyncStateMachine(typeof(<GetAccountAsync>d__9))]
	public Task<IApiAccount> GetAccountAsync(string bearerToken, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<GetSubscriptionAsync>d__66))]
	public Task<IApiValidatedSubscription> GetSubscriptionAsync(string bearerToken, string productId, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<GetUsersAsync>d__89))]
	public Task<IApiUsers> GetUsersAsync(string bearerToken, IEnumerable<String> ids, IEnumerable<String> usernames, IEnumerable<String> facebookIds, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<HealthcheckAsync>d__7))]
	public Task HealthcheckAsync(string bearerToken, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ImportFacebookFriendsAsync>d__45))]
	public Task ImportFacebookFriendsAsync(string bearerToken, ApiAccountFacebook account, Nullable<Boolean> reset, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ImportSteamFriendsAsync>d__46))]
	public Task ImportSteamFriendsAsync(string bearerToken, ApiAccountSteam account, Nullable<Boolean> reset, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<JoinGroupAsync>d__54))]
	public Task JoinGroupAsync(string bearerToken, string groupId, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<JoinTournamentAsync>d__87))]
	public Task JoinTournamentAsync(string bearerToken, string tournamentId, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<KickGroupUsersAsync>d__55))]
	public Task KickGroupUsersAsync(string bearerToken, string groupId, IEnumerable<String> userIds, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<LeaveGroupAsync>d__56))]
	public Task LeaveGroupAsync(string bearerToken, string groupId, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<LinkAppleAsync>d__20))]
	public Task LinkAppleAsync(string bearerToken, ApiAccountApple body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<LinkCustomAsync>d__21))]
	public Task LinkCustomAsync(string bearerToken, ApiAccountCustom body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<LinkDeviceAsync>d__22))]
	public Task LinkDeviceAsync(string bearerToken, ApiAccountDevice body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<LinkEmailAsync>d__23))]
	public Task LinkEmailAsync(string bearerToken, ApiAccountEmail body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<LinkFacebookAsync>d__24))]
	public Task LinkFacebookAsync(string bearerToken, ApiAccountFacebook account, Nullable<Boolean> sync, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<LinkFacebookInstantGameAsync>d__25))]
	public Task LinkFacebookInstantGameAsync(string bearerToken, ApiAccountFacebookInstantGame body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<LinkGameCenterAsync>d__26))]
	public Task LinkGameCenterAsync(string bearerToken, ApiAccountGameCenter body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<LinkGoogleAsync>d__27))]
	public Task LinkGoogleAsync(string bearerToken, ApiAccountGoogle body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<LinkSteamAsync>d__28))]
	public Task LinkSteamAsync(string bearerToken, ApiLinkSteamRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListChannelMessagesAsync>d__39))]
	public Task<IApiChannelMessageList> ListChannelMessagesAsync(string bearerToken, string channelId, Nullable<Int32> limit, Nullable<Boolean> forward, string cursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListFriendsAsync>d__42))]
	public Task<IApiFriendList> ListFriendsAsync(string bearerToken, Nullable<Int32> limit, Nullable<Int32> state, string cursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListGroupsAsync>d__47))]
	public Task<IApiGroupList> ListGroupsAsync(string bearerToken, string name, string cursor, Nullable<Int32> limit, string langTag, Nullable<Int32> members, Nullable<Boolean> open, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListGroupUsersAsync>d__58))]
	public Task<IApiGroupUserList> ListGroupUsersAsync(string bearerToken, string groupId, Nullable<Int32> limit, Nullable<Int32> state, string cursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListLeaderboardRecordsAroundOwnerAsync>d__70))]
	public Task<IApiLeaderboardRecordList> ListLeaderboardRecordsAroundOwnerAsync(string bearerToken, string leaderboardId, string ownerId, Nullable<Int32> limit, string expiry, string cursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListLeaderboardRecordsAsync>d__68))]
	public Task<IApiLeaderboardRecordList> ListLeaderboardRecordsAsync(string bearerToken, string leaderboardId, IEnumerable<String> ownerIds, Nullable<Int32> limit, string cursor, string expiry, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListMatchesAsync>d__71))]
	public Task<IApiMatchList> ListMatchesAsync(string bearerToken, Nullable<Int32> limit, Nullable<Boolean> authoritative, string label, Nullable<Int32> minSize, Nullable<Int32> maxSize, string query, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListNotificationsAsync>d__73))]
	public Task<IApiNotificationList> ListNotificationsAsync(string bearerToken, Nullable<Int32> limit, string cacheableCursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListStorageObjects2Async>d__81))]
	public Task<IApiStorageObjectList> ListStorageObjects2Async(string bearerToken, string collection, string userId, Nullable<Int32> limit, string cursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListStorageObjectsAsync>d__80))]
	public Task<IApiStorageObjectList> ListStorageObjectsAsync(string bearerToken, string collection, string userId, Nullable<Int32> limit, string cursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListSubscriptionsAsync>d__63))]
	public Task<IApiSubscriptionList> ListSubscriptionsAsync(string bearerToken, ApiListSubscriptionsRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListTournamentRecordsAroundOwnerAsync>d__88))]
	public Task<IApiTournamentRecordList> ListTournamentRecordsAroundOwnerAsync(string bearerToken, string tournamentId, string ownerId, Nullable<Int32> limit, string expiry, string cursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListTournamentRecordsAsync>d__84))]
	public Task<IApiTournamentRecordList> ListTournamentRecordsAsync(string bearerToken, string tournamentId, IEnumerable<String> ownerIds, Nullable<Int32> limit, string cursor, string expiry, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListTournamentsAsync>d__82))]
	public Task<IApiTournamentList> ListTournamentsAsync(string bearerToken, Nullable<Int32> categoryStart, Nullable<Int32> categoryEnd, Nullable<Int32> startTime, Nullable<Int32> endTime, Nullable<Int32> limit, string cursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ListUserGroupsAsync>d__90))]
	public Task<IApiUserGroupList> ListUserGroupsAsync(string bearerToken, string userId, Nullable<Int32> limit, Nullable<Int32> state, string cursor, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<PromoteGroupUsersAsync>d__57))]
	public Task PromoteGroupUsersAsync(string bearerToken, string groupId, IEnumerable<String> userIds, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadStorageObjectsAsync>d__77))]
	public Task<IApiStorageObjects> ReadStorageObjectsAsync(string bearerToken, ApiReadStorageObjectsRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<RpcFunc2Async>d__74))]
	public Task<IApiRpc> RpcFunc2Async(string bearerToken, string basicAuthUsername, string basicAuthPassword, string id, string payload, string httpKey, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<RpcFuncAsync>d__75))]
	public Task<IApiRpc> RpcFuncAsync(string bearerToken, string basicAuthUsername, string basicAuthPassword, string id, string payload, string httpKey, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SessionLogoutAsync>d__76))]
	public Task SessionLogoutAsync(string bearerToken, ApiSessionLogoutRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<SessionRefreshAsync>d__29))]
	public Task<IApiSession> SessionRefreshAsync(string basicAuthUsername, string basicAuthPassword, ApiSessionRefreshRequest body, Nullable<CancellationToken> cancellationToken) { }

	[CompilerGenerated]
	public void set_Timeout(int value) { }

	[AsyncStateMachine(typeof(<UnlinkAppleAsync>d__30))]
	public Task UnlinkAppleAsync(string bearerToken, ApiAccountApple body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<UnlinkCustomAsync>d__31))]
	public Task UnlinkCustomAsync(string bearerToken, ApiAccountCustom body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<UnlinkDeviceAsync>d__32))]
	public Task UnlinkDeviceAsync(string bearerToken, ApiAccountDevice body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<UnlinkEmailAsync>d__33))]
	public Task UnlinkEmailAsync(string bearerToken, ApiAccountEmail body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<UnlinkFacebookAsync>d__34))]
	public Task UnlinkFacebookAsync(string bearerToken, ApiAccountFacebook body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<UnlinkFacebookInstantGameAsync>d__35))]
	public Task UnlinkFacebookInstantGameAsync(string bearerToken, ApiAccountFacebookInstantGame body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<UnlinkGameCenterAsync>d__36))]
	public Task UnlinkGameCenterAsync(string bearerToken, ApiAccountGameCenter body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<UnlinkGoogleAsync>d__37))]
	public Task UnlinkGoogleAsync(string bearerToken, ApiAccountGoogle body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<UnlinkSteamAsync>d__38))]
	public Task UnlinkSteamAsync(string bearerToken, ApiAccountSteam body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<UpdateAccountAsync>d__10))]
	public Task UpdateAccountAsync(string bearerToken, ApiUpdateAccountRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<UpdateGroupAsync>d__50))]
	public Task UpdateGroupAsync(string bearerToken, string groupId, ApiUpdateGroupRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ValidatePurchaseAppleAsync>d__59))]
	public Task<IApiValidatePurchaseResponse> ValidatePurchaseAppleAsync(string bearerToken, ApiValidatePurchaseAppleRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ValidatePurchaseFacebookInstantAsync>d__60))]
	public Task<IApiValidatePurchaseResponse> ValidatePurchaseFacebookInstantAsync(string bearerToken, ApiValidatePurchaseFacebookInstantRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ValidatePurchaseGoogleAsync>d__61))]
	public Task<IApiValidatePurchaseResponse> ValidatePurchaseGoogleAsync(string bearerToken, ApiValidatePurchaseGoogleRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ValidatePurchaseHuaweiAsync>d__62))]
	public Task<IApiValidatePurchaseResponse> ValidatePurchaseHuaweiAsync(string bearerToken, ApiValidatePurchaseHuaweiRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ValidateSubscriptionAppleAsync>d__64))]
	public Task<IApiValidateSubscriptionResponse> ValidateSubscriptionAppleAsync(string bearerToken, ApiValidateSubscriptionAppleRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<ValidateSubscriptionGoogleAsync>d__65))]
	public Task<IApiValidateSubscriptionResponse> ValidateSubscriptionGoogleAsync(string bearerToken, ApiValidateSubscriptionGoogleRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteLeaderboardRecordAsync>d__69))]
	public Task<IApiLeaderboardRecord> WriteLeaderboardRecordAsync(string bearerToken, string leaderboardId, WriteLeaderboardRecordRequestLeaderboardRecordWrite record, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteStorageObjectsAsync>d__78))]
	public Task<IApiStorageObjectAcks> WriteStorageObjectsAsync(string bearerToken, ApiWriteStorageObjectsRequest body, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteTournamentRecord2Async>d__85))]
	public Task<IApiLeaderboardRecord> WriteTournamentRecord2Async(string bearerToken, string tournamentId, WriteTournamentRecordRequestTournamentRecordWrite record, Nullable<CancellationToken> cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteTournamentRecordAsync>d__86))]
	public Task<IApiLeaderboardRecord> WriteTournamentRecordAsync(string bearerToken, string tournamentId, WriteTournamentRecordRequestTournamentRecordWrite record, Nullable<CancellationToken> cancellationToken) { }

}

