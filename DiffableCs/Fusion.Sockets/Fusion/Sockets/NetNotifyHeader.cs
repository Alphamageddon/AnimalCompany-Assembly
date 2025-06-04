namespace Fusion.Sockets;

internal struct NetNotifyHeader
{
	public const int SIZE_IN_BYTES = 14; //Field offset: 0x0
	public const int SIZE_IN_BITS = 112; //Field offset: 0x0
	public NetPacketType PacketType; //Field offset: 0x0
	public byte Fragment; //Field offset: 0x1
	public ushort Sequence; //Field offset: 0x2
	public ushort AckSequence; //Field offset: 0x4
	public ulong AckMask; //Field offset: 0x6

	public static NetNotifyHeader CreateAcks(ushort ackSequence, ulong ackMask) { }

	public static NetNotifyHeader CreateData(ushort sequence, ushort ackSequence, ulong ackMask) { }

	public virtual string ToString() { }

}

