namespace UnityEngine.ProBuilder.MeshOperations;

internal static class InternalMeshUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Mesh, Vector3[]> <>9__1_0; //Field offset: 0x8
		public static Func<Mesh, Color[]> <>9__1_1; //Field offset: 0x10
		public static Func<Mesh, Vector2[]> <>9__1_2; //Field offset: 0x18
		public static Func<Mesh, Vector3[]> <>9__2_0; //Field offset: 0x20
		public static Func<Mesh, Color[]> <>9__2_1; //Field offset: 0x28
		public static Func<Mesh, Vector2[]> <>9__2_2; //Field offset: 0x30
		public static Func<Boolean, Boolean> <>9__3_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal Vector3[] <CreateMeshWithTransform>b__1_0(Mesh x) { }

		internal Color[] <CreateMeshWithTransform>b__1_1(Mesh x) { }

		internal Vector2[] <CreateMeshWithTransform>b__1_2(Mesh x) { }

		internal bool <FilterUnusedSubmeshIndexes>b__3_0(bool x) { }

		internal Vector3[] <ResetPbObjectWithMeshFilter>b__2_0(Mesh x) { }

		internal Color[] <ResetPbObjectWithMeshFilter>b__2_1(Mesh x) { }

		internal Vector2[] <ResetPbObjectWithMeshFilter>b__2_2(Mesh x) { }

	}


	internal static Vector3 AverageNormalWithIndexes(SharedVertex shared, Int32[] all, IList<Vector3> norm) { }

	public static ProBuilderMesh CreateMeshWithTransform(Transform t, bool preserveFaces) { }

	internal static void FilterUnusedSubmeshIndexes(ProBuilderMesh mesh) { }

	public static bool ResetPbObjectWithMeshFilter(ProBuilderMesh pb, bool preserveFaces) { }

}

