namespace AnimalCompany;

public class CageOverlapDebug : MonoBehaviour
{
	public AvatarAccessoryData accessoryData; //Field offset: 0x20
	public Mesh cageMesh; //Field offset: 0x28
	private Mesh culledCageMesh; //Field offset: 0x30

	public CageOverlapDebug() { }

	private void OnDrawGizmos() { }

	private void OnEnable() { }

}

