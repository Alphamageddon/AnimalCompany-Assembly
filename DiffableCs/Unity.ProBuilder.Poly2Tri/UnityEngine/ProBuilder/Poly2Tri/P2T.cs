namespace UnityEngine.ProBuilder.Poly2Tri;

internal static class P2T
{
	private static TriangulationAlgorithm _defaultAlgorithm; //Field offset: 0x0

	public static TriangulationContext CreateContext(TriangulationAlgorithm algorithm) { }

	public static void Triangulate(PolygonSet ps) { }

	public static void Triangulate(Polygon p) { }

	public static void Triangulate(ConstrainedPointSet cps) { }

	public static void Triangulate(PointSet ps) { }

	public static void Triangulate(TriangulationAlgorithm algorithm, Triangulatable t) { }

	public static void Triangulate(TriangulationContext tcx) { }

	public static void Warmup() { }

}

