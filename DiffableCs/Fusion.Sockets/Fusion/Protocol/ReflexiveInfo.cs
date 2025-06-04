namespace Fusion.Protocol;

internal class ReflexiveInfo : Message
{
	public int ActorNr; //Field offset: 0x28
	public NetAddress PublicAddr; //Field offset: 0x30
	public NetAddress PrivateAddr; //Field offset: 0x48
	public NATType NatType; //Field offset: 0x60
	public Byte[] UniqueId; //Field offset: 0x68

	public virtual bool IsValid
	{
		 get { } //Length: 148
	}

	public ReflexiveInfo() { }

	public ReflexiveInfo(int actorNr, NetAddress publicAddr, NetAddress privateAddr, NATType stunNatType, Byte[] uniqueID = null, ProtocolMessageVersion protocolVersion = 10, Version serializationVersion = null) { }

	public virtual bool get_IsValid() { }

	protected virtual void SerializeProtected(BitStream stream) { }

	public virtual string ToString() { }

}

