namespace UnityEngine.Rendering;

internal class ProbeCellIndices
{
	public struct IndexMetaData
	{
		private static UInt32[] s_PackedValues; //Field offset: 0x0
		internal Vector3Int minLocalIdx; //Field offset: 0x0
		internal Vector3Int maxLocalIdx; //Field offset: 0xC
		internal int firstChunkIndex; //Field offset: 0x18
		internal int minSubdiv; //Field offset: 0x1C

		private static IndexMetaData() { }

		internal void Pack(out UInt32[] vals) { }

	}

	private const int kUintPerEntry = 3; //Field offset: 0x0
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; //Field offset: 0x10
	private ComputeBuffer m_IndexOfIndicesBuffer; //Field offset: 0x18
	private UInt32[] m_IndexOfIndicesData; //Field offset: 0x20
	private Vector3Int m_CellCount; //Field offset: 0x28
	private Vector3Int m_CellMin; //Field offset: 0x34
	private int m_CellSizeInMinBricks; //Field offset: 0x40
	private bool m_NeedUpdateComputeBuffer; //Field offset: 0x44

	internal int estimatedVMemCost
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal ProbeCellIndices(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks) { }

	internal void Cleanup() { }

	[CompilerGenerated]
	internal int get_estimatedVMemCost() { }

	internal Vector3Int GetCellIndexDimension() { }

	internal Vector3Int GetCellMinPosition() { }

	internal int GetFlatIdxForCell(Vector3Int cellPosition) { }

	private int GetFlatIndex(Vector3Int normalizedPos) { }

	internal void GetRuntimeResources(ref RuntimeResources rr) { }

	internal void MarkCellAsUnloaded(int cellFlatIdx) { }

	internal void PushComputeData() { }

	[CompilerGenerated]
	private void set_estimatedVMemCost(int value) { }

	internal void UpdateCell(int cellFlatIdx, CellIndexUpdateInfo cellUpdateInfo) { }

}

