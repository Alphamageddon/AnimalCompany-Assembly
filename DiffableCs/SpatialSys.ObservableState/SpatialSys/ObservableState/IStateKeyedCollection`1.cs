namespace SpatialSys.ObservableState;

public interface IStateKeyedCollection
{

	public bool TryFindChild(TKey key, out IStateObject child) { }

}

