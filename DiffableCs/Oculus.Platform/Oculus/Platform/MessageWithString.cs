namespace Oculus.Platform;

public class MessageWithString : Message<String>
{

	public MessageWithString(IntPtr c_message) { }

	protected virtual string GetDataFromMessage(IntPtr c_message) { }

	public virtual string GetString() { }

}

