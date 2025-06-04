namespace Oculus.Platform;

public static class Users
{

	public static Request<User> Get(ulong userID) { }

	public static Request<String> GetAccessToken() { }

	public static Request<BlockedUserList> GetBlockedUsers() { }

	public static Request<User> GetLoggedInUser() { }

	public static Request<UserList> GetLoggedInUserFriends() { }

	public static string GetLoggedInUserLocale() { }

	public static Request<BlockedUserList> GetNextBlockedUserListPage(BlockedUserList list) { }

	public static Request<UserCapabilityList> GetNextUserCapabilityListPage(UserCapabilityList list) { }

	public static Request<UserList> GetNextUserListPage(UserList list) { }

	public static Request<OrgScopedID> GetOrgScopedID(ulong userID) { }

	public static Request<SdkAccountList> GetSdkAccounts() { }

	public static Request<UserProof> GetUserProof() { }

	public static Request<LaunchBlockFlowResult> LaunchBlockFlow(ulong userID) { }

	public static Request<LaunchFriendRequestFlowResult> LaunchFriendRequestFlow(ulong userID) { }

	public static Request<LaunchUnblockFlowResult> LaunchUnblockFlow(ulong userID) { }

}

