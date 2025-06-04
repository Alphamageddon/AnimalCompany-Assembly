namespace SpatialSys.ObservableState;

[DefaultMember("Item")]
public interface IStateDictionary : IStateObject
{

	public IStateObject Item
	{
		 get { } //Length: 0
	}

	public ICollection keys
	{
		 get { } //Length: 0
	}

	public Type keyType
	{
		 get { } //Length: 0
	}

	public int keyTypeID
	{
		 get { } //Length: 0
	}

	public ICollection values
	{
		 get { } //Length: 0
	}

	public Type valueType
	{
		 get { } //Length: 0
	}

	public IStateObject Add(object key) { }

	public void Clear() { }

	public bool ContainsKey(object key) { }

	public IStateObject get_Item(object key) { }

	public ICollection get_keys() { }

	public Type get_keyType() { }

	public int get_keyTypeID() { }

	public ICollection get_values() { }

	public Type get_valueType() { }

	public void Remove(object key) { }

	public bool TryGetValue(object key, out IStateObject value) { }

}

