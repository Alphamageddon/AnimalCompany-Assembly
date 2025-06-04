namespace Oculus.Platform;

public class MessageWithUserCapabilityList : Message<UserCapabilityList>
{

	public MessageWithUserCapabilityList(IntPtr c_message) { }

	protected virtual UserCapabilityList GetDataFromMessage(IntPtr c_message) { }

	public virtual UserCapabilityList GetUserCapabilityList() { }

}

