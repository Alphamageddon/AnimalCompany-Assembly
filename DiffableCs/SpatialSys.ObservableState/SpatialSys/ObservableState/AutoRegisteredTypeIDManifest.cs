namespace SpatialSys.ObservableState;

public class AutoRegisteredTypeIDManifest : IStateTypeIDManifest
{
	private List<Type> _typeByID; //Field offset: 0x10
	private Dictionary<Type, Int32> _idByType; //Field offset: 0x18

	public override int numRegisteredTypes
	{
		 get { } //Length: 72
	}

	public override IReadOnlyList<Type> registeredTypes
	{
		 get { } //Length: 8
	}

	public AutoRegisteredTypeIDManifest(Type rootStateObjectType) { }

	public override int get_numRegisteredTypes() { }

	public override IReadOnlyList<Type> get_registeredTypes() { }

	public override int GetIDForType(Type type) { }

	public override Type GetTypeByID(int typeID) { }

	public override void RegisterType(Type type) { }

	private void SearchRecursiveForPrimitiveTypes(HashSet<Type> typesFound, Type type) { }

	public override bool TryGetIDForType(Type type, out int id) { }

}

