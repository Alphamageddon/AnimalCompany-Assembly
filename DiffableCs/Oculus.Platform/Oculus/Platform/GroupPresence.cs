namespace Oculus.Platform;

public static class GroupPresence
{

	public static Request Clear() { }

	public static Request<UserList> GetInvitableUsers(InviteOptions options) { }

	public static Request<ApplicationInviteList> GetNextApplicationInviteListPage(ApplicationInviteList list) { }

	public static Request<ApplicationInviteList> GetSentInvites() { }

	public static Request<InvitePanelResultInfo> LaunchInvitePanel(InviteOptions options) { }

	public static Request LaunchMultiplayerErrorDialog(MultiplayerErrorOptions options) { }

	public static Request<RejoinDialogResult> LaunchRejoinDialog(string lobby_session_id, string match_session_id, string destination_api_name) { }

	public static Request LaunchRosterPanel(RosterOptions options) { }

	public static Request<SendInvitesResult> SendInvites(UInt64[] userIDs) { }

	public static Request Set(GroupPresenceOptions groupPresenceOptions) { }

	public static Request SetDeeplinkMessageOverride(string deeplink_message) { }

	public static Request SetDestination(string api_name) { }

	public static void SetInvitationsSentNotificationCallback(Callback<LaunchInvitePanelFlowResult> callback) { }

	public static Request SetIsJoinable(bool is_joinable) { }

	public static void SetJoinIntentReceivedNotificationCallback(Callback<GroupPresenceJoinIntent> callback) { }

	public static void SetLeaveIntentReceivedNotificationCallback(Callback<GroupPresenceLeaveIntent> callback) { }

	public static Request SetLobbySession(string id) { }

	public static Request SetMatchSession(string id) { }

}

