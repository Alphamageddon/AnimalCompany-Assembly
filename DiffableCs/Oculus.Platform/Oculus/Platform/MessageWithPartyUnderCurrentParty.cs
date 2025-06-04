namespace Oculus.Platform;

public class MessageWithPartyUnderCurrentParty : Message<Party>
{

	public MessageWithPartyUnderCurrentParty(IntPtr c_message) { }

	protected virtual Party GetDataFromMessage(IntPtr c_message) { }

	public virtual Party GetParty() { }

}

