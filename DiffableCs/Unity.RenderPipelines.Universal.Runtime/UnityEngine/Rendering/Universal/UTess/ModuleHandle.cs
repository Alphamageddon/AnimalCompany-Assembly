namespace UnityEngine.Rendering.Universal.UTess;

internal struct ModuleHandle
{
	internal static readonly int kMaxArea; //Field offset: 0x0
	internal static readonly int kMaxEdgeCount; //Field offset: 0x4
	internal static readonly int kMaxIndexCount; //Field offset: 0x8
	internal static readonly int kMaxVertexCount; //Field offset: 0xC
	internal static readonly int kMaxTriangleCount; //Field offset: 0x10
	internal static readonly int kMaxRefineIterations; //Field offset: 0x14
	internal static readonly int kMaxSmoothenIterations; //Field offset: 0x18
	internal static readonly float kIncrementAreaFactor; //Field offset: 0x1C

	private static ModuleHandle() { }

	internal static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<Int32> indices, int indexCount, ref NativeArray<UTriangle>& triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea, ref float maxEdge, ref float avgEdge, ref float minEdge) { }

	internal static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<Int32> indices, int indexCount, ref NativeArray<UTriangle>& triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea) { }

	internal static void BuildTrianglesAndEdges(NativeArray<float2> vertices, int vertexCount, NativeArray<Int32> indices, int indexCount, ref NativeArray<UTriangle>& triangles, ref int triangleCount, ref NativeArray<int4>& delaEdges, ref int delaEdgeCount, ref float maxArea, ref float avgArea, ref float minArea) { }

	internal static UCircle CircumCircle(UTriangle tri) { }

	public static float4 ConvexQuad(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2>& outVertices, ref int outVertexCount, ref NativeArray<Int32>& outIndices, ref int outIndexCount, ref NativeArray<int2>& outEdges, ref int outEdgeCount) { }

	internal static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	internal static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) { }

	private static void CopyGeometry(NativeArray<Int32> srcIndices, int srcIndexCount, ref NativeArray<Int32>& dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2>& dstVertices, ref int dstVertexCount) { }

	private static void CopyGraph(NativeArray<float2> srcPoints, int srcPointCount, ref NativeArray<float2>& dstPoints, ref int dstPointCount, NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2>& dstEdges, ref int dstEdgeCount) { }

	internal static int GetEqual(NativeArray<T> values, int count, U check, X condition) { }

	internal static int GetLower(NativeArray<T> values, int count, U check, X condition) { }

	internal static int GetUpper(NativeArray<T> values, int count, U check, X condition) { }

	private static void GraphConditioner(NativeArray<float2> points, ref NativeArray<float2>& pgPoints, ref int pgPointCount, ref NativeArray<int2>& pgEdges, ref int pgEdgeCount, bool resetTopology) { }

	internal static void InsertionSort(Void* array, int lo, int hi, U comp) { }

	internal static bool IsInsideCircle(UCircle c, float2 v) { }

	internal static bool IsInsideCircle(float2 a, float2 b, float2 c, float2 p) { }

	internal static bool IsInsideTriangle(float2 pt, float2 v1, float2 v2, float2 v3) { }

	internal static bool IsInsideTriangleApproximate(float2 pt, float2 v1, float2 v2, float2 v3) { }

	internal static float OrientFast(float2 a, float2 b, float2 c) { }

	internal static double OrientFastDouble(double2 a, double2 b, double2 c) { }

	private static void Reorder(int startVertexCount, int index, ref NativeArray<Int32>& indices, ref int indexCount, ref NativeArray<float2>& vertices, ref int vertexCount) { }

	internal static float Sign(float2 p1, float2 p2, float2 p3) { }

	public static float4 Subdivide(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2>& outVertices, ref int outVertexCount, ref NativeArray<Int32>& outIndices, ref int outIndexCount, ref NativeArray<int2>& outEdges, ref int outEdgeCount, float areaFactor, float targetArea, int refineIterations, int smoothenIterations) { }

	public static float4 Tessellate(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2>& outVertices, ref int outVertexCount, ref NativeArray<Int32>& outIndices, ref int outIndexCount, ref NativeArray<int2>& outEdges, ref int outEdgeCount) { }

	private static void TransferOutput(NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2>& dstEdges, ref int dstEdgeCount, NativeArray<Int32> srcIndices, int srcIndexCount, ref NativeArray<Int32>& dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2>& dstVertices, ref int dstVertexCount) { }

	internal static float TriangleArea(float2 va, float2 vb, float2 vc) { }

	internal static void VertexCleanupConditioner(int startVertexCount, ref NativeArray<Int32>& indices, ref int indexCount, ref NativeArray<float2>& vertices, ref int vertexCount) { }

}

