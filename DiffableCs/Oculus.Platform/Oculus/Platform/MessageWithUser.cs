namespace Oculus.Platform;

public class MessageWithUser : Message<User>
{

	public MessageWithUser(IntPtr c_message) { }

	protected virtual User GetDataFromMessage(IntPtr c_message) { }

	public virtual User GetUser() { }

}

