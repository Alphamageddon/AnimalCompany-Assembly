namespace SpatialSys.ObservableState;

public class NoOpTypeIDManifest : IStateTypeIDManifest
{
	[CompilerGenerated]
	private readonly IReadOnlyList<Type> <registeredTypes>k__BackingField; //Field offset: 0x10

	public override int numRegisteredTypes
	{
		 get { } //Length: 8
	}

	public override IReadOnlyList<Type> registeredTypes
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public NoOpTypeIDManifest() { }

	public override int get_numRegisteredTypes() { }

	[CompilerGenerated]
	public override IReadOnlyList<Type> get_registeredTypes() { }

	public override int GetIDForType(Type type) { }

	public override Type GetTypeByID(int typeID) { }

	public override void RegisterType(Type type) { }

	public override bool TryGetIDForType(Type type, out int id) { }

}

