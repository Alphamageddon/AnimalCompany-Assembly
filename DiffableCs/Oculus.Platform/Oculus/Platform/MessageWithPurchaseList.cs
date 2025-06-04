namespace Oculus.Platform;

public class MessageWithPurchaseList : Message<PurchaseList>
{

	public MessageWithPurchaseList(IntPtr c_message) { }

	protected virtual PurchaseList GetDataFromMessage(IntPtr c_message) { }

	public virtual PurchaseList GetPurchaseList() { }

}

