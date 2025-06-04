namespace SpatialSys.ObservableState;

public class StateRoot : StateObject, IStateRoot, IStateObject
{
	[CompilerGenerated]
	private readonly IStateObservationContext <context>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly IStateTypeIDManifest <typeIDManifest>k__BackingField; //Field offset: 0x50
	private IStateSerialization _serialization; //Field offset: 0x58

	public override IStateObservationContext context
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual IStateSerialization serialization
	{
		 get { } //Length: 8
	}

	public override IStateTypeIDManifest typeIDManifest
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public StateRoot() { }

	public StateRoot(IStateObservationContext context, IStateTypeIDManifest typeIDManifest, IStateSerialization serializationOverride = null) { }

	[CompilerGenerated]
	public override IStateObservationContext get_context() { }

	public virtual IStateSerialization get_serialization() { }

	[CompilerGenerated]
	public override IStateTypeIDManifest get_typeIDManifest() { }

}

