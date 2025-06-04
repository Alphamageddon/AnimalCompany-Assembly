namespace Oculus.Platform;

public class MessageWithSystemVoipState : Message<SystemVoipState>
{

	public MessageWithSystemVoipState(IntPtr c_message) { }

	protected virtual SystemVoipState GetDataFromMessage(IntPtr c_message) { }

	public virtual SystemVoipState GetSystemVoipState() { }

}

