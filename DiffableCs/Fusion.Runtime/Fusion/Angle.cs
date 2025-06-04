namespace Fusion;

[NetworkStructWeaved(1)]
public struct Angle : INetworkStruct, IEquatable<Angle>
{
	public const int SIZE = 4; //Field offset: 0x0
	private const int ACCURACY = 10000; //Field offset: 0x0
	private const int DECIMALS = 4; //Field offset: 0x0
	private const int _360 = 3600000; //Field offset: 0x0
	private int _value; //Field offset: 0x0

	public void Clamp(Angle min, Angle max) { }

	public static Angle Clamp(Angle value, Angle min, Angle max) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(Angle other) { }

	public virtual int GetHashCode() { }

	public static Angle Lerp(Angle a, Angle b, float t) { }

	public static Angle Max(Angle a, Angle b) { }

	public static Angle Min(Angle a, Angle b) { }

	public static Angle op_Addition(Angle a, Angle b) { }

	public static bool op_Equality(Angle a, Angle b) { }

	public static float op_Explicit(Angle value) { }

	public static double op_Explicit(Angle value) { }

	public static bool op_GreaterThan(Angle a, Angle b) { }

	public static bool op_GreaterThanOrEqual(Angle a, Angle b) { }

	public static Angle op_Implicit(double value) { }

	public static Angle op_Implicit(float value) { }

	public static Angle op_Implicit(int value) { }

	public static bool op_Inequality(Angle a, Angle b) { }

	public static bool op_LessThan(Angle a, Angle b) { }

	public static bool op_LessThanOrEqual(Angle a, Angle b) { }

	public static Angle op_Subtraction(Angle a, Angle b) { }

	public virtual string ToString() { }

}

