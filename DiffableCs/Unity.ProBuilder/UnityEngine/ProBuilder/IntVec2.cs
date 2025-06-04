namespace UnityEngine.ProBuilder;

internal struct IntVec2 : IEquatable<IntVec2>
{
	public Vector2 value; //Field offset: 0x0

	public float x
	{
		 get { } //Length: 8
	}

	public float y
	{
		 get { } //Length: 8
	}

	public IntVec2(Vector2 vector) { }

	public override bool Equals(IntVec2 p) { }

	public bool Equals(Vector2 p) { }

	public virtual bool Equals(object b) { }

	public float get_x() { }

	public float get_y() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(IntVec2 a, IntVec2 b) { }

	public static Vector2 op_Implicit(IntVec2 p) { }

	public static IntVec2 op_Implicit(Vector2 p) { }

	public static bool op_Inequality(IntVec2 a, IntVec2 b) { }

	private static int round(float v) { }

	public virtual string ToString() { }

}

