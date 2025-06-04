namespace Oculus.Platform;

public static class PlatformInternal
{
	internal static class HTTP
	{

		public static void SetHttpTransferUpdateCallback(Callback<HttpTransferUpdate> callback) { }

	}

	internal enum MessageTypeInternal
	{
		AbuseReport_LaunchAdvancedReportFlow = 1286683246,
		Application_ExecuteCoordinatedLaunch = 645772532,
		Application_GetInstalledApplications = 1376744524,
		Avatar_UpdateMetaData = 2077219214,
		Cal_FinalizeApplication = 497667029,
		Cal_GetSuggestedApplications = 1450209301,
		Cal_ProposeApplication = 1317270237,
		Colocation_GetCurrentMapUuid = 878018226,
		Colocation_RequestMap = 840263277,
		Colocation_ShareMap = 409847005,
		DeviceApplicationIntegrity_GetAttestationToken = 271557598,
		GraphAPI_Get = 822018158,
		GraphAPI_Post = 1990567876,
		HTTP_Get = 1874211363,
		HTTP_GetToFile = 1317133401,
		HTTP_MultiPartPost = 1480774160,
		HTTP_Post = 1798743375,
		Livestreaming_IsAllowedForApplication = 191729014,
		Livestreaming_StartPartyStream = 2066701532,
		Livestreaming_StartStream = 1343932350,
		Livestreaming_StopPartyStream = 661065560,
		Livestreaming_StopStream = 1155796426,
		Livestreaming_UpdateMicStatus = 475495815,
		NetSync_Connect = 1684899167,
		NetSync_Disconnect = 359268021,
		NetSync_GetSessions = 1859521077,
		NetSync_GetVoipAttenuation = 288016919,
		NetSync_GetVoipAttenuationDefault = 1467721888,
		NetSync_SetVoipAttenuation = 882366454,
		NetSync_SetVoipAttenuationModel = 1788128654,
		NetSync_SetVoipChannelCfg = 1553310963,
		NetSync_SetVoipGroup = 1477614734,
		NetSync_SetVoipListentoChannels = 1590749746,
		NetSync_SetVoipMicSource = 855832432,
		NetSync_SetVoipSessionMuted = 1434844938,
		NetSync_SetVoipSpeaktoChannels = 766496213,
		NetSync_SetVoipStreamMode = 1742839095,
		Party_Create = 450042703,
		Party_GatherInApplication = 1921499523,
		Party_Get = 1586058173,
		Party_GetCurrentForUser = 1489764138,
		Party_Invite = 901104867,
		Party_Join = 1744993395,
		Party_Leave = 848430801,
		RichPresence_SetDestination = 1328734477,
		RichPresence_SetIsJoinable = 1050353505,
		RichPresence_SetLobbySession = 1895893271,
		RichPresence_SetMatchSession = 1675623566,
		Room_CreateOrUpdateAndJoinNamed = 2089683601,
		Room_GetNamedRooms = 125660812,
		Room_GetSocialRooms = 1636310390,
		User_CancelRecordingForReportFlow = 65065289,
		User_GetLinkedAccounts = 1469314134,
		User_GetUserCapabilities = 303837564,
		User_LaunchReportFlow = 1449304081,
		User_LaunchReportFlow2 = 2139314275,
		User_NewEntitledTestUser = 292822787,
		User_NewTestUser = 921194380,
		User_NewTestUserFriends = 517416647,
		User_StartRecordingForReportFlow = 1819161571,
		User_StopRecordingAndLaunchReportFlow = 1618513035,
		User_StopRecordingAndLaunchReportFlow2 = 432190251,
		User_TestUserCreateDeviceManifest = 1701884605,
		Voip_ReportAppVoipSessions = 408048078,
	}

	internal static class Users
	{

		public static Request<LinkedAccountList> GetLinkedAccounts(ServiceProvider[] providers) { }

	}


	public static void CrashApplication() { }

	public static Request<PlatformInitialize> InitializeStandaloneAsync(ulong appID, string accessToken) { }

	internal static Message ParseMessageHandle(IntPtr messageHandle, MessageType messageType) { }

}

