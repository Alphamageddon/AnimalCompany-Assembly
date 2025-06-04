namespace Fusion.Protocol;

internal class Join : Message
{
	public JoinMessageType Type; //Field offset: 0x28
	public PluginGameMode GameMode; //Field offset: 0x29
	public PeerMode PeerMode; //Field offset: 0x2A
	public JoinRequests JoinRequests; //Field offset: 0x2C
	public Byte[] UniqueId; //Field offset: 0x30
	public int PlayerRef; //Field offset: 0x38
	public Byte[] EncryptionKey; //Field offset: 0x40
	public Byte[] EncryptionKeySecret; //Field offset: 0x48

	public Join() { }

	public Join(JoinMessageType type, PluginGameMode mode, PeerMode peerMode, int playerRef, JoinRequests joinRequests = 0, Byte[] uniqueID = null, Byte[] encryptionKey = null, Byte[] encryptionKeySecret = null, ProtocolMessageVersion protocolVersion = 10, Version serializationVersion = null) { }

	protected virtual void SerializeProtected(BitStream stream) { }

	public virtual string ToString() { }

}

