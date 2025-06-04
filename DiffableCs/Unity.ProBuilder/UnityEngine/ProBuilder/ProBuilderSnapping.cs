namespace UnityEngine.ProBuilder;

internal static class ProBuilderSnapping
{
	private const float k_MaxRaySnapDistance = ∞; //Field offset: 0x0

	internal static Vector3 GetSnappingMaskBasedOnNormalVector(Vector3 normal) { }

	internal static bool IsCardinalDirection(Vector3 direction) { }

	public static float Snap(float val, float snap) { }

	public static Vector3 Snap(Vector3 val, Vector3 snap) { }

	internal static Vector3 SnapValueOnRay(Ray ray, float distance, float snap, Vector3Mask mask) { }

	public static void SnapVertices(ProBuilderMesh mesh, IEnumerable<Int32> indexes, Vector3 snap) { }

}

