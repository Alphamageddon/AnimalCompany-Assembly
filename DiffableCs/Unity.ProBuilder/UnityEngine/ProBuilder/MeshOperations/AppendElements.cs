namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class AppendElements
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector3[], Int32> <>9__8_0; //Field offset: 0x8
		public static Func<Vertex, Vector3> <>9__10_0; //Field offset: 0x10
		public static Func<Vertex, Vector3> <>9__10_1; //Field offset: 0x18
		public static Func<FaceRebuildData, Face> <>9__18_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <CreateShapeFromPolygon>b__8_0(Vector3[] arr) { }

		internal Vector3 <FaceWithVerticesAndHole>b__10_0(Vertex v) { }

		internal Vector3 <FaceWithVerticesAndHole>b__10_1(Vertex v) { }

		internal Face <InsertVertexInFace>b__18_0(FaceRebuildData f) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public int delCount; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal Edge <AppendVerticesToEdge>b__0(EdgeLookup x) { }

	}


	[Extension]
	internal static Face AppendFace(ProBuilderMesh mesh, Vector3[] positions, Color[] colors, Vector2[] uv0s, Vector4[] uv2s, Vector4[] uv3s, Face face, Int32[] common) { }

	[Extension]
	public static Face[] AppendFaces(ProBuilderMesh mesh, Vector3[][] positions, Color[][] colors, Vector2[][] uvs, Face[] faces, Int32[][] shared) { }

	[Extension]
	public static List<Edge> AppendVerticesToEdge(ProBuilderMesh mesh, IList<Edge> edges, int count) { }

	[Extension]
	public static List<Edge> AppendVerticesToEdge(ProBuilderMesh mesh, Edge edge, int count) { }

	[Extension]
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points) { }

	[Extension]
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points, bool insertOnEdge) { }

	[Extension]
	public static Face Bridge(ProBuilderMesh mesh, Edge a, Edge b, bool allowNonManifoldGeometry = false) { }

	[Extension]
	internal static void ClearAndRefreshMesh(ProBuilderMesh mesh) { }

	[Extension]
	public static Face CreatePolygon(ProBuilderMesh mesh, IList<Int32> indexes, bool unordered) { }

	[Extension]
	public static Face CreatePolygonWithHole(ProBuilderMesh mesh, IList<Int32> indexes, IList<IList`1<Int32>> holes) { }

	[Extension]
	public static ActionResult CreateShapeFromPolygon(PolyShape poly) { }

	[Extension]
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, IList<Vector3> points, float extrude, bool flipNormals) { }

	[Extension]
	[Obsolete("Face.CreateShapeFromPolygon is deprecated as it no longer relies on camera look at.")]
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, IList<Vector3> points, float extrude, bool flipNormals, Vector3 cameraLookAt, IList<IList`1<Vector3>> holePoints = null) { }

	[Extension]
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, IList<Vector3> points, float extrude, bool flipNormals, IList<IList`1<Vector3>> holePoints) { }

	[Extension]
	public static void DuplicateAndFlip(ProBuilderMesh mesh, Face[] faces) { }

	internal static FaceRebuildData FaceWithVertices(List<Vertex> vertices, bool unordered = true) { }

	internal static FaceRebuildData FaceWithVerticesAndHole(List<Vertex> borderVertices, List<List`1<Vertex>> holes) { }

	[Extension]
	public static Face[] InsertVertexInFace(ProBuilderMesh mesh, Face face, Vector3 point) { }

	[Extension]
	public static Vertex InsertVertexInMesh(ProBuilderMesh mesh, Vector3 point, Vector3 normal) { }

	[Extension]
	public static Vertex InsertVertexOnEdge(ProBuilderMesh mesh, Edge originalEdge, Vector3 point) { }

	internal static List<FaceRebuildData> TentCapWithVertices(List<Vertex> path) { }

}

