namespace Oculus.Platform;

public class MessageWithGroupPresenceJoinIntent : Message<GroupPresenceJoinIntent>
{

	public MessageWithGroupPresenceJoinIntent(IntPtr c_message) { }

	protected virtual GroupPresenceJoinIntent GetDataFromMessage(IntPtr c_message) { }

	public virtual GroupPresenceJoinIntent GetGroupPresenceJoinIntent() { }

}

