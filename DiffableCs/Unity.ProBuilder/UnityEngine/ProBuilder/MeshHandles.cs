namespace UnityEngine.ProBuilder;

internal static class MeshHandles
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Face, IEnumerable`1<Int32>> <>9__9_0; //Field offset: 0x8
		public static Func<Face, IEnumerable`1<Int32>> <>9__10_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Int32> <CreateFaceMesh>b__9_0(Face x) { }

		internal IEnumerable<Int32> <CreateFaceMeshFromFaces>b__10_0(Face x) { }

	}

	private static List<Vector3> s_Vector2List; //Field offset: 0x0
	private static List<Vector3> s_Vector3List; //Field offset: 0x8
	private static List<Vector4> s_Vector4List; //Field offset: 0x10
	private static List<Int32> s_IndexList; //Field offset: 0x18
	private static List<Int32> s_SharedVertexIndexList; //Field offset: 0x20
	private static readonly Vector2 k_Billboard0; //Field offset: 0x28
	private static readonly Vector2 k_Billboard1; //Field offset: 0x30
	private static readonly Vector2 k_Billboard2; //Field offset: 0x38
	private static readonly Vector2 k_Billboard3; //Field offset: 0x40

	private static MeshHandles() { }

	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target) { }

	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target, ICollection<Edge> edges) { }

	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target) { }

	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target, Edge[] edges) { }

	internal static void CreateFaceMesh(ProBuilderMesh mesh, Mesh target) { }

	internal static void CreateFaceMeshFromFaces(ProBuilderMesh mesh, IList<Face> faces, Mesh target) { }

	internal static void CreatePointBillboardMesh(IList<Vector3> positions, Mesh target) { }

	private static void CreatePointBillboardMesh(IList<Vector3> positions, IList<Int32> indexes, Mesh target) { }

	private static void CreatePointMesh(Vector3[] positions, IList<Int32> indexes, Mesh target) { }

	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target) { }

	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target, IList<Int32> indexes) { }

}

