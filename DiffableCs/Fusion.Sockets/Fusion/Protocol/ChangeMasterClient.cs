namespace Fusion.Protocol;

internal class ChangeMasterClient : Message
{
	public int NewMasterClientCandidate; //Field offset: 0x28

	public ChangeMasterClient() { }

	public ChangeMasterClient(int newMasterClientCandidate, ProtocolMessageVersion protocolVersion = 10, Version serializationVersion = null) { }

	protected virtual void SerializeProtected(BitStream stream) { }

	public virtual string ToString() { }

}

