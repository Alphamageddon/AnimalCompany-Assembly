namespace Oculus.Platform;

public class MessageWithCowatchViewerList : Message<CowatchViewerList>
{

	public MessageWithCowatchViewerList(IntPtr c_message) { }

	public virtual CowatchViewerList GetCowatchViewerList() { }

	protected virtual CowatchViewerList GetDataFromMessage(IntPtr c_message) { }

}

