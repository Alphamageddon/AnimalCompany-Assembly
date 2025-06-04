namespace AnimalCompany;

[Extension]
public static class AuthCommands
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string deviceID; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <LoginAsync>b__0(IApiAccountDevice d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public AuthResult result; //Field offset: 0x10
		public bool entitlementCheckComplete; //Field offset: 0x28
		public User user; //Field offset: 0x30
		public bool loggedInUserRequestComplete; //Field offset: 0x38
		public string userNonce; //Field offset: 0x40
		public bool userProofRequestComplete; //Field offset: 0x48

		public <>c__DisplayClass7_0() { }

		internal void <AuthenticateWithMetaQuestAccount>b__0(Message msg) { }

		internal void <AuthenticateWithMetaQuestAccount>b__1(Message<User> msg) { }

		internal void <AuthenticateWithMetaQuestAccount>b__2(Message<UserProof> msg) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateWithMetaQuestAccount>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AuthResult> <>t__builder; //Field offset: 0x8
		private <>c__DisplayClass7_0 <>8__1; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter<ISession> <>u__2; //Field offset: 0x30
		private TaskAwaiter <>u__3; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthRetryLoop>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AuthResult> <>t__builder; //Field offset: 0x8
		public Func<Task`1<AuthResult>> authMethod; //Field offset: 0x20
		private int <retryDelayMs>5__2; //Field offset: 0x28
		private AuthResult <authResult>5__3; //Field offset: 0x30
		private int <retryAttempt>5__4; //Field offset: 0x48
		private TaskAwaiter<AuthResult> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoginAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LoginResult> <>t__builder; //Field offset: 0x8
		private AuthResult <authResult>5__2; //Field offset: 0x20
		private LoginResult <result>5__3; //Field offset: 0x38
		private TaskAwaiter<AuthResult> <>u__1; //Field offset: 0xA8
		private TaskAwaiter<IApiAccount> <>u__2; //Field offset: 0xB0
		private TaskAwaiter<GetAvatarsResponse> <>u__3; //Field offset: 0xB8
		private TaskAwaiter<ApiUserInventory> <>u__4; //Field offset: 0xC0
		private TaskAwaiter <>u__5; //Field offset: 0xC8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct AuthResult
	{
		public ISession session; //Field offset: 0x0
		public LoginErrorCode errorCode; //Field offset: 0x8
		public string errorMessage; //Field offset: 0x10

		public bool hasError
		{
			 get { } //Length: 16
		}

		public bool success
		{
			 get { } //Length: 16
		}

		public bool get_hasError() { }

		public bool get_success() { }

	}

	internal enum LoginErrorCode
	{
		None = 0,
		Unknown = 1,
		InternalException = 2,
		Cancelled = 3,
		MetaQuestAppEntitlementCheckFailed = 4,
		MetaQuestGetLoggedInUserFailed = 5,
		MetaQuestGetUserProofFailed = 6,
		MetaQuestCustomAuthApiFailed_Unknown = 7,
		ServiceUnavailable = 8,
		UnhandledApiError = 9,
		UnhandledHttpError = 10,
		FetchAccountFailed = 11,
		UserBanned = 12,
	}

	internal struct LoginResult
	{
		public ISession session; //Field offset: 0x0
		public IApiAccount account; //Field offset: 0x8
		public ApiUserAvatar avatar; //Field offset: 0x10
		public ApiUserInventory inventory; //Field offset: 0x60
		public LoginErrorCode errorCode; //Field offset: 0x68

		public bool success
		{
			 get { } //Length: 16
		}

		public bool get_success() { }

	}

	public const string EDITOR_PREFS_AUTH_DEVICE_ID_OVERRIDE = "AC_AUTH_DEVICE_ID_OVERRIDE"; //Field offset: 0x0
	private const string PLAYER_PREFS_DEVICE_ID = "AC_DEVICE_ID"; //Field offset: 0x0

	[AsyncStateMachine(typeof(<AuthenticateWithMetaQuestAccount>d__7))]
	private static Task<AuthResult> AuthenticateWithMetaQuestAccount() { }

	[AsyncStateMachine(typeof(<AuthRetryLoop>d__6))]
	private static Task<AuthResult> AuthRetryLoop(Func<Task`1<AuthResult>> authMethod) { }

	public static string GetAuthDeviceID() { }

	private static Dictionary<String, String> GetAuthVars(Dictionary<String, String> vars = null) { }

	private static void LogAuthEvent(AuthResult result, string method) { }

	[AsyncStateMachine(typeof(<LoginAsync>d__4))]
	public static Task<LoginResult> LoginAsync(CancellationToken token = null) { }

	[Extension]
	private static bool ShouldLogAsError(LoginErrorCode errorCode) { }

	private static bool TryParseAuthError(Exception exc, ref AuthResult result) { }

}

