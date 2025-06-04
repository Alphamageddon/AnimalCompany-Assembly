namespace Fusion.Statistics;

public struct MemoryStatisticsSnapshot
{
	internal enum TargetAllocator
	{
		General = 0,
		Objects = 1,
	}

	public const int BUCKET_COUNT = 57; //Field offset: 0x0
	public int TotalFreeBlocks; //Field offset: 0x0
	public Int32[] BucketFullBlocksCount; //Field offset: 0x8
	public Int32[] BucketUsedBlocksCount; //Field offset: 0x10
	public Int32[] BucketFreeBlocksCount; //Field offset: 0x18

}

