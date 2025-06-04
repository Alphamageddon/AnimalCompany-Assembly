namespace AnimalCompany;

public class AisleObject : MonoBehaviour
{
	internal enum Direction
	{
		forward = 0,
		right = 1,
		up = 2,
	}

	[SerializeField]
	private Direction _direction; //Field offset: 0x20
	[SerializeField]
	private Vector3 _centerOffset; //Field offset: 0x24
	[SerializeField]
	private float _length; //Field offset: 0x30

	public Vector3 center
	{
		 get { } //Length: 120
	}

	public Vector3 direction
	{
		 get { } //Length: 432
	}

	public Vector3[] endPoints
	{
		 get { } //Length: 276
	}

	public AisleObject() { }

	public Vector3 get_center() { }

	public Vector3 get_direction() { }

	public Vector3[] get_endPoints() { }

	public AisleData GetAisleData(float stayOffset) { }

	private void OnDrawGizmosSelected() { }

}

