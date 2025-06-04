namespace Oculus.Platform;

public class MessageWithUserList : Message<UserList>
{

	public MessageWithUserList(IntPtr c_message) { }

	protected virtual UserList GetDataFromMessage(IntPtr c_message) { }

	public virtual UserList GetUserList() { }

}

