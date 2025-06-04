namespace ExitGames.Client.Photon;

[DefaultMember("Item")]
public class OperationResponse
{
	public byte OperationCode; //Field offset: 0x10
	public short ReturnCode; //Field offset: 0x12
	public string DebugMessage; //Field offset: 0x18
	public ParameterDictionary Parameters; //Field offset: 0x20

	public object Item
	{
		 get { } //Length: 44
		 set { } //Length: 28
	}

	public OperationResponse() { }

	public object get_Item(byte parameterCode) { }

	public void set_Item(byte parameterCode, object value) { }

	public virtual string ToString() { }

	public string ToStringFull() { }

}

