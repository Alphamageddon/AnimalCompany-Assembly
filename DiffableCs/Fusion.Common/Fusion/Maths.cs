namespace Fusion;

public static class Maths
{
	internal struct FastAbs
	{
		public const uint Mask = 2147483647; //Field offset: 0x0
		public uint UInt32; //Field offset: 0x0
		public float Single; //Field offset: 0x0

	}

	private struct FastAbs2
	{
		public uint uint32; //Field offset: 0x0
		public float single; //Field offset: 0x0

	}

	private const float ENRANGE = 1.4142133; //Field offset: 0x0
	private const float UNRANGE = 0.7071069; //Field offset: 0x0
	private const uint HALF_ENCODED = 512; //Field offset: 0x0
	private const float ENCODER = 724.0772; //Field offset: 0x0
	private const float DECODER = 0.0013810681; //Field offset: 0x0
	private const uint MASK10BITS = 1023; //Field offset: 0x0
	private static Byte[] _debruijnTable32; //Field offset: 0x0
	private static Byte[] _debruijnTable64; //Field offset: 0x8
	private static readonly Int32[] DeBruijnLookupLong; //Field offset: 0x10

	private static Maths() { }

	public static int BitScanReverse(int v) { }

	public static int BitScanReverse(ulong v) { }

	public static int BitScanReverse(long v) { }

	public static int BitScanReverse(uint v) { }

	public static int BitsRequiredForNumber(int n) { }

	public static int BitsRequiredForNumber(uint n) { }

	public static int BytesRequiredForBits(int b) { }

	public static short BytesRequiredForBits(short b) { }

	public static int CeilToInt(double value) { }

	public static float Clamp(float v, float min, float max) { }

	public static double Clamp(double v, double min, double max) { }

	public static uint Clamp(uint v, uint min, uint max) { }

	public static int Clamp(int v, int min, int max) { }

	public static float Clamp01(float v) { }

	public static double Clamp01(double v) { }

	public static byte ClampToByte(int v) { }

	public static double CosineInterpolate(double a, double b, double t) { }

	public static int CountSetBits(ulong x) { }

	public static int CountUsedBitsMinOne(uint value) { }

	public static int FloorToInt(double value) { }

	public static int IntsRequiredForBits(int b) { }

	public static double Lerp(double a, double b, double t) { }

	public static float Lerp(float a, float b, float t) { }

	public static double MicrosecondsToSeconds(long microseconds) { }

	public static long MillisecondsToMicroseconds(long milliseconds) { }

	public static double MillisecondsToSeconds(double seconds) { }

	public static uint Min(uint v, uint max) { }

	public static uint NextPowerOfTwo(uint v) { }

	public static string PrintBits(Byte* data, int count) { }

	public static uint QuaternionCompress(Quaternion rot) { }

	public static Quaternion QuaternionDecompress(uint buffer) { }

	public static long SecondsToMicroseconds(double seconds) { }

	public static long SecondsToMilliseconds(double seconds) { }

	public static int SizeOfBits() { }

	public static long ZigZagDecode(long i) { }

	public static int ZigZagDecode(int i) { }

	public static long ZigZagEncode(long i) { }

	public static int ZigZagEncode(int i) { }

}

