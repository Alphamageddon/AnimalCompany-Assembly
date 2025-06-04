namespace SpatialSys.ObservableState;

[DefaultMember("Item")]
public interface IStateDictionary : IStateDictionary, IStateObject
{

	public IStateObject Item
	{
		 get { } //Length: 0
	}

	public IStateObject Add(TKey key) { }

	public bool ContainsKey(TKey key) { }

	public IStateObject get_Item(TKey key) { }

}

