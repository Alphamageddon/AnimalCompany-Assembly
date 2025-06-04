namespace AnimalCompany;

[NetworkStructWeaved(12)]
public struct NetRigData : INetworkStruct
{
	public NetRigTransform head; //Field offset: 0x0
	public NetRigTransform rightHand; //Field offset: 0x10
	public NetRigTransform leftHand; //Field offset: 0x20

}

