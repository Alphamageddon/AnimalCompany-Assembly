namespace Fusion.Protocol;

internal class PlayerRefMapping : Message
{
	public int ActorId; //Field offset: 0x28
	public int PlayerRef; //Field offset: 0x2C
	public Byte[] UniqueId; //Field offset: 0x30

	public PlayerRefMapping() { }

	protected virtual void SerializeProtected(BitStream stream) { }

	public virtual string ToString() { }

}

