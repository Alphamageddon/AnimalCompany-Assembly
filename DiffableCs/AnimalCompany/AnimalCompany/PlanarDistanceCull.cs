namespace AnimalCompany;

[ExecuteAlways]
public class PlanarDistanceCull : MonoBehaviour
{
	public MeshRenderer meshRenderer; //Field offset: 0x20
	[Tooltip("The renderer will be visible if the SQR distance is less than this.")]
	public float sqrDistanceVisible; //Field offset: 0x28
	private Plane plane; //Field offset: 0x2C

	public PlanarDistanceCull() { }

	private void OnEnable() { }

	private void Update() { }

}

