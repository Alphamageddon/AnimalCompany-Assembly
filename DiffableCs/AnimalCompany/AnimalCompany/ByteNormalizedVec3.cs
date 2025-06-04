namespace AnimalCompany;

[NetworkStructWeaved(3)]
public struct ByteNormalizedVec3 : INetworkStruct
{
	public byte x; //Field offset: 0x0
	public byte y; //Field offset: 0x4
	public byte z; //Field offset: 0x8

	public ByteNormalizedVec3(Vector3 input, float range) { }

	public static float DecodeValue(byte inValue, float range) { }

	public static byte EncodeValue(float inValue, float range) { }

}

