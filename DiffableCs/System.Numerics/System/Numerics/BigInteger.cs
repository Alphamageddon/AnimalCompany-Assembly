namespace System.Numerics;

[IsReadOnly]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
{
	private enum GetBytesMode
	{
		AllocateArray = 0,
		Count = 1,
		Span = 2,
	}

	private static readonly BigInteger s_bnMinInt; //Field offset: 0x0
	private static readonly BigInteger s_bnOneInt; //Field offset: 0x10
	private static readonly BigInteger s_bnZeroInt; //Field offset: 0x20
	private static readonly BigInteger s_bnMinusOneInt; //Field offset: 0x30
	private static readonly Byte[] s_success; //Field offset: 0x40
	internal readonly int _sign; //Field offset: 0x0
	internal readonly UInt32[] _bits; //Field offset: 0x8

	public bool IsEven
	{
		 get { } //Length: 48
	}

	public static BigInteger MinusOne
	{
		 get { } //Length: 88
	}

	public int Sign
	{
		 get { } //Length: 20
	}

	private static BigInteger() { }

	internal BigInteger(UInt32[] value, bool negative) { }

	internal BigInteger(int n, UInt32[] rgu) { }

	public BigInteger(int value) { }

	[CLSCompliant(False)]
	public BigInteger(Byte[] value) { }

	public BigInteger(long value) { }

	public BigInteger(ReadOnlySpan<Byte> value, bool isUnsigned = false, bool isBigEndian = false) { }

	private static BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	public int CompareTo(long other) { }

	public override int CompareTo(BigInteger other) { }

	public override int CompareTo(object obj) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(BigInteger other) { }

	public bool get_IsEven() { }

	public static BigInteger get_MinusOne() { }

	public int get_Sign() { }

	internal static int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	public virtual int GetHashCode() { }

	private static bool GetPartsForBitManipulation(ref BigInteger x, out UInt32[] xd, out int xl) { }

	public static BigInteger ModPow(BigInteger value, BigInteger exponent, BigInteger modulus) { }

	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	public static int op_Explicit(BigInteger value) { }

	public static bool op_GreaterThanOrEqual(BigInteger left, BigInteger right) { }

	public static BigInteger op_Implicit(byte value) { }

	public static BigInteger op_Implicit(int value) { }

	public static BigInteger op_Implicit(long value) { }

	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	public static bool op_LessThan(BigInteger left, long right) { }

	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	private static BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	public Byte[] ToByteArray() { }

	public Byte[] ToByteArray(bool isUnsigned = false, bool isBigEndian = false) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider provider) { }

	private Byte[] TryGetBytes(GetBytesMode mode, Span<Byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	public bool TryWriteBytes(Span<Byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false) { }

	internal bool TryWriteOrCountBytes(Span<Byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false) { }

}

