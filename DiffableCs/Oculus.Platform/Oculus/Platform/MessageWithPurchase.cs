namespace Oculus.Platform;

public class MessageWithPurchase : Message<Purchase>
{

	public MessageWithPurchase(IntPtr c_message) { }

	protected virtual Purchase GetDataFromMessage(IntPtr c_message) { }

	public virtual Purchase GetPurchase() { }

}

