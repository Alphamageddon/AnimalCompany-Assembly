namespace Oculus.Platform;

public class MessageWithParty : Message<Party>
{

	public MessageWithParty(IntPtr c_message) { }

	protected virtual Party GetDataFromMessage(IntPtr c_message) { }

	public virtual Party GetParty() { }

}

