namespace AnimalCompany.AvatarSystem;

public class GarmentRefitPreProcessResult
{
	public Vector3[] verticesCageSpace; //Field offset: 0x10
	public Vector3[] closestCagePoints; //Field offset: 0x18
	public Vector3[] displacementVectors; //Field offset: 0x20
	public Int32[] closestCageTriangle; //Field offset: 0x28
	public Int32[] occludedCageTriangles; //Field offset: 0x30

	public GarmentRefitPreProcessResult() { }

}

