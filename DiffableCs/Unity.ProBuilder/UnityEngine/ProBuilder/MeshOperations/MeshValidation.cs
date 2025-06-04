namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class MeshValidation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Triangle, IEnumerable`1<Int32>> <>9__4_0; //Field offset: 0x8
		public static Func<Triangle, IEnumerable`1<Int32>> <>9__4_1; //Field offset: 0x10
		public static Func<Face, IEnumerable`1<Int32>> <>9__7_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Int32> <EnsureFacesAreComposedOfContiguousTriangles>b__4_0(Triangle x) { }

		internal IEnumerable<Int32> <EnsureFacesAreComposedOfContiguousTriangles>b__4_1(Triangle x) { }

		internal IEnumerable<Int32> <RemoveUnusedVertices>b__7_0(Face x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public ProBuilderMesh mesh; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <RebuildSelectionIndexes>b__0(Face x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Triangle triangle; //Field offset: 0x10
		public Func<Triangle, Boolean> <>9__0; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal bool <CollectFaceGroups>b__0(Triangle x) { }

	}

	private enum AttributeValidationStrategy
	{
		Resize = 0,
		Nullify = 1,
	}


	[Extension]
	internal static List<List`1<Triangle>> CollectFaceGroups(ProBuilderMesh mesh, Face face) { }

	[Extension]
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh) { }

	[Extension]
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, IList<Face> faces) { }

	[Extension]
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, Face face) { }

	[Extension]
	public static bool ContainsNonContiguousTriangles(ProBuilderMesh mesh, Face face) { }

	private static void EnsureArraySize(ref T[] attribute, int expectedVertexCount, AttributeValidationStrategy strategy = 1, T fill = null) { }

	[Extension]
	public static List<Face> EnsureFacesAreComposedOfContiguousTriangles(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	private static void EnsureListSize(ref List<T>& attribute, int expectedVertexCount, AttributeValidationStrategy strategy = 1, T fill = null) { }

	internal static bool EnsureMeshIsValid(ProBuilderMesh mesh, out int removedVertices) { }

	private static void EnsureRealNumbers(IList<Vector4> attribute) { }

	private static void EnsureRealNumbers(IList<Vector3> attribute) { }

	private static void EnsureRealNumbers(IList<Vector2> attribute) { }

	private static void EnsureValidAttributes(ProBuilderMesh mesh) { }

	internal static List<Edge> RebuildEdges(IEnumerable<Edge> edges, List<Int32> removed) { }

	internal static List<Int32> RebuildIndexes(IEnumerable<Int32> indices, List<Int32> removed) { }

	internal static void RebuildSelectionIndexes(ProBuilderMesh mesh, ref Face[] faces, ref Edge[] edges, ref Int32[] indices, IEnumerable<Int32> removed) { }

	public static bool RemoveDegenerateTriangles(ProBuilderMesh mesh, List<Int32> removed = null) { }

	public static bool RemoveUnusedVertices(ProBuilderMesh mesh, List<Int32> removed = null) { }

}

