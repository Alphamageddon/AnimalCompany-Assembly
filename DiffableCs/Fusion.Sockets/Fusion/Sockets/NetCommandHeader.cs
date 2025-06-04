namespace Fusion.Sockets;

internal struct NetCommandHeader
{
	public const int SIZE_BYTES = 2; //Field offset: 0x0
	public const int SIZE_BITS = 16; //Field offset: 0x0
	public NetPacketType PacketType; //Field offset: 0x0
	public NetCommands Command; //Field offset: 0x1

	public static NetCommandHeader Create(NetCommands command) { }

	public static NetCommandHeader op_Implicit(NetCommands commands) { }

}

