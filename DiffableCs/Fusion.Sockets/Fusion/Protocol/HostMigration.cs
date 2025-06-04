namespace Fusion.Protocol;

internal class HostMigration : Message
{
	public PeerMode PeerMode; //Field offset: 0x28

	public HostMigration() { }

	public HostMigration(PeerMode peerMode, ProtocolMessageVersion protocolVersion = 10, Version serializationVersion = null) { }

	protected virtual void SerializeProtected(BitStream stream) { }

	public virtual string ToString() { }

}

