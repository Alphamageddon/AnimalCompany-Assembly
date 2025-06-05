namespace AnimalCompany.API;

public class AnimalCompanyAPI : MonoBehaviour, IClient
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Task`1<IApiRpc>, ClientBootstrapResponse> <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal ClientBootstrapResponse <BootstrapAsync>b__24_0(Task<IApiRpc> task) { }

	}

	[CompilerGenerated]
	private struct <RefreshAPISession>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public int delay; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter<ISession> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct ClientBootstrapResponse
	{
		public UpdateType updateType; //Field offset: 0x0
		public string photonAppID; //Field offset: 0x8
		public string photonVoiceAppID; //Field offset: 0x10

	}

	private struct ClientBootstrapResponseInternal
	{
		public string updateType; //Field offset: 0x0
		public string photonAppID; //Field offset: 0x8
		public string photonVoiceAppID; //Field offset: 0x10

	}

	internal enum UpdateType
	{
		None = 0,
		Force = 1,
		Optional = 2,
	}

	public const string API_ORIGIN_PROD = "https://animalcompany.us-east1.nakamacloud.io:443"; //Field offset: 0x0
	public const string API_TOKEN_PROD = "6URuTSlDKKfYbuDW"; //Field offset: 0x0
	public const string API_ORIGIN_DEV = "http://135.181.246.229:7350"; //Field offset: 0x0
	public const string API_TOKEN_DEV = "defaultkey"; //Field offset: 0x0
	private static AnimalCompanyAPI _instance; //Field offset: 0x0
	private static HttpRequestAdapter _httpRequestAdapter; //Field offset: 0x8
	private static IClient _client; //Field offset: 0x10
	private static CancellationTokenSource _refreshSessionTokenSource; //Field offset: 0x18
	[CompilerGenerated]
	private static ISession <session>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private static ISocket <socket>k__BackingField; //Field offset: 0x28

	public override event Action<ISession> ReceivedSessionUpdated
	{
		 add { } //Length: 212
		 remove { } //Length: 212
	}

	public override bool AutoRefreshSession
	{
		 get { } //Length: 200
	}

	public override RetryConfiguration GlobalRetryConfiguration
	{
		 get { } //Length: 204
		 set { } //Length: 212
	}

	public override string Host
	{
		 get { } //Length: 204
	}

	public static AnimalCompanyAPI instance
	{
		 get { } //Length: 88
	}

	public override ILogger Logger
	{
		 get { } //Length: 204
		 set { } //Length: 212
	}

	public override int Port
	{
		 get { } //Length: 204
	}

	public override string Scheme
	{
		 get { } //Length: 204
	}

	public override string ServerKey
	{
		 get { } //Length: 204
	}

	public private static ISession session
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		private set { } //Length: 92
	}

	public private static ISocket socket
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		private set { } //Length: 92
	}

	public override int Timeout
	{
		 get { } //Length: 204
		 set { } //Length: 212
	}

	private static AnimalCompanyAPI() { }

	public AnimalCompanyAPI() { }

	public override void add_ReceivedSessionUpdated(Action<ISession> value) { }

	public override Task AddFriendsAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task AddGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<ISession> AuthenticateAppleAsync(string token, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<ISession> AuthenticateCustomAsync(string id, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<ISession> AuthenticateDeviceAsync(string id, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<ISession> AuthenticateEmailAsync(string email, string password, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<ISession> AuthenticateFacebookAsync(string token, string username = null, bool create = true, bool import = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<ISession> AuthenticateGameCenterAsync(string bundleId, string playerId, string publicKeyUrl, string salt, string signature, string timestamp, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<ISession> AuthenticateGoogleAsync(string token, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<ISession> AuthenticateSteamAsync(string token, string username = null, bool create = true, bool import = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	private void Awake() { }

	public override Task BanGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task BlockFriendsAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<ClientBootstrapResponse> BootstrapAsync(ISession session, CancellationToken canceller = null) { }

	public override Task<IApiGroup> CreateGroupAsync(ISession session, string name, string description = "", string avatarUrl = null, string langTag = null, bool open = true, int maxCount = 100, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task DeleteAccountAsync(ISession session, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task DeleteFriendsAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task DeleteGroupAsync(ISession session, string groupId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task DeleteLeaderboardRecordAsync(ISession session, string leaderboardId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task DeleteNotificationsAsync(ISession session, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task DeleteStorageObjectsAsync(ISession session, StorageObjectId[] ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task DeleteTournamentRecordAsync(ISession session, string tournamentId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task DemoteGroupUsersAsync(ISession session, string groupId, IEnumerable<String> userIds, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task EventAsync(ISession session, string name, Dictionary<String, String> properties, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override bool get_AutoRefreshSession() { }

	public override RetryConfiguration get_GlobalRetryConfiguration() { }

	public override string get_Host() { }

	public static AnimalCompanyAPI get_instance() { }

	public override ILogger get_Logger() { }

	public override int get_Port() { }

	public override string get_Scheme() { }

	public override string get_ServerKey() { }

	[CompilerGenerated]
	public static ISession get_session() { }

	[CompilerGenerated]
	public static ISocket get_socket() { }

	public override int get_Timeout() { }

	public override Task<IApiAccount> GetAccountAsync(ISession session, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiValidatedSubscription> GetSubscriptionAsync(ISession session, string productId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiUsers> GetUsersAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, IEnumerable<String> facebookIds = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	private void HandleClientAgentHeaderChanged(StateChangedEventArgs args) { }

	private void HandleSessionUpdated(ISession session) { }

	public override Task ImportFacebookFriendsAsync(ISession session, string token, Nullable<Boolean> reset = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task ImportSteamFriendsAsync(ISession session, string token, Nullable<Boolean> reset = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task JoinGroupAsync(ISession session, string groupId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task JoinTournamentAsync(ISession session, string tournamentId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task KickGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task LeaveGroupAsync(ISession session, string groupId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task LinkAppleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task LinkCustomAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task LinkDeviceAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task LinkEmailAsync(ISession session, string email, string password, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task LinkFacebookAsync(ISession session, string token, Nullable<Boolean> import = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task LinkGameCenterAsync(ISession session, string bundleId, string playerId, string publicKeyUrl, string salt, string signature, string timestamp, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task LinkGoogleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task LinkSteamAsync(ISession session, string token, bool import, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiChannelMessageList> ListChannelMessagesAsync(ISession session, IChannel channel, int limit = 1, bool forward = true, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiChannelMessageList> ListChannelMessagesAsync(ISession session, string channelId, int limit = 1, bool forward = true, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiFriendList> ListFriendsAsync(ISession session, Nullable<Int32> state = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiGroupList> ListGroupsAsync(ISession session, string name = null, int limit = 1, string cursor = null, string langTag = null, Nullable<Int32> members = null, Nullable<Boolean> open = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiGroupUserList> ListGroupUsersAsync(ISession session, string groupId, Nullable<Int32> state = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiLeaderboardRecordList> ListLeaderboardRecordsAroundOwnerAsync(ISession session, string leaderboardId, string ownerId, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiLeaderboardRecordList> ListLeaderboardRecordsAsync(ISession session, string leaderboardId, IEnumerable<String> ownerIds = null, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiMatchList> ListMatchesAsync(ISession session, int min, int max, int limit, bool authoritative, string label, string query, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiNotificationList> ListNotificationsAsync(ISession session, int limit = 1, string cacheableCursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[Obsolete("ListStorageObjects is obsolete, please use ListStorageObjectsAsync instead.", False)]
	public override Task<IApiStorageObjectList> ListStorageObjects(ISession session, string collection, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiStorageObjectList> ListStorageObjectsAsync(ISession session, string collection, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiSubscriptionList> ListSubscriptionsAsync(ISession session, int limit, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiTournamentRecordList> ListTournamentRecordsAroundOwnerAsync(ISession session, string tournamentId, string ownerId, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiTournamentRecordList> ListTournamentRecordsAsync(ISession session, string tournamentId, IEnumerable<String> ownerIds = null, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiTournamentList> ListTournamentsAsync(ISession session, int categoryStart, int categoryEnd, Nullable<Int32> startTime = null, Nullable<Int32> endTime = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiUserGroupList> ListUserGroupsAsync(ISession session, string userId, Nullable<Int32> state = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiUserGroupList> ListUserGroupsAsync(ISession session, Nullable<Int32> state = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiStorageObjectList> ListUsersStorageObjectsAsync(ISession session, string collection, string userId, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	private void OnDestroy() { }

	public override Task PromoteGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiStorageObjects> ReadStorageObjectsAsync(ISession session, IApiReadStorageObjectId[] ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<RefreshAPISession>d__23))]
	private static void RefreshAPISession(int delay, CancellationToken token) { }

	public override void remove_ReceivedSessionUpdated(Action<ISession> value) { }

	public override Task<IApiRpc> RpcAsync(ISession session, string id, string payload, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiRpc> RpcAsync(string httpKey, string id, string payload, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiRpc> RpcAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiRpc> RpcAsync(string httpKey, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task SessionLogoutAsync(ISession session, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task SessionLogoutAsync(string authToken, string refreshToken, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<ISession> SessionRefreshAsync(ISession session, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override void set_GlobalRetryConfiguration(RetryConfiguration value) { }

	public override void set_Logger(ILogger value) { }

	[CompilerGenerated]
	private static void set_session(ISession value) { }

	[CompilerGenerated]
	private static void set_socket(ISocket value) { }

	public override void set_Timeout(int value) { }

	public static void SetSession(ISession session) { }

	public override Task UnlinkAppleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task UnlinkCustomAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task UnlinkDeviceAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task UnlinkEmailAsync(ISession session, string email, string password, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task UnlinkFacebookAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task UnlinkGameCenterAsync(ISession session, string bundleId, string playerId, string publicKeyUrl, string salt, string signature, string timestamp, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task UnlinkGoogleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task UnlinkSteamAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task UpdateAccountAsync(ISession session, string username, string displayName = null, string avatarUrl = null, string langTag = null, string location = null, string timezone = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task UpdateGroupAsync(ISession session, string groupId, string name, bool open, string description = null, string avatarUrl = null, string langTag = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiRpc> UpdateWalletSoftCurrencyAsync(ISession session, int amount, CancellationToken canceller = null) { }

	public override Task<IApiValidatePurchaseResponse> ValidatePurchaseAppleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiValidatePurchaseResponse> ValidatePurchaseFacebookInstantAsync(ISession session, string signedRequest, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiValidatePurchaseResponse> ValidatePurchaseGoogleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiValidatePurchaseResponse> ValidatePurchaseHuaweiAsync(ISession session, string receipt, string signature, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiValidateSubscriptionResponse> ValidateSubscriptionAppleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiValidateSubscriptionResponse> ValidateSubscriptionGoogleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiLeaderboardRecord> WriteLeaderboardRecordAsync(ISession session, string leaderboardId, long score, long subScore = 0, string metadata = null, ApiOperator apiOperator = 0, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiStorageObjectAcks> WriteStorageObjectsAsync(ISession session, IApiWriteStorageObject[] objects, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiLeaderboardRecord> WriteTournamentRecordAsync(ISession session, string tournamentId, long score, long subScore = 0, string metadata = null, ApiOperator apiOperator = 0, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

}

