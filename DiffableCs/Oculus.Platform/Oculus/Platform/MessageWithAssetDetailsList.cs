namespace Oculus.Platform;

public class MessageWithAssetDetailsList : Message<AssetDetailsList>
{

	public MessageWithAssetDetailsList(IntPtr c_message) { }

	public virtual AssetDetailsList GetAssetDetailsList() { }

	protected virtual AssetDetailsList GetDataFromMessage(IntPtr c_message) { }

}

