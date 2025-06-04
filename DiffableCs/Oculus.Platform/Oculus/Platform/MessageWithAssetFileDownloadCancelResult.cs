namespace Oculus.Platform;

public class MessageWithAssetFileDownloadCancelResult : Message<AssetFileDownloadCancelResult>
{

	public MessageWithAssetFileDownloadCancelResult(IntPtr c_message) { }

	public virtual AssetFileDownloadCancelResult GetAssetFileDownloadCancelResult() { }

	protected virtual AssetFileDownloadCancelResult GetDataFromMessage(IntPtr c_message) { }

}

