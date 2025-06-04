namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class ConnectElements
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Face, IEnumerable`1<Edge>> <>9__0_0; //Field offset: 0x8
		public static Func<Face, Int32> <>9__2_1; //Field offset: 0x10
		public static Func<ConnectFaceRebuildData, FaceRebuildData> <>9__2_2; //Field offset: 0x18
		public static Func<Face, Int32> <>9__3_0; //Field offset: 0x20
		public static Func<ConnectFaceRebuildData, FaceRebuildData> <>9__3_1; //Field offset: 0x28
		public static Func<ConnectFaceRebuildData, IEnumerable`1<Edge>> <>9__3_2; //Field offset: 0x30
		public static Func<EdgeLookup, Edge> <>9__3_4; //Field offset: 0x38
		public static Func<Int32, List`1<Vertex>> <>9__5_0; //Field offset: 0x40
		public static Func<Int32, List`1<Int32>> <>9__5_1; //Field offset: 0x48
		public static Func<WingedEdge, Edge> <>9__5_2; //Field offset: 0x50
		public static Func<WingedEdge, Edge> <>9__6_0; //Field offset: 0x58
		public static Func<Int32, List`1<Vertex>> <>9__8_0; //Field offset: 0x60
		public static Func<Int32, List`1<Int32>> <>9__8_1; //Field offset: 0x68
		public static Func<Int32, List`1<Int32>> <>9__8_2; //Field offset: 0x70

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Edge> <Connect>b__0_0(Face x) { }

		internal int <Connect>b__2_1(Face x) { }

		internal FaceRebuildData <Connect>b__2_2(ConnectFaceRebuildData x) { }

		internal int <Connect>b__3_0(Face x) { }

		internal FaceRebuildData <Connect>b__3_1(ConnectFaceRebuildData x) { }

		internal IEnumerable<Edge> <Connect>b__3_2(ConnectFaceRebuildData x) { }

		internal Edge <Connect>b__3_4(EdgeLookup x) { }

		internal List<Vertex> <ConnectEdgesInFace>b__5_0(int x) { }

		internal List<Int32> <ConnectEdgesInFace>b__5_1(int x) { }

		internal Edge <ConnectEdgesInFace>b__5_2(WingedEdge x) { }

		internal List<Vertex> <ConnectIndexesPerFace>b__8_0(int x) { }

		internal List<Int32> <ConnectIndexesPerFace>b__8_1(int x) { }

		internal List<Int32> <ConnectIndexesPerFace>b__8_2(int x) { }

		internal Edge <InsertVertices>b__6_0(WingedEdge x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Dictionary<Int32, Int32> lookup; //Field offset: 0x10
		public ProBuilderMesh mesh; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal int <Connect>b__0(int x) { }

		internal int <Connect>b__3(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public HashSet<Int32> appended; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <Connect>b__3(Edge x) { }

	}


	[Extension]
	public static Face[] Connect(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	[Extension]
	public static SimpleTuple<Face[], Edge[]> Connect(ProBuilderMesh mesh, IEnumerable<Edge> edges) { }

	[Extension]
	public static Int32[] Connect(ProBuilderMesh mesh, IList<Int32> indexes) { }

	[Extension]
	internal static ActionResult Connect(ProBuilderMesh mesh, IEnumerable<Edge> edges, out Face[] addedFaces, out Edge[] connections, bool returnFaces = false, bool returnEdges = false, HashSet<Face> faceMask = null) { }

	private static List<ConnectFaceRebuildData> ConnectEdgesInFace(Face face, WingedEdge a, WingedEdge b, List<Vertex> vertices) { }

	private static List<ConnectFaceRebuildData> ConnectEdgesInFace(Face face, List<WingedEdge> edges, List<Vertex> vertices) { }

	private static List<ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, int a, int b, List<Vertex> vertices, Dictionary<Int32, Int32> lookup) { }

	private static List<ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, List<Int32> indexes, List<Vertex> vertices, Dictionary<Int32, Int32> lookup, int sharedIndexOffset) { }

	private static bool InsertVertices(Face face, List<WingedEdge> edges, List<Vertex> vertices, out ConnectFaceRebuildData data) { }

}

