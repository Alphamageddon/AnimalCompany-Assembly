namespace AnimalCompany;

public class PlayerCollider : MonoBehaviour
{
	private const int LOCAL_PLAYER_LAYER = 6; //Field offset: 0x0
	public Action<PlayerController> onPlayerCollisionEnter; //Field offset: 0x20

	public PlayerCollider() { }

	private void OnTriggerEnter(Collider other) { }

}

