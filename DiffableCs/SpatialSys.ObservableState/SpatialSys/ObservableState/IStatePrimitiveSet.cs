namespace SpatialSys.ObservableState;

public interface IStatePrimitiveSet : IStateObject, IEnumerable
{

	public Type elementType
	{
		 get { } //Length: 0
	}

	public int elementTypeID
	{
		 get { } //Length: 0
	}

	public void Add(object value) { }

	public void Clear() { }

	public bool Contains(object value) { }

	public Type get_elementType() { }

	public int get_elementTypeID() { }

	public void Remove(object value) { }

}

