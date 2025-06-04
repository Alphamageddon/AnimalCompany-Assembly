namespace emotitron.Compression;

[Extension]
public static class QuatCompress
{
	internal struct Cache
	{
		public int bitsA; //Field offset: 0x0
		public int bitsB; //Field offset: 0x4
		public int bitsC; //Field offset: 0x8
		public int shiftB; //Field offset: 0xC
		public int shiftC; //Field offset: 0x10
		public int shiftExtra; //Field offset: 0x14
		public uint halfA; //Field offset: 0x18
		public uint halfB; //Field offset: 0x1C
		public uint halfC; //Field offset: 0x20
		public uint maxA; //Field offset: 0x24
		public uint maxB; //Field offset: 0x28
		public uint maxC; //Field offset: 0x2C
		public float decoderA; //Field offset: 0x30
		public float decoderB; //Field offset: 0x34
		public float decoderC; //Field offset: 0x38
		public float encoderA; //Field offset: 0x3C
		public float encoderB; //Field offset: 0x40
		public float encoderC; //Field offset: 0x44

		public Cache(int _bitsA, int _bitsB, int _bitsC) { }

	}

	internal struct FastAbs
	{
		public uint uint32; //Field offset: 0x0
		public float single; //Field offset: 0x0

	}

	public static Byte[] reusableByteArray; //Field offset: 0x0
	public const bool ISPRO = True; //Field offset: 0x0
	public const int MIN_ALLOWED_BITS = 16; //Field offset: 0x0
	public const int MAX_ALLOWED_BITS = 64; //Field offset: 0x0
	public const int DEF_BYTE_COUNT = 5; //Field offset: 0x0
	private const float ENRANGE = 1.414213; //Field offset: 0x0
	private const float UNRANGE = 0.7071069; //Field offset: 0x0
	private static Single[] invHalfRange; //Field offset: 0x8
	public static Cache[] caches; //Field offset: 0x10

	private static QuatCompress() { }

	[Extension]
	public static ulong Compress(Quaternion rot, PrimitivePresets preset) { }

	[Extension]
	public static ulong Compress(Quaternion rot, int bits) { }

	[Extension]
	public static ulong Compress(Quaternion rot, Cache cache) { }

	[Extension]
	public static Byte[] CompressToByteArray(Quaternion rot, int bytecount = 5) { }

	[Extension]
	public static Byte[] CompressToByteArrayNonAlloc(Quaternion rot, Byte[] arr, int bytecount = -1) { }

	[Extension]
	public static uint CompressToUint(Quaternion rot) { }

	[Extension]
	public static ulong CompressToULong(Quaternion rotation, int totalBits = 64) { }

	[Extension]
	public static ushort CompressToUShort(Quaternion rot) { }

	[Extension]
	public static ulong ConvertByteArrayToULongBuffer(Byte[] arr, int bytecount = -1, int startIndex = 0) { }

	[Extension]
	public static Quaternion Decompress(ulong buffer, PrimitivePresets preset) { }

	[Extension]
	public static Quaternion Decompress(ulong buffer, int bits) { }

	[Extension]
	public static Quaternion Decompress(ulong buffer, Cache cache) { }

	[Extension]
	public static Quaternion DecompressToQuat(Byte[] arr, int bytecount = 5, int startIndex = 0) { }

	[Extension]
	public static Quaternion DecompressToQuat(ulong buffer, int totalBits = 64) { }

	[Extension]
	public static Quaternion DecompressToQuat(uint buffer, int bits = 32) { }

	[Extension]
	public static Quaternion DecompressToQuat(short buffer, int bits = 16) { }

	private static Cache DivideBitsAmongChannels(int totalbits) { }

}

