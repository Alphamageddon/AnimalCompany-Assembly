namespace Photon.SocketServer.Numeric;

internal class BigInteger
{
	private const int maxLength = 70; //Field offset: 0x0
	public static readonly Int32[] primesBelow2000; //Field offset: 0x0
	private UInt32[] data; //Field offset: 0x10
	public int dataLength; //Field offset: 0x18

	private static BigInteger() { }

	public BigInteger(UInt32[] inData) { }

	public BigInteger(Byte[] inData, int inLen) { }

	public BigInteger(Byte[] inData) { }

	public BigInteger() { }

	public BigInteger(BigInteger bi) { }

	public BigInteger(ulong value) { }

	public BigInteger(long value) { }

	public BigInteger(string value, int radix) { }

	public BigInteger abs() { }

	private BigInteger BarrettReduction(BigInteger x, BigInteger n, BigInteger constant) { }

	public int bitCount() { }

	public virtual bool Equals(object o) { }

	public bool FermatLittleTest(int confidence) { }

	public BigInteger gcd(BigInteger bi) { }

	public BigInteger genCoPrime(int bits, Random rand) { }

	public static BigInteger GenerateRandom(int bits) { }

	public static BigInteger genPseudoPrime(int bits, int confidence, Random rand) { }

	public void genRandomBits(int bits, Random rand) { }

	public Byte[] GetBytes() { }

	public virtual int GetHashCode() { }

	public int IntValue() { }

	public bool isProbablePrime() { }

	public bool isProbablePrime(int confidence) { }

	public static int Jacobi(BigInteger a, BigInteger b) { }

	public long LongValue() { }

	public static BigInteger[] LucasSequence(BigInteger P, BigInteger Q, BigInteger k, BigInteger n) { }

	private static BigInteger[] LucasSequenceHelper(BigInteger P, BigInteger Q, BigInteger k, BigInteger n, BigInteger constant, int s) { }

	public bool LucasStrongTest() { }

	private bool LucasStrongTestHelper(BigInteger thisVal) { }

	public static void Main(String[] args) { }

	public BigInteger max(BigInteger bi) { }

	public BigInteger min(BigInteger bi) { }

	public BigInteger modInverse(BigInteger modulus) { }

	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	public static void MulDivTest(int rounds) { }

	private static void multiByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder) { }

	public static BigInteger op_Addition(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_BitwiseAnd(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_BitwiseOr(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_Decrement(BigInteger bi1) { }

	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_ExclusiveOr(BigInteger bi1, BigInteger bi2) { }

	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_Implicit(long value) { }

	public static BigInteger op_Implicit(ulong value) { }

	public static BigInteger op_Implicit(int value) { }

	public static BigInteger op_Implicit(uint value) { }

	public static BigInteger op_Increment(BigInteger bi1) { }

	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_OnesComplement(BigInteger bi1) { }

	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_UnaryNegation(BigInteger bi1) { }

	public bool RabinMillerTest(int confidence) { }

	public static void RSATest(int rounds) { }

	public static void RSATest2(int rounds) { }

	public void setBit(uint bitNum) { }

	private static int shiftLeft(UInt32[] buffer, int shiftVal) { }

	private static int shiftRight(UInt32[] buffer, int shiftVal) { }

	private static void singleByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder) { }

	public bool SolovayStrassenTest(int confidence) { }

	public BigInteger sqrt() { }

	public static void SqrtTest(int rounds) { }

	public string ToHexString() { }

	public virtual string ToString() { }

	public string ToString(int radix) { }

	public void unsetBit(uint bitNum) { }

}

