namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class ElementSelection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Face, IEnumerable`1<Edge>> <>9__5_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<Edge, List`1<Edge>>, Boolean> <>9__5_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<Edge, List`1<Edge>>, Edge> <>9__5_2; //Field offset: 0x18
		public static Func<KeyValuePair`2<Edge, List`1<Face>>, Boolean> <>9__7_0; //Field offset: 0x20
		public static Func<KeyValuePair`2<Edge, List`1<Face>>, Face> <>9__7_1; //Field offset: 0x28
		public static Func<EdgeLookup, Edge> <>9__10_0; //Field offset: 0x30
		public static Func<EdgeLookup, Edge> <>9__11_0; //Field offset: 0x38
		public static Func<EdgeLookup, Edge> <>9__12_0; //Field offset: 0x40
		public static Func<EdgeLookup, Edge> <>9__13_0; //Field offset: 0x48
		public static Func<WingedEdge, Edge> <>9__14_0; //Field offset: 0x50
		public static Func<WingedEdge, Edge> <>9__15_0; //Field offset: 0x58
		public static Func<WingedEdge, Edge> <>9__15_1; //Field offset: 0x60
		public static Func<WingedEdge, Edge> <>9__26_0; //Field offset: 0x68
		public static Comparison<SimpleTuple`2<Int32, Int32>> <>9__27_0; //Field offset: 0x70

		private static <>c() { }

		public <>c() { }

		internal Edge <FindHoles>b__26_0(WingedEdge x) { }

		internal int <FindHoles>b__27_0(SimpleTuple<Int32, Int32> x, SimpleTuple<Int32, Int32> y) { }

		internal Edge <GetEdgeLoop>b__12_0(EdgeLookup x) { }

		internal Edge <GetEdgeLoopInternal>b__14_0(WingedEdge x) { }

		internal Edge <GetEdgeLoopInternalIterative>b__15_0(WingedEdge x) { }

		internal Edge <GetEdgeLoopInternalIterative>b__15_1(WingedEdge x) { }

		internal Edge <GetEdgeLoopIterative>b__13_0(EdgeLookup x) { }

		internal Edge <GetEdgeRing>b__10_0(EdgeLookup x) { }

		internal Edge <GetEdgeRingIterative>b__11_0(EdgeLookup x) { }

		internal IEnumerable<Edge> <GetPerimeterEdges>b__5_0(Face x) { }

		internal bool <GetPerimeterEdges>b__5_1(KeyValuePair<Edge, List`1<Edge>> x) { }

		internal Edge <GetPerimeterEdges>b__5_2(KeyValuePair<Edge, List`1<Edge>> x) { }

		internal bool <GetPerimeterFaces>b__7_0(KeyValuePair<Edge, List`1<Face>> x) { }

		internal Face <GetPerimeterFaces>b__7_1(KeyValuePair<Edge, List`1<Face>> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public Face face; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <GetFaceLoop>b__0(WingedEdge x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public HashSet<Int32> common; //Field offset: 0x10
		public Func<WingedEdge, Boolean> <>9__1; //Field offset: 0x18
		public Func<WingedEdge, Boolean> <>9__2; //Field offset: 0x20

		public <>c__DisplayClass27_0() { }

		internal bool <FindHoles>b__1(WingedEdge w) { }

		internal bool <FindHoles>b__2(WingedEdge w) { }

	}

	private const int k_MaxHoleIterations = 2048; //Field offset: 0x0
	private static readonly Vector3 Vector3_Zero; //Field offset: 0x0

	private static ElementSelection() { }

	private static WingedEdge EdgeRingNext(WingedEdge edge) { }

	internal static List<List`1<WingedEdge>> FindHoles(List<WingedEdge> wings, HashSet<Int32> common) { }

	internal static List<List`1<Edge>> FindHoles(ProBuilderMesh mesh, IEnumerable<Int32> indexes) { }

	private static WingedEdge FindNextEdgeInHole(WingedEdge wing, int common) { }

	internal static void Flood(ProBuilderMesh pb, WingedEdge wing, Vector3 wingNrm, float maxAngle, HashSet<Face> selection) { }

	internal static void Flood(WingedEdge wing, HashSet<Face> selection) { }

	public static HashSet<Face> FloodSelection(ProBuilderMesh mesh, IList<Face> faces, float maxAngleDiff) { }

	internal static Edge[] GetConnectedEdges(ProBuilderMesh mesh, Int32[] indexes) { }

	internal static bool GetEdgeLoop(ProBuilderMesh mesh, IEnumerable<Edge> edges, out Edge[] loop) { }

	private static bool GetEdgeLoopInternal(WingedEdge start, int startIndex, HashSet<EdgeLookup> used) { }

	private static void GetEdgeLoopInternalIterative(WingedEdge start, Edge edge, HashSet<EdgeLookup> used) { }

	internal static bool GetEdgeLoopIterative(ProBuilderMesh mesh, IEnumerable<Edge> edges, out Edge[] loop) { }

	internal static IEnumerable<Edge> GetEdgeRing(ProBuilderMesh pb, IEnumerable<Edge> edges) { }

	internal static IEnumerable<Edge> GetEdgeRingIterative(ProBuilderMesh pb, IEnumerable<Edge> edges) { }

	private static HashSet<Face> GetFaceLoop(List<WingedEdge> wings, Face face, bool ring) { }

	public static HashSet<Face> GetFaceLoop(ProBuilderMesh mesh, Face[] faces, bool ring = false) { }

	public static HashSet<Face> GetFaceRingAndLoop(ProBuilderMesh mesh, Face[] faces) { }

	internal static List<SimpleTuple`2<Face, Edge>> GetNeighborFaces(ProBuilderMesh mesh, Edge edge) { }

	internal static List<Face> GetNeighborFaces(ProBuilderMesh mesh, Int32[] indexes) { }

	public static void GetNeighborFaces(ProBuilderMesh mesh, Edge edge, List<Face> neighborFaces) { }

	[Extension]
	public static IEnumerable<Edge> GetPerimeterEdges(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	internal static Int32[] GetPerimeterEdges(ProBuilderMesh mesh, IList<Edge> edges) { }

	internal static IEnumerable<Face> GetPerimeterFaces(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	internal static Int32[] GetPerimeterVertices(ProBuilderMesh mesh, Int32[] indexes, Edge[] universal_edges_all) { }

	internal static List<WingedEdge> GetSpokes(WingedEdge wing, int sharedIndex, bool allowHoles = false) { }

	public static HashSet<Face> GrowSelection(ProBuilderMesh mesh, IEnumerable<Face> faces, float maxAngleDiff = -1) { }

	private static WingedEdge NextSpoke(WingedEdge wing, int pivot, bool opp) { }

}

