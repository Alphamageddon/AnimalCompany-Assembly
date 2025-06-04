namespace UnityEngine.Rendering.Universal;

internal class ShadowUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int32> <>9__9_0; //Field offset: 0x8
		public static Func<ContourVertex, Vector3> <>9__9_1; //Field offset: 0x10
		public static Func<ContourVertex, Color> <>9__9_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <GenerateShadowMesh>b__9_0(int i) { }

		internal Vector3 <GenerateShadowMesh>b__9_1(ContourVertex v) { }

		internal Color <GenerateShadowMesh>b__9_2(ContourVertex v) { }

	}

	public struct Edge : IComparable<Edge>
	{
		public int vertexIndex0; //Field offset: 0x0
		public int vertexIndex1; //Field offset: 0x4
		public Vector4 tangent; //Field offset: 0x8
		private bool compareReversed; //Field offset: 0x18

		public void AssignVertexIndices(int vi0, int vi1) { }

		public int Compare(Edge a, Edge b) { }

		public override int CompareTo(Edge edgeToCompare) { }

	}


	public ShadowUtility() { }

	internal static Bounds CalculateLocalBounds(Vector3[] inVertices) { }

	private static Edge CreateEdge(int triangleIndexA, int triangleIndexB, List<Vector3> vertices, List<Int32> triangles) { }

	private static void CreateShadowTriangles(List<Vector3> vertices, List<Color> colors, List<Int32> triangles, List<Vector4> tangents, List<Edge> edges) { }

	public static Bounds GenerateShadowMesh(Mesh mesh, Vector3[] shapePath) { }

	private static void InitializeTangents(int tangentsToAdd, List<Vector4> tangents) { }

	private static object InterpCustomVertexData(Vec3 position, Object[] data, Single[] weights) { }

	private static bool IsOutsideEdge(int edgeIndex, List<Edge> edgesToProcess) { }

	private static void PopulateEdgeArray(List<Vector3> vertices, List<Int32> triangles, List<Edge> edges) { }

	private static void SortEdges(List<Edge> edgesToProcess) { }

}

