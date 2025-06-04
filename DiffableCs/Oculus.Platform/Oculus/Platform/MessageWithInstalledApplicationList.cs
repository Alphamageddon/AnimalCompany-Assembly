namespace Oculus.Platform;

public class MessageWithInstalledApplicationList : Message<InstalledApplicationList>
{

	public MessageWithInstalledApplicationList(IntPtr c_message) { }

	protected virtual InstalledApplicationList GetDataFromMessage(IntPtr c_message) { }

	public virtual InstalledApplicationList GetInstalledApplicationList() { }

}

