namespace ExitGames.Client.Photon;

[DefaultMember("Item")]
public class NonAllocDictionary : IDictionary<K, V>, ICollection<KeyValuePair`2<K, V>>, IEnumerable<KeyValuePair`2<K, V>>, IEnumerable
{
	internal struct KeyIterator : IEnumerator<K>, IEnumerator, IDisposable
	{
		private int _index; //Field offset: 0x0
		private NonAllocDictionary<K, V> _dict; //Field offset: 0x0

		public override K Current
		{
			 get { } //Length: 76
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 156
		}

		public KeyIterator(NonAllocDictionary<K, V> dictionary) { }

		public override void Dispose() { }

		public override K get_Current() { }

		public KeyIterator<K, V> GetEnumerator() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private struct Node
	{
		public bool Used; //Field offset: 0x0
		public int Next; //Field offset: 0x0
		public uint Hash; //Field offset: 0x0
		public K Key; //Field offset: 0x0
		public V Val; //Field offset: 0x0

	}

	internal struct PairIterator : IEnumerator<KeyValuePair`2<K, V>>, IEnumerator, IDisposable
	{
		private int _index; //Field offset: 0x0
		private NonAllocDictionary<K, V> _dict; //Field offset: 0x0

		public override KeyValuePair<K, V> Current
		{
			 get { } //Length: 148
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 152
		}

		public PairIterator(NonAllocDictionary<K, V> dictionary) { }

		public override void Dispose() { }

		public override KeyValuePair<K, V> get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal struct ValueIterator : IEnumerator<V>, IEnumerator, IDisposable
	{
		private int _index; //Field offset: 0x0
		private NonAllocDictionary<K, V> _dict; //Field offset: 0x0

		public override V Current
		{
			 get { } //Length: 76
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 120
		}

		public ValueIterator(NonAllocDictionary<K, V> dictionary) { }

		public override void Dispose() { }

		public override V get_Current() { }

		public ValueIterator<K, V> GetEnumerator() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private static UInt32[] _primeTableUInt; //Field offset: 0x0
	private int _freeHead; //Field offset: 0x0
	private int _freeCount; //Field offset: 0x0
	private int _usedCount; //Field offset: 0x0
	private uint _capacity; //Field offset: 0x0
	private Int32[] _buckets; //Field offset: 0x0
	private Node<K, V>[] _nodes; //Field offset: 0x0
	private bool isReadOnly; //Field offset: 0x0
	private ICollection<K> keys; //Field offset: 0x0
	private ICollection<V> values; //Field offset: 0x0

	public uint Capacity
	{
		 get { } //Length: 8
	}

	public override int Count
	{
		 get { } //Length: 16
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 8
	}

	public override V Item
	{
		 get { } //Length: 204
		 set { } //Length: 288
	}

	public KeyIterator<K, V> Keys
	{
		 get { } //Length: 52
	}

	private override ICollection<K> System.Collections.Generic.IDictionary<K,V>.Keys
	{
		private get { } //Length: 8
	}

	private override ICollection<V> System.Collections.Generic.IDictionary<K,V>.Values
	{
		private get { } //Length: 8
	}

	public ValueIterator<K, V> Values
	{
		 get { } //Length: 52
	}

	private static NonAllocDictionary`2() { }

	public NonAllocDictionary`2(uint capacity = 29) { }

	public override void Add(KeyValuePair<K, V> item) { }

	public override void Add(K key, V val) { }

	private static void Assert(bool condition) { }

	public override void Clear() { }

	public override bool Contains(KeyValuePair<K, V> item) { }

	public override bool ContainsKey(K key) { }

	private void Expand() { }

	private int FindNode(K key) { }

	public uint get_Capacity() { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override V get_Item(K key) { }

	public KeyIterator<K, V> get_Keys() { }

	public ValueIterator<K, V> get_Values() { }

	public PairIterator<K, V> GetEnumerator() { }

	private static uint GetNextPrime(uint value) { }

	private void Insert(K key, V val) { }

	private static bool IsPrimeFromList(uint value) { }

	public override bool Remove(KeyValuePair<K, V> item) { }

	public override bool Remove(K key) { }

	public void Set(K key, V val) { }

	public override void set_Item(K key, V value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(KeyValuePair<K, V>[] array, int index) { }

	private override ICollection<K> System.Collections.Generic.IDictionary<K,V>.get_Keys() { }

	private override ICollection<V> System.Collections.Generic.IDictionary<K,V>.get_Values() { }

	private override IEnumerator<KeyValuePair`2<K, V>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(K key, out V val) { }

}

