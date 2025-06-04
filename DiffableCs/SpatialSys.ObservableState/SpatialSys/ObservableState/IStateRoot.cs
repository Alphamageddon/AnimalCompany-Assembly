namespace SpatialSys.ObservableState;

public interface IStateRoot : IStateObject
{

	public IStateObservationContext context
	{
		 get { } //Length: 0
	}

	public IStateTypeIDManifest typeIDManifest
	{
		 get { } //Length: 0
	}

	public IStateObservationContext get_context() { }

	public IStateTypeIDManifest get_typeIDManifest() { }

}

