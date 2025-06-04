namespace AnimalCompany;

public class ChangeMeshBounds : MonoBehaviour
{
	[SerializeField]
	private MeshFilter _meshFilter; //Field offset: 0x20

	public ChangeMeshBounds() { }

	[ContextMenu("ChangeBounds")]
	public void ChangeBounds() { }

}

