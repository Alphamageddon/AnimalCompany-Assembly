namespace Fusion.Sockets;

internal struct NetUnreliableHeader
{
	public const int SIZE = 1; //Field offset: 0x0
	public const int SIZE_IN_BITS = 8; //Field offset: 0x0
	public NetPacketType PacketType; //Field offset: 0x0

	public static NetUnreliableHeader Create() { }

}

