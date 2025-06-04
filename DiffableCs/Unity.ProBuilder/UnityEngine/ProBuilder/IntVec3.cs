namespace UnityEngine.ProBuilder;

internal struct IntVec3 : IEquatable<IntVec3>
{
	public Vector3 value; //Field offset: 0x0

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

	public IntVec3(Vector3 vector) { }

	public override bool Equals(IntVec3 p) { }

	public bool Equals(Vector3 p) { }

	public virtual bool Equals(object b) { }

	public float get_x() { }

	public float get_y() { }

	public float get_z() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(IntVec3 a, IntVec3 b) { }

	public static Vector3 op_Implicit(IntVec3 p) { }

	public static IntVec3 op_Implicit(Vector3 p) { }

	public static bool op_Inequality(IntVec3 a, IntVec3 b) { }

	private static int round(float v) { }

	public virtual string ToString() { }

}

