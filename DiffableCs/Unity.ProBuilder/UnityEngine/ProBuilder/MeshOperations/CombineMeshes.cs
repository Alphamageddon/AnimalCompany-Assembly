namespace UnityEngine.ProBuilder.MeshOperations;

public static class CombineMeshes
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Face, Int32> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <SplitByMaxVertexCount>b__5_0(Face x) { }

	}


	private static void AccumulateMeshesInfo(IEnumerable<ProBuilderMesh> meshes, int offset, ref List<Vertex>& vertices, ref List<Face>& faces, ref List<Face>& autoUvFaces, ref List<SharedVertex>& sharedVertices, ref List<SharedVertex>& sharedTextures, ref List<Material>& materialMap, Transform targetTransform = null) { }

	[Obsolete("Combine(IEnumerable<ProBuilderMesh> meshes) is deprecated. Plase use Combine(IEnumerable<ProBuilderMesh> meshes, ProBuilderMesh meshTarget).")]
	public static List<ProBuilderMesh> Combine(IEnumerable<ProBuilderMesh> meshes) { }

	public static List<ProBuilderMesh> Combine(IEnumerable<ProBuilderMesh> meshes, ProBuilderMesh meshTarget) { }

	private static List<ProBuilderMesh> CombineToNewMeshes(IEnumerable<ProBuilderMesh> meshes) { }

	private static ProBuilderMesh CreateMeshFromSplit(List<Vertex> vertices, List<Face> faces, Dictionary<Int32, Int32> sharedVertexLookup, Dictionary<Int32, Int32> sharedTextureLookup, Dictionary<Int32, Int32> remap, Material[] materials) { }

	internal static List<ProBuilderMesh> SplitByMaxVertexCount(IList<Vertex> vertices, IList<Face> faces, IList<SharedVertex> sharedVertices, IList<SharedVertex> sharedTextures, uint maxVertexCount = 65535) { }

}

