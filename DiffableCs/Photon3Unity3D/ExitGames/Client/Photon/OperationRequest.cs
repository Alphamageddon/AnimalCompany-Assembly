namespace ExitGames.Client.Photon;

public class OperationRequest
{
	public byte OperationCode; //Field offset: 0x10
	public ParameterDictionary Parameters; //Field offset: 0x18

	public OperationRequest() { }

}

