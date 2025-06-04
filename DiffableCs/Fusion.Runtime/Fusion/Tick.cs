namespace Fusion;

[NetworkStructWeaved(1)]
public struct Tick : IComparable<Tick>, IEquatable<Tick>
{
	internal sealed class EqualityComparer : IEqualityComparer<Tick>
	{

		public EqualityComparer() { }

		public override bool Equals(Tick x, Tick y) { }

		public override int GetHashCode(Tick obj) { }

	}

	internal sealed class RelationalComparer : IComparer<Tick>
	{

		public RelationalComparer() { }

		public override int Compare(Tick x, Tick y) { }

	}

	public const int SIZE = 4; //Field offset: 0x0
	public const int ALIGNMENT = 4; //Field offset: 0x0
	public int Raw; //Field offset: 0x0

	public override int CompareTo(Tick other) { }

	public override bool Equals(Tick other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public Tick Next(int increment) { }

	public static bool op_Equality(Tick a, Tick b) { }

	public static bool op_GreaterThan(Tick a, Tick b) { }

	public static bool op_GreaterThanOrEqual(Tick a, Tick b) { }

	public static Tick op_Implicit(int value) { }

	public static int op_Implicit(Tick value) { }

	public static bool op_Implicit(Tick value) { }

	public static bool op_Inequality(Tick a, Tick b) { }

	public static bool op_LessThan(Tick a, Tick b) { }

	public static bool op_LessThanOrEqual(Tick a, Tick b) { }

	public virtual string ToString() { }

}

