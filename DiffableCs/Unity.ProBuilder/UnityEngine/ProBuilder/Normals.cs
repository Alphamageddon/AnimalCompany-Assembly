namespace UnityEngine.ProBuilder;

public static class Normals
{
	private static Vector3[] s_SmoothAvg; //Field offset: 0x0
	private static Single[] s_SmoothAvgCount; //Field offset: 0x8
	private static Int32[] s_CachedIntArray; //Field offset: 0x10

	private static Normals() { }

	private static void CalculateHardNormals(ProBuilderMesh mesh) { }

	public static void CalculateNormals(ProBuilderMesh mesh) { }

	public static void CalculateTangents(ProBuilderMesh mesh) { }

	private static void ClearIntArray(int count) { }

}

