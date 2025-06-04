namespace Oculus.Platform;

public class MessageWithAssetFileDownloadUpdate : Message<AssetFileDownloadUpdate>
{

	public MessageWithAssetFileDownloadUpdate(IntPtr c_message) { }

	public virtual AssetFileDownloadUpdate GetAssetFileDownloadUpdate() { }

	protected virtual AssetFileDownloadUpdate GetDataFromMessage(IntPtr c_message) { }

}

