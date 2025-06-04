namespace Oculus.Platform;

public class Message
{
	internal sealed class Callback : MulticastDelegate
	{

		public Callback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Message message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Message message) { }

	}

	public sealed class ExtraMessageTypesHandler : MulticastDelegate
	{

		public ExtraMessageTypesHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr messageHandle, MessageType message_type, AsyncCallback callback, object object) { }

		public override Message EndInvoke(IAsyncResult result) { }

		public override Message Invoke(IntPtr messageHandle, MessageType message_type) { }

	}

	internal enum MessageType
	{
		Unknown = 0,
		AbuseReport_ReportRequestHandled = 1267661958,
		Achievements_AddCount = 65495601,
		Achievements_AddFields = 346693929,
		Achievements_GetAllDefinitions = 64177549,
		Achievements_GetAllProgress = 1335877149,
		Achievements_GetDefinitionsByName = 1653670332,
		Achievements_GetNextAchievementDefinitionArrayPage = 712888917,
		Achievements_GetNextAchievementProgressArrayPage = 792913703,
		Achievements_GetProgressByName = 354837425,
		Achievements_Unlock = 1497156573,
		ApplicationLifecycle_GetRegisteredPIDs = 82169698,
		ApplicationLifecycle_GetSessionKey = 984570141,
		ApplicationLifecycle_RegisterSessionKey = 1303818232,
		Application_CancelAppDownload = 2082496734,
		Application_CheckAppDownloadProgress = 1429514532,
		Application_GetVersion = 1751583246,
		Application_InstallAppUpdateAndRelaunch = 343960453,
		Application_LaunchOtherApp = 1424151032,
		Application_StartAppDownload = 1157365870,
		AssetFile_Delete = 1834842246,
		AssetFile_DeleteById = 1525206354,
		AssetFile_DeleteByName = 1108001231,
		AssetFile_Download = 289710021,
		AssetFile_DownloadById = 755009938,
		AssetFile_DownloadByName = 1664536314,
		AssetFile_DownloadCancel = 134927303,
		AssetFile_DownloadCancelById = 1365611796,
		AssetFile_DownloadCancelByName = 1147858170,
		AssetFile_GetList = 1258057588,
		AssetFile_Status = 47394656,
		AssetFile_StatusById = 1570069816,
		AssetFile_StatusByName = 1104140880,
		Avatar_LaunchAvatarEditor = 99737939,
		Challenges_Create = 1750718017,
		Challenges_DeclineInvite = 1452177088,
		Challenges_Delete = 642287050,
		Challenges_Get = 2002276083,
		Challenges_GetEntries = 303739999,
		Challenges_GetEntriesAfterRank = 143202943,
		Challenges_GetEntriesByIds = 828705244,
		Challenges_GetList = 1126581078,
		Challenges_GetNextChallenges = 1534894518,
		Challenges_GetNextEntries = 2135728326,
		Challenges_GetPreviousChallenges = 246678541,
		Challenges_GetPreviousEntries = 2026439792,
		Challenges_Join = 556040297,
		Challenges_Leave = 694228709,
		Challenges_UpdateInfo = 292929120,
		Cowatching_GetNextCowatchViewerArrayPage = 490748210,
		Cowatching_GetPresenterData = 1233536821,
		Cowatching_GetViewersData = 1557635663,
		Cowatching_IsInSession = 1696286852,
		Cowatching_JoinSession = 1669899604,
		Cowatching_LaunchInviteDialog = 580072087,
		Cowatching_LeaveSession = 1017005773,
		Cowatching_RequestToPresent = 2138684586,
		Cowatching_ResignFromPresenting = 1263124994,
		Cowatching_SetPresenterData = 1830586630,
		Cowatching_SetViewerData = 1021044774,
		DeviceApplicationIntegrity_GetIntegrityToken = 846310362,
		Entitlement_GetIsViewerEntitled = 409688241,
		GroupPresence_Clear = 1839897795,
		GroupPresence_GetInvitableUsers = 592167921,
		GroupPresence_GetNextApplicationInviteArrayPage = 83411186,
		GroupPresence_GetSentInvites = 136710833,
		GroupPresence_LaunchInvitePanel = 262066079,
		GroupPresence_LaunchMultiplayerErrorDialog = 693481252,
		GroupPresence_LaunchRejoinDialog = 360121199,
		GroupPresence_LaunchRosterPanel = 896698498,
		GroupPresence_SendInvites = 231461732,
		GroupPresence_Set = 1734302756,
		GroupPresence_SetDeeplinkMessageOverride = 1377492749,
		GroupPresence_SetDestination = 1281042058,
		GroupPresence_SetIsJoinable = 714018901,
		GroupPresence_SetLobbySession = 1224693182,
		GroupPresence_SetMatchSession = 827098296,
		IAP_ConsumePurchase = 532378329,
		IAP_GetNextProductArrayPage = 467225263,
		IAP_GetNextPurchaseArrayPage = 1196886677,
		IAP_GetProductsBySKU = 2124073717,
		IAP_GetViewerPurchases = 974095385,
		IAP_GetViewerPurchasesDurableCache = 1666817579,
		IAP_LaunchCheckoutFlow = 1067126029,
		LanguagePack_GetCurrent = 529592533,
		LanguagePack_SetCurrent = 1531952096,
		Leaderboard_Get = 1792298744,
		Leaderboard_GetEntries = 1572030284,
		Leaderboard_GetEntriesAfterRank = 406293487,
		Leaderboard_GetEntriesByIds = 962624508,
		Leaderboard_GetNextEntries = 1310751961,
		Leaderboard_GetNextLeaderboardArrayPage = 905344667,
		Leaderboard_GetPreviousEntries = 1224858304,
		Leaderboard_WriteEntry = 293587198,
		Leaderboard_WriteEntryWithSupplementaryMetric = 1925616378,
		Media_ShareToFacebook = 14912239,
		Notification_MarkAsRead = 1903319523,
		Party_GetCurrent = 1200830304,
		RichPresence_Clear = 1471632051,
		RichPresence_GetDestinations = 1483681044,
		RichPresence_GetNextDestinationArrayPage = 1731624773,
		RichPresence_Set = 1007973641,
		UserAgeCategory_Get = 567009472,
		UserAgeCategory_Report = 776853718,
		User_Get = 1808768583,
		User_GetAccessToken = 111696574,
		User_GetBlockedUsers = 2099254614,
		User_GetLoggedInUser = 1131361373,
		User_GetLoggedInUserFriends = 1484532365,
		User_GetNextBlockedUserArrayPage = 2083192267,
		User_GetNextUserArrayPage = 645723971,
		User_GetNextUserCapabilityArrayPage = 587854745,
		User_GetOrgScopedID = 418426907,
		User_GetSdkAccounts = 1733454467,
		User_GetUserProof = 578880643,
		User_LaunchBlockFlow = 1876305192,
		User_LaunchFriendRequestFlow = 151303576,
		User_LaunchUnblockFlow = 346172055,
		Voip_GetMicrophoneAvailability = 1951195973,
		Voip_SetSystemVoipSuppressed = 1161808298,
		Notification_AbuseReport_ReportButtonPressed = 608644972,
		Notification_ApplicationLifecycle_LaunchIntentChanged = 78859427,
		Notification_AssetFile_DownloadUpdate = 803015885,
		Notification_Cowatching_ApiNotReady = 1711880577,
		Notification_Cowatching_ApiReady = 160786067,
		Notification_Cowatching_InSessionChanged = 234434835,
		Notification_Cowatching_Initialized = 1960397043,
		Notification_Cowatching_PresenterDataChanged = 1309118190,
		Notification_Cowatching_SessionStarted = 1931580316,
		Notification_Cowatching_SessionStopped = 1239866362,
		Notification_Cowatching_ViewersDataChanged = 1760752127,
		Notification_GroupPresence_InvitationsSent = 1738179766,
		Notification_GroupPresence_JoinIntentReceived = 2000194038,
		Notification_GroupPresence_LeaveIntentReceived = 1194846749,
		Notification_HTTP_Transfer = 2111073839,
		Notification_Livestreaming_StatusChange = 575101294,
		Notification_NetSync_ConnectionStatusChanged = 120882378,
		Notification_NetSync_SessionsChanged = 947814198,
		Notification_Party_PartyUpdate = 487688882,
		Notification_Voip_MicrophoneAvailabilityStateUpdate = 1042336599,
		Notification_Voip_SystemVoipState = 1490179237,
		Notification_Vrcamera_GetDataChannelMessageUpdate = 1860498236,
		Notification_Vrcamera_GetSurfaceUpdate = 938610820,
		Platform_InitializeWithAccessToken = 896085803,
		Platform_InitializeStandaloneOculus = 1375260172,
		Platform_InitializeAndroidAsynchronous = 450037684,
		Platform_InitializeWindowsAsynchronous = 1839708815,
	}

	[CompilerGenerated]
	private static ExtraMessageTypesHandler <HandleExtraMessageTypes>k__BackingField; //Field offset: 0x0
	private MessageType type; //Field offset: 0x10
	private ulong requestID; //Field offset: 0x18
	private Error error; //Field offset: 0x20

	internal static ExtraMessageTypesHandler HandleExtraMessageTypes
	{
		[CompilerGenerated]
		private get { } //Length: 72
		[CompilerGenerated]
		internal set { } //Length: 76
	}

	public bool IsError
	{
		 get { } //Length: 16
	}

	public ulong RequestID
	{
		 get { } //Length: 8
	}

	public MessageType Type
	{
		 get { } //Length: 8
	}

	public Message(IntPtr c_message) { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	private static ExtraMessageTypesHandler get_HandleExtraMessageTypes() { }

	public bool get_IsError() { }

	public ulong get_RequestID() { }

	public MessageType get_Type() { }

	public override AbuseReportRecording GetAbuseReportRecording() { }

	public override AchievementDefinitionList GetAchievementDefinitions() { }

	public override AchievementProgressList GetAchievementProgressList() { }

	public override AchievementUpdate GetAchievementUpdate() { }

	public override AppDownloadProgressResult GetAppDownloadProgressResult() { }

	public override AppDownloadResult GetAppDownloadResult() { }

	public override ApplicationInviteList GetApplicationInviteList() { }

	public override ApplicationVersion GetApplicationVersion() { }

	public override AssetDetails GetAssetDetails() { }

	public override AssetDetailsList GetAssetDetailsList() { }

	public override AssetFileDeleteResult GetAssetFileDeleteResult() { }

	public override AssetFileDownloadCancelResult GetAssetFileDownloadCancelResult() { }

	public override AssetFileDownloadResult GetAssetFileDownloadResult() { }

	public override AssetFileDownloadUpdate GetAssetFileDownloadUpdate() { }

	public override AvatarEditorResult GetAvatarEditorResult() { }

	public override BlockedUserList GetBlockedUserList() { }

	public override Challenge GetChallenge() { }

	public override ChallengeEntryList GetChallengeEntryList() { }

	public override ChallengeList GetChallengeList() { }

	public override CowatchingState GetCowatchingState() { }

	public override CowatchViewerList GetCowatchViewerList() { }

	public override CowatchViewerUpdate GetCowatchViewerUpdate() { }

	public override DestinationList GetDestinationList() { }

	public override Error GetError() { }

	public override GroupPresenceJoinIntent GetGroupPresenceJoinIntent() { }

	public override GroupPresenceLeaveIntent GetGroupPresenceLeaveIntent() { }

	public override HttpTransferUpdate GetHttpTransferUpdate() { }

	public override InstalledApplicationList GetInstalledApplicationList() { }

	public override InvitePanelResultInfo GetInvitePanelResultInfo() { }

	public override LaunchBlockFlowResult GetLaunchBlockFlowResult() { }

	public override LaunchFriendRequestFlowResult GetLaunchFriendRequestFlowResult() { }

	public override LaunchInvitePanelFlowResult GetLaunchInvitePanelFlowResult() { }

	public override LaunchReportFlowResult GetLaunchReportFlowResult() { }

	public override LaunchUnblockFlowResult GetLaunchUnblockFlowResult() { }

	public override bool GetLeaderboardDidUpdate() { }

	public override LeaderboardEntryList GetLeaderboardEntryList() { }

	public override LeaderboardList GetLeaderboardList() { }

	public override LinkedAccountList GetLinkedAccountList() { }

	public override LivestreamingApplicationStatus GetLivestreamingApplicationStatus() { }

	public override LivestreamingStartResult GetLivestreamingStartResult() { }

	public override LivestreamingStatus GetLivestreamingStatus() { }

	public override LivestreamingVideoStats GetLivestreamingVideoStats() { }

	public override MicrophoneAvailabilityState GetMicrophoneAvailabilityState() { }

	public override NetSyncConnection GetNetSyncConnection() { }

	public override NetSyncSessionList GetNetSyncSessionList() { }

	public override NetSyncSessionsChangedNotification GetNetSyncSessionsChangedNotification() { }

	public override NetSyncSetSessionPropertyResult GetNetSyncSetSessionPropertyResult() { }

	public override NetSyncVoipAttenuationValueList GetNetSyncVoipAttenuationValueList() { }

	public override OrgScopedID GetOrgScopedID() { }

	public override Party GetParty() { }

	public override PartyID GetPartyID() { }

	public override PartyUpdateNotification GetPartyUpdateNotification() { }

	public override PidList GetPidList() { }

	public override PlatformInitialize GetPlatformInitialize() { }

	public override ProductList GetProductList() { }

	public override Purchase GetPurchase() { }

	public override PurchaseList GetPurchaseList() { }

	public override RejoinDialogResult GetRejoinDialogResult() { }

	public override SdkAccountList GetSdkAccountList() { }

	public override SendInvitesResult GetSendInvitesResult() { }

	public override ShareMediaResult GetShareMediaResult() { }

	public override string GetString() { }

	public override SystemVoipState GetSystemVoipState() { }

	public override User GetUser() { }

	public override UserAccountAgeCategory GetUserAccountAgeCategory() { }

	public override UserCapabilityList GetUserCapabilityList() { }

	public override UserList GetUserList() { }

	public override UserProof GetUserProof() { }

	public override UserReportID GetUserReportID() { }

	internal static Message ParseMessageHandle(IntPtr messageHandle) { }

	public static Message PopMessage() { }

	[CompilerGenerated]
	internal static void set_HandleExtraMessageTypes(ExtraMessageTypesHandler value) { }

}

