namespace Nakama;

public interface IClient
{

	public event Action<ISession> ReceivedSessionUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool AutoRefreshSession
	{
		 get { } //Length: 0
	}

	public RetryConfiguration GlobalRetryConfiguration
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string Host
	{
		 get { } //Length: 0
	}

	public ILogger Logger
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int Port
	{
		 get { } //Length: 0
	}

	public string Scheme
	{
		 get { } //Length: 0
	}

	public string ServerKey
	{
		 get { } //Length: 0
	}

	public int Timeout
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ReceivedSessionUpdated(Action<ISession> value) { }

	public Task AddFriendsAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task AddGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<ISession> AuthenticateAppleAsync(string token, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<ISession> AuthenticateCustomAsync(string id, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<ISession> AuthenticateDeviceAsync(string id, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<ISession> AuthenticateEmailAsync(string email, string password, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<ISession> AuthenticateFacebookAsync(string token, string username = null, bool create = true, bool import = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<ISession> AuthenticateGameCenterAsync(string bundleId, string playerId, string publicKeyUrl, string salt, string signature, string timestamp, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<ISession> AuthenticateGoogleAsync(string token, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<ISession> AuthenticateSteamAsync(string token, string username = null, bool create = true, bool import = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task BanGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task BlockFriendsAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiGroup> CreateGroupAsync(ISession session, string name, string description = "", string avatarUrl = null, string langTag = null, bool open = true, int maxCount = 100, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task DeleteAccountAsync(ISession session, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task DeleteFriendsAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task DeleteGroupAsync(ISession session, string groupId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task DeleteLeaderboardRecordAsync(ISession session, string leaderboardId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task DeleteNotificationsAsync(ISession session, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task DeleteStorageObjectsAsync(ISession session, StorageObjectId[] ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task DeleteTournamentRecordAsync(ISession session, string tournamentId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task DemoteGroupUsersAsync(ISession session, string groupId, IEnumerable<String> userIds, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task EventAsync(ISession session, string name, Dictionary<String, String> properties, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public bool get_AutoRefreshSession() { }

	public RetryConfiguration get_GlobalRetryConfiguration() { }

	public string get_Host() { }

	public ILogger get_Logger() { }

	public int get_Port() { }

	public string get_Scheme() { }

	public string get_ServerKey() { }

	public int get_Timeout() { }

	public Task<IApiAccount> GetAccountAsync(ISession session, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiValidatedSubscription> GetSubscriptionAsync(ISession session, string productId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiUsers> GetUsersAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, IEnumerable<String> facebookIds = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task ImportFacebookFriendsAsync(ISession session, string token, Nullable<Boolean> reset = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task ImportSteamFriendsAsync(ISession session, string token, Nullable<Boolean> reset = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task JoinGroupAsync(ISession session, string groupId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task JoinTournamentAsync(ISession session, string tournamentId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task KickGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task LeaveGroupAsync(ISession session, string groupId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task LinkAppleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task LinkCustomAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task LinkDeviceAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task LinkEmailAsync(ISession session, string email, string password, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task LinkFacebookAsync(ISession session, string token, Nullable<Boolean> import = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task LinkGameCenterAsync(ISession session, string bundleId, string playerId, string publicKeyUrl, string salt, string signature, string timestamp, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task LinkGoogleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task LinkSteamAsync(ISession session, string token, bool import, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiChannelMessageList> ListChannelMessagesAsync(ISession session, IChannel channel, int limit = 1, bool forward = true, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiChannelMessageList> ListChannelMessagesAsync(ISession session, string channelId, int limit = 1, bool forward = true, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiFriendList> ListFriendsAsync(ISession session, Nullable<Int32> state = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiGroupList> ListGroupsAsync(ISession session, string name = null, int limit = 1, string cursor = null, string langTag = null, Nullable<Int32> members = null, Nullable<Boolean> open = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiGroupUserList> ListGroupUsersAsync(ISession session, string groupId, Nullable<Int32> state = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiLeaderboardRecordList> ListLeaderboardRecordsAroundOwnerAsync(ISession session, string leaderboardId, string ownerId, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiLeaderboardRecordList> ListLeaderboardRecordsAsync(ISession session, string leaderboardId, IEnumerable<String> ownerIds = null, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiMatchList> ListMatchesAsync(ISession session, int min, int max, int limit, bool authoritative, string label, string query, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiNotificationList> ListNotificationsAsync(ISession session, int limit = 1, string cacheableCursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[Obsolete("ListStorageObjects is obsolete, please use ListStorageObjectsAsync instead.", False)]
	public Task<IApiStorageObjectList> ListStorageObjects(ISession session, string collection, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiStorageObjectList> ListStorageObjectsAsync(ISession session, string collection, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiSubscriptionList> ListSubscriptionsAsync(ISession session, int limit, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiTournamentRecordList> ListTournamentRecordsAroundOwnerAsync(ISession session, string tournamentId, string ownerId, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiTournamentRecordList> ListTournamentRecordsAsync(ISession session, string tournamentId, IEnumerable<String> ownerIds = null, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiTournamentList> ListTournamentsAsync(ISession session, int categoryStart, int categoryEnd, Nullable<Int32> startTime = null, Nullable<Int32> endTime = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiUserGroupList> ListUserGroupsAsync(ISession session, string userId, Nullable<Int32> state = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiUserGroupList> ListUserGroupsAsync(ISession session, Nullable<Int32> state = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiStorageObjectList> ListUsersStorageObjectsAsync(ISession session, string collection, string userId, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task PromoteGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiStorageObjects> ReadStorageObjectsAsync(ISession session, IApiReadStorageObjectId[] ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[CompilerGenerated]
	public void remove_ReceivedSessionUpdated(Action<ISession> value) { }

	public Task<IApiRpc> RpcAsync(ISession session, string id, string payload, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiRpc> RpcAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiRpc> RpcAsync(string httpKey, string id, string payload, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiRpc> RpcAsync(string httpKey, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task SessionLogoutAsync(ISession session, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task SessionLogoutAsync(string authToken, string refreshToken, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<ISession> SessionRefreshAsync(ISession session, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public void set_GlobalRetryConfiguration(RetryConfiguration value) { }

	public void set_Logger(ILogger value) { }

	public void set_Timeout(int value) { }

	public Task UnlinkAppleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task UnlinkCustomAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task UnlinkDeviceAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task UnlinkEmailAsync(ISession session, string email, string password, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task UnlinkFacebookAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task UnlinkGameCenterAsync(ISession session, string bundleId, string playerId, string publicKeyUrl, string salt, string signature, string timestamp, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task UnlinkGoogleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task UnlinkSteamAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task UpdateAccountAsync(ISession session, string username, string displayName = null, string avatarUrl = null, string langTag = null, string location = null, string timezone = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task UpdateGroupAsync(ISession session, string groupId, string name, bool open, string description = null, string avatarUrl = null, string langTag = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiValidatePurchaseResponse> ValidatePurchaseAppleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiValidatePurchaseResponse> ValidatePurchaseFacebookInstantAsync(ISession session, string signedRequest, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiValidatePurchaseResponse> ValidatePurchaseGoogleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiValidatePurchaseResponse> ValidatePurchaseHuaweiAsync(ISession session, string receipt, string signature, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiValidateSubscriptionResponse> ValidateSubscriptionAppleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiValidateSubscriptionResponse> ValidateSubscriptionGoogleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiLeaderboardRecord> WriteLeaderboardRecordAsync(ISession session, string leaderboardId, long score, long subScore = 0, string metadata = null, ApiOperator apiOperator = 0, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiStorageObjectAcks> WriteStorageObjectsAsync(ISession session, IApiWriteStorageObject[] objects, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public Task<IApiLeaderboardRecord> WriteTournamentRecordAsync(ISession session, string tournamentId, long score, long subScore = 0, string metadata = null, ApiOperator apiOperator = 0, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

}

