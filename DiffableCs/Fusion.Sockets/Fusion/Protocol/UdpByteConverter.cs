namespace Fusion.Protocol;

internal struct UdpByteConverter
{
	public short Signed16; //Field offset: 0x0
	public byte Byte0; //Field offset: 0x0
	public float Float32; //Field offset: 0x0
	public ulong Unsigned64; //Field offset: 0x0
	public long Signed64; //Field offset: 0x0
	public double Float64; //Field offset: 0x0
	public int Signed32; //Field offset: 0x0
	public char Char; //Field offset: 0x0
	public ushort Unsigned16; //Field offset: 0x0
	public uint Unsigned32; //Field offset: 0x0
	public byte Byte1; //Field offset: 0x1
	public byte Byte2; //Field offset: 0x2
	public byte Byte3; //Field offset: 0x3
	public byte Byte4; //Field offset: 0x4
	public byte Byte5; //Field offset: 0x5
	public byte Byte6; //Field offset: 0x6
	public byte Byte7; //Field offset: 0x7

	public static UdpByteConverter op_Implicit(short val) { }

	public static UdpByteConverter op_Implicit(ushort val) { }

	public static UdpByteConverter op_Implicit(char val) { }

	public static UdpByteConverter op_Implicit(uint val) { }

	public static UdpByteConverter op_Implicit(int val) { }

	public static UdpByteConverter op_Implicit(ulong val) { }

	public static UdpByteConverter op_Implicit(long val) { }

	public static UdpByteConverter op_Implicit(float val) { }

	public static UdpByteConverter op_Implicit(double val) { }

}

