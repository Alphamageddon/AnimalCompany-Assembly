namespace SpatialSys.ObservableState;

[DefaultMember("Item")]
public interface IStateList : IStateObject
{

	public IStateObject Item
	{
		 get { } //Length: 0
	}

	public IStateObject Add() { }

	public void AddMany(int count) { }

	public void Clear() { }

	public bool Contains(object value) { }

	public IStateObject get_Item(int index) { }

	public IStateObject Insert(int index) { }

	public void InsertMany(int index, int count) { }

	public void Remove(object value) { }

	public void RemoveAt(int index) { }

}

