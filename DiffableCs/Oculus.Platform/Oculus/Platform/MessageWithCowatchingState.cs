namespace Oculus.Platform;

public class MessageWithCowatchingState : Message<CowatchingState>
{

	public MessageWithCowatchingState(IntPtr c_message) { }

	public virtual CowatchingState GetCowatchingState() { }

	protected virtual CowatchingState GetDataFromMessage(IntPtr c_message) { }

}

