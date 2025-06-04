namespace UnityEngine.Rendering.Universal;

internal static class LightUtility
{
	public struct LightMeshVertex
	{
		public static readonly VertexAttributeDescriptor[] VertexLayout; //Field offset: 0x0
		public Vector3 position; //Field offset: 0x0
		public Color color; //Field offset: 0xC
		public Vector2 uv; //Field offset: 0x1C

		private static LightMeshVertex() { }

	}

	private enum PivotType
	{
		PivotBase = 0,
		PivotCurve = 1,
		PivotIntersect = 2,
		PivotSkip = 3,
		PivotClip = 4,
	}


	public static bool CheckForChange(LightType a, ref LightType b) { }

	public static bool CheckForChange(int a, ref int b) { }

	public static bool CheckForChange(float a, ref float b) { }

	public static bool CheckForChange(bool a, ref bool b) { }

	private static List<IntPoint> DegeneratePivots(List<IntPoint> path, List<IntPoint> inPath, ref int interiorStart) { }

	private static List<IntPoint> FixPivots(List<IntPoint> outPath, List<IntPoint> inPath, ref int interiorStart) { }

	public static Bounds GenerateParametricMesh(Light2D light, float radius, float falloffDistance, float angle, int sides) { }

	public static Bounds GenerateShapeMesh(Light2D light, Vector3[] shapePath, float falloffDistance) { }

	public static Bounds GenerateSpriteMesh(Light2D light, Sprite sprite) { }

	internal static List<Vector2> GetOutlinePath(Vector3[] shapePath, float offsetDistance) { }

	public static int GetShapePathHash(Vector3[] path) { }

	private static List<IntPoint> SortPivots(List<IntPoint> outPath, List<IntPoint> inPath) { }

	private static bool TestPivot(List<IntPoint> path, int activePoint, long lastPoint) { }

	private static void TransferToMesh(NativeArray<LightMeshVertex> vertices, int vertexCount, NativeArray<UInt16> indices, int indexCount, Light2D light) { }

}

