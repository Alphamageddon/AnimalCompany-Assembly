namespace UnityEngine.ProBuilder;

[Extension]
public static class MeshUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Dictionary`2<Vertex, Int32>, IEnumerable`1<Vertex>> <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Vertex> <CollapseSharedVertices>b__11_0(Dictionary<Vertex, Int32> x) { }

	}


	public static void CollapseSharedVertices(Mesh mesh, Vertex[] vertices = null) { }

	public static void Compile(ProBuilderMesh probuilderMesh, Mesh targetMesh, MeshTopology preferredTopology = 0) { }

	public static void CopyTo(Mesh source, Mesh destination) { }

	public static Mesh DeepCopy(Mesh source) { }

	public static void FitToSize(ProBuilderMesh mesh, Bounds currentSize, Vector3 sizeToFit) { }

	internal static Vertex[] GeneratePerTriangleMesh(Mesh mesh) { }

	public static void GenerateTangent(Mesh mesh) { }

	[Extension]
	internal static Bounds GetBounds(ProBuilderMesh mesh) { }

	public static uint GetIndexCount(Mesh mesh) { }

	internal static T GetMeshChannel(GameObject gameObject, Func<Mesh, T> attributeGetter) { }

	public static uint GetPrimitiveCount(Mesh mesh) { }

	[Extension]
	public static Vertex[] GetVertices(Mesh mesh) { }

	internal static bool IsUsedInParticleSystem(ProBuilderMesh pbmesh) { }

	public static string Print(Mesh mesh) { }

	private static void PrintAttribute(StringBuilder sb, string title, IEnumerable<T> attrib, string fmt) { }

	internal static void RestoreParticleSystem(ProBuilderMesh pbmesh) { }

	internal static string SanityCheck(ProBuilderMesh mesh) { }

	internal static string SanityCheck(Mesh mesh) { }

	internal static string SanityCheck(IList<Vertex> vertices) { }

}

