namespace UnityEngine.ProBuilder;

[Extension]
internal static class EdgeUtility
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public ProBuilderMesh mesh; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal Edge <GetSharedVertexHandleEdges>b__0(Edge x) { }

	}


	[Extension]
	internal static Int32[] AllTriangles(Edge[] edges) { }

	[Extension]
	internal static bool Contains(Edge[] edges, Edge edge) { }

	[Extension]
	internal static bool Contains(Edge[] edges, int x, int y) { }

	[Extension]
	internal static Edge GetEdgeWithSharedVertexHandles(ProBuilderMesh mesh, Edge edge) { }

	[Extension]
	internal static Face GetFace(ProBuilderMesh mesh, Edge edge) { }

	[Extension]
	public static Edge GetSharedVertexHandleEdge(ProBuilderMesh mesh, Edge edge) { }

	[Extension]
	public static IEnumerable<Edge> GetSharedVertexHandleEdges(ProBuilderMesh mesh, IEnumerable<Edge> edges) { }

	[Extension]
	internal static int IndexOf(ProBuilderMesh mesh, IList<Edge> edges, Edge edge) { }

	public static bool ValidateEdge(ProBuilderMesh mesh, Edge edge, out SimpleTuple<Face, Edge>& validEdge) { }

}

