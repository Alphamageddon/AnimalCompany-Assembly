namespace UnityEngine.ProBuilder.MeshOperations;

internal static class Triangulation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public int index; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal TriangulationPoint <Triangulate>b__0(Vector2 x) { }

		internal PolygonPoint <Triangulate>b__1(Vector2 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public int index; //Field offset: 0x10
		public Func<Vector2, PolygonPoint> <>9__1; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal PolygonPoint <Triangulate>b__0(Vector2 x) { }

		internal PolygonPoint <Triangulate>b__1(Vector2 x) { }

	}

	private static TriangulationContext s_TriangulationContext; //Field offset: 0x0

	private static TriangulationContext triangulationContext
	{
		private get { } //Length: 140
	}

	private static TriangulationContext get_triangulationContext() { }

	public static bool SortAndTriangulate(IList<Vector2> points, out List<Int32>& indexes, bool convex = false) { }

	public static bool Triangulate(IList<Vector2> points, out List<Int32>& indexes, bool convex = false) { }

	public static bool Triangulate(IList<Vector2> points, IList<IList`1<Vector2>> holes, out List<Int32>& indexes) { }

	public static bool TriangulateVertices(IList<Vertex> vertices, out List<Int32>& triangles, bool unordered = true, bool convex = false) { }

	public static bool TriangulateVertices(Vector3[] vertices, out List<Int32>& triangles, Vector3[][] holes = null) { }

	public static bool TriangulateVertices(Vector3[] vertices, out List<Int32>& triangles, bool unordered = true, bool convex = false) { }

}

