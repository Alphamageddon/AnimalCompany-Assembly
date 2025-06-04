namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class ExtrudeElements
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FaceRebuildData, Face> <>9__3_0; //Field offset: 0x8
		public static Func<Face, Int32> <>9__4_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Face <DetachFaces>b__3_0(FaceRebuildData x) { }

		internal int <ExtrudePerFace>b__4_0(Face x) { }

	}


	[Extension]
	public static List<Face> DetachFaces(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	[Extension]
	public static List<Face> DetachFaces(ProBuilderMesh mesh, IEnumerable<Face> faces, bool deleteSourceFaces) { }

	[Extension]
	public static Face[] Extrude(ProBuilderMesh mesh, IEnumerable<Face> faces, ExtrudeMethod method, float distance) { }

	[Extension]
	public static Edge[] Extrude(ProBuilderMesh mesh, IEnumerable<Edge> edges, float distance, bool extrudeAsGroup, bool enableManifoldExtrude) { }

	private static Face[] ExtrudeAsGroups(ProBuilderMesh mesh, IEnumerable<Face> faces, bool compensateAngleVertexDistance, float distance) { }

	private static Face[] ExtrudePerFace(ProBuilderMesh pb, IEnumerable<Face> faces, float distance) { }

	private static List<HashSet`1<Face>> GetFaceGroups(List<WingedEdge> wings) { }

	private static Dictionary<EdgeLookup, Face> GetPerimeterEdges(HashSet<Face> faces, Dictionary<Int32, Int32> lookup) { }

}

