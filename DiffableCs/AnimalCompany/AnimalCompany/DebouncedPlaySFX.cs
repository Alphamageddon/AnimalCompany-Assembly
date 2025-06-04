namespace AnimalCompany;

public class DebouncedPlaySFX : MonoBehaviour
{
	public CollisionTrigger collisionTrigger; //Field offset: 0x20
	public AudioSource audioSource; //Field offset: 0x28
	public float debounceTime; //Field offset: 0x30
	private float lastPlayedTime; //Field offset: 0x34

	public DebouncedPlaySFX() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void PlaySFX(Collider other) { }

}

