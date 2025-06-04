namespace Fusion;

[DefaultMember("Item")]
[NetworkStructWeaved(6)]
public struct BitSet192 : INetworkStruct, IEquatable<BitSet192>, IEnumerable<Int32>, IEnumerable
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <Bits>e__FixedBuffer
	{
		public ulong FixedElementField; //Field offset: 0x0

	}

	internal struct Enumerator : IEnumerator<Int32>, IEnumerator, IDisposable
	{
		private UInt64* _bits; //Field offset: 0x0
		private int _bit; //Field offset: 0x8

		public override int Current
		{
			 get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 92
		}

		public Enumerator(UInt64* bits) { }

		public override void Dispose() { }

		public override int get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal struct Iterator
	{
		private int _bit; //Field offset: 0x0
		public BitSet192 _set; //Field offset: 0x8

		public Iterator(BitSet192 set) { }

		public bool Next(out int index) { }

	}

	public const int SIZE = 24; //Field offset: 0x0
	public const int CAPACITY = 192; //Field offset: 0x0
	[FixedBuffer(typeof(ulong, 3)]
	public <Bits>e__FixedBuffer Bits; //Field offset: 0x0

	public bool Item
	{
		 get { } //Length: 32
		 set { } //Length: 52
	}

	public int Length
	{
		 get { } //Length: 8
	}

	public void And(BitSet192 other) { }

	public void AndNot(BitSet192 other) { }

	public bool Any() { }

	public void Clear(int bit) { }

	public void ClearAll() { }

	public bool Empty() { }

	public override bool Equals(BitSet192 other) { }

	public virtual bool Equals(object obj) { }

	public static BitSet192 FromArray(UInt64[] values) { }

	public bool get_Item(int index) { }

	public int get_Length() { }

	public Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public Iterator GetIterator() { }

	public int GetSetCount() { }

	public bool IsSet(int bit) { }

	public void Not() { }

	public static bool op_Equality(BitSet192 a, BitSet192 b) { }

	public static bool op_Inequality(BitSet192 a, BitSet192 b) { }

	public void Or(BitSet192 other) { }

	public void Set(int bit) { }

	public void set_Item(int index, bool value) { }

	private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Xor(BitSet192 other) { }

}

