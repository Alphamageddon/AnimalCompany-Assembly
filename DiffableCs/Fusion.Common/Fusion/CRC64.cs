namespace Fusion;

public static class CRC64
{
	private static readonly UInt64[] _tab; //Field offset: 0x0

	private static CRC64() { }

	public static ulong Compute(ulong crc, Byte* data, int offset, int length) { }

	public static ulong Compute(Byte* data, int length) { }

}

