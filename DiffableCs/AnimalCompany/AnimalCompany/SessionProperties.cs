namespace AnimalCompany;

public class SessionProperties
{
	public const string PVP_KEY = "PVP"; //Field offset: 0x0
	public bool pvpEnabled; //Field offset: 0x10

	public SessionProperties() { }

	public SessionProperties(ReadOnlyDictionary<String, SessionProperty> photonProps) { }

	public SessionProperties(NetSessionPropertiesState propertiesState) { }

	public Dictionary<String, SessionProperty> CreatePhotonProperties() { }

}

