namespace Oculus.Platform;

public class MessageWithApplicationVersion : Message<ApplicationVersion>
{

	public MessageWithApplicationVersion(IntPtr c_message) { }

	public virtual ApplicationVersion GetApplicationVersion() { }

	protected virtual ApplicationVersion GetDataFromMessage(IntPtr c_message) { }

}

