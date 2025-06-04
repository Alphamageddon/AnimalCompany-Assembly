namespace Nakama;

public class Client : IClient
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass100_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public List<ApiReadStorageObjectId> objects; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass100_0() { }

		internal Task<IApiStorageObjects> <ReadStorageObjectsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass101_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string id; //Field offset: 0x20
		public string payload; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass101_0() { }

		internal Task<IApiRpc> <RpcAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass102_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string id; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass102_0() { }

		internal Task<IApiRpc> <RpcAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass103_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string id; //Field offset: 0x18
		public string payload; //Field offset: 0x20
		public string httpkey; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass103_0() { }

		internal Task<IApiRpc> <RpcAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass104_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string id; //Field offset: 0x18
		public string httpkey; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass104_0() { }

		internal Task<IApiRpc> <RpcAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass106_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string authToken; //Field offset: 0x18
		public string refreshToken; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass106_0() { }

		internal Task <SessionLogoutAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass107_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public Dictionary<String, String> vars; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass107_0() { }

		internal Task<IApiSession> <SessionRefreshAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass109_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string token; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass109_0() { }

		internal Task <UnlinkAppleAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass110_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string id; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass110_0() { }

		internal Task <UnlinkCustomAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass111_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string id; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass111_0() { }

		internal Task <UnlinkDeviceAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass112_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string email; //Field offset: 0x20
		public string password; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass112_0() { }

		internal Task <UnlinkEmailAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass113_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string token; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass113_0() { }

		internal Task <UnlinkFacebookAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass114_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string bundleId; //Field offset: 0x20
		public string playerId; //Field offset: 0x28
		public string publicKeyUrl; //Field offset: 0x30
		public string salt; //Field offset: 0x38
		public string signature; //Field offset: 0x40
		public string timestamp; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50

		public <>c__DisplayClass114_0() { }

		internal Task <UnlinkGameCenterAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass115_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string token; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass115_0() { }

		internal Task <UnlinkGoogleAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass116_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string token; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass116_0() { }

		internal Task <UnlinkSteamAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass117_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string avatarUrl; //Field offset: 0x20
		public string displayName; //Field offset: 0x28
		public string langTag; //Field offset: 0x30
		public string location; //Field offset: 0x38
		public string timezone; //Field offset: 0x40
		public string username; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50

		public <>c__DisplayClass117_0() { }

		internal Task <UpdateAccountAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass118_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string groupId; //Field offset: 0x20
		public string name; //Field offset: 0x28
		public bool open; //Field offset: 0x30
		public string avatarUrl; //Field offset: 0x38
		public string description; //Field offset: 0x40
		public string langTag; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50

		public <>c__DisplayClass118_0() { }

		internal Task <UpdateGroupAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass119_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string receipt; //Field offset: 0x20
		public bool persist; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass119_0() { }

		internal Task<IApiValidatePurchaseResponse> <ValidatePurchaseAppleAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass120_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string signedRequest; //Field offset: 0x20
		public bool persist; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass120_0() { }

		internal Task<IApiValidatePurchaseResponse> <ValidatePurchaseFacebookInstantAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass121_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string receipt; //Field offset: 0x20
		public bool persist; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass121_0() { }

		internal Task<IApiValidatePurchaseResponse> <ValidatePurchaseGoogleAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass122_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string receipt; //Field offset: 0x20
		public string signature; //Field offset: 0x28
		public bool persist; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38

		public <>c__DisplayClass122_0() { }

		internal Task<IApiValidatePurchaseResponse> <ValidatePurchaseHuaweiAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass123_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string receipt; //Field offset: 0x20
		public bool persist; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass123_0() { }

		internal Task<IApiValidateSubscriptionResponse> <ValidateSubscriptionAppleAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass124_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string receipt; //Field offset: 0x20
		public bool persist; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass124_0() { }

		internal Task<IApiValidateSubscriptionResponse> <ValidateSubscriptionGoogleAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass125_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string leaderboardId; //Field offset: 0x20
		public string metadata; //Field offset: 0x28
		public long score; //Field offset: 0x30
		public long subScore; //Field offset: 0x38
		public ApiOperator apiOperator; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48

		public <>c__DisplayClass125_0() { }

		internal Task<IApiLeaderboardRecord> <WriteLeaderboardRecordAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass126_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public List<ApiWriteStorageObject> writes; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass126_0() { }

		internal Task<IApiStorageObjectAcks> <WriteStorageObjectsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass127_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string tournamentId; //Field offset: 0x20
		public string metadata; //Field offset: 0x28
		public long score; //Field offset: 0x30
		public long subScore; //Field offset: 0x38
		public ApiOperator apiOperator; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48

		public <>c__DisplayClass127_0() { }

		internal Task<IApiLeaderboardRecord> <WriteTournamentRecordAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public IEnumerable<String> ids; //Field offset: 0x20
		public IEnumerable<String> usernames; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass42_0() { }

		internal Task <AddFriendsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string groupId; //Field offset: 0x20
		public IEnumerable<String> ids; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass43_0() { }

		internal Task <AddGroupUsersAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string token; //Field offset: 0x18
		public Dictionary<String, String> vars; //Field offset: 0x20
		public bool create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38

		public <>c__DisplayClass44_0() { }

		internal Task<IApiSession> <AuthenticateAppleAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string id; //Field offset: 0x18
		public Dictionary<String, String> vars; //Field offset: 0x20
		public bool create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38

		public <>c__DisplayClass45_0() { }

		internal Task<IApiSession> <AuthenticateCustomAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string id; //Field offset: 0x18
		public Dictionary<String, String> vars; //Field offset: 0x20
		public bool create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38

		public <>c__DisplayClass46_0() { }

		internal Task<IApiSession> <AuthenticateDeviceAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string email; //Field offset: 0x18
		public string password; //Field offset: 0x20
		public Dictionary<String, String> vars; //Field offset: 0x28
		public bool create; //Field offset: 0x30
		public string username; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40

		public <>c__DisplayClass47_0() { }

		internal Task<IApiSession> <AuthenticateEmailAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string token; //Field offset: 0x18
		public Dictionary<String, String> vars; //Field offset: 0x20
		public bool create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public bool import; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40

		public <>c__DisplayClass48_0() { }

		internal Task<IApiSession> <AuthenticateFacebookAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string bundleId; //Field offset: 0x18
		public string playerId; //Field offset: 0x20
		public string publicKeyUrl; //Field offset: 0x28
		public string salt; //Field offset: 0x30
		public string signature; //Field offset: 0x38
		public string timestamp; //Field offset: 0x40
		public Dictionary<String, String> vars; //Field offset: 0x48
		public bool create; //Field offset: 0x50
		public string username; //Field offset: 0x58
		public CancellationToken canceller; //Field offset: 0x60

		public <>c__DisplayClass49_0() { }

		internal Task<IApiSession> <AuthenticateGameCenterAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string token; //Field offset: 0x18
		public Dictionary<String, String> vars; //Field offset: 0x20
		public bool create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38

		public <>c__DisplayClass50_0() { }

		internal Task<IApiSession> <AuthenticateGoogleAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public Client <>4__this; //Field offset: 0x10
		public string token; //Field offset: 0x18
		public Dictionary<String, String> vars; //Field offset: 0x20
		public bool create; //Field offset: 0x28
		public string username; //Field offset: 0x30
		public bool import; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40

		public <>c__DisplayClass51_0() { }

		internal Task<IApiSession> <AuthenticateSteamAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string groupId; //Field offset: 0x20
		public IEnumerable<String> ids; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass52_0() { }

		internal Task <BanGroupUsersAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public IEnumerable<String> ids; //Field offset: 0x20
		public IEnumerable<String> usernames; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass53_0() { }

		internal Task <BlockFriendsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string name; //Field offset: 0x20
		public string description; //Field offset: 0x28
		public string avatarUrl; //Field offset: 0x30
		public string langTag; //Field offset: 0x38
		public bool open; //Field offset: 0x40
		public int maxCount; //Field offset: 0x44
		public CancellationToken canceller; //Field offset: 0x48

		public <>c__DisplayClass54_0() { }

		internal Task<IApiGroup> <CreateGroupAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public CancellationToken canceller; //Field offset: 0x20

		public <>c__DisplayClass55_0() { }

		internal Task <DeleteAccountAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public IEnumerable<String> ids; //Field offset: 0x20
		public IEnumerable<String> usernames; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass56_0() { }

		internal Task <DeleteFriendsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string groupId; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass57_0() { }

		internal Task <DeleteGroupAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string leaderboardId; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass58_0() { }

		internal Task <DeleteLeaderboardRecordAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public IEnumerable<String> ids; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass59_0() { }

		internal Task <DeleteNotificationsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public List<ApiDeleteStorageObjectId> objects; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass60_0() { }

		internal Task <DeleteStorageObjectsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string tournamentId; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass61_0() { }

		internal Task <DeleteTournamentRecordAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string groupId; //Field offset: 0x20
		public IEnumerable<String> usernames; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass62_0() { }

		internal Task <DemoteGroupUsersAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string name; //Field offset: 0x20
		public Dictionary<String, String> properties; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass63_0() { }

		internal Task <EventAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public CancellationToken canceller; //Field offset: 0x20

		public <>c__DisplayClass64_0() { }

		internal Task<IApiAccount> <GetAccountAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string productId; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass65_0() { }

		internal Task<IApiValidatedSubscription> <GetSubscriptionAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public IEnumerable<String> ids; //Field offset: 0x20
		public IEnumerable<String> usernames; //Field offset: 0x28
		public IEnumerable<String> facebookIds; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38

		public <>c__DisplayClass66_0() { }

		internal Task<IApiUsers> <GetUsersAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string token; //Field offset: 0x20
		public Nullable<Boolean> reset; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass67_0() { }

		internal Task <ImportFacebookFriendsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string token; //Field offset: 0x20
		public Nullable<Boolean> reset; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass68_0() { }

		internal Task <ImportSteamFriendsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string groupId; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass69_0() { }

		internal Task <JoinGroupAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string tournamentId; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass70_0() { }

		internal Task <JoinTournamentAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string groupId; //Field offset: 0x20
		public IEnumerable<String> ids; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass71_0() { }

		internal Task <KickGroupUsersAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string groupId; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass72_0() { }

		internal Task <LeaveGroupAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string token; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass73_0() { }

		internal Task <LinkAppleAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string id; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass74_0() { }

		internal Task <LinkCustomAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass75_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string id; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass75_0() { }

		internal Task <LinkDeviceAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string email; //Field offset: 0x20
		public string password; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass76_0() { }

		internal Task <LinkEmailAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string token; //Field offset: 0x20
		public Nullable<Boolean> import; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass77_0() { }

		internal Task <LinkFacebookAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string bundleId; //Field offset: 0x20
		public string playerId; //Field offset: 0x28
		public string publicKeyUrl; //Field offset: 0x30
		public string salt; //Field offset: 0x38
		public string signature; //Field offset: 0x40
		public string timestamp; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50

		public <>c__DisplayClass78_0() { }

		internal Task <LinkGameCenterAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string token; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28

		public <>c__DisplayClass79_0() { }

		internal Task <LinkGoogleAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public bool sync; //Field offset: 0x20
		public string token; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass80_0() { }

		internal Task <LinkSteamAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string channelId; //Field offset: 0x20
		public int limit; //Field offset: 0x28
		public bool forward; //Field offset: 0x2C
		public string cursor; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38

		public <>c__DisplayClass82_0() { }

		internal Task<IApiChannelMessageList> <ListChannelMessagesAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass83_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public int limit; //Field offset: 0x20
		public Nullable<Int32> state; //Field offset: 0x24
		public string cursor; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38

		public <>c__DisplayClass83_0() { }

		internal Task<IApiFriendList> <ListFriendsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass84_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string groupId; //Field offset: 0x20
		public int limit; //Field offset: 0x28
		public Nullable<Int32> state; //Field offset: 0x2C
		public string cursor; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40

		public <>c__DisplayClass84_0() { }

		internal Task<IApiGroupUserList> <ListGroupUsersAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass85_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string name; //Field offset: 0x20
		public string cursor; //Field offset: 0x28
		public int limit; //Field offset: 0x30
		public string langTag; //Field offset: 0x38
		public Nullable<Int32> members; //Field offset: 0x40
		public Nullable<Boolean> open; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50

		public <>c__DisplayClass85_0() { }

		internal Task<IApiGroupList> <ListGroupsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string leaderboardId; //Field offset: 0x20
		public IEnumerable<String> ownerIds; //Field offset: 0x28
		public int limit; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public Nullable<Int64> expiry; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x50

		public <>c__DisplayClass86_0() { }

		internal Task<IApiLeaderboardRecordList> <ListLeaderboardRecordsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string leaderboardId; //Field offset: 0x20
		public string ownerId; //Field offset: 0x28
		public int limit; //Field offset: 0x30
		public Nullable<Int64> expiry; //Field offset: 0x38
		public string cursor; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50

		public <>c__DisplayClass87_0() { }

		internal Task<IApiLeaderboardRecordList> <ListLeaderboardRecordsAroundOwnerAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass88_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public int limit; //Field offset: 0x20
		public bool authoritative; //Field offset: 0x24
		public string label; //Field offset: 0x28
		public int min; //Field offset: 0x30
		public int max; //Field offset: 0x34
		public string query; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40

		public <>c__DisplayClass88_0() { }

		internal Task<IApiMatchList> <ListMatchesAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public int limit; //Field offset: 0x20
		public string cacheableCursor; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass89_0() { }

		internal Task<IApiNotificationList> <ListNotificationsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string collection; //Field offset: 0x20
		public int limit; //Field offset: 0x28
		public string cursor; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38

		public <>c__DisplayClass90_0() { }

		internal Task<IApiStorageObjectList> <ListStorageObjects>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass91_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string collection; //Field offset: 0x20
		public int limit; //Field offset: 0x28
		public string cursor; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38

		public <>c__DisplayClass91_0() { }

		internal Task<IApiStorageObjectList> <ListStorageObjectsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass92_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string cursor; //Field offset: 0x20
		public int limit; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass92_0() { }

		internal Task<IApiSubscriptionList> <ListSubscriptionsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass93_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string tournamentId; //Field offset: 0x20
		public string ownerId; //Field offset: 0x28
		public int limit; //Field offset: 0x30
		public Nullable<Int64> expiry; //Field offset: 0x38
		public string cursor; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50

		public <>c__DisplayClass93_0() { }

		internal Task<IApiTournamentRecordList> <ListTournamentRecordsAroundOwnerAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass94_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string tournamentId; //Field offset: 0x20
		public IEnumerable<String> ownerIds; //Field offset: 0x28
		public int limit; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public Nullable<Int64> expiry; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x50

		public <>c__DisplayClass94_0() { }

		internal Task<IApiTournamentRecordList> <ListTournamentRecordsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass95_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public int categoryStart; //Field offset: 0x20
		public int categoryEnd; //Field offset: 0x24
		public Nullable<Int32> startTime; //Field offset: 0x28
		public Nullable<Int32> endTime; //Field offset: 0x30
		public int limit; //Field offset: 0x38
		public string cursor; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48

		public <>c__DisplayClass95_0() { }

		internal Task<IApiTournamentList> <ListTournamentsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass97_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string userId; //Field offset: 0x20
		public int limit; //Field offset: 0x28
		public Nullable<Int32> state; //Field offset: 0x2C
		public string cursor; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40

		public <>c__DisplayClass97_0() { }

		internal Task<IApiUserGroupList> <ListUserGroupsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass98_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string collection; //Field offset: 0x20
		public string userId; //Field offset: 0x28
		public int limit; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40

		public <>c__DisplayClass98_0() { }

		internal Task<IApiStorageObjectList> <ListUsersStorageObjectsAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass99_0
	{
		public Client <>4__this; //Field offset: 0x10
		public ISession session; //Field offset: 0x18
		public string groupId; //Field offset: 0x20
		public IEnumerable<String> ids; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30

		public <>c__DisplayClass99_0() { }

		internal Task <PromoteGroupUsersAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <AddFriendsAsync>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public IEnumerable<String> ids; //Field offset: 0x30
		public IEnumerable<String> usernames; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass42_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AddGroupUsersAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string groupId; //Field offset: 0x30
		public IEnumerable<String> ids; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass43_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateAppleAsync>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public string token; //Field offset: 0x28
		public Dictionary<String, String> vars; //Field offset: 0x30
		public bool create; //Field offset: 0x38
		public string username; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48
		public RetryConfiguration retryConfiguration; //Field offset: 0x50
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateCustomAsync>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public string id; //Field offset: 0x28
		public Dictionary<String, String> vars; //Field offset: 0x30
		public bool create; //Field offset: 0x38
		public string username; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48
		public RetryConfiguration retryConfiguration; //Field offset: 0x50
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateDeviceAsync>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public string id; //Field offset: 0x28
		public Dictionary<String, String> vars; //Field offset: 0x30
		public bool create; //Field offset: 0x38
		public string username; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48
		public RetryConfiguration retryConfiguration; //Field offset: 0x50
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateEmailAsync>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public string email; //Field offset: 0x28
		public string password; //Field offset: 0x30
		public Dictionary<String, String> vars; //Field offset: 0x38
		public bool create; //Field offset: 0x40
		public string username; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50
		public RetryConfiguration retryConfiguration; //Field offset: 0x58
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateFacebookAsync>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public string token; //Field offset: 0x28
		public Dictionary<String, String> vars; //Field offset: 0x30
		public bool create; //Field offset: 0x38
		public string username; //Field offset: 0x40
		public bool import; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50
		public RetryConfiguration retryConfiguration; //Field offset: 0x58
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateGameCenterAsync>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public string bundleId; //Field offset: 0x28
		public string playerId; //Field offset: 0x30
		public string publicKeyUrl; //Field offset: 0x38
		public string salt; //Field offset: 0x40
		public string signature; //Field offset: 0x48
		public string timestamp; //Field offset: 0x50
		public Dictionary<String, String> vars; //Field offset: 0x58
		public bool create; //Field offset: 0x60
		public string username; //Field offset: 0x68
		public CancellationToken canceller; //Field offset: 0x70
		public RetryConfiguration retryConfiguration; //Field offset: 0x78
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateGoogleAsync>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public string token; //Field offset: 0x28
		public Dictionary<String, String> vars; //Field offset: 0x30
		public bool create; //Field offset: 0x38
		public string username; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48
		public RetryConfiguration retryConfiguration; //Field offset: 0x50
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AuthenticateSteamAsync>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public string token; //Field offset: 0x28
		public Dictionary<String, String> vars; //Field offset: 0x30
		public bool create; //Field offset: 0x38
		public string username; //Field offset: 0x40
		public bool import; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50
		public RetryConfiguration retryConfiguration; //Field offset: 0x58
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BanGroupUsersAsync>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string groupId; //Field offset: 0x30
		public IEnumerable<String> ids; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass52_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BlockFriendsAsync>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public IEnumerable<String> ids; //Field offset: 0x30
		public IEnumerable<String> usernames; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass53_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateGroupAsync>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiGroup> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string name; //Field offset: 0x30
		public string description; //Field offset: 0x38
		public string avatarUrl; //Field offset: 0x40
		public string langTag; //Field offset: 0x48
		public bool open; //Field offset: 0x50
		public int maxCount; //Field offset: 0x54
		public CancellationToken canceller; //Field offset: 0x58
		public RetryConfiguration retryConfiguration; //Field offset: 0x60
		private <>c__DisplayClass54_0 <>8__1; //Field offset: 0x68
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x70
		private TaskAwaiter<IApiGroup> <>u__2; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteAccountAsync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30
		public RetryConfiguration retryConfiguration; //Field offset: 0x38
		private <>c__DisplayClass55_0 <>8__1; //Field offset: 0x40
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteFriendsAsync>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public IEnumerable<String> ids; //Field offset: 0x30
		public IEnumerable<String> usernames; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass56_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteGroupAsync>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string groupId; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass57_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteLeaderboardRecordAsync>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string leaderboardId; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass58_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteNotificationsAsync>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public IEnumerable<String> ids; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass59_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteStorageObjectsAsync>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30
		public RetryConfiguration retryConfiguration; //Field offset: 0x38
		private <>c__DisplayClass60_0 <>8__1; //Field offset: 0x40
		public StorageObjectId[] ids; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteTournamentRecordAsync>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string tournamentId; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass61_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DemoteGroupUsersAsync>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string groupId; //Field offset: 0x30
		public IEnumerable<String> usernames; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass62_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EventAsync>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string name; //Field offset: 0x30
		public Dictionary<String, String> properties; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass63_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAccountAsync>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiAccount> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30
		public RetryConfiguration retryConfiguration; //Field offset: 0x38
		private <>c__DisplayClass64_0 <>8__1; //Field offset: 0x40
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x48
		private TaskAwaiter<IApiAccount> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetSubscriptionAsync>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidatedSubscription> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string productId; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass65_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter<IApiValidatedSubscription> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetUsersAsync>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiUsers> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public IEnumerable<String> ids; //Field offset: 0x30
		public IEnumerable<String> usernames; //Field offset: 0x38
		public IEnumerable<String> facebookIds; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48
		public RetryConfiguration retryConfiguration; //Field offset: 0x50
		private <>c__DisplayClass66_0 <>8__1; //Field offset: 0x58
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x60
		private TaskAwaiter<IApiUsers> <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ImportFacebookFriendsAsync>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string token; //Field offset: 0x30
		public Nullable<Boolean> reset; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass67_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ImportSteamFriendsAsync>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string token; //Field offset: 0x30
		public Nullable<Boolean> reset; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass68_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <JoinGroupAsync>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string groupId; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass69_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <JoinTournamentAsync>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string tournamentId; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass70_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <KickGroupUsersAsync>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string groupId; //Field offset: 0x30
		public IEnumerable<String> ids; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass71_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LeaveGroupAsync>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string groupId; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass72_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkAppleAsync>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string token; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass73_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkCustomAsync>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string id; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass74_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkDeviceAsync>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string id; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass75_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkEmailAsync>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string email; //Field offset: 0x30
		public string password; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass76_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkFacebookAsync>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string token; //Field offset: 0x30
		public Nullable<Boolean> import; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass77_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkGameCenterAsync>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string bundleId; //Field offset: 0x30
		public string playerId; //Field offset: 0x38
		public string publicKeyUrl; //Field offset: 0x40
		public string salt; //Field offset: 0x48
		public string signature; //Field offset: 0x50
		public string timestamp; //Field offset: 0x58
		public CancellationToken canceller; //Field offset: 0x60
		public RetryConfiguration retryConfiguration; //Field offset: 0x68
		private <>c__DisplayClass78_0 <>8__1; //Field offset: 0x70
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x78
		private TaskAwaiter <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkGoogleAsync>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string token; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass79_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkSteamAsync>d__80 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public bool sync; //Field offset: 0x30
		public string token; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass80_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListChannelMessagesAsync>d__82 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiChannelMessageList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string channelId; //Field offset: 0x30
		public int limit; //Field offset: 0x38
		public bool forward; //Field offset: 0x3C
		public string cursor; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48
		public RetryConfiguration retryConfiguration; //Field offset: 0x50
		private <>c__DisplayClass82_0 <>8__1; //Field offset: 0x58
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x60
		private TaskAwaiter<IApiChannelMessageList> <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListFriendsAsync>d__83 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiFriendList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public int limit; //Field offset: 0x30
		public Nullable<Int32> state; //Field offset: 0x34
		public string cursor; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48
		public RetryConfiguration retryConfiguration; //Field offset: 0x50
		private <>c__DisplayClass83_0 <>8__1; //Field offset: 0x58
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x60
		private TaskAwaiter<IApiFriendList> <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListGroupsAsync>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiGroupList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string name; //Field offset: 0x30
		public string cursor; //Field offset: 0x38
		public int limit; //Field offset: 0x40
		public string langTag; //Field offset: 0x48
		public Nullable<Int32> members; //Field offset: 0x50
		public Nullable<Boolean> open; //Field offset: 0x58
		public CancellationToken canceller; //Field offset: 0x60
		public RetryConfiguration retryConfiguration; //Field offset: 0x68
		private <>c__DisplayClass85_0 <>8__1; //Field offset: 0x70
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x78
		private TaskAwaiter<IApiGroupList> <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListGroupUsersAsync>d__84 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiGroupUserList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string groupId; //Field offset: 0x30
		public int limit; //Field offset: 0x38
		public Nullable<Int32> state; //Field offset: 0x3C
		public string cursor; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50
		public RetryConfiguration retryConfiguration; //Field offset: 0x58
		private <>c__DisplayClass84_0 <>8__1; //Field offset: 0x60
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x68
		private TaskAwaiter<IApiGroupUserList> <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListLeaderboardRecordsAroundOwnerAsync>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLeaderboardRecordList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string leaderboardId; //Field offset: 0x30
		public string ownerId; //Field offset: 0x38
		public int limit; //Field offset: 0x40
		public Nullable<Int64> expiry; //Field offset: 0x48
		public string cursor; //Field offset: 0x58
		public CancellationToken canceller; //Field offset: 0x60
		public RetryConfiguration retryConfiguration; //Field offset: 0x68
		private <>c__DisplayClass87_0 <>8__1; //Field offset: 0x70
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x78
		private TaskAwaiter<IApiLeaderboardRecordList> <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListLeaderboardRecordsAsync>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLeaderboardRecordList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string leaderboardId; //Field offset: 0x30
		public IEnumerable<String> ownerIds; //Field offset: 0x38
		public int limit; //Field offset: 0x40
		public string cursor; //Field offset: 0x48
		public Nullable<Int64> expiry; //Field offset: 0x50
		public CancellationToken canceller; //Field offset: 0x60
		public RetryConfiguration retryConfiguration; //Field offset: 0x68
		private <>c__DisplayClass86_0 <>8__1; //Field offset: 0x70
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x78
		private TaskAwaiter<IApiLeaderboardRecordList> <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListMatchesAsync>d__88 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiMatchList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public int limit; //Field offset: 0x30
		public bool authoritative; //Field offset: 0x34
		public string label; //Field offset: 0x38
		public int min; //Field offset: 0x40
		public int max; //Field offset: 0x44
		public string query; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50
		public RetryConfiguration retryConfiguration; //Field offset: 0x58
		private <>c__DisplayClass88_0 <>8__1; //Field offset: 0x60
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x68
		private TaskAwaiter<IApiMatchList> <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListNotificationsAsync>d__89 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiNotificationList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public int limit; //Field offset: 0x30
		public string cacheableCursor; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass89_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IApiNotificationList> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListStorageObjectsAsync>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiStorageObjectList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string collection; //Field offset: 0x30
		public int limit; //Field offset: 0x38
		public string cursor; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48
		public RetryConfiguration retryConfiguration; //Field offset: 0x50
		private <>c__DisplayClass91_0 <>8__1; //Field offset: 0x58
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x60
		private TaskAwaiter<IApiStorageObjectList> <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListSubscriptionsAsync>d__92 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiSubscriptionList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string cursor; //Field offset: 0x30
		public int limit; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass92_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IApiSubscriptionList> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListTournamentRecordsAroundOwnerAsync>d__93 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiTournamentRecordList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string tournamentId; //Field offset: 0x30
		public string ownerId; //Field offset: 0x38
		public int limit; //Field offset: 0x40
		public Nullable<Int64> expiry; //Field offset: 0x48
		public string cursor; //Field offset: 0x58
		public CancellationToken canceller; //Field offset: 0x60
		public RetryConfiguration retryConfiguration; //Field offset: 0x68
		private <>c__DisplayClass93_0 <>8__1; //Field offset: 0x70
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x78
		private TaskAwaiter<IApiTournamentRecordList> <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListTournamentRecordsAsync>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiTournamentRecordList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string tournamentId; //Field offset: 0x30
		public IEnumerable<String> ownerIds; //Field offset: 0x38
		public int limit; //Field offset: 0x40
		public string cursor; //Field offset: 0x48
		public Nullable<Int64> expiry; //Field offset: 0x50
		public CancellationToken canceller; //Field offset: 0x60
		public RetryConfiguration retryConfiguration; //Field offset: 0x68
		private <>c__DisplayClass94_0 <>8__1; //Field offset: 0x70
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x78
		private TaskAwaiter<IApiTournamentRecordList> <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListTournamentsAsync>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiTournamentList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public int categoryStart; //Field offset: 0x30
		public int categoryEnd; //Field offset: 0x34
		public Nullable<Int32> startTime; //Field offset: 0x38
		public Nullable<Int32> endTime; //Field offset: 0x40
		public int limit; //Field offset: 0x48
		public string cursor; //Field offset: 0x50
		public CancellationToken canceller; //Field offset: 0x58
		public RetryConfiguration retryConfiguration; //Field offset: 0x60
		private <>c__DisplayClass95_0 <>8__1; //Field offset: 0x68
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x70
		private TaskAwaiter<IApiTournamentList> <>u__2; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListUserGroupsAsync>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiUserGroupList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string userId; //Field offset: 0x30
		public int limit; //Field offset: 0x38
		public Nullable<Int32> state; //Field offset: 0x3C
		public string cursor; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50
		public RetryConfiguration retryConfiguration; //Field offset: 0x58
		private <>c__DisplayClass97_0 <>8__1; //Field offset: 0x60
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x68
		private TaskAwaiter<IApiUserGroupList> <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListUsersStorageObjectsAsync>d__98 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiStorageObjectList> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string collection; //Field offset: 0x30
		public string userId; //Field offset: 0x38
		public int limit; //Field offset: 0x40
		public string cursor; //Field offset: 0x48
		public CancellationToken canceller; //Field offset: 0x50
		public RetryConfiguration retryConfiguration; //Field offset: 0x58
		private <>c__DisplayClass98_0 <>8__1; //Field offset: 0x60
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x68
		private TaskAwaiter<IApiStorageObjectList> <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PromoteGroupUsersAsync>d__99 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string groupId; //Field offset: 0x30
		public IEnumerable<String> ids; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass99_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadStorageObjectsAsync>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiStorageObjects> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30
		public RetryConfiguration retryConfiguration; //Field offset: 0x38
		private <>c__DisplayClass100_0 <>8__1; //Field offset: 0x40
		public IApiReadStorageObjectId[] ids; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter<IApiStorageObjects> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RpcAsync>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiRpc> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string id; //Field offset: 0x30
		public string payload; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass101_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IApiRpc> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RpcAsync>d__102 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiRpc> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string id; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass102_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter<IApiRpc> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SessionRefreshAsync>d__107 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ISession> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public Dictionary<String, String> vars; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass107_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<IApiSession> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkAppleAsync>d__109 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string token; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass109_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkCustomAsync>d__110 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string id; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass110_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkDeviceAsync>d__111 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string id; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass111_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkEmailAsync>d__112 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string email; //Field offset: 0x30
		public string password; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass112_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkFacebookAsync>d__113 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string token; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass113_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkGameCenterAsync>d__114 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string bundleId; //Field offset: 0x30
		public string playerId; //Field offset: 0x38
		public string publicKeyUrl; //Field offset: 0x40
		public string salt; //Field offset: 0x48
		public string signature; //Field offset: 0x50
		public string timestamp; //Field offset: 0x58
		public CancellationToken canceller; //Field offset: 0x60
		public RetryConfiguration retryConfiguration; //Field offset: 0x68
		private <>c__DisplayClass114_0 <>8__1; //Field offset: 0x70
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x78
		private TaskAwaiter <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkGoogleAsync>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string token; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass115_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnlinkSteamAsync>d__116 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string token; //Field offset: 0x30
		public CancellationToken canceller; //Field offset: 0x38
		public RetryConfiguration retryConfiguration; //Field offset: 0x40
		private <>c__DisplayClass116_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateAccountAsync>d__117 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string avatarUrl; //Field offset: 0x30
		public string displayName; //Field offset: 0x38
		public string langTag; //Field offset: 0x40
		public string location; //Field offset: 0x48
		public string timezone; //Field offset: 0x50
		public string username; //Field offset: 0x58
		public CancellationToken canceller; //Field offset: 0x60
		public RetryConfiguration retryConfiguration; //Field offset: 0x68
		private <>c__DisplayClass117_0 <>8__1; //Field offset: 0x70
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x78
		private TaskAwaiter <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateGroupAsync>d__118 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string groupId; //Field offset: 0x30
		public string name; //Field offset: 0x38
		public bool open; //Field offset: 0x40
		public string avatarUrl; //Field offset: 0x48
		public string description; //Field offset: 0x50
		public string langTag; //Field offset: 0x58
		public CancellationToken canceller; //Field offset: 0x60
		public RetryConfiguration retryConfiguration; //Field offset: 0x68
		private <>c__DisplayClass118_0 <>8__1; //Field offset: 0x70
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x78
		private TaskAwaiter <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidatePurchaseAppleAsync>d__119 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidatePurchaseResponse> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string receipt; //Field offset: 0x30
		public bool persist; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass119_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IApiValidatePurchaseResponse> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidatePurchaseFacebookInstantAsync>d__120 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidatePurchaseResponse> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string signedRequest; //Field offset: 0x30
		public bool persist; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass120_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IApiValidatePurchaseResponse> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidatePurchaseGoogleAsync>d__121 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidatePurchaseResponse> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string receipt; //Field offset: 0x30
		public bool persist; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass121_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IApiValidatePurchaseResponse> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidatePurchaseHuaweiAsync>d__122 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidatePurchaseResponse> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string receipt; //Field offset: 0x30
		public string signature; //Field offset: 0x38
		public bool persist; //Field offset: 0x40
		public CancellationToken canceller; //Field offset: 0x48
		public RetryConfiguration retryConfiguration; //Field offset: 0x50
		private <>c__DisplayClass122_0 <>8__1; //Field offset: 0x58
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x60
		private TaskAwaiter<IApiValidatePurchaseResponse> <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateSubscriptionAppleAsync>d__123 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidateSubscriptionResponse> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string receipt; //Field offset: 0x30
		public bool persist; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass123_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IApiValidateSubscriptionResponse> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateSubscriptionGoogleAsync>d__124 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiValidateSubscriptionResponse> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string receipt; //Field offset: 0x30
		public bool persist; //Field offset: 0x38
		public CancellationToken canceller; //Field offset: 0x40
		public RetryConfiguration retryConfiguration; //Field offset: 0x48
		private <>c__DisplayClass124_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IApiValidateSubscriptionResponse> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteLeaderboardRecordAsync>d__125 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLeaderboardRecord> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string leaderboardId; //Field offset: 0x30
		public string metadata; //Field offset: 0x38
		public long score; //Field offset: 0x40
		public long subScore; //Field offset: 0x48
		public ApiOperator apiOperator; //Field offset: 0x50
		public CancellationToken canceller; //Field offset: 0x58
		public RetryConfiguration retryConfiguration; //Field offset: 0x60
		private <>c__DisplayClass125_0 <>8__1; //Field offset: 0x68
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x70
		private TaskAwaiter<IApiLeaderboardRecord> <>u__2; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteStorageObjectsAsync>d__126 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiStorageObjectAcks> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30
		public RetryConfiguration retryConfiguration; //Field offset: 0x38
		private <>c__DisplayClass126_0 <>8__1; //Field offset: 0x40
		public IApiWriteStorageObject[] objects; //Field offset: 0x48
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x50
		private TaskAwaiter<IApiStorageObjectAcks> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteTournamentRecordAsync>d__127 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiLeaderboardRecord> <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public ISession session; //Field offset: 0x28
		public string tournamentId; //Field offset: 0x30
		public string metadata; //Field offset: 0x38
		public long score; //Field offset: 0x40
		public long subScore; //Field offset: 0x48
		public ApiOperator apiOperator; //Field offset: 0x50
		public CancellationToken canceller; //Field offset: 0x58
		public RetryConfiguration retryConfiguration; //Field offset: 0x60
		private <>c__DisplayClass127_0 <>8__1; //Field offset: 0x68
		private TaskAwaiter<ISession> <>u__1; //Field offset: 0x70
		private TaskAwaiter<IApiLeaderboardRecord> <>u__2; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string DefaultHost = "127.0.0.1"; //Field offset: 0x0
	public const string DefaultScheme = "http"; //Field offset: 0x0
	public const int DefaultPort = 7350; //Field offset: 0x0
	public static TimeSpan DefaultExpiredTimeSpan; //Field offset: 0x0
	private const int DefaultTimeout = 15; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <AutoRefreshSession>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private RetryConfiguration <GlobalRetryConfiguration>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <Host>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly int <Port>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <Scheme>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <ServerKey>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Action<ISession> ReceivedSessionUpdated; //Field offset: 0x40
	private readonly ApiClient _apiClient; //Field offset: 0x48
	private ILogger _logger; //Field offset: 0x50
	private readonly RetryInvoker _retryInvoker; //Field offset: 0x58

	public override event Action<ISession> ReceivedSessionUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override bool AutoRefreshSession
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override RetryConfiguration GlobalRetryConfiguration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override string Host
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override ILogger Logger
	{
		 get { } //Length: 8
		 set { } //Length: 188
	}

	public override int Port
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override string Scheme
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override string ServerKey
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override int Timeout
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	private static Client() { }

	public Client(Uri uri, string serverKey, IHttpAdapter adapter, bool autoRefreshSession = true) { }

	public Client(Uri uri, string serverKey) { }

	public Client(string scheme, string host, int port, string serverKey, IHttpAdapter adapter, bool autoRefreshSession = true) { }

	public Client(string scheme, string host, int port, string serverKey) { }

	public Client(string serverKey) { }

	public Client(string serverKey, IHttpAdapter adapter) { }

	[CompilerGenerated]
	public override void add_ReceivedSessionUpdated(Action<ISession> value) { }

	[AsyncStateMachine(typeof(<AddFriendsAsync>d__42))]
	public override Task AddFriendsAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<AddGroupUsersAsync>d__43))]
	public override Task AddGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<AuthenticateAppleAsync>d__44))]
	public override Task<ISession> AuthenticateAppleAsync(string token, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<AuthenticateCustomAsync>d__45))]
	public override Task<ISession> AuthenticateCustomAsync(string id, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<AuthenticateDeviceAsync>d__46))]
	public override Task<ISession> AuthenticateDeviceAsync(string id, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<AuthenticateEmailAsync>d__47))]
	public override Task<ISession> AuthenticateEmailAsync(string email, string password, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<AuthenticateFacebookAsync>d__48))]
	public override Task<ISession> AuthenticateFacebookAsync(string token, string username = null, bool create = true, bool import = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<AuthenticateGameCenterAsync>d__49))]
	public override Task<ISession> AuthenticateGameCenterAsync(string bundleId, string playerId, string publicKeyUrl, string salt, string signature, string timestamp, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<AuthenticateGoogleAsync>d__50))]
	public override Task<ISession> AuthenticateGoogleAsync(string token, string username = null, bool create = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<AuthenticateSteamAsync>d__51))]
	public override Task<ISession> AuthenticateSteamAsync(string token, string username = null, bool create = true, bool import = true, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<BanGroupUsersAsync>d__52))]
	public override Task BanGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<BlockFriendsAsync>d__53))]
	public override Task BlockFriendsAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<CreateGroupAsync>d__54))]
	public override Task<IApiGroup> CreateGroupAsync(ISession session, string name, string description = "", string avatarUrl = null, string langTag = null, bool open = true, int maxCount = 100, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<DeleteAccountAsync>d__55))]
	public override Task DeleteAccountAsync(ISession session, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<DeleteFriendsAsync>d__56))]
	public override Task DeleteFriendsAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<DeleteGroupAsync>d__57))]
	public override Task DeleteGroupAsync(ISession session, string groupId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<DeleteLeaderboardRecordAsync>d__58))]
	public override Task DeleteLeaderboardRecordAsync(ISession session, string leaderboardId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<DeleteNotificationsAsync>d__59))]
	public override Task DeleteNotificationsAsync(ISession session, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<DeleteStorageObjectsAsync>d__60))]
	public override Task DeleteStorageObjectsAsync(ISession session, StorageObjectId[] ids = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<DeleteTournamentRecordAsync>d__61))]
	public override Task DeleteTournamentRecordAsync(ISession session, string tournamentId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<DemoteGroupUsersAsync>d__62))]
	public override Task DemoteGroupUsersAsync(ISession session, string groupId, IEnumerable<String> usernames, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<EventAsync>d__63))]
	public override Task EventAsync(ISession session, string name, Dictionary<String, String> properties, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[CompilerGenerated]
	public override bool get_AutoRefreshSession() { }

	[CompilerGenerated]
	public override RetryConfiguration get_GlobalRetryConfiguration() { }

	[CompilerGenerated]
	public override string get_Host() { }

	public override ILogger get_Logger() { }

	[CompilerGenerated]
	public override int get_Port() { }

	[CompilerGenerated]
	public override string get_Scheme() { }

	[CompilerGenerated]
	public override string get_ServerKey() { }

	public override int get_Timeout() { }

	[AsyncStateMachine(typeof(<GetAccountAsync>d__64))]
	public override Task<IApiAccount> GetAccountAsync(ISession session, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<GetSubscriptionAsync>d__65))]
	public override Task<IApiValidatedSubscription> GetSubscriptionAsync(ISession session, string productId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<GetUsersAsync>d__66))]
	public override Task<IApiUsers> GetUsersAsync(ISession session, IEnumerable<String> ids, IEnumerable<String> usernames = null, IEnumerable<String> facebookIds = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ImportFacebookFriendsAsync>d__67))]
	public override Task ImportFacebookFriendsAsync(ISession session, string token, Nullable<Boolean> reset = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ImportSteamFriendsAsync>d__68))]
	public override Task ImportSteamFriendsAsync(ISession session, string token, Nullable<Boolean> reset = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<JoinGroupAsync>d__69))]
	public override Task JoinGroupAsync(ISession session, string groupId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<JoinTournamentAsync>d__70))]
	public override Task JoinTournamentAsync(ISession session, string tournamentId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<KickGroupUsersAsync>d__71))]
	public override Task KickGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<LeaveGroupAsync>d__72))]
	public override Task LeaveGroupAsync(ISession session, string groupId, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<LinkAppleAsync>d__73))]
	public override Task LinkAppleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<LinkCustomAsync>d__74))]
	public override Task LinkCustomAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<LinkDeviceAsync>d__75))]
	public override Task LinkDeviceAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<LinkEmailAsync>d__76))]
	public override Task LinkEmailAsync(ISession session, string email, string password, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<LinkFacebookAsync>d__77))]
	public override Task LinkFacebookAsync(ISession session, string token, Nullable<Boolean> import = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<LinkGameCenterAsync>d__78))]
	public override Task LinkGameCenterAsync(ISession session, string bundleId, string playerId, string publicKeyUrl, string salt, string signature, string timestamp, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<LinkGoogleAsync>d__79))]
	public override Task LinkGoogleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<LinkSteamAsync>d__80))]
	public override Task LinkSteamAsync(ISession session, string token, bool sync, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiChannelMessageList> ListChannelMessagesAsync(ISession session, IChannel channel, int limit = 1, bool forward = true, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListChannelMessagesAsync>d__82))]
	public override Task<IApiChannelMessageList> ListChannelMessagesAsync(ISession session, string channelId, int limit = 1, bool forward = true, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListFriendsAsync>d__83))]
	public override Task<IApiFriendList> ListFriendsAsync(ISession session, Nullable<Int32> state, int limit, string cursor, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListGroupsAsync>d__85))]
	public override Task<IApiGroupList> ListGroupsAsync(ISession session, string name = null, int limit = 1, string cursor = null, string langTag = null, Nullable<Int32> members = null, Nullable<Boolean> open = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListGroupUsersAsync>d__84))]
	public override Task<IApiGroupUserList> ListGroupUsersAsync(ISession session, string groupId, Nullable<Int32> state, int limit, string cursor, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListLeaderboardRecordsAroundOwnerAsync>d__87))]
	public override Task<IApiLeaderboardRecordList> ListLeaderboardRecordsAroundOwnerAsync(ISession session, string leaderboardId, string ownerId, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListLeaderboardRecordsAsync>d__86))]
	public override Task<IApiLeaderboardRecordList> ListLeaderboardRecordsAsync(ISession session, string leaderboardId, IEnumerable<String> ownerIds = null, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListMatchesAsync>d__88))]
	public override Task<IApiMatchList> ListMatchesAsync(ISession session, int min, int max, int limit, bool authoritative, string label, string query, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListNotificationsAsync>d__89))]
	public override Task<IApiNotificationList> ListNotificationsAsync(ISession session, int limit = 1, string cacheableCursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[Obsolete("ListStorageObjects is obsolete, please use ListStorageObjectsAsync instead.", True)]
	public override Task<IApiStorageObjectList> ListStorageObjects(ISession session, string collection, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListStorageObjectsAsync>d__91))]
	public override Task<IApiStorageObjectList> ListStorageObjectsAsync(ISession session, string collection, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListSubscriptionsAsync>d__92))]
	public override Task<IApiSubscriptionList> ListSubscriptionsAsync(ISession session, int limit, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListTournamentRecordsAroundOwnerAsync>d__93))]
	public override Task<IApiTournamentRecordList> ListTournamentRecordsAroundOwnerAsync(ISession session, string tournamentId, string ownerId, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListTournamentRecordsAsync>d__94))]
	public override Task<IApiTournamentRecordList> ListTournamentRecordsAsync(ISession session, string tournamentId, IEnumerable<String> ownerIds = null, Nullable<Int64> expiry = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListTournamentsAsync>d__95))]
	public override Task<IApiTournamentList> ListTournamentsAsync(ISession session, int categoryStart, int categoryEnd, Nullable<Int32> startTime = null, Nullable<Int32> endTime = null, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListUserGroupsAsync>d__97))]
	public override Task<IApiUserGroupList> ListUserGroupsAsync(ISession session, string userId, Nullable<Int32> state, int limit, string cursor, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiUserGroupList> ListUserGroupsAsync(ISession session, Nullable<Int32> state, int limit, string cursor, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ListUsersStorageObjectsAsync>d__98))]
	public override Task<IApiStorageObjectList> ListUsersStorageObjectsAsync(ISession session, string collection, string userId, int limit = 1, string cursor = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<PromoteGroupUsersAsync>d__99))]
	public override Task PromoteGroupUsersAsync(ISession session, string groupId, IEnumerable<String> ids, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ReadStorageObjectsAsync>d__100))]
	public override Task<IApiStorageObjects> ReadStorageObjectsAsync(ISession session, IApiReadStorageObjectId[] ids = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[CompilerGenerated]
	public override void remove_ReceivedSessionUpdated(Action<ISession> value) { }

	[AsyncStateMachine(typeof(<RpcAsync>d__101))]
	public override Task<IApiRpc> RpcAsync(ISession session, string id, string payload, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<RpcAsync>d__102))]
	public override Task<IApiRpc> RpcAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiRpc> RpcAsync(string httpkey, string id, string payload, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task<IApiRpc> RpcAsync(string httpkey, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task SessionLogoutAsync(ISession session, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	public override Task SessionLogoutAsync(string authToken, string refreshToken, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<SessionRefreshAsync>d__107))]
	public override Task<ISession> SessionRefreshAsync(ISession session, Dictionary<String, String> vars = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[CompilerGenerated]
	public override void set_GlobalRetryConfiguration(RetryConfiguration value) { }

	public override void set_Logger(ILogger value) { }

	public override void set_Timeout(int value) { }

	public virtual string ToString() { }

	[AsyncStateMachine(typeof(<UnlinkAppleAsync>d__109))]
	public override Task UnlinkAppleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<UnlinkCustomAsync>d__110))]
	public override Task UnlinkCustomAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<UnlinkDeviceAsync>d__111))]
	public override Task UnlinkDeviceAsync(ISession session, string id, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<UnlinkEmailAsync>d__112))]
	public override Task UnlinkEmailAsync(ISession session, string email, string password, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<UnlinkFacebookAsync>d__113))]
	public override Task UnlinkFacebookAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<UnlinkGameCenterAsync>d__114))]
	public override Task UnlinkGameCenterAsync(ISession session, string bundleId, string playerId, string publicKeyUrl, string salt, string signature, string timestamp, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<UnlinkGoogleAsync>d__115))]
	public override Task UnlinkGoogleAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<UnlinkSteamAsync>d__116))]
	public override Task UnlinkSteamAsync(ISession session, string token, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<UpdateAccountAsync>d__117))]
	public override Task UpdateAccountAsync(ISession session, string username, string displayName = null, string avatarUrl = null, string langTag = null, string location = null, string timezone = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<UpdateGroupAsync>d__118))]
	public override Task UpdateGroupAsync(ISession session, string groupId, string name, bool open, string description = null, string avatarUrl = null, string langTag = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ValidatePurchaseAppleAsync>d__119))]
	public override Task<IApiValidatePurchaseResponse> ValidatePurchaseAppleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ValidatePurchaseFacebookInstantAsync>d__120))]
	public override Task<IApiValidatePurchaseResponse> ValidatePurchaseFacebookInstantAsync(ISession session, string signedRequest, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ValidatePurchaseGoogleAsync>d__121))]
	public override Task<IApiValidatePurchaseResponse> ValidatePurchaseGoogleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ValidatePurchaseHuaweiAsync>d__122))]
	public override Task<IApiValidatePurchaseResponse> ValidatePurchaseHuaweiAsync(ISession session, string receipt, string signature, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ValidateSubscriptionAppleAsync>d__123))]
	public override Task<IApiValidateSubscriptionResponse> ValidateSubscriptionAppleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<ValidateSubscriptionGoogleAsync>d__124))]
	public override Task<IApiValidateSubscriptionResponse> ValidateSubscriptionGoogleAsync(ISession session, string receipt, bool persist = true, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<WriteLeaderboardRecordAsync>d__125))]
	public override Task<IApiLeaderboardRecord> WriteLeaderboardRecordAsync(ISession session, string leaderboardId, long score, long subScore = 0, string metadata = null, ApiOperator apiOperator = 0, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<WriteStorageObjectsAsync>d__126))]
	public override Task<IApiStorageObjectAcks> WriteStorageObjectsAsync(ISession session, IApiWriteStorageObject[] objects = null, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

	[AsyncStateMachine(typeof(<WriteTournamentRecordAsync>d__127))]
	public override Task<IApiLeaderboardRecord> WriteTournamentRecordAsync(ISession session, string tournamentId, long score, long subScore = 0, string metadata = null, ApiOperator apiOperator = 0, RetryConfiguration retryConfiguration = null, CancellationToken canceller = null) { }

}

