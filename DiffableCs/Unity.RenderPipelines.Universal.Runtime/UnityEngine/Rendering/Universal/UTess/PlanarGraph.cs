namespace UnityEngine.Rendering.Universal.UTess;

internal struct PlanarGraph
{
	private static readonly double kEpsilon; //Field offset: 0x0
	private static readonly int kMaxIntersectionTolerance; //Field offset: 0x8

	private static PlanarGraph() { }

	internal static bool CalculateEdgeIntersections(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, ref NativeArray<int2>& results, ref NativeArray<double2>& intersects, ref int resultCount) { }

	internal static bool CalculateTJunctions(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, NativeArray<int2> results, ref int resultCount) { }

	internal static bool CheckCollinear(double2 a0, double2 a1, double2 b0, double2 b1) { }

	internal static bool CutEdges(ref NativeArray<double2>& points, ref int pointCount, ref NativeArray<int2>& edges, ref int edgeCount, ref NativeArray<int2>& tJunctions, ref int tJunctionCount, NativeArray<int2> intersections, NativeArray<double2> intersects, int intersectionCount) { }

	internal static bool LineLineIntersection(double2 a0, double2 a1, double2 b0, double2 b1) { }

	internal static bool LineLineIntersection(double2 p1, double2 p2, double2 p3, double2 p4, ref double2 result) { }

	internal static void RemoveDuplicateEdges(ref NativeArray<int2>& edges, ref int edgeCount, NativeArray<Int32> duplicates, int duplicateCount) { }

	internal static void RemoveDuplicatePoints(ref NativeArray<double2>& points, ref int pointCount, ref NativeArray<Int32>& duplicates, ref int duplicateCount, Allocator allocator) { }

	internal static bool Validate(Allocator allocator, NativeArray<float2> inputPoints, int pointCount, NativeArray<int2> inputEdges, int edgeCount, ref NativeArray<float2>& outputPoints, ref int outputPointCount, ref NativeArray<int2>& outputEdges, ref int outputEdgeCount) { }

}

