namespace Fusion;

public struct Allocator
{
	private static class AllocatorBucketSize
	{
		public static readonly Int32[] Sizes; //Field offset: 0x0

		private static AllocatorBucketSize() { }

	}

	private struct Block
	{
		public const int SIZE = 28; //Field offset: 0x0
		public Ptr Prev; //Field offset: 0x0
		public Ptr Next; //Field offset: 0x4
		public int Bucket; //Field offset: 0x8
		public Ptr SegmentsFree; //Field offset: 0xC
		public int SegmentsUsed; //Field offset: 0x10
		public int SegmentsAllocated; //Field offset: 0x14
		public int Index; //Field offset: 0x18

		public bool SegmentsFreeContains(Allocator* a, Void* ptr) { }

		public int SegmentsFreeCount(Allocator* a) { }

	}

	private struct BlockList
	{
		public const int SIZE = 8; //Field offset: 0x0
		public Ptr Head; //Field offset: 0x0
		public Ptr Tail; //Field offset: 0x4

		public bool IsEmpty
		{
			 get { } //Length: 16
		}

		public void AddFirst(Allocator* a, Block* item) { }

		public void AddLast(Allocator* a, Block* item) { }

		public bool Contains(Allocator* a, Block* item) { }

		[Conditional("DEBUG")]
		private void DebugVerifyListIntegrity(Allocator* a) { }

		public bool get_IsEmpty() { }

		public void MoveFirst(Allocator* a, Block* item) { }

		public void MoveLast(Allocator* a, Block* item) { }

		public void Remove(Allocator* a, Block* item) { }

		public Block* RemoveHead(Allocator* a) { }

	}

	private struct Bucket
	{
		public const int SIZE = 16; //Field offset: 0x0
		public int Index; //Field offset: 0x0
		public int SegmentStride; //Field offset: 0x4
		public int SegmentWordCount; //Field offset: 0x8
		public int SegmentCapacity; //Field offset: 0xC

		public static Bucket Create(int index, int wordCount, Config config) { }

	}

	internal struct Config
	{
		public const int SIZE = 12; //Field offset: 0x0
		public const PageSizes DEFAULT_BLOCK_SHIFT = 15; //Field offset: 0x0
		public const int DEFAULT_BLOCK_COUNT = 256; //Field offset: 0x0
		public int BlockShift; //Field offset: 0x0
		public int BlockCount; //Field offset: 0x4
		public int GlobalsSize; //Field offset: 0x8

		public int BlockByteSize
		{
			 get { } //Length: 16
		}

		public int BlockWordCount
		{
			 get { } //Length: 24
		}

		public int HeapSizeAllocated
		{
			 get { } //Length: 16
		}

		public int HeapSizeUsable
		{
			 get { } //Length: 12
		}

		public Config(PageSizes shift, int count, int globalsSize) { }

		public bool Equals(Config other) { }

		public virtual bool Equals(object obj) { }

		public int get_BlockByteSize() { }

		public int get_BlockWordCount() { }

		public int get_HeapSizeAllocated() { }

		public int get_HeapSizeUsable() { }

		public virtual int GetHashCode() { }

		public virtual string ToString() { }

	}

	private struct Segment
	{
		public const int SIZE = 4; //Field offset: 0x0
		public Ptr Next; //Field offset: 0x0

	}

	private const int SIZE = 112; //Field offset: 0x0
	private const int WORD_SHIFT = 3; //Field offset: 0x0
	private const int WORD_BYTE_SIZE = 8; //Field offset: 0x0
	public const int HEAP_ALIGNMENT = 8; //Field offset: 0x0
	public const int REPLICATE_WORD_SHIFT = 2; //Field offset: 0x0
	public const int REPLICATE_WORD_SIZE = 4; //Field offset: 0x0
	public const int REPLICATE_WORD_ALIGN = 4; //Field offset: 0x0
	public const int BUCKET_COUNT = 57; //Field offset: 0x0
	public const byte BUCKET_INVALID = 255; //Field offset: 0x0
	private const int PTR_SIZE = 8; //Field offset: 0x0
	private Byte* _root; //Field offset: 0x0
	private Byte* _heap; //Field offset: 0x8
	private Byte* _meta; //Field offset: 0x10
	private Void* _globals; //Field offset: 0x18
	private Void* _checksum; //Field offset: 0x20
	private Void* _replicate; //Field offset: 0x28
	private Block* _blocks; //Field offset: 0x30
	private BlockList* _blocksFreeList; //Field offset: 0x38
	private Bucket* _buckets; //Field offset: 0x40
	private Byte* _bucketsMap; //Field offset: 0x48
	private BlockList* _bucketsLists; //Field offset: 0x50
	private Config _config; //Field offset: 0x58
	private int _maxBlockIndexUsed; //Field offset: 0x64
	private int _checksumByteLength; //Field offset: 0x68
	private int _replicateByteLength; //Field offset: 0x6C

	internal Config Configuration
	{
		internal get { } //Length: 16
	}

	internal static Void* Alloc(Allocator* a, int size) { }

	internal static T* Alloc(Allocator* s) { }

	internal static Void* AllocAndClear(Allocator* a, int size) { }

	internal static T* AllocAndClear(Allocator* s) { }

	internal static T* AllocAndClearArray(Allocator* s, int length) { }

	internal static T* AllocArray(Allocator* s, int length) { }

	internal bool CanAllocSize(int size) { }

	internal bool CanAllocSizeAssert_Temp(int size) { }

	internal static Allocator* Create(Config config) { }

	[Conditional("DEBUG")]
	private static void DebugVerifyBucketIntegrity(Allocator* a, int index) { }

	internal static void Dispose(Allocator* a) { }

	internal static void Free(Allocator* a, Void* ptr) { }

	internal static void FreeCheckedRef(Allocator* a, ref T* ptr) { }

	internal Config get_Configuration() { }

	private Block* GetBlock(int index) { }

	private Block* GetBlock(long index) { }

	private int GetBlockBucket(long index) { }

	private Block* GetBlockForPointer(Void* ptr) { }

	private int GetBlockIndexForPointer(Void* ptr) { }

	private Byte* GetBlockMemory(long blockIndex) { }

	private Byte* GetBlockMemory(Block* block) { }

	private Bucket* GetBucket(int index) { }

	private Bucket* GetBucketForBlock(Block* block) { }

	private BlockList* GetBucketList(int index) { }

	internal int GetFreeSegmentsInBytes() { }

	internal void GetMemorySnapshot(ref MemoryStatisticsSnapshot snapshot, Allocator* a) { }

	internal int GetReplicateWordOffset(Ptr ptr) { }

	internal int GetReplicateWordOffset(Void* ptr) { }

	internal Void* GetSegmentRoot(Void* ptr) { }

	internal int GetTotalSegmentsUsedInBytes() { }

	internal bool IsPointerInHeap(Void* p) { }

	private bool IsPointerInMeta(Void* p) { }

	private Void* Meta(Ptr ptr) { }

	private Ptr Meta(Void* p) { }

	internal static string PrintDebugInfo(Allocator* allocator) { }

	internal Void* Ptr(Ptr ptr) { }

	internal Ptr Ptr(Void* p) { }

	internal T* Ptr(Ptr ptr) { }

	private static Void* TryAllocateSegmentFromBlock(Allocator* a, Bucket* bucket, Block* block, int size) { }

	internal bool TryGetSegmentRoot(Void* ptr, out Void* root) { }

	private static int WordCount(int size) { }

}

