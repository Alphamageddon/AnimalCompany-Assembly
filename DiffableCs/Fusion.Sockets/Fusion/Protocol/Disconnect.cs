namespace Fusion.Protocol;

internal class Disconnect : Message
{
	public DisconnectReason DisconnectReason; //Field offset: 0x28

	public Disconnect() { }

	public Disconnect(DisconnectReason reason, ProtocolMessageVersion protocolVersion = 10, Version serializationVersion = null) { }

	protected virtual void SerializeProtected(BitStream stream) { }

	public virtual string ToString() { }

}

