namespace Oculus.Platform;

public class CAPI
{
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class FilterCallback : MulticastDelegate
	{

		public FilterCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out Int16[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(out Int16[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels) { }

	}

	internal struct OculusInitParams
	{
		public int sType; //Field offset: 0x0
		public string email; //Field offset: 0x8
		public string password; //Field offset: 0x10
		public ulong appId; //Field offset: 0x18
		public string uriPrefixOverride; //Field offset: 0x20

	}

	internal struct ovrKeyValuePair
	{
		public string key_; //Field offset: 0x0
		private KeyValuePairType valueType_; //Field offset: 0x8
		public string stringValue_; //Field offset: 0x10
		public int intValue_; //Field offset: 0x18
		public double doubleValue_; //Field offset: 0x20

		public ovrKeyValuePair(string key, string value) { }

		public ovrKeyValuePair(string key, int value) { }

		public ovrKeyValuePair(string key, double value) { }

	}

	internal struct ovrNetSyncVec3
	{
		public float x; //Field offset: 0x0
		public float y; //Field offset: 0x4
		public float z; //Field offset: 0x8

	}

	public const string DLL_NAME = "ovrplatformloader"; //Field offset: 0x0
	private static UTF8Encoding nativeStringEncoding; //Field offset: 0x0
	public const int VoipFilterBufferSize = 480; //Field offset: 0x0

	private static CAPI() { }

	public CAPI() { }

	public static IntPtr ArrayOfStructsToIntPtr(Array ar) { }

	public static Byte[] BlobFromNative(uint size, IntPtr pointer) { }

	public static Dictionary<String, String> DataStoreFromNative(IntPtr pointer) { }

	public static DateTime DateTimeFromNative(ulong seconds_since_the_one_true_epoch) { }

	public static ulong DateTimeToNative(DateTime dt) { }

	public static ovrKeyValuePair[] DictionaryToOVRKeyValuePairs(Dictionary<String, Object> dict) { }

	public static ovrKeyValuePair[] DictionaryToOVRKeyValuePairs(Dictionary<InitConfigOptions, Boolean> dict) { }

	public static Byte[] FiledataFromNative(uint size, IntPtr pointer) { }

	public static int GetNativeStringLengthNotIncludingNullTerminator(IntPtr pointer) { }

	public static Byte[] IntPtrToByteArray(IntPtr data, ulong size) { }

	public static void LogNewEvent(string eventName, Dictionary<String, String> values) { }

	public static void LogNewUnifiedEvent(LogEventName eventName, Dictionary<String, String> values) { }

	public static ulong ovr_AbuseReport_LaunchAdvancedReportFlow(ulong content_id, IntPtr abuse_report_options) { }

	public static ulong ovr_AbuseReport_ReportRequestHandled(ReportRequestResponse response) { }

	public static IntPtr ovr_AbuseReportOptions_Create() { }

	public static void ovr_AbuseReportOptions_Destroy(IntPtr handle) { }

	public static void ovr_AbuseReportOptions_SetPreventPeopleChooser(IntPtr handle, bool value) { }

	public static void ovr_AbuseReportOptions_SetReportType(IntPtr handle, AbuseReportType value) { }

	public static string ovr_AbuseReportRecording_GetRecordingUuid(IntPtr obj) { }

	private static IntPtr ovr_AbuseReportRecording_GetRecordingUuid_Native(IntPtr obj) { }

	public static uint ovr_AchievementDefinition_GetBitfieldLength(IntPtr obj) { }

	public static string ovr_AchievementDefinition_GetName(IntPtr obj) { }

	private static IntPtr ovr_AchievementDefinition_GetName_Native(IntPtr obj) { }

	public static ulong ovr_AchievementDefinition_GetTarget(IntPtr obj) { }

	public static AchievementType ovr_AchievementDefinition_GetType(IntPtr obj) { }

	public static IntPtr ovr_AchievementDefinitionArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_AchievementDefinitionArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_AchievementDefinitionArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_AchievementDefinitionArray_GetSize(IntPtr obj) { }

	public static bool ovr_AchievementDefinitionArray_HasNextPage(IntPtr obj) { }

	public static string ovr_AchievementProgress_GetBitfield(IntPtr obj) { }

	private static IntPtr ovr_AchievementProgress_GetBitfield_Native(IntPtr obj) { }

	public static ulong ovr_AchievementProgress_GetCount(IntPtr obj) { }

	public static bool ovr_AchievementProgress_GetIsUnlocked(IntPtr obj) { }

	public static string ovr_AchievementProgress_GetName(IntPtr obj) { }

	private static IntPtr ovr_AchievementProgress_GetName_Native(IntPtr obj) { }

	public static DateTime ovr_AchievementProgress_GetUnlockTime(IntPtr obj) { }

	private static ulong ovr_AchievementProgress_GetUnlockTime_Native(IntPtr obj) { }

	public static IntPtr ovr_AchievementProgressArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_AchievementProgressArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_AchievementProgressArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_AchievementProgressArray_GetSize(IntPtr obj) { }

	public static bool ovr_AchievementProgressArray_HasNextPage(IntPtr obj) { }

	public static ulong ovr_Achievements_AddCount(string name, ulong count) { }

	private static ulong ovr_Achievements_AddCount_Native(IntPtr name, ulong count) { }

	public static ulong ovr_Achievements_AddFields(string name, string fields) { }

	private static ulong ovr_Achievements_AddFields_Native(IntPtr name, IntPtr fields) { }

	public static ulong ovr_Achievements_GetAllDefinitions() { }

	public static ulong ovr_Achievements_GetAllProgress() { }

	public static ulong ovr_Achievements_GetDefinitionsByName(String[] names, int count) { }

	public static ulong ovr_Achievements_GetProgressByName(String[] names, int count) { }

	public static ulong ovr_Achievements_Unlock(string name) { }

	private static ulong ovr_Achievements_Unlock_Native(IntPtr name) { }

	public static bool ovr_AchievementUpdate_GetJustUnlocked(IntPtr obj) { }

	public static string ovr_AchievementUpdate_GetName(IntPtr obj) { }

	private static IntPtr ovr_AchievementUpdate_GetName_Native(IntPtr obj) { }

	public static void ovr_AdvancedAbuseReportOptions_AddSuggestedUser(IntPtr handle, ulong value) { }

	public static void ovr_AdvancedAbuseReportOptions_ClearDeveloperDefinedContext(IntPtr handle) { }

	public static void ovr_AdvancedAbuseReportOptions_ClearSuggestedUsers(IntPtr handle) { }

	public static IntPtr ovr_AdvancedAbuseReportOptions_Create() { }

	public static void ovr_AdvancedAbuseReportOptions_Destroy(IntPtr handle) { }

	public static void ovr_AdvancedAbuseReportOptions_SetDeveloperDefinedContextString(IntPtr handle, string key, string value) { }

	private static void ovr_AdvancedAbuseReportOptions_SetDeveloperDefinedContextString_Native(IntPtr handle, IntPtr key, IntPtr value) { }

	public static void ovr_AdvancedAbuseReportOptions_SetObjectType(IntPtr handle, string value) { }

	private static void ovr_AdvancedAbuseReportOptions_SetObjectType_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_AdvancedAbuseReportOptions_SetReportType(IntPtr handle, AbuseReportType value) { }

	public static void ovr_AdvancedAbuseReportOptions_SetVideoMode(IntPtr handle, AbuseReportVideoMode value) { }

	public static long ovr_AppDownloadProgressResult_GetDownloadBytes(IntPtr obj) { }

	public static long ovr_AppDownloadProgressResult_GetDownloadedBytes(IntPtr obj) { }

	public static AppStatus ovr_AppDownloadProgressResult_GetStatusCode(IntPtr obj) { }

	public static AppInstallResult ovr_AppDownloadResult_GetAppInstallResult(IntPtr obj) { }

	public static long ovr_AppDownloadResult_GetTimestamp(IntPtr obj) { }

	public static ulong ovr_Application_CancelAppDownload() { }

	public static ulong ovr_Application_CheckAppDownloadProgress() { }

	public static ulong ovr_Application_GetID(IntPtr obj) { }

	public static ulong ovr_Application_GetInstalledApplications() { }

	public static ulong ovr_Application_GetVersion() { }

	public static ulong ovr_Application_InstallAppUpdateAndRelaunch(IntPtr deeplink_options) { }

	public static ulong ovr_Application_LaunchOtherApp(ulong appID, IntPtr deeplink_options) { }

	public static ulong ovr_Application_StartAppDownload() { }

	public static IntPtr ovr_ApplicationInvite_GetDestination(IntPtr obj) { }

	public static ulong ovr_ApplicationInvite_GetID(IntPtr obj) { }

	public static bool ovr_ApplicationInvite_GetIsActive(IntPtr obj) { }

	public static string ovr_ApplicationInvite_GetLobbySessionId(IntPtr obj) { }

	private static IntPtr ovr_ApplicationInvite_GetLobbySessionId_Native(IntPtr obj) { }

	public static string ovr_ApplicationInvite_GetMatchSessionId(IntPtr obj) { }

	private static IntPtr ovr_ApplicationInvite_GetMatchSessionId_Native(IntPtr obj) { }

	public static IntPtr ovr_ApplicationInvite_GetRecipient(IntPtr obj) { }

	public static IntPtr ovr_ApplicationInviteArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_ApplicationInviteArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_ApplicationInviteArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_ApplicationInviteArray_GetSize(IntPtr obj) { }

	public static bool ovr_ApplicationInviteArray_HasNextPage(IntPtr obj) { }

	public static IntPtr ovr_ApplicationLifecycle_GetLaunchDetails() { }

	public static ulong ovr_ApplicationLifecycle_GetRegisteredPIDs() { }

	public static ulong ovr_ApplicationLifecycle_GetSessionKey() { }

	public static void ovr_ApplicationLifecycle_LogDeeplinkResult(string trackingID, LaunchResult result) { }

	private static void ovr_ApplicationLifecycle_LogDeeplinkResult_Native(IntPtr trackingID, LaunchResult result) { }

	public static ulong ovr_ApplicationLifecycle_RegisterSessionKey(string sessionKey) { }

	private static ulong ovr_ApplicationLifecycle_RegisterSessionKey_Native(IntPtr sessionKey) { }

	public static IntPtr ovr_ApplicationOptions_Create() { }

	public static void ovr_ApplicationOptions_Destroy(IntPtr handle) { }

	public static void ovr_ApplicationOptions_SetDeeplinkMessage(IntPtr handle, string value) { }

	private static void ovr_ApplicationOptions_SetDeeplinkMessage_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_ApplicationOptions_SetDestinationApiName(IntPtr handle, string value) { }

	private static void ovr_ApplicationOptions_SetDestinationApiName_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_ApplicationOptions_SetLobbySessionId(IntPtr handle, string value) { }

	private static void ovr_ApplicationOptions_SetLobbySessionId_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_ApplicationOptions_SetMatchSessionId(IntPtr handle, string value) { }

	private static void ovr_ApplicationOptions_SetMatchSessionId_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_ApplicationOptions_SetRoomId(IntPtr handle, ulong value) { }

	public static int ovr_ApplicationVersion_GetCurrentCode(IntPtr obj) { }

	public static string ovr_ApplicationVersion_GetCurrentName(IntPtr obj) { }

	private static IntPtr ovr_ApplicationVersion_GetCurrentName_Native(IntPtr obj) { }

	public static int ovr_ApplicationVersion_GetLatestCode(IntPtr obj) { }

	public static string ovr_ApplicationVersion_GetLatestName(IntPtr obj) { }

	private static IntPtr ovr_ApplicationVersion_GetLatestName_Native(IntPtr obj) { }

	public static long ovr_ApplicationVersion_GetReleaseDate(IntPtr obj) { }

	public static string ovr_ApplicationVersion_GetSize(IntPtr obj) { }

	private static IntPtr ovr_ApplicationVersion_GetSize_Native(IntPtr obj) { }

	public static ulong ovr_AssetDetails_GetAssetId(IntPtr obj) { }

	public static string ovr_AssetDetails_GetAssetType(IntPtr obj) { }

	private static IntPtr ovr_AssetDetails_GetAssetType_Native(IntPtr obj) { }

	public static string ovr_AssetDetails_GetDownloadStatus(IntPtr obj) { }

	private static IntPtr ovr_AssetDetails_GetDownloadStatus_Native(IntPtr obj) { }

	public static string ovr_AssetDetails_GetFilepath(IntPtr obj) { }

	private static IntPtr ovr_AssetDetails_GetFilepath_Native(IntPtr obj) { }

	public static string ovr_AssetDetails_GetIapStatus(IntPtr obj) { }

	private static IntPtr ovr_AssetDetails_GetIapStatus_Native(IntPtr obj) { }

	public static IntPtr ovr_AssetDetails_GetLanguage(IntPtr obj) { }

	public static string ovr_AssetDetails_GetMetadata(IntPtr obj) { }

	private static IntPtr ovr_AssetDetails_GetMetadata_Native(IntPtr obj) { }

	public static IntPtr ovr_AssetDetailsArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static UIntPtr ovr_AssetDetailsArray_GetSize(IntPtr obj) { }

	public static ulong ovr_AssetFile_Delete(ulong assetFileID) { }

	public static ulong ovr_AssetFile_DeleteById(ulong assetFileID) { }

	public static ulong ovr_AssetFile_DeleteByName(string assetFileName) { }

	private static ulong ovr_AssetFile_DeleteByName_Native(IntPtr assetFileName) { }

	public static ulong ovr_AssetFile_Download(ulong assetFileID) { }

	public static ulong ovr_AssetFile_DownloadById(ulong assetFileID) { }

	public static ulong ovr_AssetFile_DownloadByName(string assetFileName) { }

	private static ulong ovr_AssetFile_DownloadByName_Native(IntPtr assetFileName) { }

	public static ulong ovr_AssetFile_DownloadCancel(ulong assetFileID) { }

	public static ulong ovr_AssetFile_DownloadCancelById(ulong assetFileID) { }

	public static ulong ovr_AssetFile_DownloadCancelByName(string assetFileName) { }

	private static ulong ovr_AssetFile_DownloadCancelByName_Native(IntPtr assetFileName) { }

	public static ulong ovr_AssetFile_GetList() { }

	public static ulong ovr_AssetFile_Status(ulong assetFileID) { }

	public static ulong ovr_AssetFile_StatusById(ulong assetFileID) { }

	public static ulong ovr_AssetFile_StatusByName(string assetFileName) { }

	private static ulong ovr_AssetFile_StatusByName_Native(IntPtr assetFileName) { }

	public static ulong ovr_AssetFileDeleteResult_GetAssetFileId(IntPtr obj) { }

	public static ulong ovr_AssetFileDeleteResult_GetAssetId(IntPtr obj) { }

	public static string ovr_AssetFileDeleteResult_GetFilepath(IntPtr obj) { }

	private static IntPtr ovr_AssetFileDeleteResult_GetFilepath_Native(IntPtr obj) { }

	public static bool ovr_AssetFileDeleteResult_GetSuccess(IntPtr obj) { }

	public static ulong ovr_AssetFileDownloadCancelResult_GetAssetFileId(IntPtr obj) { }

	public static ulong ovr_AssetFileDownloadCancelResult_GetAssetId(IntPtr obj) { }

	public static string ovr_AssetFileDownloadCancelResult_GetFilepath(IntPtr obj) { }

	private static IntPtr ovr_AssetFileDownloadCancelResult_GetFilepath_Native(IntPtr obj) { }

	public static bool ovr_AssetFileDownloadCancelResult_GetSuccess(IntPtr obj) { }

	public static ulong ovr_AssetFileDownloadResult_GetAssetId(IntPtr obj) { }

	public static string ovr_AssetFileDownloadResult_GetFilepath(IntPtr obj) { }

	private static IntPtr ovr_AssetFileDownloadResult_GetFilepath_Native(IntPtr obj) { }

	public static ulong ovr_AssetFileDownloadUpdate_GetAssetFileId(IntPtr obj) { }

	public static ulong ovr_AssetFileDownloadUpdate_GetAssetId(IntPtr obj) { }

	public static uint ovr_AssetFileDownloadUpdate_GetBytesTotal(IntPtr obj) { }

	public static ulong ovr_AssetFileDownloadUpdate_GetBytesTotalLong(IntPtr obj) { }

	public static int ovr_AssetFileDownloadUpdate_GetBytesTransferred(IntPtr obj) { }

	public static long ovr_AssetFileDownloadUpdate_GetBytesTransferredLong(IntPtr obj) { }

	public static bool ovr_AssetFileDownloadUpdate_GetCompleted(IntPtr obj) { }

	public static ulong ovr_Avatar_LaunchAvatarEditor(IntPtr options) { }

	public static ulong ovr_Avatar_UpdateMetaData(string avatarMetaData, string imageFilePath) { }

	private static ulong ovr_Avatar_UpdateMetaData_Native(IntPtr avatarMetaData, IntPtr imageFilePath) { }

	public static IntPtr ovr_AvatarEditorOptions_Create() { }

	public static void ovr_AvatarEditorOptions_Destroy(IntPtr handle) { }

	public static void ovr_AvatarEditorOptions_SetSourceOverride(IntPtr handle, string value) { }

	private static void ovr_AvatarEditorOptions_SetSourceOverride_Native(IntPtr handle, IntPtr value) { }

	public static bool ovr_AvatarEditorResult_GetRequestSent(IntPtr obj) { }

	public static ulong ovr_BlockedUser_GetId(IntPtr obj) { }

	public static IntPtr ovr_BlockedUserArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_BlockedUserArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_BlockedUserArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_BlockedUserArray_GetSize(IntPtr obj) { }

	public static bool ovr_BlockedUserArray_HasNextPage(IntPtr obj) { }

	public static ChallengeCreationType ovr_Challenge_GetCreationType(IntPtr obj) { }

	public static string ovr_Challenge_GetDescription(IntPtr obj) { }

	private static IntPtr ovr_Challenge_GetDescription_Native(IntPtr obj) { }

	public static DateTime ovr_Challenge_GetEndDate(IntPtr obj) { }

	private static ulong ovr_Challenge_GetEndDate_Native(IntPtr obj) { }

	public static ulong ovr_Challenge_GetID(IntPtr obj) { }

	public static IntPtr ovr_Challenge_GetInvitedUsers(IntPtr obj) { }

	public static IntPtr ovr_Challenge_GetLeaderboard(IntPtr obj) { }

	public static IntPtr ovr_Challenge_GetParticipants(IntPtr obj) { }

	public static DateTime ovr_Challenge_GetStartDate(IntPtr obj) { }

	private static ulong ovr_Challenge_GetStartDate_Native(IntPtr obj) { }

	public static string ovr_Challenge_GetTitle(IntPtr obj) { }

	private static IntPtr ovr_Challenge_GetTitle_Native(IntPtr obj) { }

	public static ChallengeVisibility ovr_Challenge_GetVisibility(IntPtr obj) { }

	public static IntPtr ovr_ChallengeArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_ChallengeArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_ChallengeArray_GetNextUrl_Native(IntPtr obj) { }

	public static string ovr_ChallengeArray_GetPreviousUrl(IntPtr obj) { }

	private static IntPtr ovr_ChallengeArray_GetPreviousUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_ChallengeArray_GetSize(IntPtr obj) { }

	public static ulong ovr_ChallengeArray_GetTotalCount(IntPtr obj) { }

	public static bool ovr_ChallengeArray_HasNextPage(IntPtr obj) { }

	public static bool ovr_ChallengeArray_HasPreviousPage(IntPtr obj) { }

	public static string ovr_ChallengeEntry_GetDisplayScore(IntPtr obj) { }

	private static IntPtr ovr_ChallengeEntry_GetDisplayScore_Native(IntPtr obj) { }

	public static Byte[] ovr_ChallengeEntry_GetExtraData(IntPtr obj) { }

	private static IntPtr ovr_ChallengeEntry_GetExtraData_Native(IntPtr obj) { }

	public static uint ovr_ChallengeEntry_GetExtraDataLength(IntPtr obj) { }

	public static ulong ovr_ChallengeEntry_GetID(IntPtr obj) { }

	public static int ovr_ChallengeEntry_GetRank(IntPtr obj) { }

	public static long ovr_ChallengeEntry_GetScore(IntPtr obj) { }

	public static DateTime ovr_ChallengeEntry_GetTimestamp(IntPtr obj) { }

	private static ulong ovr_ChallengeEntry_GetTimestamp_Native(IntPtr obj) { }

	public static IntPtr ovr_ChallengeEntry_GetUser(IntPtr obj) { }

	public static IntPtr ovr_ChallengeEntryArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_ChallengeEntryArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_ChallengeEntryArray_GetNextUrl_Native(IntPtr obj) { }

	public static string ovr_ChallengeEntryArray_GetPreviousUrl(IntPtr obj) { }

	private static IntPtr ovr_ChallengeEntryArray_GetPreviousUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_ChallengeEntryArray_GetSize(IntPtr obj) { }

	public static ulong ovr_ChallengeEntryArray_GetTotalCount(IntPtr obj) { }

	public static bool ovr_ChallengeEntryArray_HasNextPage(IntPtr obj) { }

	public static bool ovr_ChallengeEntryArray_HasPreviousPage(IntPtr obj) { }

	public static IntPtr ovr_ChallengeOptions_Create() { }

	public static void ovr_ChallengeOptions_Destroy(IntPtr handle) { }

	public static void ovr_ChallengeOptions_SetDescription(IntPtr handle, string value) { }

	private static void ovr_ChallengeOptions_SetDescription_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_ChallengeOptions_SetEndDate(IntPtr handle, DateTime value) { }

	private static void ovr_ChallengeOptions_SetEndDate_Native(IntPtr handle, ulong value) { }

	public static void ovr_ChallengeOptions_SetIncludeActiveChallenges(IntPtr handle, bool value) { }

	public static void ovr_ChallengeOptions_SetIncludeFutureChallenges(IntPtr handle, bool value) { }

	public static void ovr_ChallengeOptions_SetIncludePastChallenges(IntPtr handle, bool value) { }

	public static void ovr_ChallengeOptions_SetLeaderboardName(IntPtr handle, string value) { }

	private static void ovr_ChallengeOptions_SetLeaderboardName_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_ChallengeOptions_SetStartDate(IntPtr handle, DateTime value) { }

	private static void ovr_ChallengeOptions_SetStartDate_Native(IntPtr handle, ulong value) { }

	public static void ovr_ChallengeOptions_SetTitle(IntPtr handle, string value) { }

	private static void ovr_ChallengeOptions_SetTitle_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_ChallengeOptions_SetViewerFilter(IntPtr handle, ChallengeViewerFilter value) { }

	public static void ovr_ChallengeOptions_SetVisibility(IntPtr handle, ChallengeVisibility value) { }

	public static ulong ovr_Challenges_Create(string leaderboardName, IntPtr challengeOptions) { }

	private static ulong ovr_Challenges_Create_Native(IntPtr leaderboardName, IntPtr challengeOptions) { }

	public static ulong ovr_Challenges_DeclineInvite(ulong challengeID) { }

	public static ulong ovr_Challenges_Delete(ulong challengeID) { }

	public static ulong ovr_Challenges_Get(ulong challengeID) { }

	public static ulong ovr_Challenges_GetEntries(ulong challengeID, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt) { }

	public static ulong ovr_Challenges_GetEntriesAfterRank(ulong challengeID, int limit, ulong afterRank) { }

	public static ulong ovr_Challenges_GetEntriesByIds(ulong challengeID, int limit, LeaderboardStartAt startAt, UInt64[] userIDs, uint userIDLength) { }

	public static ulong ovr_Challenges_GetList(IntPtr challengeOptions, int limit) { }

	public static ulong ovr_Challenges_GetNextChallenges(IntPtr handle) { }

	public static ulong ovr_Challenges_GetNextEntries(IntPtr handle) { }

	public static ulong ovr_Challenges_GetPreviousChallenges(IntPtr handle) { }

	public static ulong ovr_Challenges_GetPreviousEntries(IntPtr handle) { }

	public static ulong ovr_Challenges_Join(ulong challengeID) { }

	public static ulong ovr_Challenges_Leave(ulong challengeID) { }

	public static ulong ovr_Challenges_UpdateInfo(ulong challengeID, IntPtr challengeOptions) { }

	public static ulong ovr_Colocation_GetCurrentMapUuid() { }

	public static ulong ovr_Colocation_RequestMap(string uuid) { }

	private static ulong ovr_Colocation_RequestMap_Native(IntPtr uuid) { }

	public static ulong ovr_Colocation_ShareMap(string uuid) { }

	private static ulong ovr_Colocation_ShareMap_Native(IntPtr uuid) { }

	public static ulong ovr_Cowatching_GetPresenterData() { }

	public static ulong ovr_Cowatching_GetViewersData() { }

	public static ulong ovr_Cowatching_IsInSession() { }

	public static ulong ovr_Cowatching_JoinSession() { }

	public static ulong ovr_Cowatching_LaunchInviteDialog() { }

	public static ulong ovr_Cowatching_LeaveSession() { }

	public static ulong ovr_Cowatching_RequestToPresent() { }

	public static ulong ovr_Cowatching_ResignFromPresenting() { }

	public static ulong ovr_Cowatching_SetPresenterData(string video_title, string presenter_data) { }

	private static ulong ovr_Cowatching_SetPresenterData_Native(IntPtr video_title, IntPtr presenter_data) { }

	public static ulong ovr_Cowatching_SetViewerData(string viewer_data) { }

	private static ulong ovr_Cowatching_SetViewerData_Native(IntPtr viewer_data) { }

	public static bool ovr_CowatchingState_GetInSession(IntPtr obj) { }

	public static string ovr_CowatchViewer_GetData(IntPtr obj) { }

	private static IntPtr ovr_CowatchViewer_GetData_Native(IntPtr obj) { }

	public static ulong ovr_CowatchViewer_GetId(IntPtr obj) { }

	public static IntPtr ovr_CowatchViewerArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_CowatchViewerArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_CowatchViewerArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_CowatchViewerArray_GetSize(IntPtr obj) { }

	public static bool ovr_CowatchViewerArray_HasNextPage(IntPtr obj) { }

	public static IntPtr ovr_CowatchViewerUpdate_GetDataList(IntPtr obj) { }

	public static ulong ovr_CowatchViewerUpdate_GetId(IntPtr obj) { }

	public static void ovr_CrashApplication() { }

	public static uint ovr_DataStore_Contains(IntPtr obj, string key) { }

	private static uint ovr_DataStore_Contains_Native(IntPtr obj, IntPtr key) { }

	public static string ovr_DataStore_GetKey(IntPtr obj, int index) { }

	private static IntPtr ovr_DataStore_GetKey_Native(IntPtr obj, int index) { }

	public static UIntPtr ovr_DataStore_GetNumKeys(IntPtr obj) { }

	public static string ovr_DataStore_GetValue(IntPtr obj, string key) { }

	private static IntPtr ovr_DataStore_GetValue_Native(IntPtr obj, IntPtr key) { }

	public static string ovr_Destination_GetApiName(IntPtr obj) { }

	private static IntPtr ovr_Destination_GetApiName_Native(IntPtr obj) { }

	public static string ovr_Destination_GetDeeplinkMessage(IntPtr obj) { }

	private static IntPtr ovr_Destination_GetDeeplinkMessage_Native(IntPtr obj) { }

	public static string ovr_Destination_GetDisplayName(IntPtr obj) { }

	private static IntPtr ovr_Destination_GetDisplayName_Native(IntPtr obj) { }

	public static string ovr_Destination_GetShareableUri(IntPtr obj) { }

	private static IntPtr ovr_Destination_GetShareableUri_Native(IntPtr obj) { }

	public static IntPtr ovr_DestinationArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_DestinationArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_DestinationArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_DestinationArray_GetSize(IntPtr obj) { }

	public static bool ovr_DestinationArray_HasNextPage(IntPtr obj) { }

	public static ulong ovr_DeviceApplicationIntegrity_GetAttestationToken(string challenge_nonce) { }

	private static ulong ovr_DeviceApplicationIntegrity_GetAttestationToken_Native(IntPtr challenge_nonce) { }

	public static ulong ovr_DeviceApplicationIntegrity_GetIntegrityToken(string challenge_nonce) { }

	private static ulong ovr_DeviceApplicationIntegrity_GetIntegrityToken_Native(IntPtr challenge_nonce) { }

	public static ulong ovr_Entitlement_GetIsViewerEntitled() { }

	public static int ovr_Error_GetCode(IntPtr obj) { }

	public static string ovr_Error_GetDisplayableMessage(IntPtr obj) { }

	private static IntPtr ovr_Error_GetDisplayableMessage_Native(IntPtr obj) { }

	public static int ovr_Error_GetHttpCode(IntPtr obj) { }

	public static string ovr_Error_GetMessage(IntPtr obj) { }

	private static IntPtr ovr_Error_GetMessage_Native(IntPtr obj) { }

	public static void ovr_FreeMessage(IntPtr message) { }

	public static string ovr_GetLoggedInUserLocale() { }

	private static IntPtr ovr_GetLoggedInUserLocale_Native() { }

	public static ulong ovr_GraphAPI_Get(string url) { }

	private static ulong ovr_GraphAPI_Get_Native(IntPtr url) { }

	public static ulong ovr_GraphAPI_Post(string url) { }

	private static ulong ovr_GraphAPI_Post_Native(IntPtr url) { }

	public static ulong ovr_GroupPresence_Clear() { }

	public static ulong ovr_GroupPresence_GetInvitableUsers(IntPtr options) { }

	public static ulong ovr_GroupPresence_GetSentInvites() { }

	public static ulong ovr_GroupPresence_LaunchInvitePanel(IntPtr options) { }

	public static ulong ovr_GroupPresence_LaunchMultiplayerErrorDialog(IntPtr options) { }

	public static ulong ovr_GroupPresence_LaunchRejoinDialog(string lobby_session_id, string match_session_id, string destination_api_name) { }

	private static ulong ovr_GroupPresence_LaunchRejoinDialog_Native(IntPtr lobby_session_id, IntPtr match_session_id, IntPtr destination_api_name) { }

	public static ulong ovr_GroupPresence_LaunchRosterPanel(IntPtr options) { }

	public static ulong ovr_GroupPresence_SendInvites(UInt64[] userIDs, uint userIDLength) { }

	public static ulong ovr_GroupPresence_Set(IntPtr groupPresenceOptions) { }

	public static ulong ovr_GroupPresence_SetDeeplinkMessageOverride(string deeplink_message) { }

	private static ulong ovr_GroupPresence_SetDeeplinkMessageOverride_Native(IntPtr deeplink_message) { }

	public static ulong ovr_GroupPresence_SetDestination(string api_name) { }

	private static ulong ovr_GroupPresence_SetDestination_Native(IntPtr api_name) { }

	public static ulong ovr_GroupPresence_SetIsJoinable(bool is_joinable) { }

	public static ulong ovr_GroupPresence_SetLobbySession(string id) { }

	private static ulong ovr_GroupPresence_SetLobbySession_Native(IntPtr id) { }

	public static ulong ovr_GroupPresence_SetMatchSession(string id) { }

	private static ulong ovr_GroupPresence_SetMatchSession_Native(IntPtr id) { }

	public static string ovr_GroupPresenceJoinIntent_GetDeeplinkMessage(IntPtr obj) { }

	private static IntPtr ovr_GroupPresenceJoinIntent_GetDeeplinkMessage_Native(IntPtr obj) { }

	public static string ovr_GroupPresenceJoinIntent_GetDestinationApiName(IntPtr obj) { }

	private static IntPtr ovr_GroupPresenceJoinIntent_GetDestinationApiName_Native(IntPtr obj) { }

	public static string ovr_GroupPresenceJoinIntent_GetLobbySessionId(IntPtr obj) { }

	private static IntPtr ovr_GroupPresenceJoinIntent_GetLobbySessionId_Native(IntPtr obj) { }

	public static string ovr_GroupPresenceJoinIntent_GetMatchSessionId(IntPtr obj) { }

	private static IntPtr ovr_GroupPresenceJoinIntent_GetMatchSessionId_Native(IntPtr obj) { }

	public static string ovr_GroupPresenceLeaveIntent_GetDestinationApiName(IntPtr obj) { }

	private static IntPtr ovr_GroupPresenceLeaveIntent_GetDestinationApiName_Native(IntPtr obj) { }

	public static string ovr_GroupPresenceLeaveIntent_GetLobbySessionId(IntPtr obj) { }

	private static IntPtr ovr_GroupPresenceLeaveIntent_GetLobbySessionId_Native(IntPtr obj) { }

	public static string ovr_GroupPresenceLeaveIntent_GetMatchSessionId(IntPtr obj) { }

	private static IntPtr ovr_GroupPresenceLeaveIntent_GetMatchSessionId_Native(IntPtr obj) { }

	public static IntPtr ovr_GroupPresenceOptions_Create() { }

	public static void ovr_GroupPresenceOptions_Destroy(IntPtr handle) { }

	public static void ovr_GroupPresenceOptions_SetDeeplinkMessageOverride(IntPtr handle, string value) { }

	private static void ovr_GroupPresenceOptions_SetDeeplinkMessageOverride_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_GroupPresenceOptions_SetDestinationApiName(IntPtr handle, string value) { }

	private static void ovr_GroupPresenceOptions_SetDestinationApiName_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_GroupPresenceOptions_SetIsJoinable(IntPtr handle, bool value) { }

	public static void ovr_GroupPresenceOptions_SetLobbySessionId(IntPtr handle, string value) { }

	private static void ovr_GroupPresenceOptions_SetLobbySessionId_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_GroupPresenceOptions_SetMatchSessionId(IntPtr handle, string value) { }

	private static void ovr_GroupPresenceOptions_SetMatchSessionId_Native(IntPtr handle, IntPtr value) { }

	public static ulong ovr_HTTP_Get(string url) { }

	private static ulong ovr_HTTP_Get_Native(IntPtr url) { }

	public static ulong ovr_HTTP_GetToFile(string url, string diskFile) { }

	private static ulong ovr_HTTP_GetToFile_Native(IntPtr url, IntPtr diskFile) { }

	public static ulong ovr_HTTP_GetWithMessageType(string url, int messageType) { }

	public static ulong ovr_HTTP_MultiPartPost(string url, string filepath_param_name, string filepath, string access_token, ovrKeyValuePair[] post_params) { }

	private static ulong ovr_HTTP_MultiPartPost_Native(IntPtr url, IntPtr filepath_param_name, IntPtr filepath, IntPtr access_token, ovrKeyValuePair[] post_params, UIntPtr numItems) { }

	public static ulong ovr_HTTP_Post(string url) { }

	private static ulong ovr_HTTP_Post_Native(IntPtr url) { }

	public static ulong ovr_HTTP_StartTransfer(string url, ovrKeyValuePair[] headers) { }

	private static ulong ovr_HTTP_StartTransfer_Native(IntPtr url, ovrKeyValuePair[] headers, UIntPtr numItems) { }

	public static bool ovr_HTTP_Write(ulong transferId, Byte[] bytes, UIntPtr length) { }

	public static void ovr_HTTP_WriteEOM(ulong transferId) { }

	public static IntPtr ovr_HttpTransferUpdate_GetBytes(IntPtr obj) { }

	public static ulong ovr_HttpTransferUpdate_GetID(IntPtr obj) { }

	public static UIntPtr ovr_HttpTransferUpdate_GetSize(IntPtr obj) { }

	public static bool ovr_HttpTransferUpdate_IsCompleted(IntPtr obj) { }

	public static ulong ovr_IAP_ConsumePurchase(string sku) { }

	private static ulong ovr_IAP_ConsumePurchase_Native(IntPtr sku) { }

	public static ulong ovr_IAP_GetProductsBySKU(String[] skus, int count) { }

	public static ulong ovr_IAP_GetViewerPurchases() { }

	public static ulong ovr_IAP_GetViewerPurchasesDurableCache() { }

	public static ulong ovr_IAP_LaunchCheckoutFlow(string sku) { }

	private static ulong ovr_IAP_LaunchCheckoutFlow_Native(IntPtr sku) { }

	public static string ovr_InstalledApplication_GetApplicationId(IntPtr obj) { }

	private static IntPtr ovr_InstalledApplication_GetApplicationId_Native(IntPtr obj) { }

	public static string ovr_InstalledApplication_GetPackageName(IntPtr obj) { }

	private static IntPtr ovr_InstalledApplication_GetPackageName_Native(IntPtr obj) { }

	public static string ovr_InstalledApplication_GetStatus(IntPtr obj) { }

	private static IntPtr ovr_InstalledApplication_GetStatus_Native(IntPtr obj) { }

	public static int ovr_InstalledApplication_GetVersionCode(IntPtr obj) { }

	public static string ovr_InstalledApplication_GetVersionName(IntPtr obj) { }

	private static IntPtr ovr_InstalledApplication_GetVersionName_Native(IntPtr obj) { }

	public static IntPtr ovr_InstalledApplicationArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static UIntPtr ovr_InstalledApplicationArray_GetSize(IntPtr obj) { }

	public static void ovr_InviteOptions_AddSuggestedUser(IntPtr handle, ulong value) { }

	public static void ovr_InviteOptions_ClearSuggestedUsers(IntPtr handle) { }

	public static IntPtr ovr_InviteOptions_Create() { }

	public static void ovr_InviteOptions_Destroy(IntPtr handle) { }

	public static bool ovr_InvitePanelResultInfo_GetInvitesSent(IntPtr obj) { }

	public static ulong ovr_LanguagePack_GetCurrent() { }

	public static ulong ovr_LanguagePack_SetCurrent(string tag) { }

	private static ulong ovr_LanguagePack_SetCurrent_Native(IntPtr tag) { }

	public static string ovr_LanguagePackInfo_GetEnglishName(IntPtr obj) { }

	private static IntPtr ovr_LanguagePackInfo_GetEnglishName_Native(IntPtr obj) { }

	public static string ovr_LanguagePackInfo_GetNativeName(IntPtr obj) { }

	private static IntPtr ovr_LanguagePackInfo_GetNativeName_Native(IntPtr obj) { }

	public static string ovr_LanguagePackInfo_GetTag(IntPtr obj) { }

	private static IntPtr ovr_LanguagePackInfo_GetTag_Native(IntPtr obj) { }

	public static bool ovr_LaunchBlockFlowResult_GetDidBlock(IntPtr obj) { }

	public static bool ovr_LaunchBlockFlowResult_GetDidCancel(IntPtr obj) { }

	public static string ovr_LaunchDetails_GetDeeplinkMessage(IntPtr obj) { }

	private static IntPtr ovr_LaunchDetails_GetDeeplinkMessage_Native(IntPtr obj) { }

	public static string ovr_LaunchDetails_GetDestinationApiName(IntPtr obj) { }

	private static IntPtr ovr_LaunchDetails_GetDestinationApiName_Native(IntPtr obj) { }

	public static string ovr_LaunchDetails_GetLaunchSource(IntPtr obj) { }

	private static IntPtr ovr_LaunchDetails_GetLaunchSource_Native(IntPtr obj) { }

	public static LaunchType ovr_LaunchDetails_GetLaunchType(IntPtr obj) { }

	public static string ovr_LaunchDetails_GetLobbySessionID(IntPtr obj) { }

	private static IntPtr ovr_LaunchDetails_GetLobbySessionID_Native(IntPtr obj) { }

	public static string ovr_LaunchDetails_GetMatchSessionID(IntPtr obj) { }

	private static IntPtr ovr_LaunchDetails_GetMatchSessionID_Native(IntPtr obj) { }

	public static string ovr_LaunchDetails_GetTrackingID(IntPtr obj) { }

	private static IntPtr ovr_LaunchDetails_GetTrackingID_Native(IntPtr obj) { }

	public static IntPtr ovr_LaunchDetails_GetUsers(IntPtr obj) { }

	public static bool ovr_LaunchFriendRequestFlowResult_GetDidCancel(IntPtr obj) { }

	public static bool ovr_LaunchFriendRequestFlowResult_GetDidSendRequest(IntPtr obj) { }

	public static IntPtr ovr_LaunchInvitePanelFlowResult_GetInvitedUsers(IntPtr obj) { }

	public static bool ovr_LaunchReportFlowResult_GetDidCancel(IntPtr obj) { }

	public static ulong ovr_LaunchReportFlowResult_GetUserReportId(IntPtr obj) { }

	public static bool ovr_LaunchUnblockFlowResult_GetDidCancel(IntPtr obj) { }

	public static bool ovr_LaunchUnblockFlowResult_GetDidUnblock(IntPtr obj) { }

	public static ulong ovr_Leaderboard_Get(string leaderboardName) { }

	private static ulong ovr_Leaderboard_Get_Native(IntPtr leaderboardName) { }

	public static string ovr_Leaderboard_GetApiName(IntPtr obj) { }

	private static IntPtr ovr_Leaderboard_GetApiName_Native(IntPtr obj) { }

	public static IntPtr ovr_Leaderboard_GetDestination(IntPtr obj) { }

	public static ulong ovr_Leaderboard_GetEntries(string leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt) { }

	private static ulong ovr_Leaderboard_GetEntries_Native(IntPtr leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt) { }

	public static ulong ovr_Leaderboard_GetEntriesAfterRank(string leaderboardName, int limit, ulong afterRank) { }

	private static ulong ovr_Leaderboard_GetEntriesAfterRank_Native(IntPtr leaderboardName, int limit, ulong afterRank) { }

	public static ulong ovr_Leaderboard_GetEntriesByIds(string leaderboardName, int limit, LeaderboardStartAt startAt, UInt64[] userIDs, uint userIDLength) { }

	private static ulong ovr_Leaderboard_GetEntriesByIds_Native(IntPtr leaderboardName, int limit, LeaderboardStartAt startAt, UInt64[] userIDs, uint userIDLength) { }

	public static ulong ovr_Leaderboard_GetID(IntPtr obj) { }

	public static ulong ovr_Leaderboard_GetNextEntries(IntPtr handle) { }

	public static ulong ovr_Leaderboard_GetPreviousEntries(IntPtr handle) { }

	public static ulong ovr_Leaderboard_WriteEntry(string leaderboardName, long score, Byte[] extraData, uint extraDataLength, bool forceUpdate) { }

	private static ulong ovr_Leaderboard_WriteEntry_Native(IntPtr leaderboardName, long score, Byte[] extraData, uint extraDataLength, bool forceUpdate) { }

	public static ulong ovr_Leaderboard_WriteEntryWithSupplementaryMetric(string leaderboardName, long score, long supplementaryMetric, Byte[] extraData, uint extraDataLength, bool forceUpdate) { }

	private static ulong ovr_Leaderboard_WriteEntryWithSupplementaryMetric_Native(IntPtr leaderboardName, long score, long supplementaryMetric, Byte[] extraData, uint extraDataLength, bool forceUpdate) { }

	public static IntPtr ovr_LeaderboardArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_LeaderboardArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_LeaderboardArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_LeaderboardArray_GetSize(IntPtr obj) { }

	public static bool ovr_LeaderboardArray_HasNextPage(IntPtr obj) { }

	public static string ovr_LeaderboardEntry_GetDisplayScore(IntPtr obj) { }

	private static IntPtr ovr_LeaderboardEntry_GetDisplayScore_Native(IntPtr obj) { }

	public static Byte[] ovr_LeaderboardEntry_GetExtraData(IntPtr obj) { }

	private static IntPtr ovr_LeaderboardEntry_GetExtraData_Native(IntPtr obj) { }

	public static uint ovr_LeaderboardEntry_GetExtraDataLength(IntPtr obj) { }

	public static ulong ovr_LeaderboardEntry_GetID(IntPtr obj) { }

	public static int ovr_LeaderboardEntry_GetRank(IntPtr obj) { }

	public static long ovr_LeaderboardEntry_GetScore(IntPtr obj) { }

	public static IntPtr ovr_LeaderboardEntry_GetSupplementaryMetric(IntPtr obj) { }

	public static DateTime ovr_LeaderboardEntry_GetTimestamp(IntPtr obj) { }

	private static ulong ovr_LeaderboardEntry_GetTimestamp_Native(IntPtr obj) { }

	public static IntPtr ovr_LeaderboardEntry_GetUser(IntPtr obj) { }

	public static IntPtr ovr_LeaderboardEntryArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_LeaderboardEntryArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_LeaderboardEntryArray_GetNextUrl_Native(IntPtr obj) { }

	public static string ovr_LeaderboardEntryArray_GetPreviousUrl(IntPtr obj) { }

	private static IntPtr ovr_LeaderboardEntryArray_GetPreviousUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_LeaderboardEntryArray_GetSize(IntPtr obj) { }

	public static ulong ovr_LeaderboardEntryArray_GetTotalCount(IntPtr obj) { }

	public static bool ovr_LeaderboardEntryArray_HasNextPage(IntPtr obj) { }

	public static bool ovr_LeaderboardEntryArray_HasPreviousPage(IntPtr obj) { }

	public static bool ovr_LeaderboardUpdateStatus_GetDidUpdate(IntPtr obj) { }

	public static ulong ovr_LeaderboardUpdateStatus_GetUpdatedChallengeId(IntPtr obj, uint index) { }

	public static uint ovr_LeaderboardUpdateStatus_GetUpdatedChallengeIdsSize(IntPtr obj) { }

	public static string ovr_LinkedAccount_GetAccessToken(IntPtr obj) { }

	private static IntPtr ovr_LinkedAccount_GetAccessToken_Native(IntPtr obj) { }

	public static ServiceProvider ovr_LinkedAccount_GetServiceProvider(IntPtr obj) { }

	public static string ovr_LinkedAccount_GetUserId(IntPtr obj) { }

	private static IntPtr ovr_LinkedAccount_GetUserId_Native(IntPtr obj) { }

	public static IntPtr ovr_LinkedAccountArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static UIntPtr ovr_LinkedAccountArray_GetSize(IntPtr obj) { }

	public static ulong ovr_Livestreaming_IsAllowedForApplication(string packageName) { }

	private static ulong ovr_Livestreaming_IsAllowedForApplication_Native(IntPtr packageName) { }

	public static ulong ovr_Livestreaming_StartPartyStream() { }

	public static ulong ovr_Livestreaming_StartStream(LivestreamingAudience audience, LivestreamingMicrophoneStatus micStatus) { }

	public static ulong ovr_Livestreaming_StopPartyStream() { }

	public static ulong ovr_Livestreaming_StopStream() { }

	public static ulong ovr_Livestreaming_UpdateMicStatus(LivestreamingMicrophoneStatus micStatus) { }

	public static bool ovr_LivestreamingApplicationStatus_GetStreamingEnabled(IntPtr obj) { }

	public static LivestreamingStartStatus ovr_LivestreamingStartResult_GetStreamingResult(IntPtr obj) { }

	public static bool ovr_LivestreamingStatus_GetCommentsVisible(IntPtr obj) { }

	public static bool ovr_LivestreamingStatus_GetIsPaused(IntPtr obj) { }

	public static bool ovr_LivestreamingStatus_GetLivestreamingEnabled(IntPtr obj) { }

	public static int ovr_LivestreamingStatus_GetLivestreamingType(IntPtr obj) { }

	public static bool ovr_LivestreamingStatus_GetMicEnabled(IntPtr obj) { }

	public static int ovr_LivestreamingVideoStats_GetCommentCount(IntPtr obj) { }

	public static int ovr_LivestreamingVideoStats_GetReactionCount(IntPtr obj) { }

	public static string ovr_LivestreamingVideoStats_GetTotalViews(IntPtr obj) { }

	private static IntPtr ovr_LivestreamingVideoStats_GetTotalViews_Native(IntPtr obj) { }

	public static void ovr_Log_NewEvent(IntPtr eventName, IntPtr[] values, UIntPtr length) { }

	public static ulong ovr_Media_ShareToFacebook(string postTextSuggestion, string filePath, MediaContentType contentType) { }

	private static ulong ovr_Media_ShareToFacebook_Native(IntPtr postTextSuggestion, IntPtr filePath, MediaContentType contentType) { }

	public static IntPtr ovr_Message_GetAbuseReportRecording(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAchievementDefinitionArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAchievementProgressArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAchievementUpdate(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAppDownloadProgressResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAppDownloadResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetApplicationInviteArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetApplicationVersion(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAssetDetails(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAssetDetailsArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAssetFileDeleteResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAssetFileDownloadCancelResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAssetFileDownloadResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAssetFileDownloadUpdate(IntPtr obj) { }

	public static IntPtr ovr_Message_GetAvatarEditorResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetBlockedUserArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetChallenge(IntPtr obj) { }

	public static IntPtr ovr_Message_GetChallengeArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetChallengeEntryArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetCowatchingState(IntPtr obj) { }

	public static IntPtr ovr_Message_GetCowatchViewerArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetCowatchViewerUpdate(IntPtr obj) { }

	public static IntPtr ovr_Message_GetDataStore(IntPtr obj) { }

	public static IntPtr ovr_Message_GetDestinationArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetError(IntPtr obj) { }

	public static IntPtr ovr_Message_GetGroupPresenceJoinIntent(IntPtr obj) { }

	public static IntPtr ovr_Message_GetGroupPresenceLeaveIntent(IntPtr obj) { }

	public static IntPtr ovr_Message_GetHttpTransferUpdate(IntPtr obj) { }

	public static IntPtr ovr_Message_GetInstalledApplicationArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetInvitePanelResultInfo(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLaunchBlockFlowResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLaunchFriendRequestFlowResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLaunchInvitePanelFlowResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLaunchReportFlowResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLaunchUnblockFlowResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLeaderboardArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLeaderboardEntryArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLeaderboardUpdateStatus(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLinkedAccountArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLivestreamingApplicationStatus(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLivestreamingStartResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLivestreamingStatus(IntPtr obj) { }

	public static IntPtr ovr_Message_GetLivestreamingVideoStats(IntPtr obj) { }

	public static IntPtr ovr_Message_GetMicrophoneAvailabilityState(IntPtr obj) { }

	public static IntPtr ovr_Message_GetNativeMessage(IntPtr obj) { }

	public static IntPtr ovr_Message_GetNetSyncConnection(IntPtr obj) { }

	public static IntPtr ovr_Message_GetNetSyncSessionArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetNetSyncSessionsChangedNotification(IntPtr obj) { }

	public static IntPtr ovr_Message_GetNetSyncSetSessionPropertyResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetNetSyncVoipAttenuationValueArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetOrgScopedID(IntPtr obj) { }

	public static IntPtr ovr_Message_GetParty(IntPtr obj) { }

	public static IntPtr ovr_Message_GetPartyID(IntPtr obj) { }

	public static IntPtr ovr_Message_GetPartyUpdateNotification(IntPtr obj) { }

	public static IntPtr ovr_Message_GetPidArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetPlatformInitialize(IntPtr obj) { }

	public static IntPtr ovr_Message_GetProductArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetPurchase(IntPtr obj) { }

	public static IntPtr ovr_Message_GetPurchaseArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetRejoinDialogResult(IntPtr obj) { }

	public static ulong ovr_Message_GetRequestID(IntPtr obj) { }

	public static IntPtr ovr_Message_GetSdkAccountArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetSendInvitesResult(IntPtr obj) { }

	public static IntPtr ovr_Message_GetShareMediaResult(IntPtr obj) { }

	public static string ovr_Message_GetString(IntPtr obj) { }

	private static IntPtr ovr_Message_GetString_Native(IntPtr obj) { }

	public static string ovr_Message_GetStringForJavascript(IntPtr message) { }

	private static IntPtr ovr_Message_GetStringForJavascript_Native(IntPtr message) { }

	public static IntPtr ovr_Message_GetSystemVoipState(IntPtr obj) { }

	public static MessageType ovr_Message_GetType(IntPtr obj) { }

	public static IntPtr ovr_Message_GetUser(IntPtr obj) { }

	public static IntPtr ovr_Message_GetUserAccountAgeCategory(IntPtr obj) { }

	public static IntPtr ovr_Message_GetUserArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetUserCapabilityArray(IntPtr obj) { }

	public static IntPtr ovr_Message_GetUserDataStoreUpdateResponse(IntPtr obj) { }

	public static IntPtr ovr_Message_GetUserProof(IntPtr obj) { }

	public static IntPtr ovr_Message_GetUserReportID(IntPtr obj) { }

	public static bool ovr_Message_IsError(IntPtr obj) { }

	public static IntPtr ovr_Microphone_Create() { }

	public static void ovr_Microphone_Destroy(IntPtr obj) { }

	public static UIntPtr ovr_Microphone_GetNumSamplesAvailable(IntPtr obj) { }

	public static UIntPtr ovr_Microphone_GetOutputBufferMaxSize(IntPtr obj) { }

	public static UIntPtr ovr_Microphone_GetPCM(IntPtr obj, Int16[] outputBuffer, UIntPtr outputBufferNumElements) { }

	public static UIntPtr ovr_Microphone_GetPCMFloat(IntPtr obj, Single[] outputBuffer, UIntPtr outputBufferNumElements) { }

	public static UIntPtr ovr_Microphone_ReadData(IntPtr obj, Single[] outputBuffer, UIntPtr outputBufferSize) { }

	public static void ovr_Microphone_SetAcceptableRecordingDelayHint(IntPtr obj, UIntPtr delayMs) { }

	public static void ovr_Microphone_Start(IntPtr obj) { }

	public static void ovr_Microphone_Stop(IntPtr obj) { }

	public static bool ovr_MicrophoneAvailabilityState_GetMicrophoneAvailable(IntPtr obj) { }

	public static IntPtr ovr_MultiplayerErrorOptions_Create() { }

	public static void ovr_MultiplayerErrorOptions_Destroy(IntPtr handle) { }

	public static void ovr_MultiplayerErrorOptions_SetErrorKey(IntPtr handle, MultiplayerErrorErrorKey value) { }

	public static ulong ovr_NetSync_Connect(IntPtr connect_options) { }

	public static ulong ovr_NetSync_Disconnect(long connection_id) { }

	public static UIntPtr ovr_NetSync_GetAmbisonicFloatPCM(long connection_id, Single[] outputBuffer, UIntPtr outputBufferNumElements) { }

	public static UIntPtr ovr_NetSync_GetAmbisonicInt16PCM(long connection_id, Int16[] outputBuffer, UIntPtr outputBufferNumElements) { }

	public static UIntPtr ovr_NetSync_GetAmbisonicInterleavedFloatPCM(long connection_id, Single[] outputBuffer, UIntPtr outputBufferNumElements) { }

	public static UIntPtr ovr_NetSync_GetAmbisonicInterleavedInt16PCM(long connection_id, Int16[] outputBuffer, UIntPtr outputBufferNumElements) { }

	public static bool ovr_NetSync_GetListenerPosition(long connection_id, ulong sessionId, ref ovrNetSyncVec3 position) { }

	public static UIntPtr ovr_NetSync_GetMonostreamFloatPCM(long connection_id, ulong sessionId, Single[] outputBuffer, UIntPtr outputBufferNumElements) { }

	public static UIntPtr ovr_NetSync_GetMonostreamInt16PCM(long connection_id, ulong session_id, Int16[] outputBuffer, UIntPtr outputBufferNumElements) { }

	public static UIntPtr ovr_NetSync_GetPcmBufferMaxSamples() { }

	public static ulong ovr_NetSync_GetSessions(long connection_id) { }

	public static bool ovr_NetSync_GetVoipAmplitude(long connection_id, ulong sessionId, ref float amplitude) { }

	public static ulong ovr_NetSync_GetVoipAttenuation(long connection_id) { }

	public static ulong ovr_NetSync_GetVoipAttenuationDefault() { }

	public static void ovr_NetSync_SetListenerPosition(long connection_id, ref ovrNetSyncVec3 position) { }

	public static ulong ovr_NetSync_SetVoipAttenuation(long connection_id, Single[] distances, Single[] decibels, UIntPtr count) { }

	public static ulong ovr_NetSync_SetVoipAttenuationModel(long connection_id, string name, Single[] distances, Single[] decibels, UIntPtr count) { }

	private static ulong ovr_NetSync_SetVoipAttenuationModel_Native(long connection_id, IntPtr name, Single[] distances, Single[] decibels, UIntPtr count) { }

	public static ulong ovr_NetSync_SetVoipChannelCfg(long connection_id, string channel_name, string attnmodel, bool disable_spatialization) { }

	private static ulong ovr_NetSync_SetVoipChannelCfg_Native(long connection_id, IntPtr channel_name, IntPtr attnmodel, bool disable_spatialization) { }

	public static ulong ovr_NetSync_SetVoipGroup(long connection_id, string group_id) { }

	private static ulong ovr_NetSync_SetVoipGroup_Native(long connection_id, IntPtr group_id) { }

	public static ulong ovr_NetSync_SetVoipListentoChannels(long connection_id, String[] listento_channels, UIntPtr count) { }

	public static ulong ovr_NetSync_SetVoipMicSource(long connection_id, NetSyncVoipMicSource mic_source) { }

	public static ulong ovr_NetSync_SetVoipSessionMuted(long connection_id, ulong session_id, bool muted) { }

	public static ulong ovr_NetSync_SetVoipSpeaktoChannels(long connection_id, String[] speakto_channels, UIntPtr count) { }

	public static ulong ovr_NetSync_SetVoipStreamMode(long connection_id, ulong sessionId, NetSyncVoipStreamMode streamMode) { }

	public static long ovr_NetSyncConnection_GetConnectionId(IntPtr obj) { }

	public static NetSyncDisconnectReason ovr_NetSyncConnection_GetDisconnectReason(IntPtr obj) { }

	public static ulong ovr_NetSyncConnection_GetSessionId(IntPtr obj) { }

	public static NetSyncConnectionStatus ovr_NetSyncConnection_GetStatus(IntPtr obj) { }

	public static string ovr_NetSyncConnection_GetZoneId(IntPtr obj) { }

	private static IntPtr ovr_NetSyncConnection_GetZoneId_Native(IntPtr obj) { }

	public static IntPtr ovr_NetSyncOptions_Create() { }

	public static void ovr_NetSyncOptions_Destroy(IntPtr handle) { }

	public static void ovr_NetSyncOptions_SetVoipGroup(IntPtr handle, string value) { }

	private static void ovr_NetSyncOptions_SetVoipGroup_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_NetSyncOptions_SetVoipStreamDefault(IntPtr handle, NetSyncVoipStreamMode value) { }

	public static void ovr_NetSyncOptions_SetZoneId(IntPtr handle, string value) { }

	private static void ovr_NetSyncOptions_SetZoneId_Native(IntPtr handle, IntPtr value) { }

	public static long ovr_NetSyncSession_GetConnectionId(IntPtr obj) { }

	public static bool ovr_NetSyncSession_GetMuted(IntPtr obj) { }

	public static ulong ovr_NetSyncSession_GetSessionId(IntPtr obj) { }

	public static ulong ovr_NetSyncSession_GetUserId(IntPtr obj) { }

	public static string ovr_NetSyncSession_GetVoipGroup(IntPtr obj) { }

	private static IntPtr ovr_NetSyncSession_GetVoipGroup_Native(IntPtr obj) { }

	public static IntPtr ovr_NetSyncSessionArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static UIntPtr ovr_NetSyncSessionArray_GetSize(IntPtr obj) { }

	public static long ovr_NetSyncSessionsChangedNotification_GetConnectionId(IntPtr obj) { }

	public static IntPtr ovr_NetSyncSessionsChangedNotification_GetSessions(IntPtr obj) { }

	public static IntPtr ovr_NetSyncSetSessionPropertyResult_GetSession(IntPtr obj) { }

	public static float ovr_NetSyncVoipAttenuationValue_GetDecibels(IntPtr obj) { }

	public static float ovr_NetSyncVoipAttenuationValue_GetDistance(IntPtr obj) { }

	public static IntPtr ovr_NetSyncVoipAttenuationValueArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static UIntPtr ovr_NetSyncVoipAttenuationValueArray_GetSize(IntPtr obj) { }

	public static ulong ovr_Notification_MarkAsRead(ulong notificationID) { }

	public static ulong ovr_OrgScopedID_GetID(IntPtr obj) { }

	public static void ovr_Packet_Free(IntPtr obj) { }

	public static IntPtr ovr_Packet_GetBytes(IntPtr obj) { }

	public static ulong ovr_Packet_GetSenderID(IntPtr obj) { }

	public static UIntPtr ovr_Packet_GetSize(IntPtr obj) { }

	public static ulong ovr_Party_Create() { }

	public static ulong ovr_Party_GatherInApplication(ulong partyID, ulong appID) { }

	public static ulong ovr_Party_Get(ulong partyID) { }

	public static ulong ovr_Party_GetCurrent() { }

	public static ulong ovr_Party_GetCurrentForUser(ulong userID) { }

	public static ulong ovr_Party_GetID(IntPtr obj) { }

	public static IntPtr ovr_Party_GetInvitedUsers(IntPtr obj) { }

	public static IntPtr ovr_Party_GetLeader(IntPtr obj) { }

	public static IntPtr ovr_Party_GetUsers(IntPtr obj) { }

	public static ulong ovr_Party_Invite(ulong partyID, ulong userID) { }

	public static ulong ovr_Party_Join(ulong partyID) { }

	public static ulong ovr_Party_Leave(ulong partyID) { }

	public static int ovr_Party_PluginGetSharedMemHandle() { }

	public static VoipMuteState ovr_Party_PluginGetVoipMicrophoneMuted() { }

	public static bool ovr_Party_PluginGetVoipPassthrough() { }

	public static SystemVoipStatus ovr_Party_PluginGetVoipStatus() { }

	public static ulong ovr_PartyID_GetID(IntPtr obj) { }

	public static PartyUpdateAction ovr_PartyUpdateNotification_GetAction(IntPtr obj) { }

	public static ulong ovr_PartyUpdateNotification_GetPartyId(IntPtr obj) { }

	public static ulong ovr_PartyUpdateNotification_GetSenderId(IntPtr obj) { }

	public static string ovr_PartyUpdateNotification_GetUpdateTimestamp(IntPtr obj) { }

	private static IntPtr ovr_PartyUpdateNotification_GetUpdateTimestamp_Native(IntPtr obj) { }

	public static string ovr_PartyUpdateNotification_GetUserAlias(IntPtr obj) { }

	private static IntPtr ovr_PartyUpdateNotification_GetUserAlias_Native(IntPtr obj) { }

	public static ulong ovr_PartyUpdateNotification_GetUserId(IntPtr obj) { }

	public static string ovr_PartyUpdateNotification_GetUserName(IntPtr obj) { }

	private static IntPtr ovr_PartyUpdateNotification_GetUserName_Native(IntPtr obj) { }

	public static string ovr_Pid_GetId(IntPtr obj) { }

	private static IntPtr ovr_Pid_GetId_Native(IntPtr obj) { }

	public static IntPtr ovr_PidArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static UIntPtr ovr_PidArray_GetSize(IntPtr obj) { }

	public static ulong ovr_Platform_InitializeStandaloneOculus(ref OculusInitParams init) { }

	public static PlatformInitializeResult ovr_PlatformInitialize_GetResult(IntPtr obj) { }

	public static ulong ovr_PlatformInitializeWithAccessToken(ulong appId, string accessToken) { }

	public static ulong ovr_PlatformInitializeWithAccessTokenAndOptions(ulong appId, string accessToken, ovrKeyValuePair[] configOptions, UIntPtr numOptions) { }

	public static IntPtr ovr_PopMessage() { }

	public static uint ovr_Price_GetAmountInHundredths(IntPtr obj) { }

	public static string ovr_Price_GetCurrency(IntPtr obj) { }

	private static IntPtr ovr_Price_GetCurrency_Native(IntPtr obj) { }

	public static string ovr_Price_GetFormatted(IntPtr obj) { }

	private static IntPtr ovr_Price_GetFormatted_Native(IntPtr obj) { }

	public static string ovr_Product_GetDescription(IntPtr obj) { }

	private static IntPtr ovr_Product_GetDescription_Native(IntPtr obj) { }

	public static string ovr_Product_GetFormattedPrice(IntPtr obj) { }

	private static IntPtr ovr_Product_GetFormattedPrice_Native(IntPtr obj) { }

	public static string ovr_Product_GetName(IntPtr obj) { }

	private static IntPtr ovr_Product_GetName_Native(IntPtr obj) { }

	public static string ovr_Product_GetSKU(IntPtr obj) { }

	private static IntPtr ovr_Product_GetSKU_Native(IntPtr obj) { }

	public static IntPtr ovr_ProductArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_ProductArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_ProductArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_ProductArray_GetSize(IntPtr obj) { }

	public static bool ovr_ProductArray_HasNextPage(IntPtr obj) { }

	public static string ovr_Purchase_GetDeveloperPayload(IntPtr obj) { }

	private static IntPtr ovr_Purchase_GetDeveloperPayload_Native(IntPtr obj) { }

	public static DateTime ovr_Purchase_GetExpirationTime(IntPtr obj) { }

	private static ulong ovr_Purchase_GetExpirationTime_Native(IntPtr obj) { }

	public static DateTime ovr_Purchase_GetGrantTime(IntPtr obj) { }

	private static ulong ovr_Purchase_GetGrantTime_Native(IntPtr obj) { }

	public static ulong ovr_Purchase_GetPurchaseID(IntPtr obj) { }

	public static string ovr_Purchase_GetPurchaseStrID(IntPtr obj) { }

	private static IntPtr ovr_Purchase_GetPurchaseStrID_Native(IntPtr obj) { }

	public static string ovr_Purchase_GetReportingId(IntPtr obj) { }

	private static IntPtr ovr_Purchase_GetReportingId_Native(IntPtr obj) { }

	public static string ovr_Purchase_GetSKU(IntPtr obj) { }

	private static IntPtr ovr_Purchase_GetSKU_Native(IntPtr obj) { }

	public static IntPtr ovr_PurchaseArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_PurchaseArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_PurchaseArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_PurchaseArray_GetSize(IntPtr obj) { }

	public static bool ovr_PurchaseArray_HasNextPage(IntPtr obj) { }

	public static bool ovr_RejoinDialogResult_GetRejoinSelected(IntPtr obj) { }

	public static ulong ovr_RichPresence_Clear() { }

	public static ulong ovr_RichPresence_GetDestinations() { }

	public static ulong ovr_RichPresence_Set(IntPtr richPresenceOptions) { }

	public static ulong ovr_RichPresence_SetDestination(string api_name) { }

	private static ulong ovr_RichPresence_SetDestination_Native(IntPtr api_name) { }

	public static ulong ovr_RichPresence_SetIsJoinable(bool is_joinable) { }

	public static ulong ovr_RichPresence_SetLobbySession(string id) { }

	private static ulong ovr_RichPresence_SetLobbySession_Native(IntPtr id) { }

	public static ulong ovr_RichPresence_SetMatchSession(string id) { }

	private static ulong ovr_RichPresence_SetMatchSession_Native(IntPtr id) { }

	public static IntPtr ovr_RichPresenceOptions_Create() { }

	public static void ovr_RichPresenceOptions_Destroy(IntPtr handle) { }

	public static void ovr_RichPresenceOptions_SetApiName(IntPtr handle, string value) { }

	private static void ovr_RichPresenceOptions_SetApiName_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_RichPresenceOptions_SetDeeplinkMessageOverride(IntPtr handle, string value) { }

	private static void ovr_RichPresenceOptions_SetDeeplinkMessageOverride_Native(IntPtr handle, IntPtr value) { }

	public static void ovr_RichPresenceOptions_SetIsJoinable(IntPtr handle, bool value) { }

	public static void ovr_RosterOptions_AddSuggestedUser(IntPtr handle, ulong value) { }

	public static void ovr_RosterOptions_ClearSuggestedUsers(IntPtr handle) { }

	public static IntPtr ovr_RosterOptions_Create() { }

	public static void ovr_RosterOptions_Destroy(IntPtr handle) { }

	public static SdkAccountType ovr_SdkAccount_GetAccountType(IntPtr obj) { }

	public static ulong ovr_SdkAccount_GetUserId(IntPtr obj) { }

	public static IntPtr ovr_SdkAccountArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static UIntPtr ovr_SdkAccountArray_GetSize(IntPtr obj) { }

	public static IntPtr ovr_SendInvitesResult_GetInvites(IntPtr obj) { }

	public static bool ovr_SetDeveloperAccessToken(string accessToken) { }

	public static ShareMediaStatus ovr_ShareMediaResult_GetStatus(IntPtr obj) { }

	public static ulong ovr_SupplementaryMetric_GetID(IntPtr obj) { }

	public static long ovr_SupplementaryMetric_GetMetric(IntPtr obj) { }

	public static VoipMuteState ovr_SystemVoipState_GetMicrophoneMuted(IntPtr obj) { }

	public static SystemVoipStatus ovr_SystemVoipState_GetStatus(IntPtr obj) { }

	public static string ovr_TestUser_GetAccessToken(IntPtr obj) { }

	private static IntPtr ovr_TestUser_GetAccessToken_Native(IntPtr obj) { }

	public static IntPtr ovr_TestUser_GetAppAccessArray(IntPtr obj) { }

	public static IntPtr ovr_TestUser_GetFbAppAccessArray(IntPtr obj) { }

	public static string ovr_TestUser_GetFriendAccessToken(IntPtr obj) { }

	private static IntPtr ovr_TestUser_GetFriendAccessToken_Native(IntPtr obj) { }

	public static IntPtr ovr_TestUser_GetFriendAppAccessArray(IntPtr obj) { }

	public static string ovr_TestUser_GetUserAlias(IntPtr obj) { }

	private static IntPtr ovr_TestUser_GetUserAlias_Native(IntPtr obj) { }

	public static ulong ovr_TestUser_GetUserFbid(IntPtr obj) { }

	public static ulong ovr_TestUser_GetUserId(IntPtr obj) { }

	public static string ovr_TestUserAppAccess_GetAccessToken(IntPtr obj) { }

	private static IntPtr ovr_TestUserAppAccess_GetAccessToken_Native(IntPtr obj) { }

	public static ulong ovr_TestUserAppAccess_GetAppId(IntPtr obj) { }

	public static ulong ovr_TestUserAppAccess_GetUserId(IntPtr obj) { }

	public static IntPtr ovr_TestUserAppAccessArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static UIntPtr ovr_TestUserAppAccessArray_GetSize(IntPtr obj) { }

	public static void ovr_UnityInitGlobals(IntPtr loggingCB) { }

	public static bool ovr_UnityInitWrapper(string appId) { }

	public static ulong ovr_UnityInitWrapperAsynchronous(string appId) { }

	public static bool ovr_UnityInitWrapperStandalone(string accessToken, IntPtr loggingCB) { }

	public static bool ovr_UnityInitWrapperWindows(string appId, IntPtr loggingCB) { }

	public static ulong ovr_UnityInitWrapperWindowsAsynchronous(string appId, IntPtr loggingCB) { }

	public static void ovr_UnityResetTestPlatform() { }

	public static ulong ovr_User_CancelRecordingForReportFlow(string recordingUUID) { }

	private static ulong ovr_User_CancelRecordingForReportFlow_Native(IntPtr recordingUUID) { }

	public static ulong ovr_User_Get(ulong userID) { }

	public static ulong ovr_User_GetAccessToken() { }

	public static ulong ovr_User_GetBlockedUsers() { }

	public static string ovr_User_GetDisplayName(IntPtr obj) { }

	private static IntPtr ovr_User_GetDisplayName_Native(IntPtr obj) { }

	public static ulong ovr_User_GetID(IntPtr obj) { }

	public static string ovr_User_GetImageUrl(IntPtr obj) { }

	private static IntPtr ovr_User_GetImageUrl_Native(IntPtr obj) { }

	public static ulong ovr_User_GetLinkedAccounts(IntPtr userOptions) { }

	public static ulong ovr_User_GetLoggedInUser() { }

	public static ulong ovr_User_GetLoggedInUserFriends() { }

	public static string ovr_User_GetOculusID(IntPtr obj) { }

	private static IntPtr ovr_User_GetOculusID_Native(IntPtr obj) { }

	public static ulong ovr_User_GetOrgScopedID(ulong userID) { }

	public static string ovr_User_GetPresence(IntPtr obj) { }

	private static IntPtr ovr_User_GetPresence_Native(IntPtr obj) { }

	public static string ovr_User_GetPresenceDeeplinkMessage(IntPtr obj) { }

	private static IntPtr ovr_User_GetPresenceDeeplinkMessage_Native(IntPtr obj) { }

	public static string ovr_User_GetPresenceDestinationApiName(IntPtr obj) { }

	private static IntPtr ovr_User_GetPresenceDestinationApiName_Native(IntPtr obj) { }

	public static string ovr_User_GetPresenceLobbySessionId(IntPtr obj) { }

	private static IntPtr ovr_User_GetPresenceLobbySessionId_Native(IntPtr obj) { }

	public static string ovr_User_GetPresenceMatchSessionId(IntPtr obj) { }

	private static IntPtr ovr_User_GetPresenceMatchSessionId_Native(IntPtr obj) { }

	public static UserPresenceStatus ovr_User_GetPresenceStatus(IntPtr obj) { }

	public static ulong ovr_User_GetSdkAccounts() { }

	public static string ovr_User_GetSmallImageUrl(IntPtr obj) { }

	private static IntPtr ovr_User_GetSmallImageUrl_Native(IntPtr obj) { }

	public static ulong ovr_User_GetUserCapabilities() { }

	public static ulong ovr_User_GetUserProof() { }

	public static ulong ovr_User_LaunchBlockFlow(ulong userID) { }

	public static ulong ovr_User_LaunchFriendRequestFlow(ulong userID) { }

	public static ulong ovr_User_LaunchReportFlow(ulong userID) { }

	public static ulong ovr_User_LaunchReportFlow2(ulong optionalUserID, IntPtr abuseReportOptions) { }

	public static ulong ovr_User_LaunchUnblockFlow(ulong userID) { }

	public static ulong ovr_User_NewEntitledTestUser() { }

	public static ulong ovr_User_NewTestUser() { }

	public static ulong ovr_User_NewTestUserFriends() { }

	public static ulong ovr_User_StartRecordingForReportFlow() { }

	public static ulong ovr_User_StopRecordingAndLaunchReportFlow(ulong optionalUserID, string optionalRecordingUUID) { }

	private static ulong ovr_User_StopRecordingAndLaunchReportFlow_Native(ulong optionalUserID, IntPtr optionalRecordingUUID) { }

	public static ulong ovr_User_StopRecordingAndLaunchReportFlow2(ulong optionalUserID, string optionalRecordingUUID, IntPtr abuseReportOptions) { }

	private static ulong ovr_User_StopRecordingAndLaunchReportFlow2_Native(ulong optionalUserID, IntPtr optionalRecordingUUID, IntPtr abuseReportOptions) { }

	public static ulong ovr_User_TestUserCreateDeviceManifest(string deviceID, UInt64[] appIDs, int numAppIDs) { }

	private static ulong ovr_User_TestUserCreateDeviceManifest_Native(IntPtr deviceID, UInt64[] appIDs, int numAppIDs) { }

	public static AccountAgeCategory ovr_UserAccountAgeCategory_GetAgeCategory(IntPtr obj) { }

	public static ulong ovr_UserAgeCategory_Get() { }

	public static ulong ovr_UserAgeCategory_Report(AppAgeCategory age_category) { }

	public static IntPtr ovr_UserArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_UserArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_UserArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_UserArray_GetSize(IntPtr obj) { }

	public static bool ovr_UserArray_HasNextPage(IntPtr obj) { }

	public static string ovr_UserCapability_GetDescription(IntPtr obj) { }

	private static IntPtr ovr_UserCapability_GetDescription_Native(IntPtr obj) { }

	public static bool ovr_UserCapability_GetIsEnabled(IntPtr obj) { }

	public static string ovr_UserCapability_GetName(IntPtr obj) { }

	private static IntPtr ovr_UserCapability_GetName_Native(IntPtr obj) { }

	public static string ovr_UserCapability_GetReasonCode(IntPtr obj) { }

	private static IntPtr ovr_UserCapability_GetReasonCode_Native(IntPtr obj) { }

	public static IntPtr ovr_UserCapabilityArray_GetElement(IntPtr obj, UIntPtr index) { }

	public static string ovr_UserCapabilityArray_GetNextUrl(IntPtr obj) { }

	private static IntPtr ovr_UserCapabilityArray_GetNextUrl_Native(IntPtr obj) { }

	public static UIntPtr ovr_UserCapabilityArray_GetSize(IntPtr obj) { }

	public static bool ovr_UserCapabilityArray_HasNextPage(IntPtr obj) { }

	public static bool ovr_UserDataStoreUpdateResponse_GetSuccess(IntPtr obj) { }

	public static void ovr_UserOptions_AddServiceProvider(IntPtr handle, ServiceProvider value) { }

	public static void ovr_UserOptions_ClearServiceProviders(IntPtr handle) { }

	public static IntPtr ovr_UserOptions_Create() { }

	public static void ovr_UserOptions_Destroy(IntPtr handle) { }

	public static void ovr_UserOptions_SetMaxUsers(IntPtr handle, uint value) { }

	public static void ovr_UserOptions_SetTimeWindow(IntPtr handle, TimeWindow value) { }

	public static string ovr_UserProof_GetNonce(IntPtr obj) { }

	private static IntPtr ovr_UserProof_GetNonce_Native(IntPtr obj) { }

	public static bool ovr_UserReportID_GetDidCancel(IntPtr obj) { }

	public static ulong ovr_UserReportID_GetID(IntPtr obj) { }

	public static void ovr_Voip_Accept(ulong userID) { }

	public static IntPtr ovr_Voip_CreateDecoder() { }

	public static IntPtr ovr_Voip_CreateEncoder() { }

	public static void ovr_Voip_DestroyDecoder(IntPtr decoder) { }

	public static void ovr_Voip_DestroyEncoder(IntPtr encoder) { }

	public static VoipDtxState ovr_Voip_GetIsConnectionUsingDtx(ulong peerID) { }

	public static VoipBitrate ovr_Voip_GetLocalBitrate(ulong peerID) { }

	public static ulong ovr_Voip_GetMicrophoneAvailability() { }

	public static UIntPtr ovr_Voip_GetOutputBufferMaxSize() { }

	public static UIntPtr ovr_Voip_GetPCM(ulong senderID, Int16[] outputBuffer, UIntPtr outputBufferNumElements) { }

	public static UIntPtr ovr_Voip_GetPCMFloat(ulong senderID, Single[] outputBuffer, UIntPtr outputBufferNumElements) { }

	public static UIntPtr ovr_Voip_GetPCMSize(ulong senderID) { }

	public static UIntPtr ovr_Voip_GetPCMWithTimestamp(ulong senderID, Int16[] outputBuffer, UIntPtr outputBufferNumElements, UInt32[] timestamp) { }

	public static UIntPtr ovr_Voip_GetPCMWithTimestampFloat(ulong senderID, Single[] outputBuffer, UIntPtr outputBufferNumElements, UInt32[] timestamp) { }

	public static VoipBitrate ovr_Voip_GetRemoteBitrate(ulong peerID) { }

	public static uint ovr_Voip_GetSyncTimestamp(ulong userID) { }

	public static long ovr_Voip_GetSyncTimestampDifference(uint lhs, uint rhs) { }

	public static VoipMuteState ovr_Voip_GetSystemVoipMicrophoneMuted() { }

	public static SystemVoipStatus ovr_Voip_GetSystemVoipStatus() { }

	public static ulong ovr_Voip_ReportAppVoipSessions(UInt64[] sessionIDs) { }

	public static void ovr_Voip_SetMicrophoneFilterCallback(FilterCallback cb) { }

	public static void ovr_Voip_SetMicrophoneFilterCallbackWithFixedSizeBuffer(FilterCallback cb, UIntPtr bufferSizeElements) { }

	public static void ovr_Voip_SetMicrophoneMuted(VoipMuteState state) { }

	public static void ovr_Voip_SetNewConnectionOptions(IntPtr voipOptions) { }

	public static void ovr_Voip_SetOutputSampleRate(VoipSampleRate rate) { }

	public static void ovr_Voip_SetSystemVoipMicrophoneMuted(VoipMuteState muted) { }

	public static void ovr_Voip_SetSystemVoipPassthrough(bool passthrough) { }

	public static ulong ovr_Voip_SetSystemVoipSuppressed(bool suppressed) { }

	public static void ovr_Voip_Start(ulong userID) { }

	public static void ovr_Voip_Stop(ulong userID) { }

	public static void ovr_VoipDecoder_Decode(IntPtr obj, Byte[] compressedData, ulong compressedSize) { }

	public static void ovr_VoipDecoder_Decode(IntPtr obj, Byte[] compressedData, UIntPtr compressedSize) { }

	public static UIntPtr ovr_VoipDecoder_GetDecodedPCM(IntPtr obj, Single[] outputBuffer, UIntPtr outputBufferSize) { }

	public static void ovr_VoipEncoder_AddPCM(IntPtr obj, Single[] inputData, uint inputSize) { }

	public static UIntPtr ovr_VoipEncoder_GetCompressedData(IntPtr obj, Byte[] outputBuffer, UIntPtr intputSize) { }

	public static UIntPtr ovr_VoipEncoder_GetCompressedDataSize(IntPtr obj) { }

	public static IntPtr ovr_VoipOptions_Create() { }

	public static void ovr_VoipOptions_Destroy(IntPtr handle) { }

	public static void ovr_VoipOptions_SetBitrateForNewConnections(IntPtr handle, VoipBitrate value) { }

	public static void ovr_VoipOptions_SetCreateNewConnectionUseDtx(IntPtr handle, VoipDtxState value) { }

	public static string StringFromNative(IntPtr pointer) { }

	public static IntPtr StringToNative(string s) { }

}

