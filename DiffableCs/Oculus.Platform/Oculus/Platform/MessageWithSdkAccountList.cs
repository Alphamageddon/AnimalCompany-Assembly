namespace Oculus.Platform;

public class MessageWithSdkAccountList : Message<SdkAccountList>
{

	public MessageWithSdkAccountList(IntPtr c_message) { }

	protected virtual SdkAccountList GetDataFromMessage(IntPtr c_message) { }

	public virtual SdkAccountList GetSdkAccountList() { }

}

