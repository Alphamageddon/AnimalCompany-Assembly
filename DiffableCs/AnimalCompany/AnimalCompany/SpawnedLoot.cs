namespace AnimalCompany;

[NetworkStructWeaved(3)]
public struct SpawnedLoot : INetworkStruct
{
	public NetworkId netId; //Field offset: 0x0
	public byte itemPointId; //Field offset: 0x4
	public byte connectionId; //Field offset: 0x8

}

