namespace Fusion;

[NetworkStructWeaved(1)]
public struct Ptr : IEquatable<Ptr>, INetworkStruct
{
	internal sealed class EqualityComparer : IEqualityComparer<Ptr>
	{

		public EqualityComparer() { }

		public override bool Equals(Ptr x, Ptr y) { }

		public override int GetHashCode(Ptr obj) { }

	}

	public const int SIZE = 4; //Field offset: 0x0
	public int Address; //Field offset: 0x0

	public static Ptr Null
	{
		 get { } //Length: 8
	}

	public override bool Equals(Ptr other) { }

	public virtual bool Equals(object obj) { }

	public static Ptr get_Null() { }

	public virtual int GetHashCode() { }

	public static Ptr op_Addition(Ptr p, int v) { }

	public static bool op_Equality(Ptr a, Ptr b) { }

	public static bool op_Implicit(Ptr a) { }

	public static bool op_Inequality(Ptr a, Ptr b) { }

	public static Ptr op_Subtraction(Ptr p, int v) { }

	public virtual string ToString() { }

}

