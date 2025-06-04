namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IReadOnlyDictionary : IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
{

	public bool TryGetValue(TKey key, out TValue value) { }

}

