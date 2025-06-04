namespace Fusion.Protocol;

internal class NetworkConfigSync : Message
{
	public SyncType Type; //Field offset: 0x28
	public string NetworkConfig; //Field offset: 0x30

	public NetworkConfigSync() { }

	public NetworkConfigSync(SyncType type, string serializedNetworkConfig, ProtocolMessageVersion protocolVersion = 10, Version serializationVersion = null) { }

	protected virtual void SerializeProtected(BitStream stream) { }

	public virtual string ToString() { }

}

