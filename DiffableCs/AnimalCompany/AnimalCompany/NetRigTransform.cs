namespace AnimalCompany;

[NetworkStructWeaved(4)]
public struct NetRigTransform : INetworkStruct
{
	public const float NORMALIZED_POS_RANGE = 2; //Field offset: 0x0
	public ByteNormalizedVec3 pos; //Field offset: 0x0
	public ushort rot; //Field offset: 0xC

	public NetRigTransform(Vector3 p, Quaternion r) { }

}

