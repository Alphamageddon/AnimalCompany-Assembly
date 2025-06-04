namespace Oculus.Platform;

public class MessageWithAssetDetails : Message<AssetDetails>
{

	public MessageWithAssetDetails(IntPtr c_message) { }

	public virtual AssetDetails GetAssetDetails() { }

	protected virtual AssetDetails GetDataFromMessage(IntPtr c_message) { }

}

