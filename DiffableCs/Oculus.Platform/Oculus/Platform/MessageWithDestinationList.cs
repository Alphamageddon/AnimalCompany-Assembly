namespace Oculus.Platform;

public class MessageWithDestinationList : Message<DestinationList>
{

	public MessageWithDestinationList(IntPtr c_message) { }

	protected virtual DestinationList GetDataFromMessage(IntPtr c_message) { }

	public virtual DestinationList GetDestinationList() { }

}

