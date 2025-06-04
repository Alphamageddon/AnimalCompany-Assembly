namespace Oculus.Platform;

public static class Cowatching
{

	public static Request<CowatchViewerList> GetNextCowatchViewerListPage(CowatchViewerList list) { }

	public static Request<String> GetPresenterData() { }

	public static Request<CowatchViewerList> GetViewersData() { }

	public static Request<CowatchingState> IsInSession() { }

	public static Request JoinSession() { }

	public static Request LaunchInviteDialog() { }

	public static Request LeaveSession() { }

	public static Request RequestToPresent() { }

	public static Request ResignFromPresenting() { }

	public static void SetApiNotReadyNotificationCallback(Callback<String> callback) { }

	public static void SetApiReadyNotificationCallback(Callback<String> callback) { }

	public static void SetInitializedNotificationCallback(Callback<String> callback) { }

	public static void SetInSessionChangedNotificationCallback(Callback<CowatchingState> callback) { }

	public static Request SetPresenterData(string video_title, string presenter_data) { }

	public static void SetPresenterDataChangedNotificationCallback(Callback<String> callback) { }

	public static void SetSessionStartedNotificationCallback(Callback<String> callback) { }

	public static void SetSessionStoppedNotificationCallback(Callback<String> callback) { }

	public static Request SetViewerData(string viewer_data) { }

	public static void SetViewersDataChangedNotificationCallback(Callback<CowatchViewerUpdate> callback) { }

}

