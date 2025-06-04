namespace UnityEngine.Rendering;

[PreferBinarySerialization]
internal class ProbeVolumeAsset : ScriptableObject
{
	public enum AssetVersion
	{
		First = 0,
		AddProbeVolumesAtlasEncodingModes = 1,
		PV2 = 2,
		ChunkBasedIndex = 3,
		BinaryRuntimeDebugSplit = 4,
		BinaryTextureData = 5,
		Max = 6,
		Current = 5,
	}

	public struct CellCounts
	{
		public int bricksCount; //Field offset: 0x0
		public int probesCount; //Field offset: 0x4
		public int offsetsCount; //Field offset: 0x8
		public int chunksCount; //Field offset: 0xC

		public void Add(CellCounts o) { }

	}

	[SerializeField]
	protected private int m_Version; //Field offset: 0x18
	[SerializeField]
	internal Cell[] cells; //Field offset: 0x20
	[SerializeField]
	internal CellCounts[] cellCounts; //Field offset: 0x28
	[SerializeField]
	internal CellCounts totalCellCounts; //Field offset: 0x30
	[SerializeField]
	internal Vector3Int maxCellPosition; //Field offset: 0x40
	[SerializeField]
	internal Vector3Int minCellPosition; //Field offset: 0x4C
	[SerializeField]
	internal Bounds globalBounds; //Field offset: 0x58
	[SerializeField]
	internal ProbeVolumeSHBands bands; //Field offset: 0x70
	[SerializeField]
	internal int chunkSizeInBricks; //Field offset: 0x74
	[SerializeField]
	private string m_AssetFullPath; //Field offset: 0x78
	[SerializeField]
	internal int cellSizeInBricks; //Field offset: 0x80
	[SerializeField]
	internal int simplificationLevels; //Field offset: 0x84
	[SerializeField]
	internal float minDistanceBetweenProbes; //Field offset: 0x88

	internal int maxSubdivision
	{
		internal get { } //Length: 12
	}

	internal float minBrickSize
	{
		internal get { } //Length: 28
	}

	public int Version
	{
		 get { } //Length: 8
	}

	public ProbeVolumeAsset() { }

	private static int AlignUp16(int count) { }

	internal bool CompatibleWith(ProbeVolumeAsset otherAsset) { }

	internal int get_maxSubdivision() { }

	internal float get_minBrickSize() { }

	public int get_Version() { }

	public string GetSerializedFullPath() { }

	private NativeArray<T> GetSubArray(NativeArray<Byte> input, int count, ref int offset) { }

	internal bool IsInvalid() { }

	internal bool ResolvePerScenarioCellData(TextAsset cellDataAsset, TextAsset cellOptionalDataAsset, int stateIndex) { }

	internal bool ResolveSharedCellData(TextAsset cellSharedDataAsset, TextAsset cellSupportDataAsset) { }

}

