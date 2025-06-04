namespace UnityEngine.Rendering.Universal.LibTessDotNet;

internal static class Geom
{

	public static void AddWinding(Edge eDst, Edge eSrc) { }

	public static float EdgeEval(Vertex u, Vertex v, Vertex w) { }

	public static bool EdgeGoesLeft(Edge e) { }

	public static bool EdgeGoesRight(Edge e) { }

	public static void EdgeIntersect(Vertex o1, Vertex d1, Vertex o2, Vertex d2, Vertex v) { }

	public static float EdgeSign(Vertex u, Vertex v, Vertex w) { }

	public static float Interpolate(float a, float x, float b, float y) { }

	public static bool IsWindingInside(WindingRule rule, int n) { }

	private static void Swap(ref Vertex a, ref Vertex b) { }

	public static float TransEval(Vertex u, Vertex v, Vertex w) { }

	public static bool TransLeq(Vertex lhs, Vertex rhs) { }

	public static float TransSign(Vertex u, Vertex v, Vertex w) { }

	public static bool VertCCW(Vertex u, Vertex v, Vertex w) { }

	public static bool VertEq(Vertex lhs, Vertex rhs) { }

	public static float VertL1dist(Vertex u, Vertex v) { }

	public static bool VertLeq(Vertex lhs, Vertex rhs) { }

}

