namespace Fusion.Sockets;

public struct NetSendEnvelope
{
	public Void* UserData; //Field offset: 0x0
	public ushort Sequence; //Field offset: 0x8
	public double SendTime; //Field offset: 0x10
	internal NetPacketType PacketType; //Field offset: 0x18

}

