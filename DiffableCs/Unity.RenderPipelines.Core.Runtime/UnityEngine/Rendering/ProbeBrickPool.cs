namespace UnityEngine.Rendering;

internal class ProbeBrickPool
{
	[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
	internal struct BrickChunkAlloc
	{
		public int x; //Field offset: 0x0
		public int y; //Field offset: 0x4
		public int z; //Field offset: 0x8

		internal int flattenIndex(int sx, int sy) { }

	}

	internal struct DataLocation
	{
		internal Texture TexL0_L1rx; //Field offset: 0x0
		internal Texture TexL1_G_ry; //Field offset: 0x8
		internal Texture TexL1_B_rz; //Field offset: 0x10
		internal Texture TexL2_0; //Field offset: 0x18
		internal Texture TexL2_1; //Field offset: 0x20
		internal Texture TexL2_2; //Field offset: 0x28
		internal Texture TexL2_3; //Field offset: 0x30
		internal Texture3D TexValidity; //Field offset: 0x38
		internal int width; //Field offset: 0x40
		internal int height; //Field offset: 0x44
		internal int depth; //Field offset: 0x48

		internal void Cleanup() { }

	}

	private const int kProbePoolChunkSizeInBricks = 128; //Field offset: 0x0
	internal const int kBrickCellCount = 3; //Field offset: 0x0
	internal const int kBrickProbeCountPerDim = 4; //Field offset: 0x0
	internal const int kBrickProbeCountTotal = 64; //Field offset: 0x0
	internal const int kChunkProbeCountPerDim = 512; //Field offset: 0x0
	private const int kMaxPoolWidth = 2048; //Field offset: 0x0
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; //Field offset: 0x10
	internal DataLocation m_Pool; //Field offset: 0x18
	private BrickChunkAlloc m_NextFreeChunk; //Field offset: 0x68
	private Stack<BrickChunkAlloc> m_FreeList; //Field offset: 0x78
	private int m_AvailableChunkCount; //Field offset: 0x80
	private ProbeVolumeSHBands m_SHBands; //Field offset: 0x84
	private bool m_ContainsValidity; //Field offset: 0x88

	internal int estimatedVMemCost
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal ProbeBrickPool(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool allocateValidityData = true) { }

	internal bool Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations, bool ignoreErrorLog) { }

	internal void Cleanup() { }

	internal void Clear() { }

	public static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, out int allocatedBytes) { }

	public static Texture CreateDataTexture(int width, int height, int depth, GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes) { }

	internal void Deallocate(List<BrickChunkAlloc> allocations) { }

	private void DerivePoolSizeFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth) { }

	internal void EnsureTextureValidity() { }

	[CompilerGenerated]
	internal int get_estimatedVMemCost() { }

	internal static int GetChunkCount(int brickCount, int chunkSizeInBricks) { }

	internal static int GetChunkSizeInBrickCount() { }

	internal static int GetChunkSizeInProbeCount() { }

	internal Vector3Int GetPoolDimensions() { }

	internal int GetPoolHeight() { }

	internal int GetPoolWidth() { }

	public int GetRemainingChunkCount() { }

	internal void GetRuntimeResources(ref RuntimeResources rr) { }

	internal static Vector3Int ProbeCountToDataLocSize(int numProbes) { }

	[CompilerGenerated]
	private void set_estimatedVMemCost(int value) { }

	internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands) { }

	internal void UpdateValidity(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex) { }

}

