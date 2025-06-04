namespace Fusion.Protocol;

internal class Start : Message
{
	public int RemoteServerID; //Field offset: 0x28
	public StartRequests StartRequests; //Field offset: 0x2C

	public Start() { }

	public Start(int remoteServerId, StartRequests startRequests, ProtocolMessageVersion protocolVersion = 10, Version serializationVersion = null) { }

	protected virtual void SerializeProtected(BitStream stream) { }

	public virtual string ToString() { }

}

