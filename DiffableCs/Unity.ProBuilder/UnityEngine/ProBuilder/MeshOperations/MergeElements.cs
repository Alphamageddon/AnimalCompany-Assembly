namespace UnityEngine.ProBuilder.MeshOperations;

public static class MergeElements
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Face, IEnumerable`1<Int32>> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Int32> <Merge>b__1_0(Face x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public HashSet<Face> remove; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <MergePairs>b__0(Face x) { }

	}


	internal static void CollapseCoincidentVertices(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	public static Face Merge(ProBuilderMesh target, IEnumerable<Face> faces) { }

	public static List<Face> MergePairs(ProBuilderMesh target, IEnumerable<SimpleTuple`2<Face, Face>> pairs, bool collapseCoincidentVertices = true) { }

}

