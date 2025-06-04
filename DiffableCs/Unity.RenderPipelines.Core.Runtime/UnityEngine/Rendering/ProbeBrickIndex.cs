namespace UnityEngine.Rendering;

internal class ProbeBrickIndex
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction<BrickMeta> <>9__28_0; //Field offset: 0x8
		public static UnityAction<List`1<VoxelMeta>> <>9__28_1; //Field offset: 0x10
		public static UnityAction<VoxelMeta> <>9__28_2; //Field offset: 0x18
		public static Predicate<VoxelMeta> <>9__39_0; //Field offset: 0x20
		public static Predicate<VoxelMeta> <>9__40_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__28_0(BrickMeta x) { }

		internal void <.ctor>b__28_1(List<VoxelMeta> x) { }

		internal void <.ctor>b__28_2(VoxelMeta x) { }

		internal bool <AddBricks>b__39_0(VoxelMeta lhs) { }

		internal bool <RemoveBricks>b__40_0(VoxelMeta lhs) { }

	}

	[DebuggerDisplay("Brick [{position}, {subdivisionLevel}]")]
	internal struct Brick : IEquatable<Brick>
	{
		public Vector3Int position; //Field offset: 0x0
		public int subdivisionLevel; //Field offset: 0xC

		internal Brick(Vector3Int position, int subdivisionLevel) { }

		public override bool Equals(Brick other) { }

	}

	private class BrickMeta
	{
		public HashSet<Vector3Int> voxels; //Field offset: 0x10
		public List<ReservedBrick> bricks; //Field offset: 0x18

		public BrickMeta() { }

		public void Clear() { }

	}

	internal struct CellIndexUpdateInfo
	{
		public int firstChunkIndex; //Field offset: 0x0
		public int numberOfChunks; //Field offset: 0x4
		public int minSubdivInCell; //Field offset: 0x8
		public Vector3Int minValidBrickIndexForCellAtMaxRes; //Field offset: 0xC
		public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne; //Field offset: 0x18
		public Vector3Int cellPositionInBricksAtMaxRes; //Field offset: 0x24

	}

	[DebuggerDisplay("Brick [{brick.position}, {brick.subdivisionLevel}], {flattenedIdx}")]
	private struct ReservedBrick
	{
		public Brick brick; //Field offset: 0x0
		public int flattenedIdx; //Field offset: 0x10

	}

	private class VoxelMeta
	{
		public Cell cell; //Field offset: 0x10
		public List<UInt16> brickIndices; //Field offset: 0x18

		public VoxelMeta() { }

		public void Clear() { }

	}

	internal const int kMaxSubdivisionLevels = 7; //Field offset: 0x0
	private static Cell g_Cell; //Field offset: 0x0
	internal const int kIndexChunkSize = 243; //Field offset: 0x0
	private BitArray m_IndexChunks; //Field offset: 0x10
	private int m_IndexInChunks; //Field offset: 0x18
	private int m_NextFreeChunk; //Field offset: 0x1C
	private int m_AvailableChunkCount; //Field offset: 0x20
	private ComputeBuffer m_PhysicalIndexBuffer; //Field offset: 0x28
	private Int32[] m_PhysicalIndexBufferData; //Field offset: 0x30
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; //Field offset: 0x38
	private Vector3Int m_CenterRS; //Field offset: 0x3C
	private Dictionary<Vector3Int, List`1<VoxelMeta>> m_VoxelToBricks; //Field offset: 0x48
	private Dictionary<Cell, BrickMeta> m_BricksToVoxels; //Field offset: 0x50
	private ObjectPool<BrickMeta> m_BrickMetaPool; //Field offset: 0x58
	private ObjectPool<List`1<VoxelMeta>> m_VoxelMetaListPool; //Field offset: 0x60
	private ObjectPool<VoxelMeta> m_VoxelMetaPool; //Field offset: 0x68
	private bool m_NeedUpdateIndexComputeBuffer; //Field offset: 0x70
	private int m_UpdateMinIndex; //Field offset: 0x74
	private int m_UpdateMaxIndex; //Field offset: 0x78

	internal int estimatedVMemCost
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget) { }

	public void AddBricks(Cell cell, NativeArray<Brick> bricks, List<BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, CellIndexUpdateInfo cellInfo) { }

	internal bool AssignIndexChunksToCell(int bricksCount, ref CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog) { }

	internal void Cleanup() { }

	internal void Clear() { }

	private void ClearVoxel(Vector3Int pos, CellIndexUpdateInfo cellInfo) { }

	private void ClipToIndexSpace(Vector3Int pos, int subdiv, out Vector3Int outMinpos, out Vector3Int outMaxpos, CellIndexUpdateInfo cellInfo) { }

	[CompilerGenerated]
	internal int get_estimatedVMemCost() { }

	public int GetRemainingChunkCount() { }

	internal void GetRuntimeResources(ref RuntimeResources rr) { }

	private int GetVoxelSubdivLevel() { }

	private void MapBrickToVoxels(Brick brick, HashSet<Vector3Int> voxels) { }

	private int MergeIndex(int index, int size) { }

	public void RemoveBricks(CellInfo cellInfo) { }

	[CompilerGenerated]
	private void set_estimatedVMemCost(int value) { }

	private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget) { }

	private void UpdateIndexForVoxel(Vector3Int voxel, CellIndexUpdateInfo cellInfo) { }

	private void UpdateIndexForVoxel(Vector3Int voxel, List<ReservedBrick> bricks, List<UInt16> indices, CellIndexUpdateInfo cellInfo) { }

	private void UpdatePhysicalIndex(Vector3Int brickMin, Vector3Int brickMax, int value, CellIndexUpdateInfo cellInfo) { }

	internal void UploadIndexData() { }

}

