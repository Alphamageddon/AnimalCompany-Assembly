namespace UnityEngine.ProBuilder;

public static class Projection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<SimpleTuple`2<Single, Vector2>> <>9__6_0; //Field offset: 0x8
		public static Func<SimpleTuple`2<Single, Vector2>, Vector2> <>9__6_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <Sort>b__6_0(SimpleTuple<Single, Vector2> a, SimpleTuple<Single, Vector2> b) { }

		internal Vector2 <Sort>b__6_1(SimpleTuple<Single, Vector2> x) { }

	}


	public static Plane FindBestPlane(IList<Vector3> points, IList<Int32> indexes = null) { }

	internal static Plane FindBestPlane(ProBuilderMesh mesh, int textureGroup) { }

	internal static Vector3 GetTangentToAxis(ProjectionAxis axis) { }

	public static Vector2[] PlanarProject(IList<Vector3> positions, IList<Int32> indexes = null) { }

	public static Vector2[] PlanarProject(IList<Vector3> positions, IList<Int32> indexes, Vector3 direction) { }

	internal static void PlanarProject(IList<Vector3> positions, IList<Int32> indexes, Vector3 direction, List<Vector2> results) { }

	internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings) { }

	internal static void PlanarProject(ProBuilderMesh mesh, Face face, Vector3 projection = null) { }

	internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis) { }

	internal static IList<Vector2> Sort(IList<Vector2> verts, SortMethod method = 1) { }

	internal static Vector2[] SphericalProject(IList<Vector3> vertices, IList<Int32> indexes = null) { }

	internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction) { }

}

