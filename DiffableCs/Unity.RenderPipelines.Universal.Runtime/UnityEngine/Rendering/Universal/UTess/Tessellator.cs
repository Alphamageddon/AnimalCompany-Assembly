namespace UnityEngine.Rendering.Universal.UTess;

internal struct Tessellator
{
	private struct TestCellE : ICondition2<int3, int3>
	{

		public override bool Test(int3 h, int3 p, ref float t) { }

	}

	private struct TestEdgePointE : ICondition2<int2, int2>
	{

		public override bool Test(int2 h, int2 p, ref float t) { }

	}

	private struct TestHullEventE : ICondition2<UHull, UEvent>
	{

		public override bool Test(UHull h, UEvent p, ref float t) { }

	}

	private struct TestHullEventLe : ICondition2<UHull, UEvent>
	{

		public override bool Test(UHull h, UEvent p, ref float t) { }

	}

	private struct TestHullPointL : ICondition2<UHull, float2>
	{

		public override bool Test(UHull h, float2 p, ref float t) { }

	}

	private struct TestHullPointU : ICondition2<UHull, float2>
	{

		public override bool Test(UHull h, float2 p, ref float t) { }

	}

	private NativeArray<int2> m_Edges; //Field offset: 0x0
	private NativeArray<UStar> m_Stars; //Field offset: 0x10
	private NativeArray<int3> m_Cells; //Field offset: 0x20
	private int m_CellCount; //Field offset: 0x30
	private NativeArray<Int32> m_ILArray; //Field offset: 0x38
	private NativeArray<Int32> m_IUArray; //Field offset: 0x48
	private NativeArray<Int32> m_SPArray; //Field offset: 0x58
	private int m_NumEdges; //Field offset: 0x68
	private int m_NumHulls; //Field offset: 0x6C
	private int m_NumPoints; //Field offset: 0x70
	private int m_StarCount; //Field offset: 0x74
	private NativeArray<Int32> m_Flags; //Field offset: 0x78
	private NativeArray<Int32> m_Neighbors; //Field offset: 0x88
	private NativeArray<Int32> m_Constraints; //Field offset: 0x98
	private Allocator m_Allocator; //Field offset: 0xA8

	private bool AddPoint(NativeArray<UHull> hulls, int hullCount, NativeArray<float2> points, float2 p, int idx) { }

	private void AddTriangle(int i, int j, int k) { }

	internal bool ApplyDelaunay(NativeArray<float2> points, NativeArray<int2> edges) { }

	internal void Cleanup() { }

	private NativeArray<int3> Constrain(ref int count) { }

	private void EdgeFlip(int i, int j) { }

	private static void EraseHull(NativeArray<UHull> Hulls, int Pos, ref int Count) { }

	private int FindConstraint(int a, int b) { }

	private int FindNeighbor(NativeArray<int3> cells, int count, int a, int b, int c) { }

	private static float FindSplit(UHull hull, UEvent edge) { }

	private bool Flip(NativeArray<float2> points, ref NativeArray<Int32>& stack, ref int stackCount, int a, int b, int x) { }

	private NativeArray<int3> GetCells(ref int count) { }

	private static void InsertHull(NativeArray<UHull> Hulls, int Pos, ref int Count, UHull Value) { }

	private static void InsertUniqueEdge(NativeArray<int2> edges, int2 e, ref int edgeCount) { }

	private bool MergeHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt) { }

	private int OppositeOf(int a, int b) { }

	private void PrepareDelaunay(NativeArray<int2> edges, int edgeCount) { }

	internal NativeArray<int3> RemoveExterior(ref int cellCount) { }

	internal NativeArray<int3> RemoveInterior(int cellCount) { }

	private void RemovePair(int r, int j, int k) { }

	private void RemoveTriangle(int i, int j, int k) { }

	private void SetAllocator(Allocator allocator) { }

	private bool SplitHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt) { }

	internal static bool Tessellate(Allocator allocator, NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<float2>& outputVertices, ref int vertexCount, ref NativeArray<Int32>& outputIndices, ref int indexCount) { }

	internal bool Triangulate(NativeArray<float2> points, int pointCount, NativeArray<int2> edges, int edgeCount) { }

}

