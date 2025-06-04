namespace Fusion;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
public struct NetworkDictionary : IEnumerable<KeyValuePair`2<K, V>>, IEnumerable, INetworkDictionary
{
	public class DebuggerProxy : Dictionary<K, V>
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public NetworkDictionary<K, V> dict; //Field offset: 0x0

			public <>c__DisplayClass0_0() { }

			internal KeyValuePair<K, V>[] <.ctor>b__0() { }

		}

		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		public Lazy<KeyValuePair`2<K, V>[]> _items; //Field offset: 0x0

		[DebuggerBrowsable(DebuggerBrowsableState::RootHidden (3))]
		public KeyValuePair<K, V>[] Items
		{
			 get { } //Length: 60
		}

		public DebuggerProxy(NetworkDictionary<K, V> dict) { }

		public KeyValuePair<K, V>[] get_Items() { }

	}

	internal struct Enumerator : IEnumerator<KeyValuePair`2<K, V>>, IEnumerator, IDisposable
	{
		private int _bucket; //Field offset: 0x0
		private int _entry; //Field offset: 0x0
		private NetworkDictionary<K, V> _dict; //Field offset: 0x0

		public override KeyValuePair<K, V> Current
		{
			 get { } //Length: 260
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 104
		}

		internal Enumerator(NetworkDictionary<K, V> dict) { }

		public override void Dispose() { }

		public override KeyValuePair<K, V> get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	public const int META_WORD_COUNT = 3; //Field offset: 0x0
	private const int FREE_OFFSET = 0; //Field offset: 0x0
	private const int FREE_COUNT_OFFSET = 1; //Field offset: 0x0
	private const int USED_COUNT_OFFSET = 2; //Field offset: 0x0
	private const int INVALID_ENTRY = 0; //Field offset: 0x0
	private Int32* _data; //Field offset: 0x0
	private int _capacity; //Field offset: 0x0
	private int _nxtOffset; //Field offset: 0x0
	private int _keyOffset; //Field offset: 0x0
	private int _valOffset; //Field offset: 0x0
	private int _entryStride; //Field offset: 0x0
	private int _bucketsOffset; //Field offset: 0x0
	private int _entriesOffset; //Field offset: 0x0
	private IElementReaderWriter<K> _keyReaderWriter; //Field offset: 0x0
	private IElementReaderWriter<V> _valReaderWriter; //Field offset: 0x0
	private EqualityComparer<K> _equalityComparer; //Field offset: 0x0

	private int _free
	{
		private get { } //Length: 12
		private set { } //Length: 12
	}

	private int _freeCount
	{
		private get { } //Length: 12
		private set { } //Length: 12
	}

	private int _usedCount
	{
		private get { } //Length: 12
		private set { } //Length: 12
	}

	public int Capacity
	{
		 get { } //Length: 12
	}

	public int Count
	{
		 get { } //Length: 100
	}

	public V Item
	{
		 get { } //Length: 68
		 set { } //Length: 84
	}

	public NetworkDictionary`2(Int32* data, int capacity, IElementReaderWriter<K> keyReaderWriter, IElementReaderWriter<V> valReaderWriter) { }

	public bool Add(K key, V value) { }

	public void Clear() { }

	private void ClrEntry(int entry) { }

	public bool ContainsKey(K key) { }

	public bool ContainsValue(V value, IEqualityComparer<V> equalityComparer = null) { }

	private int Find(K key) { }

	private override void Fusion.INetworkDictionary.Add(object item) { }

	public V Get(K key) { }

	private int get__free() { }

	private int get__freeCount() { }

	private int get__usedCount() { }

	public int get_Capacity() { }

	public int get_Count() { }

	public V get_Item(K key) { }

	private uint GetBucketFromHashCode(int hash) { }

	public Enumerator<K, V> GetEnumerator() { }

	private K GetKey(int entry) { }

	private int GetKeyHashCode(K key) { }

	private int GetNxt(int entry) { }

	private V GetVal(int entry) { }

	private int Insert(K key, V val) { }

	public static NetworkDictionaryReadOnly<K, V> op_Implicit(NetworkDictionary<K, V> value) { }

	public bool Remove(K key) { }

	public bool Remove(K key, out V value) { }

	public V Set(K key, V value) { }

	private void set__free(int value) { }

	private void set__freeCount(int value) { }

	private void set__usedCount(int value) { }

	public void set_Item(K key, V value) { }

	private void SetKey(int entry, K key) { }

	private void SetNxt(int entry, int next) { }

	private void SetVal(int entry, V val) { }

	private override IEnumerator<KeyValuePair`2<K, V>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public NetworkDictionaryReadOnly<K, V> ToReadOnly() { }

	public bool TryGet(K key, out V value) { }

}

