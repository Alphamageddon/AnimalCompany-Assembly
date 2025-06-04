namespace Oculus.Platform;

public class MessageWithPartyUpdateNotification : Message<PartyUpdateNotification>
{

	public MessageWithPartyUpdateNotification(IntPtr c_message) { }

	protected virtual PartyUpdateNotification GetDataFromMessage(IntPtr c_message) { }

	public virtual PartyUpdateNotification GetPartyUpdateNotification() { }

}

