namespace AnimalCompany.GameGen;

[RequireComponent(typeof(SphereCollider))]
public class NavPoint : MonoBehaviour
{
	public bool respawnable; //Field offset: 0x20
	[Tooltip("When spawning mobs, they will be placed within this radius of the nav point.")]
	public float respawnableRadius; //Field offset: 0x24
	[HideInInspector]
	public Vector3 position; //Field offset: 0x28

	public NavPoint() { }

	public Vector3 GetSpawnPosition() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

}

