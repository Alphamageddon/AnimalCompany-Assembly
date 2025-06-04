namespace Oculus.Platform;

public class MessageWithNetSyncVoipAttenuationValueList : Message<NetSyncVoipAttenuationValueList>
{

	public MessageWithNetSyncVoipAttenuationValueList(IntPtr c_message) { }

	protected virtual NetSyncVoipAttenuationValueList GetDataFromMessage(IntPtr c_message) { }

	public virtual NetSyncVoipAttenuationValueList GetNetSyncVoipAttenuationValueList() { }

}

