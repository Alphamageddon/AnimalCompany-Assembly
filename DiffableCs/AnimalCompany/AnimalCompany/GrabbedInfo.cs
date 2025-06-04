namespace AnimalCompany;

[NetworkStructWeaved(7)]
public struct GrabbedInfo : INetworkStruct
{
	public Vector3 rootTranslation; //Field offset: 0x0
	public Quaternion rootRotation; //Field offset: 0xC

}

