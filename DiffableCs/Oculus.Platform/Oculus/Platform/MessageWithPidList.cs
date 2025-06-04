namespace Oculus.Platform;

public class MessageWithPidList : Message<PidList>
{

	public MessageWithPidList(IntPtr c_message) { }

	protected virtual PidList GetDataFromMessage(IntPtr c_message) { }

	public virtual PidList GetPidList() { }

}

