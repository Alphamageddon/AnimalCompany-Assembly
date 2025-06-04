namespace Oculus.Platform;

public class MessageWithPartyID : Message<PartyID>
{

	public MessageWithPartyID(IntPtr c_message) { }

	protected virtual PartyID GetDataFromMessage(IntPtr c_message) { }

	public virtual PartyID GetPartyID() { }

}

