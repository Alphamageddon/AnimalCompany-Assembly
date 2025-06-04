namespace Oculus.Platform;

public class MessageWithProductList : Message<ProductList>
{

	public MessageWithProductList(IntPtr c_message) { }

	protected virtual ProductList GetDataFromMessage(IntPtr c_message) { }

	public virtual ProductList GetProductList() { }

}

