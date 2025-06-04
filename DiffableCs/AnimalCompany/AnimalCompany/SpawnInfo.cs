namespace AnimalCompany;

[NetworkStructWeaved(8)]
public struct SpawnInfo : INetworkStruct
{
	public Vector3 position; //Field offset: 0x0
	public Quaternion rotation; //Field offset: 0xC
	public bool isSetup; //Field offset: 0x1C

}

