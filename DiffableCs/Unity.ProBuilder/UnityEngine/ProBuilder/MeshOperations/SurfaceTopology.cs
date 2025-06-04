namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class SurfaceTopology
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FaceRebuildData, Face> <>9__0_0; //Field offset: 0x8
		public static Func<Vertex, Vector3> <>9__3_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Vector3 <GetWindingOrder>b__3_0(Vertex x) { }

		internal Face <ToTriangles>b__0_0(FaceRebuildData x) { }

	}


	private static List<FaceRebuildData> BreakFaceIntoTris(Face face, List<Vertex> vertices, Dictionary<Int32, Int32> lookup) { }

	[Extension]
	public static ActionResult ConformNormals(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	internal static ActionResult ConformOppositeNormal(WingedEdge source) { }

	[Extension]
	public static bool FlipEdge(ProBuilderMesh mesh, Face face) { }

	private static Edge GetCommonEdgeInWindingOrder(WingedEdge wing) { }

	private static void GetWindingFlags(WingedEdge edge, bool flag, Dictionary<Face, Boolean> flags) { }

	[Extension]
	public static WindingOrder GetWindingOrder(ProBuilderMesh mesh, Face face) { }

	private static WindingOrder GetWindingOrder(IList<Vertex> vertices, IList<Int32> indexes) { }

	public static WindingOrder GetWindingOrder(IList<Vector2> points) { }

	internal static void MatchNormal(Face source, Face target, Dictionary<Int32, Int32> lookup) { }

	[Extension]
	public static Face[] ToTriangles(ProBuilderMesh mesh, IList<Face> faces) { }

}

