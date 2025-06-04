namespace Fusion.Sockets;

public struct ReliableKey
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <Data>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	public const int SIZE = 16; //Field offset: 0x0
	[FixedBuffer(typeof(byte, 16)]
	public <Data>e__FixedBuffer Data; //Field offset: 0x0

	public static ReliableKey FromInts(int key0 = 0, int key1 = 0, int key2 = 0, int key3 = 0) { }

	public static ReliableKey FromULongs(ulong key0 = 0, ulong key1 = 0) { }

	public void GetInts(out int key0, out int key1, out int key2, out int key3) { }

	public void GetUlongs(out ulong key0, out ulong key1) { }

}

