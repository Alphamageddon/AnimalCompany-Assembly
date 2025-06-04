namespace Oculus.Platform;

public static class AssetFile
{

	public static Request<AssetFileDeleteResult> Delete(ulong assetFileID) { }

	public static Request<AssetFileDeleteResult> DeleteById(ulong assetFileID) { }

	public static Request<AssetFileDeleteResult> DeleteByName(string assetFileName) { }

	public static Request<AssetFileDownloadResult> Download(ulong assetFileID) { }

	public static Request<AssetFileDownloadResult> DownloadById(ulong assetFileID) { }

	public static Request<AssetFileDownloadResult> DownloadByName(string assetFileName) { }

	public static Request<AssetFileDownloadCancelResult> DownloadCancel(ulong assetFileID) { }

	public static Request<AssetFileDownloadCancelResult> DownloadCancelById(ulong assetFileID) { }

	public static Request<AssetFileDownloadCancelResult> DownloadCancelByName(string assetFileName) { }

	public static Request<AssetDetailsList> GetList() { }

	public static void SetDownloadUpdateNotificationCallback(Callback<AssetFileDownloadUpdate> callback) { }

	public static Request<AssetDetails> Status(ulong assetFileID) { }

	public static Request<AssetDetails> StatusById(ulong assetFileID) { }

	public static Request<AssetDetails> StatusByName(string assetFileName) { }

}

