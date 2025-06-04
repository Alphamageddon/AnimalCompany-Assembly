namespace System.Numerics;

internal static class BigIntegerCalculator
{
	public struct BitsBuffer
	{
		private UInt32[] _bits; //Field offset: 0x0
		private int _length; //Field offset: 0x8

		public BitsBuffer(int size, uint value) { }

		public BitsBuffer(int size, UInt32[] value) { }

		private void Apply(ref BitsBuffer temp, int maxLength) { }

		public UInt32[] GetBits() { }

		public int GetSize() { }

		public void MultiplySelf(ref BitsBuffer value, ref BitsBuffer temp) { }

		public void Reduce(ref FastReducer reducer) { }

		public void Reduce(UInt32[] modulus) { }

		public void SquareSelf(ref BitsBuffer temp) { }

	}

	[IsReadOnly]
	public struct FastReducer
	{
		private readonly UInt32[] _modulus; //Field offset: 0x0
		private readonly UInt32[] _mu; //Field offset: 0x8
		private readonly UInt32[] _q1; //Field offset: 0x10
		private readonly UInt32[] _q2; //Field offset: 0x18
		private readonly int _muLength; //Field offset: 0x20

		public FastReducer(UInt32[] modulus) { }

		private static int DivMul(UInt32[] left, int leftLength, UInt32[] right, int rightLength, UInt32[] bits, int k) { }

		public int Reduce(UInt32[] value, int length) { }

		private static int SubMod(UInt32[] left, int leftLength, UInt32[] right, int rightLength, UInt32[] modulus, int k) { }

	}

	private static int ReducerThreshold; //Field offset: 0x0
	private static int SquareThreshold; //Field offset: 0x4
	private static int AllocationThreshold; //Field offset: 0x8
	private static int MultiplyThreshold; //Field offset: 0xC

	private static BigIntegerCalculator() { }

	private static int ActualLength(UInt32[] value, int length) { }

	private static int ActualLength(UInt32[] value) { }

	public static UInt32[] Add(UInt32[] left, uint right) { }

	public static UInt32[] Add(UInt32[] left, UInt32[] right) { }

	private static void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	private static uint AddDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	private static void AddSelf(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	public static int Compare(UInt32[] left, UInt32[] right) { }

	private static int Compare(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	private static UInt32[] CreateCopy(UInt32[] value) { }

	public static UInt32[] Divide(UInt32[] left, UInt32[] right) { }

	private static void Divide(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) { }

	private static int LeadingZeros(uint value) { }

	private static void Multiply(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	public static UInt32[] Pow(uint value, UInt32[] power, UInt32[] modulus) { }

	public static UInt32[] Pow(uint value, uint power, UInt32[] modulus) { }

	public static UInt32[] Pow(UInt32[] value, UInt32[] power, UInt32[] modulus) { }

	public static UInt32[] Pow(UInt32[] value, uint power, UInt32[] modulus) { }

	public static uint Pow(UInt32[] value, UInt32[] power, uint modulus) { }

	public static uint Pow(UInt32[] value, uint power, uint modulus) { }

	public static uint Pow(uint value, uint power, uint modulus) { }

	public static uint Pow(uint value, UInt32[] power, uint modulus) { }

	private static void PowCore(UInt32[] power, UInt32[] modulus, ref BitsBuffer value, ref BitsBuffer result, ref BitsBuffer temp) { }

	private static uint PowCore(UInt32[] power, uint modulus, ulong value, ulong result) { }

	private static uint PowCore(uint power, uint modulus, ulong value, ulong result) { }

	private static UInt32[] PowCore(UInt32[] power, UInt32[] modulus, ref BitsBuffer value) { }

	private static UInt32[] PowCore(uint power, UInt32[] modulus, ref BitsBuffer value) { }

	private static void PowCore(uint power, UInt32[] modulus, ref BitsBuffer value, ref BitsBuffer result, ref BitsBuffer temp) { }

	private static void PowCore(UInt32[] power, ref FastReducer reducer, ref BitsBuffer value, ref BitsBuffer result, ref BitsBuffer temp) { }

	private static void PowCore(uint power, ref FastReducer reducer, ref BitsBuffer value, ref BitsBuffer result, ref BitsBuffer temp) { }

	public static UInt32[] Remainder(UInt32[] left, UInt32[] right) { }

	public static uint Remainder(UInt32[] left, uint right) { }

	private static void Square(UInt32* value, int valueLength, UInt32* bits, int bitsLength) { }

	public static UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	public static UInt32[] Subtract(UInt32[] left, uint right) { }

	private static void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	private static void SubtractCore(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* core, int coreLength) { }

	private static uint SubtractDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength, ulong q) { }

	private static void SubtractSelf(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

}

