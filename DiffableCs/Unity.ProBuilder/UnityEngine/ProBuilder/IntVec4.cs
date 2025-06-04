namespace UnityEngine.ProBuilder;

internal struct IntVec4 : IEquatable<IntVec4>
{
	public Vector4 value; //Field offset: 0x0

	public float w
	{
		 get { } //Length: 8
	}

	public float x
	{
		 get { } //Length: 8
	}

	public float y
	{
		 get { } //Length: 8
	}

	public float z
	{
		 get { } //Length: 8
	}

	public IntVec4(Vector4 vector) { }

	public override bool Equals(IntVec4 p) { }

	public bool Equals(Vector4 p) { }

	public virtual bool Equals(object b) { }

	public float get_w() { }

	public float get_x() { }

	public float get_y() { }

	public float get_z() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(IntVec4 a, IntVec4 b) { }

	public static Vector4 op_Implicit(IntVec4 p) { }

	public static IntVec4 op_Implicit(Vector4 p) { }

	public static bool op_Inequality(IntVec4 a, IntVec4 b) { }

	private static int round(float v) { }

	public virtual string ToString() { }

}

