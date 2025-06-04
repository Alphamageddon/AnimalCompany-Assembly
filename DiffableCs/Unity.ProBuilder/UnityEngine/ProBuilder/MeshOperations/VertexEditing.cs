namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class VertexEditing
{

	private static Edge AlignEdgeWithDirection(EdgeLookup edge, int commonIndex) { }

	internal static FaceRebuildData ExplodeVertex(IList<Vertex> vertices, IList<SimpleTuple`2<WingedEdge, Int32>> edgeAndCommonIndex, float distance, out Dictionary<Int32, List`1<Int32>>& appendedVertices) { }

	[Extension]
	public static int MergeVertices(ProBuilderMesh mesh, Int32[] indexes, bool collapseToFirst = false) { }

	[Extension]
	public static void SplitVertices(ProBuilderMesh mesh, Edge edge) { }

	[Extension]
	public static void SplitVertices(ProBuilderMesh mesh, IEnumerable<Int32> vertices) { }

	[Extension]
	public static Int32[] WeldVertices(ProBuilderMesh mesh, IEnumerable<Int32> indexes, float neighborRadius) { }

}

