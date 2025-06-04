namespace SpatialSys.ObservableState;

public interface IStateTypeIDManifest
{

	public int numRegisteredTypes
	{
		 get { } //Length: 0
	}

	public IReadOnlyList<Type> registeredTypes
	{
		 get { } //Length: 0
	}

	public int get_numRegisteredTypes() { }

	public IReadOnlyList<Type> get_registeredTypes() { }

	public int GetIDForType(Type type) { }

	public Type GetTypeByID(int typeID) { }

	public void RegisterType(Type type) { }

	public bool TryGetIDForType(Type type, out int id) { }

}

