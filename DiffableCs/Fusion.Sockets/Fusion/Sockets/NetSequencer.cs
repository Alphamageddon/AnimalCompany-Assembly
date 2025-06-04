namespace Fusion.Sockets;

internal struct NetSequencer
{
	private int _shift; //Field offset: 0x0
	private int _bytes; //Field offset: 0x4
	private ulong _mask; //Field offset: 0x8
	private ulong _sequence; //Field offset: 0x10

	public int Bits
	{
		 get { } //Length: 12
	}

	public int Bytes
	{
		 get { } //Length: 8
	}

	public ulong Sequence
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public NetSequencer(int bytes) { }

	public int Distance(ulong from, ulong to) { }

	public int get_Bits() { }

	public int get_Bytes() { }

	public ulong get_Sequence() { }

	public ulong Next() { }

	public ulong NextAfter(ulong sequence) { }

	public void Reset() { }

	public void set_Sequence(ulong value) { }

}

