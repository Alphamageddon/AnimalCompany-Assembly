namespace UnityEngine.ProBuilder;

[DefaultMember("Item")]
internal struct Vector3Mask : IEquatable<Vector3Mask>
{
	private const byte X = 1; //Field offset: 0x0
	private const byte Y = 2; //Field offset: 0x0
	private const byte Z = 4; //Field offset: 0x0
	public static readonly Vector3Mask XYZ; //Field offset: 0x0
	private byte m_Mask; //Field offset: 0x0

	public int active
	{
		 get { } //Length: 28
	}

	public float Item
	{
		 get { } //Length: 88
		 set { } //Length: 108
	}

	public float x
	{
		 get { } //Length: 24
	}

	public float y
	{
		 get { } //Length: 24
	}

	public float z
	{
		 get { } //Length: 24
	}

	private static Vector3Mask() { }

	public Vector3Mask(Vector3 v, float epsilon = 1E-45) { }

	public Vector3Mask(byte mask) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(Vector3Mask other) { }

	public int get_active() { }

	public float get_Item(int i) { }

	public float get_x() { }

	public float get_y() { }

	public float get_z() { }

	public virtual int GetHashCode() { }

	public static Vector3Mask op_BitwiseAnd(Vector3Mask left, Vector3Mask right) { }

	public static Vector3Mask op_BitwiseOr(Vector3Mask left, Vector3Mask right) { }

	public static bool op_Equality(Vector3Mask left, Vector3Mask right) { }

	public static Vector3Mask op_ExclusiveOr(Vector3Mask left, Vector3Mask right) { }

	public static Vector3Mask op_Explicit(Vector3 v) { }

	public static Vector3 op_Implicit(Vector3Mask mask) { }

	public static bool op_Inequality(Vector3Mask left, Vector3Mask right) { }

	public static Vector3 op_Multiply(Vector3Mask mask, float value) { }

	public static Vector3 op_Multiply(Vector3Mask mask, Vector3 value) { }

	public static Vector3 op_Multiply(Quaternion rotation, Vector3Mask mask) { }

	public void set_Item(int i, float value) { }

	public virtual string ToString() { }

}

