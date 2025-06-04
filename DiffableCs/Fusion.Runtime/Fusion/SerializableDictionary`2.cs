namespace Fusion;

[DefaultMember("Item")]
public class SerializableDictionary : SerializableDictionary, IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, ISerializationCallbackReceiver
{
	private struct Entry
	{
		public TKey Key; //Field offset: 0x0
		public TValue Value; //Field offset: 0x0

	}

	public const string ItemsPropertyPath = "_items"; //Field offset: 0x0
	public const string EntryKeyPropertyPath = "Key"; //Field offset: 0x0
	[SerializeField]
	private Entry<TKey, TValue>[] _items; //Field offset: 0x0
	private List<ValueTuple`2<Entry<TKey, TValue>, Int32>> _duplicatesAndNulls; //Field offset: 0x0
	private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 92
	}

	private ICollection<KeyValuePair`2<TKey, TValue>> DictionaryAsCollection
	{
		private get { } //Length: 60
	}

	private Dictionary<TKey, TValue> Inner
	{
		private get { } //Length: 48
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 8
	}

	public override TValue Item
	{
		 get { } //Length: 100
		 set { } //Length: 116
	}

	public KeyCollection<TKey, TValue> Keys
	{
		 get { } //Length: 92
	}

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 92
	}

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 92
	}

	public ValueCollection<TKey, TValue> Values
	{
		 get { } //Length: 92
	}

	public SerializableDictionary`2() { }

	public override void Add(TKey key, TValue value) { }

	public override void Clear() { }

	public override bool ContainsKey(TKey key) { }

	private Dictionary<TKey, TValue> CreateDictionary() { }

	public override int get_Count() { }

	private ICollection<KeyValuePair`2<TKey, TValue>> get_DictionaryAsCollection() { }

	private Dictionary<TKey, TValue> get_Inner() { }

	public override bool get_IsReadOnly() { }

	public override TValue get_Item(TKey key) { }

	public KeyCollection<TKey, TValue> get_Keys() { }

	public ValueCollection<TKey, TValue> get_Values() { }

	public Enumerator<TKey, TValue> GetEnumerator() { }

	public override bool Remove(TKey key) { }

	public void Reset() { }

	public override void set_Item(TKey key, TValue value) { }

	public void Store() { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(TKey key, out TValue value) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	public static SerializableDictionary<TKey, TValue> Wrap(Dictionary<TKey, TValue> dictionary) { }

}

