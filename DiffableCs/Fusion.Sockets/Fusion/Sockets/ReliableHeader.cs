namespace Fusion.Sockets;

public struct ReliableHeader
{
	public const int SIZE = 64; //Field offset: 0x0
	public ReliableHeader* Next; //Field offset: 0x0
	public ReliableHeader* Prev; //Field offset: 0x8
	public ReliableId Id; //Field offset: 0x10

	public static Byte* GetData(ReliableHeader* header) { }

}

