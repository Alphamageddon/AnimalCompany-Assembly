namespace Oculus.Platform;

public class MessageWithAssetFileDownloadResult : Message<AssetFileDownloadResult>
{

	public MessageWithAssetFileDownloadResult(IntPtr c_message) { }

	public virtual AssetFileDownloadResult GetAssetFileDownloadResult() { }

	protected virtual AssetFileDownloadResult GetDataFromMessage(IntPtr c_message) { }

}

