namespace AnimalCompany;

public class AppStateObservationContext : StateObservationContext
{

	public AppStateObservationContext() { }

	public AppStateObservationContext(IStateTypeIDManifest typeIDManifest) { }

	public AppStateObservationContext(ILogger logger) { }

	public AppStateObservationContext(IStateTypeIDManifest typeIDManifest, ILogger logger) { }

}

