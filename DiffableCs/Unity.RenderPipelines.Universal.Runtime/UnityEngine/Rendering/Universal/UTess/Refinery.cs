namespace UnityEngine.Rendering.Universal.UTess;

internal struct Refinery
{
	private static readonly float kMinAreaFactor; //Field offset: 0x0
	private static readonly float kMaxAreaFactor; //Field offset: 0x4
	private static readonly int kMaxSteinerCount; //Field offset: 0x8

	private static Refinery() { }

	internal static bool Condition(Allocator allocator, float factorArea, float targetArea, ref NativeArray<float2>& pgPoints, ref int pgPointCount, ref NativeArray<int2>& pgEdges, ref int pgEdgeCount, ref NativeArray<float2>& vertices, ref int vertexCount, ref NativeArray<Int32>& indices, ref int indexCount, ref float maxArea) { }

	private static void FetchEncroachedSegments(NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<UEncroachingSegment>& encroach, ref int encroachCount, UCircle c) { }

	private static int FindSegment(NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, UEncroachingSegment es) { }

	private static void InsertVertex(ref NativeArray<float2>& pgPoints, ref int pgPointCount, float2 newVertex, ref int nid) { }

	private static bool RequiresRefining(UTriangle tri, float maxArea) { }

	private static void SplitSegments(ref NativeArray<float2>& pgPoints, ref int pgPointCount, ref NativeArray<int2>& pgEdges, ref int pgEdgeCount, UEncroachingSegment es) { }

}

