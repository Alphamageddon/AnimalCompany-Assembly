namespace ExitGames.Client.Photon;

[DefaultMember("Item")]
public class ParameterDictionary : IEnumerable<KeyValuePair`2<Byte, Object>>, IEnumerable
{
	public readonly NonAllocDictionary<Byte, Object> paramDict; //Field offset: 0x10
	public readonly StructWrapperPools wrapperPools; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 80
	}

	public object Item
	{
		 get { } //Length: 176
		 set { } //Length: 104
	}

	public ParameterDictionary() { }

	public ParameterDictionary(int capacity) { }

	public void Add(byte code, object value) { }

	public void Add(byte code, long value) { }

	public void Add(byte code, int value) { }

	public void Add(byte code, short value) { }

	public void Add(byte code, bool value) { }

	public void Add(byte code, Hashtable value) { }

	public void Add(byte code, string value) { }

	public void Add(byte code, byte value) { }

	public void Clear() { }

	public bool ContainsKey(byte key) { }

	public T Get(byte key) { }

	public int get_Count() { }

	public object get_Item(byte key) { }

	public PairIterator<Byte, Object> GetEnumerator() { }

	public static NonAllocDictionary<Byte, Object> op_Implicit(ParameterDictionary value) { }

	public void set_Item(byte key, object value) { }

	private override IEnumerator<KeyValuePair`2<Byte, Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Byte,System.Object>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public string ToStringFull(bool includeTypes = true) { }

	public object TryGetObject(byte key) { }

	public bool TryGetValue(byte key, out T value) { }

	public bool TryGetValue(byte key, out object value) { }

	public T Unwrap(byte key) { }

}

