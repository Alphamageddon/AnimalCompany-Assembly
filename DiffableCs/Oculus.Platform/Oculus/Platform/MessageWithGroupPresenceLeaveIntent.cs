namespace Oculus.Platform;

public class MessageWithGroupPresenceLeaveIntent : Message<GroupPresenceLeaveIntent>
{

	public MessageWithGroupPresenceLeaveIntent(IntPtr c_message) { }

	protected virtual GroupPresenceLeaveIntent GetDataFromMessage(IntPtr c_message) { }

	public virtual GroupPresenceLeaveIntent GetGroupPresenceLeaveIntent() { }

}

