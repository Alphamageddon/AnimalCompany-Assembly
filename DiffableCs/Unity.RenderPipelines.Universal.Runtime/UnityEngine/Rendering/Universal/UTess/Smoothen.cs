namespace UnityEngine.Rendering.Universal.UTess;

internal struct Smoothen
{
	private static readonly float kMaxAreaTolerance; //Field offset: 0x0
	private static readonly float kMaxEdgeTolerance; //Field offset: 0x4

	private static Smoothen() { }

	private static void CentroidByPoints(int triIndex, NativeArray<UTriangle> triangles, ref NativeArray<Int32>& centroidTris, ref int centroidCount, ref float2 aggregate, ref float2 point) { }

	private static void CentroidByPolygon(int4 e, NativeArray<UTriangle> triangles, ref float2 centroid, ref float area, ref float distance) { }

	internal static bool Condition(Allocator allocator, ref NativeArray<float2>& pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<float2>& vertices, ref int vertexCount, ref NativeArray<Int32>& indices, ref int indexCount) { }

	private static bool ConnectTriangles(ref NativeArray<int4>& connectedTri, ref NativeArray<Int32>& affectEdges, ref NativeArray<Int32>& checkSet, NativeArray<int4> voronoiEdges, int triangleCount) { }

	private static void GetAffectingEdges(int pointIndex, NativeArray<int4> edges, int edgeCount, ref NativeArray<Int32>& resultSet, ref NativeArray<Int32>& checkSet, ref int resultCount) { }

	private static void RefineEdges(ref NativeArray<int4>& refinedEdges, ref NativeArray<int4>& delaEdges, ref int delaEdgeCount, ref NativeArray<int4>& voronoiEdges) { }

}

