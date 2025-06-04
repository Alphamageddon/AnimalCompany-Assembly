namespace Oculus.Platform;

public class MessageWithLinkedAccountList : Message<LinkedAccountList>
{

	public MessageWithLinkedAccountList(IntPtr c_message) { }

	protected virtual LinkedAccountList GetDataFromMessage(IntPtr c_message) { }

	public virtual LinkedAccountList GetLinkedAccountList() { }

}

