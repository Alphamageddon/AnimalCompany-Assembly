namespace Oculus.Platform;

public static class ApplicationLifecycle
{

	public static LaunchDetails GetLaunchDetails() { }

	public static void LogDeeplinkResult(string trackingID, LaunchResult result) { }

	public static void SetLaunchIntentChangedNotificationCallback(Callback<String> callback) { }

}

