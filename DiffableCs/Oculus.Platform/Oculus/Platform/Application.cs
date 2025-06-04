namespace Oculus.Platform;

public static class Application
{

	public static Request<AppDownloadResult> CancelAppDownload() { }

	public static Request<AppDownloadProgressResult> CheckAppDownloadProgress() { }

	public static Request<ApplicationVersion> GetVersion() { }

	public static Request<AppDownloadResult> InstallAppUpdateAndRelaunch(ApplicationOptions deeplink_options = null) { }

	public static Request<String> LaunchOtherApp(ulong appID, ApplicationOptions deeplink_options = null) { }

	public static Request<AppDownloadResult> StartAppDownload() { }

}

