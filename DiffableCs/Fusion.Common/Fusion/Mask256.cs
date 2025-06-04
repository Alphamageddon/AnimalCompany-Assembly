namespace Fusion;

[DefaultMember("Item")]
public struct Mask256 : IEquatable<Mask256>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <values>e__FixedBuffer
	{
		public long FixedElementField; //Field offset: 0x0

	}

	[FixedBuffer(typeof(long, 4)]
	[SerializeField]
	private <values>e__FixedBuffer values; //Field offset: 0x0

	public long Item
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Mask256(long a, long b = 0, long c = 0, long d = 0) { }

	public void Clear() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(Mask256 other) { }

	public long get_Item(int i) { }

	public bool GetBit(int bitIndex) { }

	public virtual int GetHashCode() { }

	public bool IsNothing() { }

	public static Mask256 op_BitwiseAnd(Mask256 a, Mask256 b) { }

	public static Mask256 op_BitwiseOr(Mask256 a, Mask256 b) { }

	public static long op_Implicit(Mask256 mask) { }

	public static Mask256 op_Implicit(long value) { }

	public static Mask256 op_OnesComplement(Mask256 a) { }

	public void set_Item(int i, long value) { }

	public void SetBit(int bitIndex, bool set) { }

	public virtual string ToString() { }

}

