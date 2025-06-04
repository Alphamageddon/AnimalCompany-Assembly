namespace Fusion;

public struct DynamicHeap
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<Type, TypeData>, UInt16> <>9__44_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<Type, TypeData>, TypeData> <>9__44_2; //Field offset: 0x10
		public static Func<TypeData, UInt16> <>9__44_3; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal ushort <Create>b__44_0(KeyValuePair<Type, TypeData> x) { }

		internal TypeData <Create>b__44_2(KeyValuePair<Type, TypeData> x) { }

		internal ushort <Create>b__44_3(TypeData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public ushort maxOffset; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal bool <Create>b__1(KeyValuePair<Type, TypeData> x) { }

	}

	private struct Bin
	{
		public int Index; //Field offset: 0x0
		public PageList Pages; //Field offset: 0x8
		public int ObjectWords; //Field offset: 0x20
		public int ObjectStride; //Field offset: 0x24
		public int ObjectCapacity; //Field offset: 0x28

	}

	private static class BinSizes
	{
		public static readonly Int32[] Sizes; //Field offset: 0x0

		private static BinSizes() { }

	}

	private struct Block
	{
		public byte Index; //Field offset: 0x0
		public Block* Prev; //Field offset: 0x8
		public Block* Next; //Field offset: 0x10
		public Page* Pages; //Field offset: 0x18
		public PageList PagesFree; //Field offset: 0x20
		public Byte* Memory; //Field offset: 0x38

	}

	private struct BlockList
	{
		public int Count; //Field offset: 0x0
		public Block* Head; //Field offset: 0x8
		public Block* Tail; //Field offset: 0x10

		public void AddAfter(Block* after, Block* item) { }

		public void AddBefore(Block* before, Block* item) { }

		public void AddFirst(Block* item) { }

		public void AddLast(Block* item) { }

		private bool IsInList(Block* item) { }

		public void MoveFirst(Block* item) { }

		public void MoveLast(Block* item) { }

		public void Remove(Block* item) { }

		public Block* RemoveHead() { }

		public bool TryRemoveHead(out Block* head) { }

	}

	internal sealed class CollectGarbageDelegate : MulticastDelegate
	{

		public CollectGarbageDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(DynamicHeap* heap, Void** dynamicRoots, int dynamicRootsLength, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(DynamicHeap* heap, Void** dynamicRoots, int dynamicRootsLength) { }

	}

	public struct Config
	{
		public int BlockPageCount; //Field offset: 0x0

		public static Config Default
		{
			 get { } //Length: 8
		}

		public static Config get_Default() { }

	}

	[AttributeUsage(AttributeTargets::Field (256))]
	internal sealed class Ignore : Attribute
	{

		public Ignore() { }

	}

	private struct object
	{
		public const int SIZE = 8; //Field offset: 0x0
		public const int WORDS = 1; //Field offset: 0x0
		public ObjectFlags Flags; //Field offset: 0x0
		public byte Block; //Field offset: 0x1
		public ushort Gen; //Field offset: 0x2
		public ushort Type; //Field offset: 0x4
		public ushort Array; //Field offset: 0x6

	}

	[Flags]
	private enum ObjectFlags
	{
		Tracked = 1,
		Root = 2,
		Pointer = 4,
		Simple = 8,
		ForceAlive = 16,
		Garbage = 32,
	}

	private struct ObjectFree
	{
		public const int SIZE = 8; //Field offset: 0x0
		public const int WORDS = 1; //Field offset: 0x0
		public int Next; //Field offset: 0x4

	}

	private struct Page
	{
		public Block* Block; //Field offset: 0x0
		public int Index; //Field offset: 0x8
		public Page* Prev; //Field offset: 0x10
		public Page* Next; //Field offset: 0x18
		public int Bin; //Field offset: 0x20
		public int Use; //Field offset: 0x24
		public Byte* Memory; //Field offset: 0x28
		public ObjectFree* ObjectsFree; //Field offset: 0x30
		public int ObjectsFreeCount; //Field offset: 0x38
		public int ObjectsComitted; //Field offset: 0x3C
		public int ObjectsAllocated; //Field offset: 0x40

	}

	private struct PageList
	{
		public int Count; //Field offset: 0x0
		public Page* Head; //Field offset: 0x8
		public Page* Tail; //Field offset: 0x10

		public void AddAfter(Page* after, Page* item) { }

		public void AddBefore(Page* before, Page* item) { }

		public void AddFirst(Page* item) { }

		public void AddLast(Page* item) { }

		public bool Contains(Page* item) { }

		public void MoveFirst(Page* item) { }

		public void MoveLast(Page* item) { }

		public void Remove(Page* item) { }

		public Page* RemoveHead() { }

		public bool TryRemoveHead(out Page* head) { }

	}

	public enum Phase
	{
		Idle = 0,
		Mark = 1,
		Sweep = 2,
		Free = 3,
	}

	private class TypeData
	{
		public int Stride; //Field offset: 0x10
		public ushort Offset; //Field offset: 0x14
		public Int32[] Pointers; //Field offset: 0x18
		public Type Type; //Field offset: 0x20

		public TypeData() { }

		public TypeData(int stride, ushort offset, Int32[] pointers, Type type) { }

	}

	internal const int WORD_SHIFT = 3; //Field offset: 0x0
	internal const int WORD_SIZE = 8; //Field offset: 0x0
	internal const int PAGE_SHIFT = 15; //Field offset: 0x0
	internal const int PAGE_SIZE = 32768; //Field offset: 0x0
	internal const int PAGE_WORD_COUNT = 4096; //Field offset: 0x0
	internal const int BIN_COUNT = 49; //Field offset: 0x0
	internal const int MAX_BLOCK_COUNT = 255; //Field offset: 0x0
	private static Dictionary<Type, TypeData> _types; //Field offset: 0x0
	private static Dictionary<UInt16, TypeData> _typesByOffset; //Field offset: 0x8
	private static Byte[] _debruijnTable; //Field offset: 0x10
	private BlockList _blocksFreePages; //Field offset: 0x0
	private Block** _blocks; //Field offset: 0x18
	private int _blocksUsed; //Field offset: 0x20
	private Bin* _bins; //Field offset: 0x28
	private Int32* _typeMap; //Field offset: 0x30
	private int _typeMapLength; //Field offset: 0x38
	private Int32* _typeMapStrides; //Field offset: 0x40
	private ushort _gcGen; //Field offset: 0x48
	private int _gcBlock; //Field offset: 0x4C
	private int _gcBlockPage; //Field offset: 0x50
	private Phase _gcPhase; //Field offset: 0x54
	private Object** _gcStack; //Field offset: 0x58
	private int _gcStackCount; //Field offset: 0x60
	private int _gcStackCapacity; //Field offset: 0x64
	private Config _config; //Field offset: 0x68
	private Object** _rootList; //Field offset: 0x70
	private int _rootListCapacity; //Field offset: 0x78
	private int _rootListCount; //Field offset: 0x7C
	private int _objectsAllocated; //Field offset: 0x80
	private int _memoryAllocated; //Field offset: 0x84

	internal Phase GCPhase
	{
		internal get { } //Length: 8
	}

	internal int GCRoots
	{
		internal get { } //Length: 8
	}

	internal double MemoryAllocated
	{
		internal get { } //Length: 164
	}

	internal int MemoryReserved
	{
		internal get { } //Length: 24
	}

	internal int ObjectsAllocated
	{
		internal get { } //Length: 8
	}

	private static DynamicHeap() { }

	internal static Void* Allocate(DynamicHeap* heap, int size) { }

	private static void AllocateBlock(DynamicHeap* heap) { }

	private static Byte* AllocateInternal(DynamicHeap* heap, int size, out byte block) { }

	private static Page* AllocatePage(DynamicHeap* heap) { }

	private static Page* AllocatePage_Internal(DynamicHeap* heap, bool mustSucceed) { }

	internal static T* AllocateTracked(DynamicHeap* heap, ushort array = 1, bool root = false) { }

	internal static T** AllocateTrackedPointerArray(DynamicHeap* heap, ushort array, bool root = false) { }

	private static int BitScan(uint v) { }

	private static int BlocksWithAvailablePages(DynamicHeap* heap) { }

	[MonoPInvokeCallback(typeof(CollectGarbageDelegate))]
	public static void CollectGarbage(DynamicHeap* heap, Void** dynamicRoots, int dynamicRootsLength) { }

	internal static DynamicHeap* Create(Config config, Type[] types) { }

	internal static DynamicHeap* Create(Type[] types) { }

	private static void Destroy(Block* block) { }

	internal static void Destroy(DynamicHeap* heap) { }

	private static void ExpandStack(DynamicHeap* heap) { }

	public static void Free(DynamicHeap* heap, Void* ptr) { }

	private static void FreeInternal(DynamicHeap* heap, Void* ptr, object objData) { }

	internal Phase get_GCPhase() { }

	internal int get_GCRoots() { }

	internal double get_MemoryAllocated() { }

	internal int get_MemoryReserved() { }

	internal int get_ObjectsAllocated() { }

	internal static int GetArrayLength(Void* ptr) { }

	private static int GetBin(int size) { }

	private static Bin* GetBinByIndex(DynamicHeap* heap, int binIndex) { }

	private static int GetBinIndexForSize(DynamicHeap* heap, int size) { }

	private static Page* GetPageForPtr(DynamicHeap* heap, Block* block, Void* ptr) { }

	private static int GetPageOffset(Page* page, ObjectFree* obj) { }

	private static ushort GetTypeOffset() { }

	private static void InitObj(DynamicHeap* heap, Object* obj, ushort type, ushort array, byte block) { }

	private static void InitRoot(DynamicHeap* heap, Object* obj) { }

	private static bool IsPtrInBlock(DynamicHeap* heap, Block* block, Void* p) { }

	private static ushort NextGen(DynamicHeap* heap) { }

	private static int ObjectsFreeCount(Page* p) { }

	private static int PagesWithAvailableObjectsInBin(Bin* bin) { }

	internal static void RegisterTypes(Type[] types) { }

	private static ObjectFree* ResolvePageOffset(Page* page, int offset) { }

	public static T* SetForcedAlive(T* ptr) { }

	private static void ThrowHeapCorrupted() { }

	private static Byte* TryAllocateFromPage(DynamicHeap* heap, Page* page, int size, out byte block) { }

	private static int WordCount(int size) { }

}

