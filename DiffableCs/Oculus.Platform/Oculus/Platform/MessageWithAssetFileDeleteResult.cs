namespace Oculus.Platform;

public class MessageWithAssetFileDeleteResult : Message<AssetFileDeleteResult>
{

	public MessageWithAssetFileDeleteResult(IntPtr c_message) { }

	public virtual AssetFileDeleteResult GetAssetFileDeleteResult() { }

	protected virtual AssetFileDeleteResult GetDataFromMessage(IntPtr c_message) { }

}

