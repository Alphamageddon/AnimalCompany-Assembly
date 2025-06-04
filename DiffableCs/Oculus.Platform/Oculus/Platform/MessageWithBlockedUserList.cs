namespace Oculus.Platform;

public class MessageWithBlockedUserList : Message<BlockedUserList>
{

	public MessageWithBlockedUserList(IntPtr c_message) { }

	public virtual BlockedUserList GetBlockedUserList() { }

	protected virtual BlockedUserList GetDataFromMessage(IntPtr c_message) { }

}

