namespace Fusion;

[NetworkStructWeaved(1)]
public struct FloatCompressed : INetworkStruct, IEquatable<FloatCompressed>
{
	public int valueEncoded; //Field offset: 0x0

	public override bool Equals(FloatCompressed other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(FloatCompressed left, FloatCompressed right) { }

	public static FloatCompressed op_Implicit(float v) { }

	public static float op_Implicit(FloatCompressed q) { }

	public static bool op_Inequality(FloatCompressed left, FloatCompressed right) { }

}

