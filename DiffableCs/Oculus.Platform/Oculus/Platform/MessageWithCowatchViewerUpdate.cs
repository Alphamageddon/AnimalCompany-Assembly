namespace Oculus.Platform;

public class MessageWithCowatchViewerUpdate : Message<CowatchViewerUpdate>
{

	public MessageWithCowatchViewerUpdate(IntPtr c_message) { }

	public virtual CowatchViewerUpdate GetCowatchViewerUpdate() { }

	protected virtual CowatchViewerUpdate GetDataFromMessage(IntPtr c_message) { }

}

