namespace UnityEngine.ProBuilder;

internal sealed class RaycastHit
{
	public float distance; //Field offset: 0x10
	public Vector3 point; //Field offset: 0x14
	public Vector3 normal; //Field offset: 0x20
	public int face; //Field offset: 0x2C

	public RaycastHit(float distance, Vector3 point, Vector3 normal, int face) { }

}

