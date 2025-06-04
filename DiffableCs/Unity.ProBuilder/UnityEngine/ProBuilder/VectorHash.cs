namespace UnityEngine.ProBuilder;

internal static class VectorHash
{
	public const float FltCompareResolution = 1000; //Field offset: 0x0

	public static int GetHashCode(Vector2 v) { }

	public static int GetHashCode(Vector3 v) { }

	public static int GetHashCode(Vector4 v) { }

	private static int HashFloat(float f) { }

}

