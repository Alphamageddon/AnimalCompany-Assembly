namespace UnityEngine.Animations.Rigging;

public static class QuaternionExt
{
	private const float k_FloatMin = 1E-10; //Field offset: 0x0
	public static readonly Quaternion zero; //Field offset: 0x0

	private static QuaternionExt() { }

	public static Quaternion Add(Quaternion rhs, Quaternion lhs) { }

	public static Quaternion FromToRotation(Vector3 from, Vector3 to) { }

	public static Quaternion NormalizeSafe(Quaternion q) { }

	public static Quaternion Scale(Quaternion q, float scale) { }

}

