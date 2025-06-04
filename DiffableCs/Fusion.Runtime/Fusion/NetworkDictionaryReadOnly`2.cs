namespace Fusion;

[IsByRefLike]
[IsReadOnly]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct NetworkDictionaryReadOnly
{
	private const int INVALID_ENTRY = 0; //Field offset: 0x0
	private const int FREE_OFFSET = 0; //Field offset: 0x0
	private const int FREE_COUNT_OFFSET = 1; //Field offset: 0x0
	private const int USED_COUNT_OFFSET = 2; //Field offset: 0x0
	private readonly Int32* _data; //Field offset: 0x0
	private readonly int _capacity; //Field offset: 0x0
	private readonly int _nxtOffset; //Field offset: 0x0
	private readonly int _keyOffset; //Field offset: 0x0
	private readonly int _valOffset; //Field offset: 0x0
	private readonly int _entryStride; //Field offset: 0x0
	private readonly int _bucketsOffset; //Field offset: 0x0
	private readonly int _entriesOffset; //Field offset: 0x0
	private readonly IElementReaderWriter<K> _keyReaderWriter; //Field offset: 0x0
	private readonly IElementReaderWriter<V> _valReaderWriter; //Field offset: 0x0
	private readonly EqualityComparer<K> _equalityComparer; //Field offset: 0x0

	private int _free
	{
		private get { } //Length: 12
	}

	private int _freeCount
	{
		private get { } //Length: 12
	}

	private int _usedCount
	{
		private get { } //Length: 12
	}

	public int Capacity
	{
		 get { } //Length: 12
	}

	public int Count
	{
		 get { } //Length: 100
	}

	internal NetworkDictionaryReadOnly`2(Int32* data, int capacity, IElementReaderWriter<K> keyReaderWriter, IElementReaderWriter<V> valReaderWriter) { }

	private int Find(K key) { }

	public V Get(K key) { }

	private int get__free() { }

	private int get__freeCount() { }

	private int get__usedCount() { }

	public int get_Capacity() { }

	public int get_Count() { }

	private uint GetBucketFromHashCode(int hash) { }

	private K GetKey(int entry) { }

	private int GetNxt(int entry) { }

	private V GetVal(int entry) { }

	public bool TryGet(K key, out V value) { }

}

