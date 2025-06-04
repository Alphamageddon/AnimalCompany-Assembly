namespace AnimalCompany;

public struct AisleData
{
	public Vector3 center; //Field offset: 0x0
	public Vector3 direction; //Field offset: 0xC
	public Vector3[] endPoints; //Field offset: 0x18
	public Vector3[] stayPoints; //Field offset: 0x20

	public AisleData(Vector3 center, Vector3 direction, Vector3[] endPoints, float stayOffset) { }

}

