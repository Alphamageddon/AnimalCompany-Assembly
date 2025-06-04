namespace Fusion.Sockets;

public struct ReliableId
{
	public const int SIZE = 48; //Field offset: 0x0
	public ulong Sequence; //Field offset: 0x0
	public int SliceLength; //Field offset: 0x8
	public int TotalLength; //Field offset: 0xC
	public int Source; //Field offset: 0x10
	public int SourceSend; //Field offset: 0x14
	public int Target; //Field offset: 0x18
	public ReliableKey Key; //Field offset: 0x1C
	private int _padding; //Field offset: 0x2C

	public long SourceCombined
	{
		 get { } //Length: 16
	}

	public long get_SourceCombined() { }

}

