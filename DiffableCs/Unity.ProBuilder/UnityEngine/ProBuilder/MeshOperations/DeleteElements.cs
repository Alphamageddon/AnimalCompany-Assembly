namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class DeleteElements
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Face, IEnumerable`1<Int32>> <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Int32> <DeleteFaces>b__3_0(Face x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public List<Int32> sorted; //Field offset: 0x10
		public Int32[] offset; //Field offset: 0x18

		public <>c__DisplayClass0_0() { }

		internal bool <DeleteVertices>b__0(KeyValuePair<Int32, Int32> x) { }

		internal KeyValuePair<Int32, Int32> <DeleteVertices>b__1(KeyValuePair<Int32, Int32> y) { }

		internal bool <DeleteVertices>b__2(KeyValuePair<Int32, Int32> x) { }

		internal KeyValuePair<Int32, Int32> <DeleteVertices>b__3(KeyValuePair<Int32, Int32> y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public ProBuilderMesh mesh; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal int <DeleteFaces>b__0(Face x) { }

	}


	[Extension]
	public static Int32[] DeleteFace(ProBuilderMesh mesh, Face face) { }

	[Extension]
	public static Int32[] DeleteFaces(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	[Extension]
	public static Int32[] DeleteFaces(ProBuilderMesh mesh, IList<Int32> faceIndexes) { }

	[Extension]
	public static void DeleteVertices(ProBuilderMesh mesh, IEnumerable<Int32> distinctIndexes) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Extension]
	[Obsolete("Use MeshValidation.RemoveDegenerateTriangles")]
	public static Int32[] RemoveDegenerateTriangles(ProBuilderMesh mesh) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Extension]
	[Obsolete("Use MeshValidation.RemoveUnusedVertices")]
	public static Int32[] RemoveUnusedVertices(ProBuilderMesh mesh) { }

}

