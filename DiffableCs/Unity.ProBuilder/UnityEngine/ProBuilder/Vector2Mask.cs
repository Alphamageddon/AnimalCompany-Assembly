namespace UnityEngine.ProBuilder;

internal struct Vector2Mask
{
	private const byte X = 1; //Field offset: 0x0
	private const byte Y = 2; //Field offset: 0x0
	public static readonly Vector2Mask XY; //Field offset: 0x0
	private byte m_Mask; //Field offset: 0x0

	public float x
	{
		 get { } //Length: 24
	}

	public float y
	{
		 get { } //Length: 24
	}

	private static Vector2Mask() { }

	public Vector2Mask(Vector3 v, float epsilon = 1E-45) { }

	public Vector2Mask(byte mask) { }

	public float get_x() { }

	public float get_y() { }

	public static Vector2Mask op_BitwiseAnd(Vector2Mask left, Vector2Mask right) { }

	public static Vector2Mask op_BitwiseOr(Vector2Mask left, Vector2Mask right) { }

	public static Vector2Mask op_ExclusiveOr(Vector2Mask left, Vector2Mask right) { }

	public static Vector2 op_Implicit(Vector2Mask mask) { }

	public static Vector2Mask op_Implicit(Vector2 v) { }

	public static Vector2 op_Multiply(Vector2Mask mask, float value) { }

}

